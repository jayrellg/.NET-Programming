//Jayrell Garcia
//SP25-CPSC-23000-001 - .NET Programming
//This program lets the user create soccer player objects and save 3 properties to them (Name , position , and time played)


namespace HW__04_Object_Oriented_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print header
            Console.WriteLine("=====================================");
            Console.WriteLine("Welcome to the Soccer Player Tracker!");
            Console.WriteLine("=====================================\n");

            Console.WriteLine("This program lets you create soccer player objects and save 3 properties to them (Name , position , and time played)");


            List<SoccerPlayer> players = new List<SoccerPlayer>();

            //loop to ask user input to create SoccerPlayer objects
            while (true)
            {
                //user input
                Console.Write("Enter player name (or type 'quit' to stop): ");
                string name = Console.ReadLine();
                if (name.ToLower().Trim() == "quit") break;

                Console.Write("Enter player position: ");
                string position = Console.ReadLine().Trim();

                Console.Write("Enter minutes played: ");
                if (!int.TryParse(Console.ReadLine().Trim(), out int minutes))
                {
                    Console.WriteLine("Invalid input. Defaulting to 0 minutes.");
                    minutes = 0;
                }

                //create Soccer Player object using user input
                SoccerPlayer player = new SoccerPlayer(name, position, minutes);

                // add the object to a list
                players.Add(player);
                Console.WriteLine("Player added successfully!\n");
            }

            // print Soccer Player objects in the order they were added
            Console.WriteLine("\nPlayers Entered:");
            players.ForEach(p => Console.WriteLine(p + "\n"));


            // sort SoccerPlayer objects by minutes played and print again
            List<SoccerPlayer> sortedSoccerPlayerByTime= players.OrderByDescending(p => p.MinutesPlayed).ToList();
            Console.WriteLine("\nPlayers Sorted by Minutes Played:");
            sortedSoccerPlayerByTime.ForEach(p => Console.WriteLine(p + "\n"));


            Console.Write("\nEnter a position to filter players: ");
            string filterPosition = Console.ReadLine().Trim();
            List<SoccerPlayer> filteredPlayersByUserInput = players.Where(p => p.PlayerPosition.Equals(filterPosition, StringComparison.OrdinalIgnoreCase)).ToList();

            if (filteredPlayersByUserInput.Count > 0)
                filteredPlayersByUserInput.ForEach(p => Console.WriteLine(p +"\n"));
            else
                Console.WriteLine($"No players found for position: {filterPosition}");



        }
    }
}
