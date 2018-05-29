using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AppControl
/// </summary>
public static class AppControl
{
    public static bool ValidateUserSignInRequest(string userName, string password)
    {
        SQLSignIn validateUserSignIn = new SQLSignIn(userName, password);
        validateUserSignIn.ExecuteSproc();
        if (validateUserSignIn.IsSuccessful)
            return true;
        return false;
    }

    public static void CreateUserSession(string userName)
    {
        User currentUser = new User(userName) { IsLoggedIn = true };
        HttpContext.Current.Session["AuthenticatedUser"] = currentUser;
        return;
    }

    public static bool IsUserLoggedIn()
    {
        if (HttpContext.Current.Session["AuthenticatedUser"] != null)
            return (((User)HttpContext.Current.Session["AuthenticatedUser"]).IsLoggedIn);
        return false;

    }
}