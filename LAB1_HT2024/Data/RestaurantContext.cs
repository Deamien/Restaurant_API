using LAB1_HT2024.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1_HT2024.Data
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Customer> customer { get; set; }
        public DbSet<Menu> menu { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Table> table { get; set; }

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) { }
    }
}
