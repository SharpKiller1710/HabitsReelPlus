using HabitsReelPlus.Models;
using HabitsReelPlus.ViewViewModels.Login;
using MyFirstMobileApp.ViewViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        public String LoginTitle { get; } = TitleMain.LoginTitle;

        public ICommand OnLoginClicked { get; set; }

        public MainViewModel() 
        {
            Title = TitleMain.MainTitle;

            OnLoginClicked = new Command(OnLoginClickedAsync);
        }

        private async void OnLoginClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LoginView());
        }
    }
}
