using DataModel.Models.Entities;
using DataModel.Parameters;

namespace Contracts.Interfaces
{
    public interface ICategory
    {
        Task<PagedList<Category>> GetAllCategoriesAsync(CategoryParameters categoryParameters, bool trackChanges);
        Task<Category> GetCategoryAsync(int categoryId, bool trackChanges);
        void CreateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
