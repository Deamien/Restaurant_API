using LAB1_HT2024.Models;

namespace LAB1_HT2024.Data.Repository.IRepository
{
    public interface IMenuRepository
    {
        Task<IEnumerable<Menu>> GetAllMenuItems();
        Task<Menu> GetMenuItemById(int MenuItemId);
        Task RemoveMenuItem(Menu menu);
        Task UpdateMenuItem(Menu menu);
        Task AddMenuItem(Menu menu);

    }
}
