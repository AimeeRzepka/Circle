using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using circle_objects;

namespace circle_objects
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                bool ValidInput;
                double Radius;
                    do
                    {

                        Console.WriteLine("Welcome to the circle game.");
                        Console.WriteLine("Please enter the radius of your circle...");
                        string userRadius = Console.ReadLine();
                        ValidInput = double.TryParse(userRadius, out Radius);

                        if (!ValidInput)
                        {
                            Console.WriteLine("Sorry, this is in invalid, press any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    }
               
                while (!ValidInput);
                    
                        Circle circle = new Circle(Radius); // creates and instance of a circle
                        Console.WriteLine($"The diamater is {circle.CalculateDiameter()}");
                        Console.WriteLine($"The circumference is {circle.CalculateCirumference()}");
                        Console.WriteLine($"The area is {circle.CalculateArea()}");

                        Console.WriteLine("Should the circle grow (y/n)?");
                        string grow = Console.ReadLine();

                        if (grow == "y" || grow == "Y")
                        {
                            circle.Grow();
                        }

                    }

                }
             


                }
        }
 


              