using System;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SqlControl
/// </summary>
public abstract class SqlControler
{
    private string connectionString;
    private SqlConnection dbConnection;
    private SqlCommand command = new SqlCommand();

    public SqlControler()
    {
        ConnectionString = WebConfigurationManager.ConnectionStrings["ConnStringLocalDB"].ConnectionString;
        DBConnection = new SqlConnection(ConnectionString);
    }

    protected string ConnectionString
    {
        get { return connectionString; }
        private set { connectionString = value; }
    }

    protected SqlConnection DBConnection { get => dbConnection; private set => dbConnection = value; }
    protected SqlCommand Command { get => command; set => command = value; }

    public abstract void ExecuteSproc();
    protected abstract void SetCommand();
}

public class SQLLoginRequest : SqlControler
{
    private int sqlOutput = 0;
    private string name;
    private string email;
    private string username;
    private string neworactive;
    private string reason;
    private string dateneededby;

    public SQLLoginRequest(string name, string email, string username, string neworactive, string reason, string dateneededby)
    {
        this.name = name;
        this.email = email;
        this.username = username;
        this.neworactive = neworactive;
        this.reason = reason;
        this.dateneededby = dateneededby;
        SetCommand();
    }

    public override void ExecuteSproc()
    {
        this.DBConnection.Open();
        try
        {
            Command.ExecuteNonQuery();

        }
        catch(Exception e)
        {
            
        }
        finally
        {
            this.DBConnection.Close();
        }
    }

    protected override void SetCommand()
    {
        Command.CommandText = @"EXEC [dbo].[pInsLoginRequest] @loginid output, @name, @emailAddress, @loginName, @neworactive, @reasonForAccess, @dateneededby";
        Command.Connection = DBConnection;
        Command.Parameters.AddWithValue("@loginid", sqlOutput); //SQL output param
        Command.Parameters[0].Direction = System.Data.ParameterDirection.Output;
        Command.Parameters.AddWithValue("@name", name);
        Command.Parameters.AddWithValue("@emailAddress", email);
        Command.Parameters.AddWithValue("@loginName", username);
        Command.Parameters.AddWithValue("@neworactive", neworactive);
        Command.Parameters.AddWithValue("@reasonForAccess", reason);
        Command.Parameters.AddWithValue("@dateneededby", dateneededby);
        return;
    }
}

public class SQLSignIn : SqlControler
{
    private string login;
    private string password;
    private int studentid = 0;
    private bool isSuccessful = false;


    public SQLSignIn(string login, string password)
    {
        this.login = login;
        this.password = password;
        SetCommand();
    }

    public bool IsSuccessful { get => isSuccessful; private set => isSuccessful = value; }

    public override void ExecuteSproc()
    {
        this.DBConnection.Open();
        try
        {
            Command.ExecuteNonQuery();
            if ((int)Command.Parameters["@studentid"].Value > 0) IsSuccessful = true;

        }
        catch (Exception e)
        {

        }
        finally
        {
            this.DBConnection.Close();
        }
    }

    protected override void SetCommand()
    {
        Command.CommandText = @"EXEC [dbo].[pSelLoginIdByLoginAndPassword] @login, @password, @studentid output";
        Command.Connection = DBConnection;
        Command.Parameters.AddWithValue("@login", login);
        Command.Parameters.AddWithValue("@password", password);
        Command.Parameters.AddWithValue("@studentid",studentid); //SQL output param
        Command.Parameters[2].Direction = System.Data.ParameterDirection.Output;
        return;
    }
}