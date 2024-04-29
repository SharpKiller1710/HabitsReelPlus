namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days;

public partial class SaturdayView : ContentPage
{
	public SaturdayView()
	{
		InitializeComponent();
		BindingContext = new SaturdayViewModel();
	}
}