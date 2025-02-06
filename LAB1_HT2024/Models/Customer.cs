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
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone]
        [RegularExpression(@"^\d{10}$")]
        public string PhoneNumber { get; set; }
    }
}
