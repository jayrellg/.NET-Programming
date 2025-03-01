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


        public string CheckOut(int id)
        {
            Holding holding = holdings.Find(h => h.ID == id);
            if (holding != null && !holding.IsCheckedOut)
            {
                holding.CheckOut();
                return "You have checked it out.";
            }
            else if (holding.IsCheckedOut == true)
                return "This has been checkout already.";
            else
                return "There was an issue with your request";

        }







    }
}
