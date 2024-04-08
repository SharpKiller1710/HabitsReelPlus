using HabitsReelPlus.ViewViewModels;

namespace HabitsReelPlus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
        }
    }
}