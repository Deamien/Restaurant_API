using LAB1_HT2024.Models;


namespace LAB1_HT2024.Data.Repository.IRepository
{
    public interface IReservationRepository
    {

        Task<IEnumerable<Reservation>> GetAllReservations();
        Task<Reservation> GetReservationById(int ReservationId);
        Task RemoveReservation(int ReservationId);
        Task UpdateReservation(Reservation reservation);
        Task AddReservation(Reservation reservation);

    }
}
