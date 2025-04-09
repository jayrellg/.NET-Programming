using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Utilities;

//Helper class to wrote files
namespace HW__08_Advanced_Windows_Forms.Models
{
    public class SoccerPlayerWriter
    {

        // Save to text file
        public void WriteToTextFile(List<SoccerPlayer> players, string filePath)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            foreach (SoccerPlayer player in players)
            {
                writer.WriteLine(player.ToString());
            }
        }

        // Save to JSON file
        public void WriteToJsonFile(List<SoccerPlayer> players, string filePath)
        {
            DataSerializer serializer = new DataSerializer();
            serializer.JsonSerialize(players, filePath);
        }
    }


}
