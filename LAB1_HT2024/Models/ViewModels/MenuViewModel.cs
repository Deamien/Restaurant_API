using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models.ViewModels
{
    public class MenuViewModel
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Availabile { get; set; }
    }
}
