using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketSystem.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FromLocation { get; set; }

        [Required]
        public string ToLocation { get; set; }

        [Column("JourneyDate")]
        public DateTime DateOfJourney { get; set; }

        [Column("Seats")]
        public int NumberOfSeats { get; set; }
    }
}
