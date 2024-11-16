using LAB1_HT2024.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1_HT2024.Data
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) 
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Table>().HasData(
                new Table { Id = 1, Seats = 2 },
                new Table { Id = 2, Seats = 3 },
                new Table { Id = 3, Seats = 4},
                new Table { Id = 4, Seats = 5 },
                new Table { Id = 5, Seats = 6},
                new Table { Id = 6, Seats = 7 },
                new Table { Id = 7, Seats = 8 },
                new Table { Id = 8, Seats = 9 },
                new Table { Id = 9, Seats = 10 },
                new Table { Id = 10, Seats = 11 },
                new Table { Id = 11, Seats = 12 },
                new Table { Id = 12, Seats = 13 },   
                new Table { Id = 13, Seats = 14 },
                new Table { Id = 14, Seats = 15 }
                );

            modelBuilder.Entity<Menu>().HasData(
                new Menu { Id = 1, Name = "Margherita Pizza", Price = 100, Available = true },
                new Menu { Id = 2, Name = "Caesar Salad", Price = 60, Available = true },
                new Menu { Id = 3, Name = "Spaghetti Bolognese", Price = 120, Available = true },
                new Menu { Id = 4, Name = "Grilled Salmon", Price = 150, Available = false },
                new Menu { Id = 5, Name = "Chocolate Cake", Price = 70, Available = true },
                new Menu { Id = 6, Name = "Bruschetta", Price = 74, Available = true },
                new Menu { Id = 7, Name = "Fried Calamari", Price = 109, Available = true },
                new Menu { Id = 8, Name = "Marinara Sauce Spaghetti", Price = 94, Available = true },
                new Menu { Id = 9, Name = "Chicken Alfredo", Price = 134, Available = true },
                new Menu { Id = 10, Name = "Beef Burger", Price = 119, Available = true },
                new Menu { Id = 11, Name = "Vegetable Stir Fry", Price = 104, Available = true },
                new Menu { Id = 12, Name = "BBQ Ribs", Price = 169, Available = true },
                new Menu { Id = 13, Name = "Shrimp Scampi", Price = 149, Available = true },
                new Menu { Id = 14, Name = "Eggplant Parmesan", Price = 124, Available = true }
                );
        }
    }
}
