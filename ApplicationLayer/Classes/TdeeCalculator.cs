using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class TdeeCalculator
    {
        private User appUser;
        
        public double CalculateBMR(int weight, int height, int age)
        {
            weight = appUser.getWeight;
            height = appUser.getHeight;
            age = appUser.getAge;

            double output = 10 * weight + Math.Round(6.25 * height, 0) - 5 * age;

            return output;
        }

        public double CalculateActivityMultiplier(string activityLevel)
        {
            activityLevel = appUser.getActivityLevel;
            double output;

            switch (activityLevel)
            {
                case "Sedentary":
                    output = 1.2;
                    break;
                case "Lightly active":
                    output = 1.375;
                    break;
                case "Moderately active":
                    output = 1.55;
                    break;
                case "Heavily active":
                    output = 1.725;
                    break;
                case "Athlete":
                    output = 1.9;
                    break;
                default:
                    output = 1.2;
                    break;
            }

            return output;
        }

        public double CalculateTDEE(double BMR, double activityLevelMultiplier)
        {
            BMR = CalculateBMR(appUser.getWeight, appUser.getHeight, appUser.getAge);
            activityLevelMultiplier = CalculateActivityMultiplier(appUser.getActivityLevel);
            double output = BMR * activityLevelMultiplier;

            return output;
        }
    }
}
