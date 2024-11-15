using LAB1_HT2024.Models;
using LAB1_HT2024.Models.DTOs.MenuDTOs;
using LAB1_HT2024.Models.ViewModels;

namespace LAB1_HT2024.Services.IServices
{
    public interface IMenuService
    {
        Task<IEnumerable<MenuViewModel>> GetAllMenuItems();
        Task<MenuViewModel> GetMenuItemById(int MenuItemId);
        Task RemoveMenuItem(int MenuItemId);
        Task UpdateMenuItem(MenuDTO updateMenuDTO);
        Task AddMenuItem(AddMenuDTO addMenuDTO);
    }
}
