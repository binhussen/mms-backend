using DataModel.Models.Entities;

namespace Infrastructure.Extensions
{
    public static class RepositoryStoreItemExtensions
    {
        public static IQueryable<StoreItem> FilterStoreItems(this IQueryable<StoreItem> storeItems, uint minQuantity, uint maxQuantity) =>
            storeItems.Where(e => (e.quantity >= minQuantity && e.quantity <= maxQuantity));

    }
}
