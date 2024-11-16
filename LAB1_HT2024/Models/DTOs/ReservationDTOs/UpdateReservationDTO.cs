namespace LAB1_HT2024.Models.DTOs.ReservationDTOs
{
    public class UpdateReservationDTO
    {
        public int ReservationId { get; set; }
        public int groupSize { get; set; }
        public int CustomerId { get; set; }
        public int TableId { get; set; }
        public DateTime reservationStart { get; set; }
        public DateTime reservationEnd { get; set; }
    }
}
