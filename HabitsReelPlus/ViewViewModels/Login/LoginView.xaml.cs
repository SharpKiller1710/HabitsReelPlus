namespace HabitsReelPlus.ViewViewModels.Login;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}