using HabitsReelPlus.Models;
using HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels.Workout
{
    internal class WorkoutViewModel : MyFirstMobileApp.ViewViewModels.Base.BaseViewModel
    {


        public string DefaultTitle { get; } = TitleMain.DefaultTitle;


        public ICommand OnDefaultClicked { get; set; }

        public WorkoutViewModel() 
        {

            Title = TitleWorkout.WorkoutTitle;

            OnDefaultClicked = new Command(OnDefaultClickedAsync);
        }

        private async void OnDefaultClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DefaultView());
        }
    }
}
