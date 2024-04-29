namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days;

public partial class ThursdayView : ContentPage
{
	public ThursdayView()
	{
		InitializeComponent();
		BindingContext = new ThursdayViewModel();
	}
}