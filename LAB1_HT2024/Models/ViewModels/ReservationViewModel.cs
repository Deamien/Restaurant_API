namespace LAB1_HT2024.Models.ViewModels
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public int PartySize { get; set; }
        public DateTime BookingStart { get; set; }
        public DateTime BookingEnd { get; set; }
        public int CustomerId { get; set; }
        public int? TableId { get; set; }
    }
}
