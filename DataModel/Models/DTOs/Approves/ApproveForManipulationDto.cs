﻿namespace DataModel.Models.DTOs.Approve
{
    public class ApproveForManipulationDto
    {
        public int approvedQuantity { get; set; }
        public int storeItemId { get; set; }
        public int requestId { get; set; }
        public string? attachments { get; set; }
    }
}
