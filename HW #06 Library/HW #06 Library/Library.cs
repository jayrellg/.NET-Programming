using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__06_Library
{
    internal class Library
    {

        List <Holding> holdings = new List <Holding> ();

        public void AddHolding (Holding holding)
        {
            holdings.Add (holding);
        }



        public void CheckOut(int id)
        {
            Holding holding = holdings.Find(h => h.ID == id);
            if (holding == null || holding.IsCheckedOut)
            {
                Console.WriteLine("There was a problem with your request , holding does not exist or is already checked out.");
                // Holding does not exist or is already checked out
            }
            else
            {
                holding.CheckOut();
                Console.WriteLine("You have checked it out.");
            }
        }

        public void CheckIn(int id)
        {
            Holding holding = holdings.Find(h => h.ID == id);
            if (holding == null || !holding.IsCheckedOut)
            {
                Console.WriteLine("There was a problem with your request, holding does not exist or is already checked in.");
                // Holding does not exist or is already checked in
            }
            else
            {
                Console.WriteLine("You have checked it in.");
                holding.CheckIn();
            }
        }


        public void ListAll()
        {
            List<Holding> checkedOutHoldings = holdings.FindAll(h => h.IsCheckedOut);
            List<Holding> checkedInHoldings = holdings.FindAll(h => !h.IsCheckedOut);


            HoldingsWriter.PrintHoldings(checkedOutHoldings, checkedInHoldings);
        }

        public void GetStats()
        {
            int checkedOut = holdings.FindAll(h => h.IsCheckedOut).Count;
            int available = holdings.Count - checkedOut;
            Console.WriteLine("Here are the library's availability stats:");
            Console.WriteLine($"{"Available",-15}{available}");
            Console.WriteLine($"{"Checked out",-15}{checkedOut}");
        }


    }
}
