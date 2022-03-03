// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using MakeYourCake.Services.Api.Models.Customers;

namespace MakeYourCake.Services.Api.Services.Foundations.Customers
{
    public interface ICustomerService
    {
        ValueTask<Customer> AddCustomerAsync(Customer customer);
    }
}
