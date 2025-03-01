using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__06_Library
{
    internal class Book : Holding
    {
        public string Author { get; set; }
        private int copyrightYear;
        public int CopyrightYear
        {
            get { return copyrightYear; }
            set
            {
                if (value >= 1800 && value <= 2025)
                    copyrightYear = value;
                else
                    throw new ArgumentException("Invalid year");
            }
        }

        public Book ()
        {
            CopyrightYear = 0;
            Author = "";
        }

        public Book(int id, string title, string description, int year, string author) : base(id, title, description)
        {
            CopyrightYear = year;
            Author = author;
        }



        public override string HoldingType()
        {
            return "Book";
        }


        public override string ToString()
        {
            return base.ToString() + $"\n{Author}\n{CopyrightYear}";
        }

    }
}
