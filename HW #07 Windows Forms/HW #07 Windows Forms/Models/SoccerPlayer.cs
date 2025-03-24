using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW__07_Windows_Forms.Models
{
    public class SoccerPlayer
    {

        //class properties
        public string PlayerName { get; set; } 
        public string PlayerPosition { get; set; }
        //Private field to store the jersey number with validation
        private int jerseyNumber;
        public int JerseyNumber
        {
            get { return jerseyNumber; }
            set
            {
                if (value < 0)
                    jerseyNumber = 0;
                else
                    jerseyNumber = value;
            }
        }

        private int minutesPlayed;
        public int MinutesPlayed
        {
            get { return minutesPlayed; }
            set
            {
                if (value < 0)
                    minutesPlayed = 0;
                else
                    minutesPlayed = value;
            }
        }


        //default Constructor
        public SoccerPlayer()
        {
            PlayerName = string.Empty;
            PlayerPosition = string.Empty;
            JerseyNumber = 0;
            minutesPlayed = 0;
        }

        //non-default Constructor
        public SoccerPlayer(string name, string position,int jerseyNumber, int minutesPlayed)
        {
            PlayerName = name;
            PlayerPosition = position;
            JerseyNumber = jerseyNumber;
            MinutesPlayed = minutesPlayed;

        }

        //calculate approx. how much distance they covred during the time they played in miles
        public double calcDistanceCovered()
        {
            return MinutesPlayed * 0.071111;
        }

        //toString representation of class 
        public override string ToString()
        {
            return $"Player: {PlayerName}\n" +
                   $"Position: {PlayerPosition}\n" +
                   $"Number: {JerseyNumber}\n" +
                   $"Minutes Played: {MinutesPlayed}\n" +
                   $"Distance Covered: {calcDistanceCovered():F2} miles";
        }

    }

}