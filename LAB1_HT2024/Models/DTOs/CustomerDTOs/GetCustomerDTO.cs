﻿namespace LAB1_HT2024.Models.DTOs.CustomerDTOs
{
    public class GetCustomerDTO
    {
        public int CustomerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
    }
}