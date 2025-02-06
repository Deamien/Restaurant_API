using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models.ViewModels
{
    public class GetMenuDTO
    {
        public int MenuId { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public bool available { get; set; }
    }
}
