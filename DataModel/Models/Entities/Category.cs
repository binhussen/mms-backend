using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Models.Entities
{
    public class Category
    {
        [Column("categoryId")]
        public int id { get; set; }
        public string name { get; set; }
        public bool? sirialize { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
