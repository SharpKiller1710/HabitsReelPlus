namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days;

public partial class SundayView : ContentPage
{
	public SundayView()
	{
		InitializeComponent();
		BindingContext = new SundayViewModel();
	}
}