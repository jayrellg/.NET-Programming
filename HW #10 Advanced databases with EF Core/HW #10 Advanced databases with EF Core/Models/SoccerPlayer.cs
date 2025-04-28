using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__10_Advanced_databases_with_EF_Core.Models
{
    internal class SoccerPlayer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(15, 99)]
        public int Age { get; set; }

        [StringLength(30)]
        public string Position { get; set; }

        // Foreign key
        public int SoccerTeamId { get; set; }

        public SoccerTeam SoccerTeam { get; set; }



        //No Contructor, Initializer lists used instead

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name} | Age: {Age} | Position: {Position} | (Team ID: {SoccerTeamId})";
        }

    }
}
