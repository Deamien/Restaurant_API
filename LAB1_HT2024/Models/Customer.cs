using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "First name cannot be longer than 30 characters.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Last name cannot be longer than 30 characters.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Not a valid email, try again.")]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must be exactly 10 digits.")]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Reservation>? reservation { get; set; }
    }
}
