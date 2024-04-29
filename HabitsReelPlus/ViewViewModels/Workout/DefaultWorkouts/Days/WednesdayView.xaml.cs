namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days;

public partial class WednesdayView : ContentPage
{
	public WednesdayView()
	{
		InitializeComponent();
		BindingContext = new WednesdayViewModel();
	}
}