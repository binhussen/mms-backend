using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Models.Entities
{
    public class CustomerWarranty
    {
        [Column("warrantyId")]
        public int id { get; set; }
        public string? name { get; set; }
        public string? address { get; set; }
        public string? subCity { get; set; }
        public string? woreda { get; set; }
        public string? region { get; set; }
        [ForeignKey(nameof(Customer))]
        public int customerId { get; set; }
        public Customer Customer { get; set; }
    }
}
