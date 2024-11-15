using LAB1_HT2024.Models.ViewModels;
using LAB1_HT2024.Models.DTOs.ReservationDTOs;


namespace LAB1_HT2024.Services.IServices
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationViewModel>> GetAllReservations();
        Task<ReservationViewModel> GetReservationById(int ReservationId);
        Task RemoveReservation(int ReservationId);
        Task UpdateReservation(ReservationDTO updateReservationDTO);
        Task AddReservation(AddReservationDTO createReservationDTO);
    }
}
