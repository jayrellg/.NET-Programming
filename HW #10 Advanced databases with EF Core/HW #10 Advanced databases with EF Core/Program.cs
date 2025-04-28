
/*
 * Using async ensures our app stays responsive and scalable when the database access is slow.
 * async operations improve application performance by freeing up threads during I/O waits, 
 * enabling the system to handle more concurrent requests without blockin by allowing threads 
 * to process other work while awaiting database responses
 * 
 */



using HW__10_Advanced_databases_with_EF_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace HW__10_Advanced_databases_with_EF_Core
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            using (SoccerDBContext dBContext = new SoccerDBContext())
            {
                // Seed database if empty
                if (!await dBContext.SoccerTeams.AnyAsync())
                {
                        SoccerTeam barcelona = new SoccerTeam { Name = "FC Barcelona", YearFounded = 1899 };
                        SoccerTeam realMadrid = new SoccerTeam { Name = "Real Madrid", YearFounded = 1902 };
                        SoccerTeam manUnited = new SoccerTeam { Name = "Manchester United", YearFounded = 1878 };
                        SoccerTeam bayern = new SoccerTeam { Name = "Bayern Munich", YearFounded = 1900 };


                        dBContext.SoccerTeams.AddRange(barcelona, realMadrid, manUnited, bayern);
                        await dBContext.SaveChangesAsync();

                        List<SoccerPlayer> players = new List<SoccerPlayer>
                        {
                            new SoccerPlayer { Name = "Lionel Messi", Age = 36, Position = "Forward", SoccerTeamId = barcelona.Id },
                            new SoccerPlayer { Name = "Pedri", Age = 21, Position = "Midfielder", SoccerTeamId = barcelona.Id },
                            new SoccerPlayer { Name = "Karim Benzema", Age = 37, Position = "Forward", SoccerTeamId = realMadrid.Id },
                            new SoccerPlayer { Name = "Luka Modrić", Age = 39, Position = "Midfielder", SoccerTeamId = realMadrid.Id },
                            new SoccerPlayer { Name = "Vinicius Jr", Age = 23, Position = "Forward", SoccerTeamId = realMadrid.Id },
                            new SoccerPlayer { Name = "Bruno Fernandes", Age = 29, Position = "Midfielder", SoccerTeamId = manUnited.Id },
                            new SoccerPlayer { Name = "Marcus Rashford", Age = 26, Position = "Forward", SoccerTeamId = manUnited.Id },
                            new SoccerPlayer { Name = "Harry Kane", Age = 30, Position = "Forward", SoccerTeamId = bayern.Id },
                            new SoccerPlayer { Name = "Jamal Musiala", Age = 21, Position = "Midfielder", SoccerTeamId = bayern.Id }

                        };

                        dBContext.SoccerPlayers.AddRange(players);
                        await dBContext.SaveChangesAsync();

                }

                // Queries for tables

                // 1. Retrieve ALL rows from BOTH tables
                Console.WriteLine("All Teams:");
                var teams = await dBContext.SoccerTeams.ToListAsync();
                foreach (var team in teams)
                    Console.WriteLine(team);

                Console.WriteLine("\nAll Players:");
                var playersAll = await dBContext.SoccerPlayers.ToListAsync();
                foreach (var player in playersAll)
                    Console.WriteLine(player);

                // 2. Retrieve X number of players
                Console.Write("\nHow many players to retrieve? ");
                if (int.TryParse(Console.ReadLine(), out int numPlayers))
                {
                    var somePlayers = await dBContext.SoccerPlayers.Take(numPlayers).ToListAsync();
                    foreach (var player in somePlayers)
                        Console.WriteLine(player);
                }

                // 3. Retrieve FIRST player who is a Forward
                var firstForward = await dBContext.SoccerPlayers.FirstOrDefaultAsync(p => p.Position == "Forward");
                if (firstForward != null)
                    Console.WriteLine($"\nFirst Forward found: {firstForward}");
                else
                    Console.WriteLine("\nNo Forward found.");

                // 4. Sort players by Age ASC then Name DESC
                var sortedPlayers = await dBContext.SoccerPlayers.OrderBy(p => p.Age).ThenByDescending(p => p.Name).ToListAsync();
                Console.WriteLine("\nPlayers sorted by Age ASC, Name DESC:");
                foreach (var player in sortedPlayers)
                    Console.WriteLine($"{player.Name} ({player.Age})");


                // 5. Retrieve subset of columns (Player name and Position) and only reutrn rows for players  over 30 within the subset
                var olderPlayers = await dBContext.SoccerPlayers
                    .Where(p => p.Age > 30)
                    .Select(p => new { p.Name, p.Position })
                    .ToListAsync();

                Console.WriteLine("\nPlayers over 30 (Name and Position only):");
                foreach (var player in olderPlayers)
                    Console.WriteLine($"{player.Name} - {player.Position}");

                // 6. Retrieve subset of columns from both tables
                var playerTeams = await dBContext.SoccerPlayers
                    .Select(p => new { p.Name, p.Position, TeamName = p.SoccerTeam.Name })
                    .OrderBy(p => p.TeamName)
                    .ToListAsync();

                Console.WriteLine("\nPlayers and their Teams:");
                foreach (var pt in playerTeams)
                    Console.WriteLine($"{pt.Name} ({pt.Position}) - {pt.TeamName}");


                // 7. Aggregation query,  Average Age
                var avgAge = await dBContext.SoccerPlayers.AverageAsync(p => p.Age);
                Console.WriteLine($"\nAverage Player Age: {avgAge:N2}");

                // 8. List Teams Founded Before 1900
                var oldTeams = await dBContext.SoccerTeams.Where(t => t.YearFounded < 1900).ToListAsync();
                Console.WriteLine("\nTeams founded before 1900:");
                foreach (var team in oldTeams)
                    Console.WriteLine(team);


            }
        }
    }
}
