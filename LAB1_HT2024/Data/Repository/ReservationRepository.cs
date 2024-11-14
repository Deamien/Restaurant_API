using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Models;
using Microsoft.EntityFrameworkCore;
using LAB1_HT2024.Data;


namespace LAB1_HT2024.Data.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly RestaurantContext _context; 

        public ReservationRepository(RestaurantContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservations() 
        {
            return await _context.Reservations.ToListAsync();
        }

        public async Task<Reservation> GetReservationById(int ReservationId)
        { 
            return await _context.Reservations.FirstOrDefaultAsync(R => R.Id == ReservationId);
        }

        public async Task RemoveReservation(Reservation reservation) 
        {
            _context.Reservations.Remove(reservation);

            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateReservation(Reservation reservation)
        {
            _context.Reservations.Update(reservation);

            await _context.SaveChangesAsync();
        }
        
        public async Task AddReservation(Reservation reservation) 
        {
            _context.Reservations.Add(reservation);
            
            await _context.SaveChangesAsync();
        }
    }
}
