// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using MakeYourCake.Services.Api.Brokers.Loggings;
using MakeYourCake.Services.Api.Brokers.Storages;
using MakeYourCake.Services.Api.Models.Customers;

namespace MakeYourCake.Services.Api.Services.Foundations.Customers
{
    public partial class CustomerService : ICustomerService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public CustomerService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public ValueTask<Customer> AddCustomerAsync(Customer customer) =>
            TryCatch(async () =>
            {
                ValidateCustomer(customer);
                return await this.storageBroker.InsertCustomerAsync(customer);
            });
    }
}
