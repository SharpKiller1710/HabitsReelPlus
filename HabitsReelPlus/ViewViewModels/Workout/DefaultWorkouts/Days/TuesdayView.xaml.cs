namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days;

public partial class TuesdayView : ContentPage
{
	public TuesdayView()
	{
		InitializeComponent();
		BindingContext = new TuesdayViewModel();
	}
}