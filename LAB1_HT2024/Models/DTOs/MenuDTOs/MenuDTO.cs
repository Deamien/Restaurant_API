namespace LAB1_HT2024.Models.DTOs.MenuDTOs
{
    public class MenuDTO
    {
        public int DishId { get; set; }
        public string dishName { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public bool isAvailable { get; set; }
    }
}
