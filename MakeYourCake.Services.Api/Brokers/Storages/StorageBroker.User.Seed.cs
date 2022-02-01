// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using MakeYourCake.Services.Api.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;

namespace MakeYourCake.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var serviceAdminUser = new User
            {
                Id = Guid.Parse("06cc6c4e-d0ee-4935-8751-8902ecd1c4d9"),
                Name = "Admin"
            };

            modelBuilder.Entity<User>().HasData(serviceAdminUser);
        }
    }
}
