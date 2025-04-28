using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__10_Advanced_databases_with_EF_Core.Models
{
    internal class SoccerTeam
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(1800, 2100)]
        public int YearFounded { get; set; }

        // Navigation property
        public List<SoccerPlayer> Players { get; set; }


        //No Contructor, Initializer lists used instead

        public override string ToString()
        {
            return $"ID : {Id} | {Name} (Founded: {YearFounded})";
        }

    }
}
