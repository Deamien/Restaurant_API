using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [Required]
        public int GroupSize { get; set; }

        [Required]
        public DateTime ReservationStart { get; set; }

        [Required]
        [ForeignKey("Table")]
        public int FK_TableId { get; set; }
        public Table table { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int FK_CustomerId { get; set; }
        public Customer customer { get; set; }
    }
}
