using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            // set properties

            Car myOtherCar = myCar;

            Car myThirdCar = new Car("Honda", "Civic", 1998, "Red");

            myOtherCar = null;
            myCar = null;

            Car.Equals

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrize { get; set; }

        public Car()
        {
            //  You could do this from a config file, database etc.
            //  I'll just hardcode in this instance.

            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color);
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        
        /*
        public Car(someOtherInputParameter, string model, int year, string color);
        {
            Make = someOtherInputParameter;
            Model = model;
            Year = year;
            Color = color;
        }
        */

    public static void myMethod()
    {

    }


        

    }
}
