// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using MakeYourCake.Services.Api.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace MakeYourCake.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<User> Users { get; set; }
    }
}
