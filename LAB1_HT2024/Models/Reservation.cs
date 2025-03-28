using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LAB1_HT2024.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int GroupSize { get; set; }

        [Required]
        [ForeignKey("Table")]
        public int TableId_FK { get; set; }
        public virtual Table Table { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int CustomerId_FK { get; set; }
        public virtual Customer Customer { get; set; }

        [Required]
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
    }
}
