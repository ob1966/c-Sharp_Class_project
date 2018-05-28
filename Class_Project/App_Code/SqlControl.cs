using System;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SqlControl
/// </summary>
public abstract class SqlControl
{
    private string connectionString;
    private SqlConnection dbConnection;

    public SqlControl()
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

    public abstract void ExecuteSproc();
}

public class SQLLoginRequest : SqlControl
{
    private int sqlOutput = 0;
    private string name;
    private string email;
    private string username;
    private string neworactive;
    private string reason;
    private string dateneededby;
    SqlCommand command = new SqlCommand();

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
            command.ExecuteNonQuery();
        }
        catch(Exception e)
        {
            
        }
        finally
        {
            this.DBConnection.Close();
        }
    }

    private void SetCommand()
    {
        command.CommandText = "EXEC [dbo].[pInsLoginRequest] @sqlOutput, @name, @emailAddress, @loginName, @neworactive, @reasonForAccess, @dateneededby";
        command.Connection = DBConnection;
        command.Parameters.AddWithValue("@sqlOutput", sqlOutput);
        command.Parameters.AddWithValue("@name", name);
        command.Parameters.AddWithValue("@emailAddress", email);
        command.Parameters.AddWithValue("@loginName", username);
        command.Parameters.AddWithValue("@neworactive", neworactive);
        command.Parameters.AddWithValue("@reasonForAccess", reason);
        command.Parameters.AddWithValue("@dateneededby", dateneededby);
        return;
    }
}