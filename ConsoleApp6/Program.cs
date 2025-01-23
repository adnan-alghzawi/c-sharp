using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        class Calculator
        {
            // Method 1: No parameters
            public void Add()
            {
                Console.WriteLine("No parameters provided.");
            }

            // Method 2: Two integer parameters
            public void Add(int a, int b)
            {
                Console.WriteLine($"Sum of integers: {a + b}");
            }

            // Method 3: Two double parameters
            public void Add(double a, double b)
            {
                Console.WriteLine($"Sum of doubles: {a + b}");
            }
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add();             // Calls method with no parameters
            calc.Add(3, 5);         // Calls method with integer parameters
            calc.Add(3.5, 4.2);     // Calls method with double parameters
        }
    }
}
