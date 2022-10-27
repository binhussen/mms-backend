using Contracts.Interfaces;
using DataModel;
using DataModel.Models.Entities;
using DataModel.Parameters;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class SubCategoryRepository : RepositoryBase<SubCategory>, ISubCategory
    {
        public SubCategoryRepository(MMSDbContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateSubCategoryForCategory(int categoryId, SubCategory subCategory)
        {
            subCategory.categoryId = categoryId;
            Create(subCategory);
        }

        public void DeleteSubCategory(SubCategory subCategory)
        {
            Delete(subCategory);
        }

        public async Task<PagedList<SubCategory>> GetSubCategoriesAsync(int categoryId, SubCategoryParameters subCategoryParameters, bool trackChanges)
        {
            var subCategories = await FindByCondition(e => e.categoryId.Equals(categoryId), trackChanges)
             .OrderBy(e => e.modelName)
             .ToListAsync();
            return PagedList<SubCategory>
              .ToPagedList(subCategories, subCategoryParameters.PageNumber, subCategoryParameters.PageSize);
        }

        public async Task<SubCategory> GetSubCategoryAsync(int categoryId, int id, bool trackChanges) =>

            await FindByCondition(e => e.categoryId.Equals(categoryId) && e.id.Equals(id), trackChanges)
             .SingleOrDefaultAsync();

    }
}
