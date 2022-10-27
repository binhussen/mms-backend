using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Models.Entities
{
    public class SubCategory
    {
        [Column("subCategoryId")]
        public int id { get; set; }
        public string modelName { get; set; }
        [ForeignKey(nameof(Category))]
        public int categoryId { get; set; }
        public Category Category { get; set; }
    }
}
