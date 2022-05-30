using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class TdeeCalculator
    {
        public double CalculateBMR(User user)
        {
            double output = 10 * user.getWeight + Math.Round(6.25 * user.getHeight, 0) - 5 * user.getAge;

            return output;
        }

        public double CalculateActivityMultiplier(User user)
        {
            double output;

            switch (user.getActivityLevel)
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

        public double CalculateTDEE(double BMR, double activityLevelMultiplier, User user)
        {
            BMR = CalculateBMR(user);
            activityLevelMultiplier = CalculateActivityMultiplier(user);
            double output = BMR * activityLevelMultiplier;

            return output;
        }
    }
}
