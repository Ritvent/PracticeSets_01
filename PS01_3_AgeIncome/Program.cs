using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_3_AgeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input age");
            int inputAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input salary");
            double inputIncome = double.Parse(Console.ReadLine());
            Console.WriteLine(Category(inputAge, inputIncome));

            


        }
        static string Category(int inputAge, double inputIncome)
        {
            if (inputAge >= 25 && inputAge <= 35 && inputIncome >= 50000)
            {
                return "Young Professional";
            }
            else if (inputAge >= 36 && inputAge <= 55 && inputIncome >= 70000)
            {
                return "Middle-Aged Professional";
            }
            else if (inputAge >= 56 && inputIncome <= 30000)
            {
                return "Senior Citizen";
            }
            else
            {
                return "Other";
            }

        }
    }
}
    
