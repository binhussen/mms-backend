using DataModel.Models.Entities;
using DataModel.Parameters;

namespace Contracts.Interfaces
{
    public interface IDistribute
    {
        Task<PagedList<Distribute>> GetAllDistributesAsync(DistributeParameters distributeParameters, bool trackChanges);
        Task<PagedList<Distribute>> GetAllDistributesAsync(int requestId, DistributeParameters distributeParameters, bool trackChanges);
        Task<Distribute> GetDistributeByIdAsync(int id, bool trackChanges);
        void CreateDistribute(Distribute distribute);
        void DeleteDistribute(Distribute distribute);
    }
}
