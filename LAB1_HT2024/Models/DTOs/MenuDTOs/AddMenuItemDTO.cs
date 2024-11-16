using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models.DTOs.MenuDTOs
{
    public class AddMenuItemDTO
    {
        public string name {  get; set; }
        public int price { get; set; }
        public bool available { get; set; }
    }
}
