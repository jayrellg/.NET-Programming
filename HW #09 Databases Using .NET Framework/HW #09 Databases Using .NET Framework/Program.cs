/*
CREATE TABLE [dbo].[SoccerPlayer] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (100) NOT NULL,
    [Nationality]  VARCHAR (50)  NOT NULL,
    [Position]     VARCHAR (50)  NOT NULL,
    [JerseyNumber] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;

namespace HW__09_Databases_Using.NET_Framework
{
    internal class Program
    {
        static SoccerPlayerDB GetNewSoccerPLayerDB()
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            SoccerPlayerDB pdb = new SoccerPlayerDB(connection);
            return pdb;
        }


        static void Main(string[] args)
        {
            try
            {
                SoccerPlayerDB spDB = GetNewSoccerPLayerDB();

                while (true)
                {

                    Console.WriteLine("************************************************");
                    Console.WriteLine("\t     Soccer Player Database");
                    Console.WriteLine("************************************************\n");



                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1. Add a player");
                    Console.WriteLine("2. List all players");
                    Console.WriteLine("3. Update a player by ID");
                    Console.WriteLine("4. Remove a player by ID");
                    Console.WriteLine("5. Remove all players");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter the number of your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddPlayer(spDB);
                            break;

                        case "2":
                            ListPlayers(spDB);
                            break;

                        case "3":
                            UpdatePlayer(spDB);
                            break;

                        case "4":
                            RemovePlayer(spDB);
                            break;

                        case "5":
                            spDB.RemoveAll();
                            Console.WriteLine("All players removed.");
                            break;

                        case "6":
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1-6.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void AddPlayer(SoccerPlayerDB spDB)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.");
                Console.Write("Enter name: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter nationality: ");
            string nationality = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nationality))
            {
                Console.WriteLine("Nationality cannot be empty.");
                Console.Write("Enter nationality: ");
                nationality = Console.ReadLine();
            }

            Console.Write("Enter position: ");
            string position = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(position))
            {
                Console.WriteLine("Position cannot be empty.");
                Console.Write("Enter position: ");
                position = Console.ReadLine();
            }

            int jerseyNumber;
            Console.Write("Enter jersey number: ");
            while (!int.TryParse(Console.ReadLine(), out jerseyNumber) || jerseyNumber < 0 || jerseyNumber > 99)
            {
                Console.WriteLine("Invalid jersey number. Please enter a number between 0-99.");
                Console.Write("Enter jersey number: ");
            }

            spDB.Add(name, nationality, position, jerseyNumber);
            Console.WriteLine("Player added successfully!");
        }

        static void ListPlayers(SoccerPlayerDB spDB)
        {
            List<SoccerPlayer> players = spDB.GetAll();
            if (players.Count == 0)
            {
                Console.WriteLine("No players found.");
                return;
            }

            foreach (SoccerPlayer p in players)
                Console.WriteLine(p);
        }

        static void UpdatePlayer(SoccerPlayerDB spDB)
        {
            int updateId;
            Console.Write("Enter the id of the player to update: ");
            while (!int.TryParse(Console.ReadLine(), out updateId) || updateId <= 0)
            {
                Console.WriteLine("Invalid ID. Please enter a positive number.");
                Console.Write("Enter the id of the player to update: ");
            }

            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.");
                Console.Write("Enter name: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter nationality: ");
            string nationality = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nationality))
            {
                Console.WriteLine("Nationality cannot be empty.");
                Console.Write("Enter nationality: ");
                nationality = Console.ReadLine();
            }

            Console.Write("Enter position: ");
            string position = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(position))
            {
                Console.WriteLine("Position cannot be empty.");
                Console.Write("Enter position: ");
                position = Console.ReadLine();
            }

            int jerseyNumber;
            Console.Write("Enter jersey number: ");
            while (!int.TryParse(Console.ReadLine(), out jerseyNumber) || jerseyNumber < 0 || jerseyNumber > 99)
            {
                Console.WriteLine("Invalid jersey number. Please enter a number between 0-99.");
                Console.Write("Enter jersey number: ");
            }

            bool updated = spDB.Update(updateId, name, nationality, position, jerseyNumber);
            Console.WriteLine(updated ? "Player updated successfully!" : "That player does not exist.");
        }

        static void RemovePlayer(SoccerPlayerDB spDB)
        {
            int removeId;
            Console.Write("Enter the id of the player to remove: ");
            while (!int.TryParse(Console.ReadLine(), out removeId) || removeId <= 0)
            {
                Console.WriteLine("Invalid ID. Please enter a positive number.");
                Console.Write("Enter the id of the player to remove: ");
            }

            bool removed = spDB.Remove(removeId);
            Console.WriteLine(removed ? "Player removed successfully!" : "That player does not exist.");
        }
    }
}
