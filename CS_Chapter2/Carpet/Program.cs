using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE
            int length = 6;
            int width = 2;
            double squarefeet = length * width;
            double pricePerSFoot = 6.66;

            Console.WriteLine("The total cost is: " + squarefeet * pricePerSFoot + "$");
        }
    }
}
