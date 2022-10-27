namespace DataModel.Models.DTOs.Categories
{
    public class CategoryForCreationDto : CategoryForManipulationDto
    {
        public IEnumerable<SubCategoryForCreationDto>? SubCategories { get; set; }
    }
}
