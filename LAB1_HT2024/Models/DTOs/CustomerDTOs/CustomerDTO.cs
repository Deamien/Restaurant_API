using LAB1_HT2024.Models.DTOs.ReservationDTOs;

namespace LAB1_HT2024.Models.DTOs.CustomerDTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public IEnumerable<ReservationDTO>? reservationDTO { get; set; }
    }
}
