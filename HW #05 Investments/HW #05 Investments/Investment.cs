using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace HW__05_Investments
{
    abstract class Investment
    {
        private DateTime openingDate;

        // Properties for investment details
        public string ID { get; set; } 
        public string NameOfHodler { get; set; }
        public double Balance { get; set; }
        public string OpeningDate
        {
            get { return openingDate.ToString("MM/dd/yyyy"); }
            set
            {
                if (DateTime.TryParseExact(value, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    openingDate = parsedDate;
                else
                    throw new Exception("Invalid date format. Use MM/dd/yyyy.");
            }
        }

        //default contructor 
        public Investment() 
        {
            ID = "Uknown";
            NameOfHodler = "Unknown";
            OpeningDate = "No Date";
            Balance = 0.0;
        }

        //None fault Constructor to initialize an investment object with specific values
        public Investment (string id, string name, string openingDate, double balance)
        {
            ID = id;
            NameOfHodler = name;
            OpeningDate = openingDate;
            Balance = balance;
        }

        // Abstract method that must be implemented by derived classes
        public abstract void ApplyAutomaticAdjustment();
        public abstract string GetInvestmentType();
        
        // Override ToString method for string representation of the investment object
        public override string ToString()
        {
            return $"Type={GetInvestmentType()}, ID={ID}, Name of Holder = {NameOfHodler}, Opening Date = {OpeningDate}, Balance = ${Balance:0.00}";
        }



    }
}
