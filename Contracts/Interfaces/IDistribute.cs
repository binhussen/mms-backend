using DataModel.Models.Entities;
using DataModel.Parameters;

namespace Contracts.Interfaces
{
    public interface IDistribute
    {
        Task<PagedList<Distribute>> GetAllApprovesAsync(DistributeParameters approveParameters, bool trackChanges);
        Task<PagedList<Distribute>> GetAllApprovesAsync(int requestId, DistributeParameters approveParameters, bool trackChanges);
        Task<Distribute> GetApproveByIdAsync(int id, bool trackChanges);
        void CreateApprove(Distribute approve);
        void DeleteApprove(Distribute approve);
    }
}
