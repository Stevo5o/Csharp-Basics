using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        // fields
        private string _make;
        private string _model;
        private int _elapsedMilage;

        /* 
         * constructor excuted each time a new
         * instance of this car class is created
         */

        public Car()
        {
            _make = "DEFAULT";
            _model = "DEFAULT";
            _elapsedMilage = 0;

            // pop-up used to display the call to the constructor
            System.Windows.Forms.MessageBox.Show("Called Constructor");
        }

        public Car(string make, string model, int elapsedMilage)
        {
            _make = make;
            _model = model;
            _elapsedMilage = elapsedMilage;
        }

        // properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int ElapsedMilage
        {
            get { return _elapsedMilage; }
            set { _elapsedMilage = value; }
        }

        public string Drive(int miles)
        {
            _elapsedMilage += miles;

            // could preform some additional calculations here
            // for determining fuel consumption and wear and tear
            // costs

            string result;
            result = "The " + Make + " " + _model + " now has " + _elapsedMilage + " miles.";
            return result;

        }
    }
}
