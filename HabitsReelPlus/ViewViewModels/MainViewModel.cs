using HabitsReelPlus.Models;
using HabitsReelPlus.ViewViewModels.Login;
using HabitsReelPlus.ViewViewModels.Settings;
using MyFirstMobileApp.ViewViewModels.Base;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        public String LoginTitle { get; } = TitleMain.LoginTitle;
        public String SettingTitle { get; } = TitleSettings.TitleSetting;

        public ICommand OnLoginClicked { get; set; }
        public ICommand OnSettingClicked { get; set; }

        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;

            OnLoginClicked = new Command(OnLoginClickedAsync);
            OnSettingClicked = new Command(OnSettingClickedAsync);
        }

        private async void OnLoginClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LoginView());
        }

        private async void OnSettingClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SettingsView());
        }
    }
}
