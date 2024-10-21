using LAB1_HT2024.Models;
using Microsoft.EntityFrameworkCore;
using MiniProjekt_API.Models;

namespace MiniProjekt_API.Data
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> InterestUrls { get; set; }
        public DbSet<Table> Tables { get; set; }

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) { }
    }
}
