using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__06_Library
{
    internal class Periodical : Holding
    {
        public string Date { get; set; }

        public Periodical()
        {
            Date = "";
        }

        public Periodical(int id, string title, string description, bool isCheckedOut, string date) : base(id, title, description, isCheckedOut)
        {
            Date = date;
        }

        public override string HoldingType()
        {
            return "Periodical";
        }

        public override string ToString()
        {
            return base.ToString() + $"\n{Date}";
        }

    }
}
