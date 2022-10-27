﻿using Contracts.Interfaces;
using DataModel;
using DataModel.Models.Entities;
using DataModel.Parameters;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class StoreHeaderRepository : RepositoryBase<StoreHeader>, IStoreHeader
    {
        public StoreHeaderRepository(MMSDbContext repositoryContext) : base(repositoryContext)
        {

        }
        public void CreateStoreHeader(StoreHeader storeHeader) => Create(storeHeader);

        public void DeleteStoreHeader(StoreHeader storeHeader) => Delete(storeHeader);

        public async Task<PagedList<StoreHeader>> GetAllStoreHeadersAsync(StoreHeaderParameters storeHeaderParameters, bool trackChanges)
        {
            var storeHeader = await FindAll(trackChanges)
                         .OrderBy(c => c.itemNoInExpenditureRegister)
                         .ToListAsync();
            return PagedList<StoreHeader>
                .ToPagedList(storeHeader, storeHeaderParameters.PageNumber, storeHeaderParameters.PageSize);
        }

        public async Task<StoreHeader> GetStoreHeaderAsync(int storeHeaderId, bool trackChanges) =>
         await FindByCondition(c => c.id.Equals(storeHeaderId), trackChanges)
            .SingleOrDefaultAsync();
    }
}
