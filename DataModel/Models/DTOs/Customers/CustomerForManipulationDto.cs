﻿namespace DataModel.Models.DTOs.Customers
{
    public class CustomerForManipulationDto
    {
        public string? name { get; set; }
        public string? sex { get; set; }
        public string? region { get; set; }
        public string? subCity { get; set; }
        public string? woreda { get; set; }
        public string? homeNumber { get; set; }
        public string? bithPlace { get; set; }
        public string? birthDate { get; set; }
        public string? occupation { get; set; }
        public string? phoneNumber { get; set; }
        public DateTimeOffset? timeLimit { get; set; }
    }
}
