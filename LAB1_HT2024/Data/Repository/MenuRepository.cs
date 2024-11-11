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
            return await _context.menu.ToListAsync();
        }
    }  
}
