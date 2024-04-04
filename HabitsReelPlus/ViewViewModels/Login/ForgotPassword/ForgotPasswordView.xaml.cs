namespace HabitsReelPlus.ViewViewModels.Login.ForgotPassword;

public partial class ForgotPasswordView : ContentPage
{
	public ForgotPasswordView()
	{
		InitializeComponent();
        BindingContext = new ForgotPasswordViewModel();
    }
}