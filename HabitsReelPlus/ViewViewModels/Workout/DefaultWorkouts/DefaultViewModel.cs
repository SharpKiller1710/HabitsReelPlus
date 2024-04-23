using HabitsReelPlus.Models;
using HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days;
using MyFirstMobileApp.ViewViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts
{
    internal class DefaultViewModel : MyFirstMobileApp.ViewViewModels.Base.BaseViewModel
    {
        public string MondayTitle { get; } = TitleMain.MondayTitle;


        public ICommand OnMondayClicked { get; set; }

        public DefaultViewModel()
        {

            Title = TitleDefault.DefaultTitle;

            OnMondayClicked = new Command(OnMondayClickedAsync);
        }

        private async void OnMondayClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MondayView());
        }
    }
    
}
