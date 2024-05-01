using HabitsReelPlus.ViewViewModels.Settings;
using HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts;
using MyFirstMobileApp.ViewViewModels.Base;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels.SplashPage
{
    public class SplashPageViewModel : BaseViewModel
    {
        public ICommand OnSettingsClicked { get; }
        public ICommand OnDefaultClicked { get; set;  }

        public SplashPageViewModel() 
        {
            Title = "HabitsReel+";
            OnSettingsClicked = new Command(settingsClickedAsync);
            OnDefaultClicked = new Command(defaultClickedAsync);

        }

        public async void settingsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SettingsView());
        }

        public async void defaultClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DefaultView());
        }
    }
}
