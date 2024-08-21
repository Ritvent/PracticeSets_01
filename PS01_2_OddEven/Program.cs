using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_2_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            if (inputNum > 0 )
            {
                Console.WriteLine($"The number {inputNum} is positive");
            }
            else if (inputNum > 0)
            {
                Console.WriteLine($"The number {inputNum} is negative");
            }
            else
            {
                Console.WriteLine($"The number {inputNum} is neither positive nor negative");
            }
        }
    }
}
