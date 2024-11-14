using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Data;
using LAB1_HT2024.Models;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace LAB1_HT2024.Data.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly RestaurantContext _context;

        public MenuRepository(RestaurantContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Menu>> GetAllMenuItems() 
        { 
            return await _context.Menus.ToListAsync();
        }

        public async Task<Menu> GetMenuItemById(int MenuItemId) 
        {
            return await _context.Menus.FirstOrDefaultAsync(M => M.Id == MenuItemId);
        }
    
        public async Task RemoveMenuItem(Menu menu)
        {

            _context.Menus.Remove(menu);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateMenuItem(Menu menu)
        {
            _context.Menus.Update(menu);

            await _context.SaveChangesAsync();
        }

        public async Task AddMenuItem(Menu menu)
        {
            _context.Menus.Add(menu);

            await _context.SaveChangesAsync();
        }
    }  
}
