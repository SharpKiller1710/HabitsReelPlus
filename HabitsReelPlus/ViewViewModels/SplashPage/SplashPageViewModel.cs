using HabitsReelPlus.ViewViewModels.Settings;
using MyFirstMobileApp.ViewViewModels.Base;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels.SplashPage
{
    public class SplashPageViewModel : BaseViewModel
    {
        public ICommand OnSettingsClicked { get; }

        public SplashPageViewModel() 
        {
            Title = "HabitsReel+";
            OnSettingsClicked = new Command(settingsClickedAsync);

        }

        public async void settingsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SettingsView());
        }
    }
}
