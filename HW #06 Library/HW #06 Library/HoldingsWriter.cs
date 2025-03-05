using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__06_Library
{
    internal class HoldingsWriter
    {

        public static void PrintHoldings(List <Holding> CheckedOut, List<Holding> CheckedIn)
        {



            Console.WriteLine("\nHere are the library's holdings:");

            Console.WriteLine("These holdings are checked out:");
            if (CheckedOut.Count == 0)
                Console.WriteLine("No holdings are checked out.");
            else
            {
                foreach (Holding h in CheckedOut)
                {
                    Console.WriteLine(h);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nThese holdings are available:");
            if (CheckedIn.Count == 0)
                Console.WriteLine("No holdings are available.");
            else
            {
                foreach (Holding h in CheckedIn)
                {
                    Console.WriteLine(h);
                    Console.WriteLine();
                }
            }



        }

    }
}
