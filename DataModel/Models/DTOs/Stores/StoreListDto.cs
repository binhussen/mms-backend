using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models.DTOs.Stores
{
    public class StoreListDto
    {
        public string itemType { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public int availableQuantity { get; set; }
        public int approvedQuantity { get; set; }
}
}
