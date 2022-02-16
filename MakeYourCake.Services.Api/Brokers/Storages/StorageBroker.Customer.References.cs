// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using MakeYourCake.Services.Api.Models.Customers;
using Microsoft.EntityFrameworkCore;

namespace MakeYourCake.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void SetCustomerReferences(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne(customer => customer.CreatedByUser)
                .WithMany(user => user.CreatedCustomers)
                .HasForeignKey(customer => customer.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Customer>()
                .HasOne(customer => customer.UpdatedByUser)
                .WithMany(user => user.UpdatedCustomers)
                .HasForeignKey(customer => customer.UpdatedBy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
