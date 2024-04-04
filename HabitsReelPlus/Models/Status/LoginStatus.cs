using System.Diagnostics;

namespace HabitsReelPlus.Models.Status
{
    public static class LoginStatus
    {
        public static Boolean IsLoggedIn { get; set; } = false;

        public static void login()
        {
            if (!IsLoggedIn)
            {
                IsLoggedIn = true;
                MessagingCenter.Send<App>(Application.Current as App, "LoggedIn");
                Debug.WriteLine("Logging In");
            }
            Debug.WriteLine("Logged in has been executed");
        }

        public static void logout()
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
            }
        }
    }
}
