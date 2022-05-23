using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class Activity
    {
        private string name;
        private double energeticValue; // kCal / h
        private int duration; // s

        // constructors
        public Activity(string name, double energeticValue)
        {
            this.name = name;
            this.energeticValue = energeticValue;
        }

        public Activity(string name, double energeticValue, int duration)
        {
            this.name = name;
            this.energeticValue = energeticValue;
            this.duration = duration;
        }
    }
}