using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [Required]
        public int PartySize { get; set; }

        [Required]
        public DateTime DateTimeFrom { get; set; }

        [Required]
        public DateTime DateTimeTo { get; set; }

    }
}
