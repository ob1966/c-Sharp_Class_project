using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
/// 
[Serializable]
public class User
{
    private string userName;
    private int userId = -1;
    private bool isLoggedIn = false;
    public User(string user)
    {
        UserName = user;
    }

    public User(string userName, int userID)
    {
        UserName = userName;
        UserId = userID;
    }

    public string UserName { get => userName; private set => userName = value; }
    public bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }
    public int UserId { get => userId; private set => userId = value; }
}