using LAB1_HT2024.Models.DTOs.ReservationDTOs;


namespace LAB1_HT2024.Services.IServices
{
    public interface IReservationService
    {
        Task<IEnumerable<GetReservationDTO>> GetAllReservations();
        Task<GetReservationDTO> GetReservationById(int ReservationId);
        Task RemoveReservation(int ReservationId);
        Task UpdateReservation(UpdateReservationDTO updateReservationDTO);
        Task AddReservation(AddReservationDTO createReservationDTO);
    }
}
