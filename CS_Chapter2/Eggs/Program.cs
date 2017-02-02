using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE
            int chickenJohnny = 69;
            int chickenAl = 32;
            int chickenMrBossMan = 47;
            int chickenLoserMcGee = 48;
            int total = chickenJohnny + chickenAl + chickenLoserMcGee + chickenMrBossMan;

            Console.WriteLine("The total amount of eggs produced: " + total / 12 + " dozen eggs and " + total % 12 + " eggs.");

        }
    }
}
