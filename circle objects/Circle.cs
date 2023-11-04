using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_objects
{
    public class Circle
    {
        public Circle(double radius) // CONSTRUCTOR
        {
            this.Radius = radius;
        }

        
        private double Radius { get; set; } //
        public double Diameter { get; set; }
        public double Cicumference { get; set; }
        public double  Area { get; set; }

        public double CalculateDiameter() //
        {
            return Radius * 2;
        }

        public double CalculateCirumference() //
        {
            return Radius * 2 * 3.14;
        }

        public double CalculateArea() //
        {
            return 3.14 * Radius * Radius;
        }

        public void Grow() //       
        {


            string Answer = "y";
            while (Answer == "y" || Answer == "Y")
            {
                Console.WriteLine($"The new radius is {GetRadius()}");
                Console.WriteLine($"The diamater is {CalculateDiameter()}");
                Console.WriteLine($"The circumference is {CalculateCirumference()}");
                Console.WriteLine($"The area is {CalculateArea()}");

                Console.WriteLine("Should the circle grow (y/n)?");
                Answer = Console.ReadLine();

            }
        
            Console.WriteLine($"Goodbye. The circle's final radius is {Radius}");
        }
        

        public double GetRadius() //
        {

            return Radius *= 2;
        }

    }
}
