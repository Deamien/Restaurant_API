using LAB1_HT2024.Models;

namespace LAB1_HT2024.Models.DTOs
{
    public class ReservationDTO
    {
        public int ReservationId { get; set; }
        public int GroupSize { get; set; }
        public int customerId { get; set; }
        public int TableId { get; set; }
        public DateTime ReservationStart { get; set; }
        public IEnumerable<TableDTO>? tableDTO { get; set; }
    }
}
