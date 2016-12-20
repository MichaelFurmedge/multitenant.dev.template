﻿using MultiTenantRepositry.EF.Core.Entities;
using MultiTenancy.Core.ProviderContracts;
using MultiTenantRepository.EntityFramework;
using MultiTenantRepository.Shards.Contracts;
using System.Data.Entity;

namespace MultiTenantRepositry.EF.Core
{
    public class AccommodationEntities : EntitiesContext
    {
        public AccommodationEntities(IUserContextDataProvider userContextProvider, ITenantShardResolver shardResolver)
            : base(userContextProvider, shardResolver, "AccommodationEntities")
        { }

        // NOTE: You have the same constructors as the DbContext here. E.g:
        public AccommodationEntities() : base("AccommodationEntities") { }

        public IDbSet<Country> Countries { get; set; }
        public IDbSet<Resort> Resorts { get; set; }
        public IDbSet<Hotel> Hotels { get; set; }
    }
}