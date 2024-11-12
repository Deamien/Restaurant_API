﻿namespace LAB1_HT2024.Models.DTOs.ReservationDTOs
{
    public class CreateReservationDTO
    {
        public int GroupSize { get; set; }
        public int CustomerId { get; set; }
        public int TableId { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
    }
}
