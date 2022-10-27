using Contracts.Interfaces;
using DataModel;
using DataModel.Models.Entities;
using DataModel.Parameters;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategory
    {
        public CategoryRepository(MMSDbContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateCategory(Category category) => Create(category);

        public void DeleteCategory(Category category) => DeleteCategory(category);

        public async Task<PagedList<Category>> GetAllCategoriesAsync(CategoryParameters categoryParameters, bool trackChanges)
        {
            var category = await FindAll(trackChanges)
                         .OrderBy(c => c.name)
                         .ToListAsync();
            return PagedList<Category>
                .ToPagedList(category, categoryParameters.PageNumber, categoryParameters.PageSize);
        }

        public async Task<Category> GetCategoryAsync(int categoryId, bool trackChanges) =>
         await FindByCondition(c => c.id.Equals(categoryId), trackChanges)
            .SingleOrDefaultAsync();
    }
}
