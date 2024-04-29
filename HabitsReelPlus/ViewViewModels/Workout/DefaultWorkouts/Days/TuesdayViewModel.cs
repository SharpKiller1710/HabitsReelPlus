﻿using HabitsReelPlus.Models;
using MyFirstMobileApp.ViewViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitsReelPlus.ViewViewModels.Workout.DefaultWorkouts.Days
{
    internal class TuesdayViewModel : BaseViewModel
    {
        public TuesdayViewModel()
        {

            Title = TitleTuesday.TuesdayTitle;
        }
        public ImageSource GetImageSource
        {


            get
            {
                return ImageSource.FromFile("upperbody.jpg");
            }
        }
    }
}
