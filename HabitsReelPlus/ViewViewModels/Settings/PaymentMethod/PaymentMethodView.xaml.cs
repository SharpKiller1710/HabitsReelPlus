using HabitsReelPlus.Models;

namespace HabitsReelPlus.ViewViewModels.Settings.PaymentMethod;

public partial class PaymentMethodView : ContentPage
{
	public PaymentMethodView()
	{
		InitializeComponent();
        BindingContext = new PaymentMethodViewModel();
    }

    public static string Text { get; private set; }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        string entryText = PaymentMethodView.Text;

        if (string.IsNullOrEmpty(entryText))
        {
            //Entry is empty, show an alert
            Application.Current.MainPage.DisplayAlert(TitleSettings.TitlePaymentMethod, "Entry is empty. Please enter text.", "OK");
        }
        else
        {
            //Entry is not empty, notify the user of what they typed
            Application.Current.MainPage.DisplayAlert(TitleSettings.TitlePaymentMethod, "You entered:" + entryText, "OK");
        }
    }
}
