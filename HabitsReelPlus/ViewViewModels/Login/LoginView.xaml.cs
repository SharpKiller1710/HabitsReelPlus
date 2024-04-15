using HabitsReelPlus.Models;

namespace HabitsReelPlus.ViewViewModels.Login;
public partial class LoginView : ContentPage
{
	public LoginView()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel();
    }

    public static string Text { get; private set; }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        string entryText = LoginView.Text;

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
    }
}