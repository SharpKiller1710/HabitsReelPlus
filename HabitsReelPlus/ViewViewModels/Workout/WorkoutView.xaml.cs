namespace HabitsReelPlus.ViewViewModels.Workout;

public partial class WorkoutView : ContentPage
{
	public WorkoutView()
	{
        InitializeComponent();
		BindingContext = new WorkoutViewModel();
	}
}