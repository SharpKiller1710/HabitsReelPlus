using HabitsReelPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitsReelPlus.ViewViewModels.Workout
{
    internal class WorkoutViewModel : MyFirstMobileApp.ViewViewModels.Base.BaseViewModel
    {
        public WorkoutViewModel() 
        {
            Title = TitleWorkout.WorkoutTitle;
        }
    }
}
