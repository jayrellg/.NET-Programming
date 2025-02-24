using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__05_Investments
{   //inheriting from Investment class
    class CD : Investment
    {
        private double interestRate;
        public double InterestRate 
        {
            get { return interestRate; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Interest rate cannot be negative.");
                interestRate = value;
            }
        }
        // Default constructor
        public CD ()
        {
            InterestRate = 0;
        }
        // Non-feault Constructor 
        public CD(string id, string customerName, string openingDate, double balance, double interestRate) : base(id, customerName, openingDate, balance)
        {
            InterestRate = interestRate;
        }

        //Apply interest rate
        public override void ApplyAutomaticAdjustment()
        {
            Balance += Balance * (InterestRate / 100);
        }

        //return the type of investment
        public override string GetInvestmentType()
        {
            return "CD";
        }
        // returns  interest rate information along with the base investment info
        public override string ToString()
        {
            // Calls base class's ToString method and append interest rate information
            return base.ToString() + $", Interest Rate = {InterestRate:0.00}%";
        }
    }


}

