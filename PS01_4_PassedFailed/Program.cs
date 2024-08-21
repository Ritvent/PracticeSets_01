using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_4_PassedFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input student's exam score");
            int inputScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Condition(inputScore));

        }
        static string Condition(int inputScore)
        {
            return (inputScore >= 50) ? "Passed" : "Failed";
        }
    }
}
