using HabitsReelPlus.Models;
using MyFirstMobileApp.ViewViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days
{
    internal class SundayViewModel : BaseViewModel
    {
        public SundayViewModel()
        {

            Title = TitleSunday.SundayTitle;
        }
        public ImageSource GetImageSource
        {


            get
            {
                return ImageSource.FromFile("restday.png");
            }
        }
    }
}
