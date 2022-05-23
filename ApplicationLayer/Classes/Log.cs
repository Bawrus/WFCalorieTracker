using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class Log
    {
        private DateTime date;
        private List<Activity> dailyActivities;
        private List<Meal> dailyMeals;

        // constructors
        public Log(DateTime date)
        {
            this.date = date;
        }
        public Log(DateTime date, List<Activity> dailyActivities, List<Meal> dailyMeals)
        {
            this.date = date;
            this.dailyActivities = dailyActivities;
            this.dailyMeals = dailyMeals;
        }

        // class methods
        public void AddMealToLog(Meal newMeal)
        {
            ;
        }

        public void AddActivityToLog(Activity newActivity)
        {
            ;
        }
    }
}
