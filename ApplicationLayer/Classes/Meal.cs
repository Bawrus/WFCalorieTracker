using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class Meal
    {
        private string name;
        private double energeticValue; // kCal/g
        private int weight; //g
        private List<Ingredient> ingredients;

        // constructors
        public Meal(string name, double energeticValue, int weight)
        {
            this.name = name;
            this.energeticValue = energeticValue;
            this.weight = weight;
        }

        public Meal(string name, double energeticValue, int weight, List<Ingredient> ingredients)
        {
            this.name = name;
            this.energeticValue = energeticValue;
            this.weight = weight;
            this.ingredients = ingredients;
        }
    }
}
