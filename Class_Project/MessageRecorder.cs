using System.Data.SqlClient;

public class MessageRecorder
{
    private static string connectionString = @"Data Source= LTPLOANER32\AU2017;" +
                                        "Initial Catalog= ASPNetHomework;" +
                                        "Integrated Security=  true";
    SqlConnection conn = new SqlConnection(connectionString);
    private readonly string name;
    private readonly string email;
    private readonly string username;
    private readonly string message;

    public MessageRecorder()
    {

    }

    public MessageRecorder(string name, string email, string username, string message)
    {
        this.name = name;
        this.email = email;
        this.username = username;
        this.message = message;
    }

    public bool SubmitRequest()
    {

        SqlCommand cmd = NewAccountRequest();

        conn.Open();
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch
        {
            return false;
        }
        finally
        {
            conn.Close();
        }

        return true;
    }

    private SqlCommand NewAccountRequest()
    {
        SqlCommand cmd = new SqlCommand("EXEC [dbo].[sproc_InsLogins] @name, @emailAddress, @loginName, @reasonForAccess", conn);

        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@emailAddress", email);
        cmd.Parameters.AddWithValue("@loginName", username);
        cmd.Parameters.AddWithValue("@reasonForAccess", message);
        return cmd;
    }

    public bool IsRequestingUniqueLoginName()
    {
        SqlCommand cmd = new SqlCommand("SELECT LoginName FROM Logins WHERE LoginName LIKE @loginName", conn);

        cmd.Parameters.AddWithValue("@loginName", username);

        conn.Open();
        try
        {
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return false;
            return true; 
        }
        catch
        {
            return false;
        }
        finally
        {
            conn.Close();
        }


    }
}
