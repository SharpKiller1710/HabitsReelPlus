namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days;

public partial class MondayView : ContentPage
{
	public MondayView()
	{
		InitializeComponent();
		BindingContext = new MondayViewModel();
	}
}