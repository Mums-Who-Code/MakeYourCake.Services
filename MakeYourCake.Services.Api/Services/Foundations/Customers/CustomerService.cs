// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using MakeYourCake.Services.Api.Brokers.Storages;
using MakeYourCake.Services.Api.Models.Customers;

namespace MakeYourCake.Services.Api.Services.Foundations.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly IStorageBroker storageBroker;

        public CustomerService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Customer> AddCustomerAsync(Customer customer) =>
            await this.storageBroker.InsertCustomerAsync(customer);
    }
}
