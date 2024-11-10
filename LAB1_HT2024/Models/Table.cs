using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Seats { get; set; }

        public virtual ICollection<Reservation> reservation { get; set; }
    }
}
