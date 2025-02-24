
namespace HW__05_Investments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print header
            Console.WriteLine("************************************************************");
            Console.WriteLine("               INVESTMENT TRACKER VERSION 1.0");
            Console.WriteLine("************************************************************\n");
            Console.WriteLine("This tool helps you manage your investments, both CDs and checking accounts.");
            Console.WriteLine("CDs accrue interest and checking accounts can have overdraft fees.\n");
            Console.WriteLine("At this bank, you have an CD and an checking account.\n");

            //ask customer name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //create checking account Object
            Console.WriteLine("\nI'll ask you about the checking account first.\n");
            Console.WriteLine("Enter the ID for the checking account, the date you opened it,\nthe starting balance, and the overdraft fee:\n");
            CheckingAccount CheckAccount;
            while (true)
            {
                try
                {
                    string[] CheckInput = Console.ReadLine().Split(' ');
                    CheckAccount = new CheckingAccount(CheckInput[0], name, CheckInput[1], double.Parse(CheckInput[2]), double.Parse(CheckInput[3]));
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please ensure you enter exactly 4 values:\nID, date, balance, and overdraft fee (balance and fee should be numbers). Try again.");
                }
            }

            //create CD object 
            Console.WriteLine("\n\nNow I'll ask you about the CD.\nEnter the ID for the CD, the date you opened it,\nthe starting balance, and the interest rate:\n");
            CD CDAccount;
            while (true)
            {
                try
                {
                    string[] CDinput = Console.ReadLine().Split(' ');
                    CDAccount = new CD(CDinput[0], name, CDinput[1], double.Parse(CDinput[2]), double.Parse(CDinput[3]));
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please ensure you enter exactly 4 values:\nID, date, balance, and interest rate (balance and interest rate should be numbers). Try again.");
                }
            }

            Console.WriteLine("\nNow that your accounts have been created, let's manage them.\n\n");



            List<Investment> investments = new List<Investment> { CheckAccount, CDAccount };

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Withdraw from checking");
                Console.WriteLine("2. Deposit into checking");
                Console.WriteLine("3. Update balances");
                Console.WriteLine("4. List investments");
                Console.WriteLine("5. Quit");
                Console.Write("Enter the number of your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        //withdraw from checking account
                        Console.Write("How much do you want to withdraw? ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                            CheckAccount.Withdraw(withdrawAmount);
                        break;
                    case "2":
                        //deposit into checking account
                        Console.Write("How much do you want to deposit? ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                            CheckAccount.Deposit(depositAmount);
                        break;
                    case "3":
                        //update balances for both checking and CD accounts (apply interest or fees)
                        foreach (var investment in investments)
                            investment.ApplyAutomaticAdjustment();
                        Console.WriteLine("The CD accrued interest, and the checking account applied late fees if applicable.");
                        break;
                    case "4":
                        //list the details of both investments
                        foreach (var investment in investments)
                            Console.WriteLine(investment);
                        break;
                    case "5":
                        // Exit 
                        Console.WriteLine("Goodbye and thank you for using the Investment Tracker!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }   
          }   
    }
}
