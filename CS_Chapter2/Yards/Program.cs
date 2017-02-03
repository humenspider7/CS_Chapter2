using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;

            double peryard = 2.69;
            double areainfeet = length * width;
            double cost = (areainfeet / 9.00) * peryard; 
            Console.WriteLine("The total cost would be: " + cost + "$.");

        }
    }
}
