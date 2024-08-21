using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            if (inputNum % 2 == 0)
            {
                Console.WriteLine($"The number {inputNum} is even");
            }
            else
            {
                Console.WriteLine($"The number {inputNum} is odd");
            }
        }
    }
}
