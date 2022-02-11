// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MakeYourCake.Services.Api.Models.Customers;

namespace MakeYourCake.Services.Api.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public IEnumerable<Customer> CreatedCustomers { get; set; }
        [JsonIgnore]
        public IEnumerable<Customer> UpdatedCustomers { get; set; }
    }
}
