﻿using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public bool Availabile { get; set; }
                
    }
}
