using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW__10_Advanced_databases_with_EF_Core.Models;
using Microsoft.EntityFrameworkCore;


namespace HW__10_Advanced_databases_with_EF_Core
{
    internal class SoccerDBContext : DbContext
    {
        public DbSet<SoccerTeam> SoccerTeams { get; set; }
        public DbSet<SoccerPlayer> SoccerPlayers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1EOJUGM\\JAYRELLGARCIA; Initial Catalog=SoccerDB;Integrated Security=True;Pooling=False;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SoccerTeam>()
                .HasMany(t => t.Players)  //Players is Nav property  for Soccer Team
                .WithOne(p => p.SoccerTeam) //Soccer Team is Nav properpty  players
                .HasForeignKey(p => p.SoccerTeamId); //foreign key
        }

    }
}
