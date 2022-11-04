using DataModel.Models.DTOs.Stores;
using DataModel.Models.Entities;
using DataModel.Parameters;

namespace Contracts.Interfaces
{
    public interface IStoreItem
    {
        Task<PagedList<StoreListDto>> GetAllStoreItemsAsync(StoreItemParameters storeItemParameters,string category, bool trackChanges);
        Task<PagedList<StoreItem>> GetStoreItemsAsync(int storeHeaderId, StoreItemParameters storeItemParameters, bool trackChanges);
        Task<StoreItem> GetStoreItemAsync(int storeHeaderId, int id, bool trackChanges);
        Task<IEnumerable<StoreItem>> GetStoreByQtyAsync(bool trtrackChanges);
        Task<IEnumerable<StoreItem>> GetStoreByModelAsync(string model, bool trtrackChanges);
        void CreateStoreItemForStoreHeader(int storeHeaderId, StoreItem storeItem);
        void DeleteStoreItem(StoreItem storeItem);
        Task<StoreItem> GetStoreByIdAsync(int id, bool trackChanges);
        Task UpdateStoreAsync(StoreItem storeItem);

        //
        Task<IEnumerable<StoreItem>> GetAllStoreItems(bool trackChanges);
    }
}
