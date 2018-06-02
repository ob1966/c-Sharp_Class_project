using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AppControl
/// </summary>
public static class AppControl
{
    public static SQLSignIn ValidateUserSignInRequest(string userName, string password)
    {
        SQLSignIn signInAttempt = new SQLSignIn(userName, password);
        signInAttempt.Execute();
        return signInAttempt;
    }

    public static void CreateUserSession(string userName, int userID)
    {
        User currentUser = new User(userName, userID) { IsLoggedIn = true };
        HttpContext.Current.Session["AuthenticatedUser"] = currentUser;
        return;
    }

    public static DataTable RetrieveMyClasses(int studentId)
    {
        SQLGetMyClasses myClasses = new SQLGetMyClasses(studentId);
        return myClasses.myClassTable;
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

    public static DataTable GetListOfClasses()
    {
        SQLClasses classes = new SQLClasses();
        return classes.classTable;
    }

    public static bool RegsiterForClass(int classID, int studentID)
    {
        SQLResiterForClass classRegistration = new SQLResiterForClass(classID, studentID);
        classRegistration.Execute();
        return classRegistration.IsSuccessful;
    }

}