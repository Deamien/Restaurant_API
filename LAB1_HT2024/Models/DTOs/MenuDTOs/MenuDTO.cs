namespace LAB1_HT2024.Models.DTOs.MenuDTOs
{
    public class MenuDTO
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
