using Contracts.Interfaces;
using DataModel;
using DataModel.Models.Entities;
using DataModel.Parameters;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class DistributeRepository : RepositoryBase<Distribute>, IDistribute
    {
        public DistributeRepository(MMSDbContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateDistribute(Distribute distribute)
        {
            Create(distribute);
        }

        public void DeleteDistribute(Distribute distribute)
        {
            Delete(distribute);
        }

        public async Task<Distribute> GetDistributeByIdAsync(int id, bool trackChanges) =>
         await FindByCondition(e => e.id.Equals(id), trackChanges)
             .SingleOrDefaultAsync();

        public async Task<PagedList<Distribute>> GetAllDistributesAsync(DistributeParameters distributeParameters, bool trackChanges)
        {
            var distributes = await FindAll(trackChanges)
                       .OrderBy(c => c.distributeQuantity)
                      .ToListAsync();
            return PagedList<Distribute>
                .ToPagedList(distributes, distributeParameters.PageNumber, distributeParameters.PageSize);

        }

        public async Task<PagedList<Distribute>> GetAllDistributesAsync(int requestId, DistributeParameters distributeParameters, bool trackChanges)
        {
            var distributes = await FindByCondition(e => e.requestId.Equals(requestId), trackChanges)
                          .OrderBy(e => e.storeItemId)
                           // .Select(s => s.status == "P" ? "pending" : s.status == "R" ? "reject" : s.status == "C" ? "Canceled" : "approve")

                           .ToListAsync();
            return PagedList<Distribute>
                .ToPagedList(distributes, distributeParameters.PageNumber, distributeParameters.PageSize);
        }

    }
}



