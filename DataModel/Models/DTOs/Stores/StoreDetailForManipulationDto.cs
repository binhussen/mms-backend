namespace DataModel.Models.DTOs.Stores
{
    public class StoreItemForManipulationDto
    {
        public string type { get; set; }
        public string itemDescription { get; set; }
        public string model { get; set; }
        public string? serialNo { get; set; }
        public int quantity { get; set; } = 1;
        public string storeNo { get; set; }
        public string shelfNo { get; set; }
        public int unitPrice { get; set; }
        public int? totalPrice { get; set; }
        public int availableQuantity { get; set; }
    }
}
