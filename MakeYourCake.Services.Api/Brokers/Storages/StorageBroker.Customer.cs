// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using MakeYourCake.Services.Api.Models.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MakeYourCake.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Customer> Customers { get; set; }

        public async ValueTask<Customer> InsertCustomerAsync(Customer customer)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Customer> entityEntry =
                await broker.Customers.AddAsync(customer);

            await broker.SaveChangesAsync();

            return entityEntry.Entity;
        }
    }
}
