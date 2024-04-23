using HabitsReelPlus.Models;
using HabitsReelPlus.Models.Status;
using HabitsReelPlus.ViewViewModels.Login.ForgotPassword;
using HabitsReelPlus.ViewViewModels.Login.SignUp;
using HabitsReelPlus.ViewViewModels.SplashPage;
using MyFirstMobileApp.ViewViewModels.Base;
using System.Diagnostics;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels.Login
{
    internal class LoginViewModel : BaseViewModel
    {
        public ICommand OnForgotClicked { get; }
        public ICommand LoginButtonClicked { get; }
        public ICommand SignUpClicked { get; }
        public ICommand SignInClicked { get; }
        public ICommand OnLoginClicked { get; }


        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _entryText = string.Empty;
        public static string Text { get; private set; }


        public string ForgotTitle { get; } = TitleMain.FgtPwd;
        public string SignUpTitle { get; } = TitleMain.SignUpTitle;

        public LoginViewModel()
        {
            Title = TitleMain.LoginTitle;
            OnForgotClicked = new Command(forgetPasswordAsync);
            LoginButtonClicked = new Command(loginButtonClicked);
            SignUpClicked = new Command(signUpClicked);
            SignInClicked = new Command(signInClicked);
        }


        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (_username != value)
                {
                    _username = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password != value)
                {
                    _password = value;
                }
            }
        }

        
        private async void OnEntryClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(TitleMain.UsernameTitle, "Username can't be empty!", "OK");
                return;
            }

            await Application.Current.MainPage.Navigation.PushAsync(new LoginView());
        }

        public void loginButtonClicked()
        {
            LoginStatus.login();
            Debug.WriteLine("Login Button Clicked");
        }

        public async void forgetPasswordAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ForgotPasswordView());
        }

        public async void signUpClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SignUpView());
        }

        public async void OnLoginClickedAsync(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(Username))
            {
                //Entry is empty, show an alert
                Application.Current.MainPage.DisplayAlert(TitleMain.UsernameTitle, "Entry is empty. Please enter text.", "OK");
            }

            if (Username == "DieGuy")
            {
                if (Password == "DeadGuy1991")
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new SplashPageView());
                }
            }

        }

        public async void signInClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SplashPageView());
        }

    }
}