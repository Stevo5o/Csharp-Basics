using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Vehicle
    {
        // fields
        protected string _make;
        protected string _model;
        protected int _elapsedMilage;

        /* 
         * constructor excuted each time a new
         * instance of this car class is created
         */

        public Vehicle()
        {
            _make = "DEFAULT";
            _model = "DEFAULT";
            _elapsedMilage = 0;

            // pop-up used to display the call to the constructor
            System.Windows.Forms.MessageBox.Show("Called Constructor");
        }

        public Vehicle(string make, string model, int elapsedMilage)
        {
            _make = make;
            _model = model;
            _elapsedMilage = elapsedMilage;
        }

        // properties
        //public string Make
        //{
        //    get { return _make; }
        //    set { _make = value; }
        //}

        public string Make
        {
            get { return _make; }
            // set { return _make = value; }

            // more control, filter out values using the set statement
            set
            {
                if ((value == "DeLorean") || (value == "Ecto-1"))
                {
                    _make = value;
                }
                else
                {
                    _make = "not assigned";
                }
            }
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

        public string Drive(int kilometers)
        {
            _elapsedMilage += kilometers;

            // could preform some additional calculations here
            // for determining fuel consumption and wear and tear
            // costs

            string result;
            result = "The " + Make + " " + _model + " now has " + _elapsedMilage + " kilometers.";
            return result;

        }
    }

    // Minivan is a Car
    public class Van : Vehicle
    {
        public Van()
        {
            _make = "NA";
        }

        private int _passengers;

        public int Passengers
        {
            get { return _passengers;  }
            set { _passengers = value;  }
        }

        public string Drive(int kilometers)
        {
            _elapsedMilage += kilometers;

            double cost = Utility.CalculatePetrolPrices(kilometers);

            string result;
            result = "The " + Make + " " + _model + " now has " + _elapsedMilage + " kilometers." + cost.ToString();
            return result;
        }

    }
}
