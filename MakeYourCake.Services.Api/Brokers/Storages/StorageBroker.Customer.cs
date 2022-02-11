// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using MakeYourCake.Services.Api.Models.Customers;
using Microsoft.EntityFrameworkCore;

namespace MakeYourCake.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Customer> Customers { get; set; }
    }
}
