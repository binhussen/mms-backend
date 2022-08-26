using DataModel.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Models.DTOs.Distribute
{
    public class DistributeDto
    {
        public int id { get; set; }
        public int distributeQuantity { get; set; }
        public int storeItemId { get; set; }
        public int requestId { get; set; }
    }
}