

namespace HW__03_Storefront
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //print header
            Console.WriteLine("************************************************************");
            Console.WriteLine("                       STOREFRONT V1.0");
            Console.WriteLine("************************************************************\n");

            //get file name from user
            Console.Write("\nEnter name of grocery items file: ");
            string fileName = Console.ReadLine();


            Dictionary<string, double> inventory = new Dictionary<string, double>(); //store inventory prices
            Dictionary<string, int> cart = new Dictionary<string, int>(); //store items purchased from user


            try
            {
                //scan each line of the file , and proccess one by one
                foreach (var line in File.ReadLines(fileName))
                {   //split each line into parts, with a tab as dilimiter 
                    var parts = line.Split('\t');
                    if (parts.Length == 2 && double.TryParse(parts[1], out double price)) //check if there are two elemnets (team and price) ,attempt to double parse price --> if successfull save value to variable price
                    {
                        inventory[parts[0].ToLower()] = price;
                    }
                }

            } catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return;
            }

            //shopping loop

            while (true)
            {   //print item list
                Console.WriteLine("What would you like to buy?");
                foreach (var item in inventory)
                {
                    Console.WriteLine($"{item.Key,-30} ${item.Value}");
                }

                //ask user item to buy
                Console.Write("\nEnter item name, or 'quit' to end: ");
                string itemName = Console.ReadLine().ToLower().Trim();

                // exits loop if user inputs quit
                if (itemName.Trim().ToLower() == "quit") break;

                //check if user input item is valid
                if (!inventory.ContainsKey(itemName))
                {
                    Console.WriteLine("Item does not exist. Try again.");
                    continue;
                }

                int quantity;
                while (true)
                {
                    //ask user how many of item they want, checks to see if input is valid
                    Console.Write("How many do you want? ");
                    if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                        break;
                    Console.WriteLine("You must enter an integer greater than zero.");
                }

                //add selected items and thier quantity to users cart
                if (cart.ContainsKey(itemName))
                    cart[itemName] += quantity;
                else
                    cart[itemName] = quantity;

                Console.WriteLine($"You added {itemName}, quantity {quantity}, to your cart.\n");
            }
                //display final receipt
                Console.WriteLine("\nHere is what you bought:");
                double totalCost = 0;
                foreach (var item in cart.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key,-30} {item.Value}");
                    totalCost += item.Value * inventory[item.Key];
                }

                Console.WriteLine($"\n{"Your total for today:",-30}${totalCost:F2}.");
                Console.WriteLine("\nThank you for shopping with us!");
            

        }
    }
}
