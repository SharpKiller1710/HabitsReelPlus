using HabitsReelPlus.Models;
using MyFirstMobileApp.ViewViewModels.Base;

namespace HabitsReelPlus.ViewViewModels.Settings
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel() 
        {
            Title = TitleSettings.TitleSetting;
        }
    }
}
