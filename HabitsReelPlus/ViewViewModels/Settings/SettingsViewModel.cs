using HabitsReelPlus.Models;
using HabitsReelPlus.ViewViewModels.Settings.PaymentMethod;
using MyFirstMobileApp.ViewViewModels.Base;
using System.Windows.Input;

namespace HabitsReelPlus.ViewViewModels.Settings
{
    public class SettingsViewModel : BaseViewModel
    {

        public ICommand OnPaymentClicked { get; }

        public SettingsViewModel() 
        {
            Title = TitleSettings.TitleSetting;
            OnPaymentClicked = new Command(paymentMethodAsync);
        }

        public async void paymentMethodAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PaymentMethodView());
        }
    }
}
