using DataModel.Models.Entities;
using DataModel.Parameters;

namespace Contracts.Interfaces
{
    public interface ISubCategory
    {
        Task<PagedList<SubCategory>> GetSubCategoriesAsync(int categoryId, SubCategoryParameters subCategoryParameters, bool trackChanges);
        Task<SubCategory> GetSubCategoryAsync(int categoryId, int id, bool trackChanges);
        void CreateSubCategoryForCategory(int categoryId, SubCategory subCategory);
        void DeleteSubCategory(SubCategory subCategory);
    }
}
