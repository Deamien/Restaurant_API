namespace LAB1_HT2024.Models.DTOs.MenuDTOs
{
    public class UpdateMenuItemDTO
    {
        public int MenuItemId { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public bool available { get; set; }
    }
}
