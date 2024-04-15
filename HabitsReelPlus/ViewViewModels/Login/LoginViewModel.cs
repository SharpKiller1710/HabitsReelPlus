using HabitsReelPlus.Models;
using HabitsReelPlus.Models.Status;
using HabitsReelPlus.ViewViewModels.Login.ForgotPassword;
using HabitsReelPlus.ViewViewModels.Login.SignUp;
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

        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _entryText = string.Empty;


        public string ForgotTitle { get; } = TitleMain.FgtPwd;
        public string SignUpTitle { get; } = TitleMain.SignUpTitle;

        public LoginViewModel()
        {
            Title = TitleMain.LoginTitle;
            OnForgotClicked = new Command(forgetPasswordAsync);
            LoginButtonClicked = new Command(loginButtonClicked);
            SignUpClicked = new Command(signUpClicked);
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

    }
}