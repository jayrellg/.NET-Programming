using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HW__05_Investments
{
    //inheriting from Investment class
     class CheckingAccount : Investment
    {
        private double overDraftFee;
        public double OverDraftFee 
        { 
            get {return overDraftFee;}
            set
            {
                if (value < 0)
                    throw new ArgumentException("Overfraft fee cannot be negative.");
                overDraftFee = value;
            }
        }
        // Default constructor 
        public CheckingAccount ()
        {
            OverDraftFee = 0;
        }
        // None feadult Constructor to initialize a Checking Account with specific values
        public CheckingAccount (string id, string customerName, string openingDate, double balance, double overDraftFee) : base(id, customerName, openingDate, balance)
        {
            OverDraftFee = overDraftFee;
        }

        //  withdraw a specified amount from the checking account
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        
        //  deposit a specified amount into the checking account
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //Apply Overfraft fee
        public override void ApplyAutomaticAdjustment()
        {
            if (Balance < 0)
                Balance -= OverDraftFee;
        }
        //return the type of the investment
        public override string GetInvestmentType()
        {
            return "Checking";
        }

        // Override ToString to include overdraft fee information along with the base investment info
        public override string ToString()
        {   
            // Call the base class's ToString method and append overdraft fee information
            return base.ToString() + $", OverDraftFee = ${OverDraftFee:0.00}";
        }


    }
}
