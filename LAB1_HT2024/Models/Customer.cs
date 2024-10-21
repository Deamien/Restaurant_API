using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace LAB1_HT2024.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength (30, ErrorMessage = "First name cannot be longer than 30 characters.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Last name cannot be longer than 30 characters.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Not a valid email, try again.")]
        public string EmailAddress { get; set; }
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits.")]
        public int PhoneNumber { get; set; }

        public virtual ICollection<Reservation>? Reservations { get; set; }
    }
}
