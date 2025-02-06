namespace LAB1_HT2024.Models.DTOs.ReservationDTOs
{
    public class GetReservationDTO
    {
        public int ReservationId { get; set; }
        public int groupSize { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime reservationStart { get; set; }
        public DateTime reservationEnd { get; set; }
        public int CustomerId { get; set; }
        public int TableId { get; set; }
    }
}
