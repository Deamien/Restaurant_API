using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Data;
using LAB1_HT2024.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Hosting.Internal;
using LAB1_HT2024.Models.DTOs.ReservationDTOs;

namespace LAB1_HT2024.Data.Repository
{
    public class TableRepository : ITableRepository
    {
        private readonly RestaurantContext _context;

        public TableRepository(RestaurantContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Table>> GetAllTables()
        {
            return await _context.Tables.ToListAsync();

        }

        public async Task<Table> GetTableById(int TableId)
        {
            return await _context.Tables.FirstOrDefaultAsync(t => t.Id == TableId);      
        }


        public async Task UpdateTable(Table table) 
        {
            _context.Update(table);

            await _context.SaveChangesAsync();
        }

        public async Task AddTable(Table table)
        {
            _context.Tables.Add(table);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Table>> GetAvailableTables(int groupSize, DateTime reservationStart)
        {
            return await _context.Tables
                .Where(t => t.Seats >= groupSize)
                .Where(t => !t.reservation.Any(r => r.ReservationStart < reservationStart.AddHours(2.5) && r.ReservationEnd > reservationStart))
                .ToListAsync();
        }

        public async Task RemoveTable(Table table)
        {
            _context.Tables.Remove(table);

            await _context.SaveChangesAsync();
        }
    }
}
