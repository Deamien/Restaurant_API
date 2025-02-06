using LAB1_HT2024.Models;
using LAB1_HT2024.Models.DTOs.MenuDTOs;
using LAB1_HT2024.Models.ViewModels;

namespace LAB1_HT2024.Services.IServices
{
    public interface IMenuService
    {
        Task<IEnumerable<GetMenuDTO>> GetAllMenuItems();
        Task<GetMenuDTO> GetMenuItemById(int MenuItemId);
        Task RemoveMenuItem(int MenuItemId);
        Task UpdateMenuItem(UpdateMenuItemDTO updateMenuDTO);
        Task AddMenuItem(AddMenuItemDTO addMenuDTO);
    }
}
