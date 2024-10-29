﻿using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }

        //kanske lägger till en grej här senare

        [Required]
        public int Seats { get; set; }

        [Required]
        public bool TableAvailability { get; set; }
        public virtual ICollection<Reservation>? reservation { get; set; }
    }
}