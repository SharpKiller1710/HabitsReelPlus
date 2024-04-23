using HabitsReelPlus.Models;
using HabitsReelPlus.ViewViewModels.SplashPage;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels.Login;
public partial class LoginView : ContentPage
{
	public LoginView()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel();
    }

    public ICommand OnLoginClicked { get; }

    public static string Text { get; private set; }

    public async void OnLoginClickedAsync(object sender, EventArgs e)
    {
        string entryText = UsernameValue.Text;
        string passText = PasswordValue.Text;

        if (string.IsNullOrEmpty(entryText))
        {
            //Entry is empty, show an alert
            Application.Current.MainPage.DisplayAlert(TitleMain.UsernameTitle, "Entry is empty. Please enter text.", "OK");
        }
        else
        {
            //Entry is not empty, notify the user of what they typed
            Application.Current.MainPage.DisplayAlert(TitleMain.UsernameTitle, "You entered:" + entryText, "OK");
        }

        if (entryText == "DieGuy")
        {
            if (passText == "DeadGuy1991")
            {
                await Application.Current.MainPage.Navigation.PushAsync(new SplashPageView());
            }
        }

    }
}