using System;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SqlControl
/// </summary>
public abstract class SqlController
{
    private string connectionString;
    private SqlConnection dbConnection;
    private SqlCommand command = new SqlCommand();
    private bool isUsingProdDB = true; //Set this manually for development or production.
    protected bool isSuccessful = false;

    public SqlController()
    {
        if (isUsingProdDB)
        {
            ConnectionString = WebConfigurationManager.ConnectionStrings["ClassDB"].ConnectionString; ; // @"Data Source=is-root01.ischool.uw.edu; User ID=CSharp; Password=sql; Initial Catalog=AdvWebDevProject;";
        }
        else
        {
            ConnectionString = WebConfigurationManager.ConnectionStrings["DEVDB"].ConnectionString;
        }

        DBConnection = new SqlConnection(ConnectionString);
    }

    protected string ConnectionString
    {
        get { return connectionString; }
        private set { connectionString = value; }
    }

    protected SqlConnection DBConnection { get => dbConnection; private set => dbConnection = value; }
    protected SqlCommand Command { get => command; set => command = value; }
    public bool IsSuccessful { get => isSuccessful; protected set => isSuccessful = value; }

    public abstract void Execute();
    protected abstract void SetCommand();
}

public class SQLLoginRequest : SqlController
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

    public override void Execute()
    {
        this.DBConnection.Open();
        try
        {
            Command.ExecuteNonQuery();
            IsSuccessful = true;

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
        Command.CommandText = @"EXEC [dbo].[pInsLoginRequests] @loginid output, @name, @emailAddress, @loginName, @neworactive, @reasonForAccess, @dateneededby";
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

public class SQLSignIn : SqlController
{
    private string login;
    private string password;
    private int studentid = 0;

    public SQLSignIn(string login, string password)
    {
        Login = login;
        this.password = password;
        SetCommand();
    }

    public int Studentid { get => studentid; private set => studentid = value; }
    public string Login { get => login; private set => login = value; }

    public override void Execute()
    {
        this.DBConnection.Open();
        try
        {
            Command.ExecuteNonQuery();
            Studentid = (int)Command.Parameters["@studentid"].Value;
            if (Studentid > 0) IsSuccessful = true;
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
        Command.Parameters.AddWithValue("@login", Login);
        Command.Parameters.AddWithValue("@password", password);
        Command.Parameters.AddWithValue("@studentid", Studentid); //SQL output param
        Command.Parameters[2].Direction = System.Data.ParameterDirection.Output;
        return;
    }
}

public class SQLClasses : SqlController
{
    public readonly DataTable classTable = new DataTable();

    public SQLClasses()
    {
        GenerateDataTable(ref classTable);
        SetCommand();
        Execute();
    }

    public override void Execute()
    {
        this.DBConnection.Open();
        try
        {
            SqlDataReader classQueryResults = Command.ExecuteReader();
            while (classQueryResults.Read() == true)
            {
                classTable.Rows.Add(classQueryResults["ClassId"].ToString(), classQueryResults["ClassName"].ToString(), classQueryResults["ClassDate"].ToString(), classQueryResults["ClassDescription"].ToString());
            }
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
        Command.CommandText = @"SELECT ClassId, ClassName, ClassDate, ClassDescription FROM [dbo].[vClasses]";
        Command.Connection = DBConnection;
        return;
    }

    private void GenerateDataTable(ref DataTable classTable)
    {
        classTable.Columns.Add("Class Id", typeof(string));
        classTable.Columns.Add("Name", typeof(string));
        classTable.Columns.Add("Date", typeof(string));
        classTable.Columns.Add("Description", typeof(string));
        return;
    }
}

public class SQLResiterForClass : SqlController
{
    private int classId;
    private int studentId;

    public SQLResiterForClass(int classID, int studentID)
    {
        ClassId = classID;
        StudentId = studentID;
        SetCommand();
    }

    public int ClassId { get => classId; private set => classId = value; }
    public int StudentId { get => studentId; private set => studentId = value; }

    public override void Execute()
    {
        this.DBConnection.Open();
        try
        {
            Command.ExecuteNonQuery();
            IsSuccessful = true;
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
        Command.CommandText = @"EXEC [dbo].[pInsClassStudents] @classId, @studentId";
        Command.Connection = DBConnection;
        Command.Parameters.AddWithValue("@classId", ClassId);
        Command.Parameters.AddWithValue("@studentId", StudentId);
        return;
    }
}

public class SQLGetMyClasses : SqlController
{
    private int studentId;
    public readonly DataTable myClassTable = new DataTable();

    public SQLGetMyClasses(int studentId)
    {
        StudentId = studentId;
        GenerateDataTable(ref myClassTable);
        SetCommand();
        Execute();

    }

    public int StudentId { get => studentId; private set => studentId = value; }

    public override void Execute()
    {
        this.DBConnection.Open();
        try
        {
            SqlDataReader classQueryResults = Command.ExecuteReader();
            while (classQueryResults.Read() == true)
            {
                myClassTable.Rows.Add(classQueryResults["ClassId"].ToString(), classQueryResults["ClassName"].ToString(), classQueryResults["ClassDate"].ToString(), classQueryResults["ClassDescription"].ToString());
            }
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
        Command.CommandText = @"SELECT ClassId, ClassName, ClassDate, ClassDescription FROM [dbo].[vClasses]";//@"SELECT ClassId, ClassName, ClassDate, ClassDescription FROM dbo.vClassesByStudents WHERE StudentId = " + StudentId.ToString();
        Command.Connection = DBConnection;
        return;
    }

    private void GenerateDataTable(ref DataTable myClassTable)
    {
        myClassTable.Columns.Add("Class Id", typeof(string));
        myClassTable.Columns.Add("Name", typeof(string));
        myClassTable.Columns.Add("Date", typeof(string));
        myClassTable.Columns.Add("Description", typeof(string));
        return;
    }


}
