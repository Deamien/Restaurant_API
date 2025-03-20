using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models.DTOs.CustomerDTOs
{
    public class AddCustomerDTO
    {
        [Required]
        [StringLength(30, ErrorMessage = "First name cannot be longer than 30 characters.")]
        public string firstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Last name cannot be longer than 30 characters.")]
        public string lastName { get; set; }

        [Required]
        [EmailAddress]
        public string emailAddress { get; set; }


        [Required(ErrorMessage = "Phone Number is required")]
        [Phone]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone Number is invalid")]
        public string phoneNumber { get; set; }
    }
}
