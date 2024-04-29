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
        public string TuesdayTitle { get; } = TitleMain.TuesdayTitle;
        public string WednesdayTitle { get; } = TitleMain.WednesdayTitle;
        public string ThursdayTitle { get; } = TitleMain.ThursdayTitle;
        public string FridayTitle { get; } = TitleMain.FridayTitle;
        public string SaturdayTitle { get; } = TitleMain.SaturdayTitle;
        public string SundayTitle { get; } = TitleMain.SundayTitle;


        public ICommand OnMondayClicked { get; set; }
        public ICommand OnTuesdayClicked { get; set; }
        public ICommand OnWednesdayClicked { get; set; }
        public ICommand OnThursdayClicked { get; set; }
        public ICommand OnFridayClicked { get; set; }
        public ICommand OnSaturdayClicked { get; set; }
        public ICommand OnSundayClicked { get; set; }

        public DefaultViewModel()
        {

            Title = TitleDefault.DefaultTitle;

            OnMondayClicked = new Command(OnMondayClickedAsync);
            OnTuesdayClicked = new Command(OnTuesdayClickedAsync);
            OnWednesdayClicked = new Command(OnWednesdayClickedAsync);
            OnThursdayClicked = new Command(OnThursdayClickedAsync);
            OnFridayClicked = new Command(OnFridayClickedAsync);
            OnSaturdayClicked = new Command(OnSaturdayClickedAsync);
            OnSundayClicked = new Command(OnSundayClickedAsync);
        }

        private async void OnMondayClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MondayView());
        }
        private async void OnTuesdayClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TuesdayView());
        }
        private async void OnWednesdayClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new WednesdayView());
        }
        private async void OnThursdayClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ThursdayView());
        }
        private async void OnFridayClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FridayView());
        }
        private async void OnSaturdayClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SaturdayView());
        }
        private async void OnSundayClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SundayView());
        }
    }
    
}
