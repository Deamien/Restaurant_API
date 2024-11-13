using LAB1_HT2024.Models.DTOs.ReservationDTOs;

namespace LAB1_HT2024.Models.DTOs.CustomerDTOs
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public IEnumerable<ReservationDTO>? reservationDTO { get; set; }
    }
}
