using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_objects
{
    public class Validator
    {
        public double userInput { get; set; }
        
        public Validator(double userInput)
        {
            userInputs = userInput;
        }

        public double userInputs { get; set; }
        public double validateInput()
        {
            while (true);
            {
                Console.WriteLine(userInputs);
                string userInput = Console.ReadLine();
                if (double.TryParse(userInput, out double result))
                {
                    return result;
                }

                Console.WriteLine("Invalid input, press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
