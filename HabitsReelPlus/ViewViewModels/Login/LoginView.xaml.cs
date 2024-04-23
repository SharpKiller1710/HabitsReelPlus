using HabitsReelPlus.Models;
using HabitsReelPlus.ViewViewModels.SplashPage;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels.Login;
public partial class LoginView : ContentPage
{
	public LoginView()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel();

        string entryText = UsernameValue.Text;
        string passText = PasswordValue.Text;
    }
}