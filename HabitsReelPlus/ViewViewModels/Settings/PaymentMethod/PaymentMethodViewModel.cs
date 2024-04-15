using HabitsReelPlus.Models;
using MyFirstMobileApp.ViewViewModels.Base;

namespace HabitsReelPlus.ViewViewModels.Settings.PaymentMethod
{
    internal class PaymentMethodViewModel : BaseViewModel
    {
        public string SettingsTitle { get; } = TitleSettings.TitlePaymentMethod;
    }
}
