using LAB1_HT2024.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using LAB1_HT2024.Data.Repository.IRepository;
using Microsoft.Extensions.Configuration;
using BCrypt.Net;



namespace LAB1_HT2024.Data.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly RestaurantContext _context;

        public AdminRepository(RestaurantContext context, IConfiguration configuration)
        {
            _context = context;
        }

        public async Task<bool> ValidateAdminCredentials(string username, string password)
        {

            var admin = await _context.Admin.AsNoTracking().FirstOrDefaultAsync(a => a.Username == username);
            if (admin == null)
                return false;

            return BCrypt.Net.BCrypt.Verify(password, admin.PasswordHash);
        }

        public async Task RegisterAdmin(string username, string passwordHash)
        {
            var admin = new AdminLogin
            {
                Username = username,
                PasswordHash = passwordHash
            };

            _context.Admin.Add(admin);
            await _context.SaveChangesAsync();
        }
    }
}

