namespace HabitsReelPlus.ViewViewModels.SplashPage;

public partial class SplashPageView : ContentPage
{
	public SplashPageView()
	{
		InitializeComponent();
		BindingContext = new SplashPageViewModel();
	}
}