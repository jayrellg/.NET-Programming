using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW__08_Advanced_Windows_Forms.Models;

namespace HW__08_Advanced_Windows_Forms.Controllers
{
    public class SoccerPlayerController
    {

        // List to store soccer player objects
        private List<SoccerPlayer> players = new List<SoccerPlayer>();

        // Method to retrieve and return the list of all players
        public List<SoccerPlayer> GetPlayers() => players;

        // Method to see if a player already exists 
        public bool PlayerExists(string name)
        {
            return players.Any(p => p.PlayerName == name);
        }

        // Method to update and existing Player
        public void UpdatePlayer(string name, string position, string jerseyNumberText, string minutesPlayedText, string imagePath)
        {
            //if strings are entered  instead of numbers --> defaulted to 0
            int jerseyNumber = int.TryParse(jerseyNumberText, out int jNum) ? jNum : 0;
            int minutesPlayed = int.TryParse(minutesPlayedText, out int mPlayed) ? mPlayed : 0;

            SoccerPlayer? player = players.FirstOrDefault(p => p.PlayerName == name);
            if (player != null)
            {
                player.PlayerPosition = position;
                player.JerseyNumber = jerseyNumber;
                player.MinutesPlayed = minutesPlayed;
                player.ImagePath = imagePath;  

            }
        }

        // Method to add a new Player
        public void AddPlayer(string name, string position, string jerseyNumberText, string minutesPlayedText, string imagePath)
        {
            // If strings are entered  instead of numbers --> defaulted to 0
            int jerseyNumber = int.TryParse(jerseyNumberText, out int jNum) ? jNum : 0;
            int minutesPlayed = int.TryParse(minutesPlayedText, out int mPlayed) ? mPlayed : 0;

            players.Add(new SoccerPlayer(name, position, imagePath, jerseyNumber, minutesPlayed));
        }


        // Method to read player data from a text file
        public List<SoccerPlayer> ReadFromTextFile(string filePath)
        {
            List<SoccerPlayer> players = new List<SoccerPlayer>();
            string[] lines = File.ReadAllLines(filePath); // Read all lines from the file

            // Iterate through the file lines, Read 6 lines per player (name, position, number, minutes, distance, image path)
            for (int i = 0; i < lines.Length; i += 6)  
            {
                // Ensure there are enough lines left to read a complete player
                if (i + 5 >= lines.Length) break;

                // Extract player data from the lines
                string name = lines[i].Split(": ")[1];
                string position = lines[i + 1].Split(": ")[1];
                int number = int.Parse(lines[i + 2].Split(": ")[1]);
                int minutes = int.Parse(lines[i + 3].Split(": ")[1]);

                // Remove the " miles" part to get the numeric value
                string distanceStr = lines[i + 4].Split(": ")[1];
                double distanceCovered = double.Parse(distanceStr.Replace(" miles", ""));

                // Image extraction
                string imagePath = lines[i + 5].Split(": ")[1].Trim();

                // Create the SoccerPlayer object and add it to the list
                players.Add(new SoccerPlayer(name, position, imagePath, number, minutes));
            }

            return players;
        }

        // Method to set or update the list of players
        public void SetPlayers(List<SoccerPlayer> newPlayers)
        {
            // Replace the current player list with the new list
            players = newPlayers;
        }


    }
}
