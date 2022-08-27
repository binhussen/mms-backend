using DataModel.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Models.DTOs.Customers
{
    public class CustomerDto
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? region { get; set; }
        public string? subCity { get; set; }
        public string? woreda { get; set; }
        public string? homeNumber { get; set; }
        public string? birthPlace { get; set; }
        public string? phoneNumber { get; set; }
        public DateTimeOffset? timeLimit { get; set; }
        public string? picture { get; set; }
        public int hrId { get; set; }
    }
}