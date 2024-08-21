using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You will be computing the area or the perimeter of a circle, please enter the radius");
            double radius = double.Parse(Console.ReadLine());
            UserChoice(radius);
        }
        static void UserChoice(double radius)
        {
            bool keepContinue = true;
            while (keepContinue)
            {
                Console.WriteLine("Please enter 'A' to compute the area of the Circle\nPlease enter 'P' to compute the perimeter of the circle\nPlease enter 'X' to exit");
                char userChoice = char.Parse(Console.ReadLine().ToUpper());
                double pi = 3.1415;
                switch (userChoice)
                {
                    case 'A':
                        
                        double area = pi * (radius * radius);
                        Console.WriteLine($"The area is {area}");
                        break;

                    case 'P':
                        double perimeter = 2 * pi * radius;
                        Console.WriteLine($"The perimeter is {perimeter}");
                        break;

                    case 'X':
                        Console.WriteLine("Exiting . . .");
                        keepContinue = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
        }
    }
}
