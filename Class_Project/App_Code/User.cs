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
    private bool isLoggedIn = false;
    public User(string user)
    {
        UserName = user;
    }

    public string UserName { get => userName; private set => userName = value; }
    public bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }
}