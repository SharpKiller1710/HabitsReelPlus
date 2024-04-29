namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days;

public partial class FridayView : ContentPage
{
	public FridayView()
	{
		InitializeComponent();
		BindingContext = new FridayViewModel();
	}
}