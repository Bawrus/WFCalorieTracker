using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class Ingredient
    {
        private string name;
        private double energeticValue; // kCal/g
        private int weight; //g

        //constructors
        public Ingredient(string name, double energeticValue, int weight)
        {
            this.name = name;
            this.energeticValue = energeticValue;
            this.weight = weight;
        }
    }
}
