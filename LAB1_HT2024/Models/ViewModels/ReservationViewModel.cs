namespace LAB1_HT2024.Models.ViewModels
{
    public class ReservationViewModel
    {
        public int ReservationId { get; set; }
        public int PartySize { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
        public int CustomerId { get; set; }
        public int TableId { get; set; }
    }
}
