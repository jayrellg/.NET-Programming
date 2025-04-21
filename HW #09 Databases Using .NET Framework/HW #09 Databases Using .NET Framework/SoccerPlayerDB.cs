using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using System.Runtime.Remoting.Messaging;

namespace HW__09_Databases_Using.NET_Framework
{

    public class SoccerPlayerDB
    {
        private DbConnection conn;
        private DbCommand cmd;

        public SoccerPlayerDB(DbConnection conn)
        {
            this.conn = conn;
            cmd = conn.CreateCommand();
        }


        // Add a new Soccer Player
        public void Add(string name, string nationality, string position, int jerseyNumber)
        {
            cmd.CommandText = $"INSERT INTO SoccerPlayer (Name, Nationality, Position, JerseyNumber) " +
                              $"VALUES ('{name}', '{nationality}', '{position}', {jerseyNumber})";
            cmd.ExecuteNonQuery();
        }



        //List all Soccer Players 
        public List<SoccerPlayer> GetAll()
        {
            cmd.CommandText = "SELECT * FROM SoccerPlayer";
            List<SoccerPlayer> players = new List<SoccerPlayer>();

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    players.Add(new SoccerPlayer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Nationality = reader.GetString(2),
                        Position = reader.GetString(3),
                        JerseyNumber = reader.GetInt32(4)
                    });
                }
            }

            return players;
        }

        // Update Player
        public bool Update(int id, string name, string nationality, string position, int jerseyNumber)
        {
            cmd.CommandText = $"UPDATE SoccerPlayer SET " +
                              $"Name = '{name}', Nationality = '{nationality}', Position = '{position}', JerseyNumber = {jerseyNumber} " +
                              $"WHERE Id = {id}";
            return cmd.ExecuteNonQuery() > 0;
        }

        // Remove player by ID
        public bool Remove(int id)
        {
            cmd.CommandText = $"DELETE FROM SoccerPlayer WHERE Id = {id}";
            return cmd.ExecuteNonQuery() > 0;
        }

        // Remove all Soccer Player Entries
        public void RemoveAll()
        {
            cmd.CommandText = "DELETE FROM SoccerPlayer";
            cmd.ExecuteNonQuery();
        }



    }
}
