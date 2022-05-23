using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class WeightGoal
    {
        private int goalWeight; // kg
        private double weeklyWeightLoss; // kg / week

        // constructors
        public WeightGoal(int goalWeight)
        {
            this.goalWeight = goalWeight;
        }

        public WeightGoal(double weeklyWeightLoss)
        {
            this.weeklyWeightLoss = weeklyWeightLoss;
        }
    }
}
