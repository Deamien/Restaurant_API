using LAB1_HT2024.Models;

namespace LAB1_HT2024.Data.Repository.IRepository
{
    public interface IMenuRepository
    {
        Task<IEnumerable<Menu>> GetAllMenuItems();
        Task<Menu> GetMenuItemById(int MenuItemId);
        Task RemoveMenuItem(int MenuItemId);
        Task UpdateMenuItem(Menu menu);
        Task AddMenuItem(Menu menu);

    }
}
