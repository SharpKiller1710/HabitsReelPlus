namespace HabitsReelPlus.ViewViewModels.Settings;

public partial class SettingsView : ContentPage
{
	public SettingsView()
	{
		InitializeComponent();
        BindingContext = new SettingsViewModel();
    }
}