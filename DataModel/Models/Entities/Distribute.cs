﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Models.Entities
{
    public class Distribute
    {
        [Column("distributeId")]
        public int? id { get; set; }
        public int distributeQuantity { get; set; }
        [ForeignKey(nameof(StoreItem))]
        public int storeItemId { get; set; }
        public StoreItem StoreItem { get; set; }
        [ForeignKey(nameof(RequestItem))]
        public int requestId { get; set; }
        public RequestItem RequestItem { get; set; }

    }
}
