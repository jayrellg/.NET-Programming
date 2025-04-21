using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW__09_Databases_Using.NET_Framework
{
    public class SoccerPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Position { get; set; }
        public int JerseyNumber { get; set; }



        public SoccerPlayer() 
        {
            Name = string.Empty;
            Nationality = string.Empty;
            Position = string.Empty;
            JerseyNumber = 0;

        
        }

        public SoccerPlayer( string name, string nationality, string position, int jerseyNumber)
        {
            Name = name;
            Nationality = nationality;
            Position = position;
            JerseyNumber = jerseyNumber;
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Nationality}\t{Position}\t{JerseyNumber}";
        }
    }

}
