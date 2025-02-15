using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__04_Object_Oriented_Programming
{
    public class SoccerPlayer
    {   
        
        //class properties
        public string PlayerName { get; set; }
        public string PlayerPosition { get; set; }
       
        private int minutesPlayed;
        public int MinutesPlayed
        {
            get { return minutesPlayed; }
            set {
                if (value < 0)
                    minutesPlayed = 0;
                else
                    minutesPlayed = value;
                }
        }


        //default Constructor
        public SoccerPlayer()
        {
            PlayerName = "Unknown";
            PlayerPosition = "Unknown";
            minutesPlayed = 0;
        }

        //non-default Constructor
        public SoccerPlayer(string name, string position, int minutesPlayed )
        {
            PlayerName = name;
            PlayerPosition = position;
            MinutesPlayed = minutesPlayed;
            
        }

        //calculate approx. how much distance they covred during the time they played in miles
        public double calcDistanceCovered ()
        {
            return MinutesPlayed * 0.071111;
        }




        public override string ToString()
        {
            return $"Player: {PlayerName}\n" +
                   $"Position: {PlayerPosition}\n" +
                   $"Minutes Played: {MinutesPlayed}\n" +
                   $"Distance Covered: {calcDistanceCovered():F2} miles";
        }

    }




}
