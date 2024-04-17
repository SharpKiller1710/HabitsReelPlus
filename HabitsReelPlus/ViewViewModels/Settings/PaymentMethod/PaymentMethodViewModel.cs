using HabitsReelPlus.Models;
using MyFirstMobileApp.ViewViewModels.Base;

namespace HabitsReelPlus.ViewViewModels.Settings.PaymentMethod
{
    

    internal class PaymentMethodViewModel : BaseViewModel
    {

        private string _holder = string.Empty;
        private string _cardnum = string.Empty;
        private string _cvv = string.Empty;
        private string _expiry = string.Empty;
        private string _entryText = string.Empty;

        public PaymentMethodViewModel()
        {
            Title = TitleSettings.TitlePaymentMethod;
            
        }


        public string SettingsTitle { get; } = TitleSettings.TitlePaymentMethod;

        public string Holder
        {
            get
            {
                return _holder;
            }
            set
            {
                if (_holder != value)
                {
                    _holder = value;
                }
            }
        }

        public string CardNumber
        {
            get
            {
                return _cardnum;
            }
            set
            {
                if (_cardnum != value)
                {
                    _cardnum = value;
                }
            }
        }

        public string SecurityCode
        {
            get
            {
                return _cvv;
            }
            set
            {
                if (_cvv != value)
                {
                    _cvv = value;
                }
            }
        }

        public string Expiration
        {
            get
            {
                return _expiry;
            }
            set
            {
                if (_expiry != value)
                {
                    _expiry = value;
                }
            }
        }

        private async void OnEntryClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(TitleMain.UsernameTitle, "Username can't be empty!", "OK");
                return;
            }

            await Application.Current.MainPage.Navigation.PushAsync(new PaymentMethodView());
        }
    }

    
}
