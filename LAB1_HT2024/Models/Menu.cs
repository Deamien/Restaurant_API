using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Price { get; set; }
        
        [Required]
        public bool Available { get; set; }
    }
}
