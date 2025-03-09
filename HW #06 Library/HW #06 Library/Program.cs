namespace HW__06_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("\t\t\t\tLIBRARY MANAGEMENT SYSTEM VERSION 1.0");
            Console.WriteLine("*******************************************************\n");
            Console.WriteLine("This tool helps you manage a library's collections.\nPlease use the menu to choose what you want to do.\n\n");


            Library library = new Library();
            while (true)
            {
                Console.WriteLine("\nHere are your options:");
                Console.WriteLine("1. List holdings\n2. Add a book\n3. Add a periodical\n4. Reserve a holding\n5. Return a holding\n6. See statistics\n7. Quit");
                Console.Write("Enter the number of your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        library.ListAll();
                        break;
                    case "2":
                        Console.Write("Enter ID Number: ");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string bookTitle = Console.ReadLine();
                        Console.Write("Enter Description: ");
                        string bookDesc = Console.ReadLine();
                        Console.Write("Enter Copyright Year: ");
                        int bookYear = int.Parse(Console.ReadLine());
                        Console.Write("Enter Author: ");
                        string bookAuthor = Console.ReadLine();
                        library.AddHolding(new Book(bookId, bookTitle, bookDesc, false, bookYear, bookAuthor)); // Hard code CheckedOut Status to be initially false,
                                                                                                                // since we never ask the user what the status is
                        break;
                    case "3":
                        Console.Write("Enter ID Number: ");
                        int periodicalId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string periodicalTitle = Console.ReadLine();
                        Console.Write("Enter Description: ");
                        string periodicalDesc = Console.ReadLine();
                        Console.Write("Enter Date: ");
                        string periodicalDate = Console.ReadLine();
                        library.AddHolding(new Periodical(periodicalId, periodicalTitle, periodicalDesc,false, periodicalDate));
                        break;
                    case "4":
                        Console.Write("Enter the ID Number of the holding to reserve: ");
                        int reserveId = int.Parse(Console.ReadLine());
                        library.CheckOut(reserveId);
                        break;
                    case "5":
                        Console.Write("Enter the ID Number of the holding to check in: ");
                        int returnId = int.Parse(Console.ReadLine());
                        library.CheckIn(returnId);
                        break;
                    case "6":
                        library.GetStats();
                        break;
                    case "7":
                        Console.WriteLine("\nThank you for using this program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
