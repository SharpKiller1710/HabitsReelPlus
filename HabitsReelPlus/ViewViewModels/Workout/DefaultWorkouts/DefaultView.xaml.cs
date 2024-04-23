namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts;

public partial class DefaultView : ContentPage
{
	public DefaultView()
	{
		InitializeComponent();
		BindingContext = new DefaultViewModel();
	}
}