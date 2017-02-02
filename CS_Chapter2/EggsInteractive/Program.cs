using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many eggs Cowardly Al laid:");
            String chickenCowardlyAl = Console.ReadLine();
            int cowardlyAl = Convert.ToInt32(chickenCowardlyAl);

            Console.WriteLine("Enter how many eggs Cowardly Rueben laid:");
            String chickenCowardlyRueben = Console.ReadLine();
            int cowardlyRueben = Convert.ToInt32(chickenCowardlyRueben);

            Console.WriteLine("Enter how many eggs Joegay laid:");
            String chickenJoeGay = Console.ReadLine();
            int Joegay = Convert.ToInt32(chickenJoeGay);

            Console.WriteLine("Enter how many eggs Sir Yusufl laid:");
            String sirYusuf = Console.ReadLine();
            int sirYusufI = Convert.ToInt32(sirYusuf);

           int total = (cowardlyAl + cowardlyrueben + Joegay + sirYusufI);

           Console.WriteLine("The total amount of eggs from the lunch loser squad is: " + total / 12 + " dozen eggs and " + total % 12 + " eggs.");
        }
    }
}
