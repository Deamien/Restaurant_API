using LAB1_HT2024.Models;
using LAB1_HT2024.Models.DTOs.ReservationDTOs;


namespace LAB1_HT2024.Services.IServices
{
    public interface IReservationService
    {
        Task<IEnumerable<Reservation>> GetAllReservations();
        Task<Reservation> GetReservationById(int ReservationId);
        Task RemoveReservation(int ReservationId);
        Task UpdateReservation(ReservationDTO UpdateReservationDTO);
        Task AddReservation(CreateReservationDTO CreateReservationDTO);
    }
}
