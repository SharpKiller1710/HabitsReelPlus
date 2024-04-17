﻿using HabitsReelPlus.Models;
using HabitsReelPlus.ViewViewModels.Login;
using HabitsReelPlus.ViewViewModels.Settings;
using HabitsReelPlus.ViewViewModels.Workout;
using MyFirstMobileApp.ViewViewModels.Base;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        public string LoginTitle { get; } = TitleMain.LoginTitle;
        public string SettingTitle { get; } = TitleSettings.TitleSetting;
        public string WorkoutTitle { get; } = TitleWorkout.WorkoutTitle;

        public ICommand OnLoginClicked { get; set; }
        public ICommand OnSettingClicked { get; set; }
        public ICommand OnWorkoutClicked { get; set; }

        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;

            OnLoginClicked = new Command(OnLoginClickedAsync);
            OnSettingClicked = new Command(OnSettingClickedAsync);
            OnWorkoutClicked = new Command(OnWorkoutClickedAsync);
        }

        private async void OnLoginClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LoginView());
        }

        private async void OnSettingClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SettingsView());
        }

        private async void OnWorkoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutView());
        }
    }
}
