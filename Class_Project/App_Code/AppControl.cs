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
        SQLSignIn signInAttempt = new SQLSignIn(userName, password);
        signInAttempt.ExecuteSproc();
        if (signInAttempt.IsSuccessful)
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
        if (IsThereAnActiveUserSession())
        {
            bool IsUserAuthenticated = ((User)HttpContext.Current.Session["AuthenticatedUser"]).IsLoggedIn;
            if (IsUserAuthenticated) return true;
        }
        return false;
    }

    private static bool IsThereAnActiveUserSession()
    {
        if (HttpContext.Current.Session["AuthenticatedUser"] != null) return true;
        return false;
    }
}