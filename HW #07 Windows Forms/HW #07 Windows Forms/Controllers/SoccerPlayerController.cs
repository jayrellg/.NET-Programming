using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW__07_Windows_Forms.Models;

namespace HW__07_Windows_Forms.Controllers
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
        public void UpdatePlayer(string name, string position, string jerseyNumberText, string minutesPlayedText)
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
            }
        }

        // Method to add a new Player
        public void AddPlayer(string name, string position, string jerseyNumberText, string minutesPlayedText)
        {
            // If strings are entered  instead of numbers --> defaulted to 0
            int jerseyNumber = int.TryParse(jerseyNumberText, out int jNum) ? jNum : 0;
            int minutesPlayed = int.TryParse(minutesPlayedText, out int mPlayed) ? mPlayed : 0;

            players.Add(new SoccerPlayer(name, position, jerseyNumber, minutesPlayed));
        }
    }
}
