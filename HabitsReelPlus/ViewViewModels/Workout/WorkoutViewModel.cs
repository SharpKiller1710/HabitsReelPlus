using HabitsReelPlus.Models;
using HabitsReelPlus.ViewViewModels.Settings;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels.Workout
{
    internal class WorkoutViewModel : MyFirstMobileApp.ViewViewModels.Base.BaseViewModel
    {

        public ICommand OnSettingsClicked { get; }
        public WorkoutViewModel() 
        {
            Title = TitleWorkout.WorkoutTitle;
            OnSettingsClicked = new Command(settingsAsync);
        }

        public async void settingsAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SettingsView());
        }
    }
}
