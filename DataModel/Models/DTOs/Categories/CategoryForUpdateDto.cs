namespace DataModel.Models.DTOs.Categories
{
    public class CategoryForUpdateDto : CategoryForManipulationDto
    {
        public IEnumerable<SubCategoryForCreationDto>? SubCategories { get; set; }
    }
}
