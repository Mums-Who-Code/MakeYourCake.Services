// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using MakeYourCake.Services.Api.Brokers.Storages;
using MakeYourCake.Services.Api.Models.Customers;
using MakeYourCake.Services.Api.Services.Foundations.Customers;
using Moq;
using Tynamix.ObjectFiller;

namespace MakeYourCake.Services.Tests.Unit.Services.Foundations.Customers
{
    public partial class CustomerServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly ICustomerService customerService;

        public CustomerServiceTests()
        { 
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.customerService = new CustomerService(
                storageBroker: this.storageBrokerMock.Object);
        }

        private static DateTimeOffset GetRandomDateTime() =>
            new DateTimeRange(earliestDate: new DateTime()).GetValue();

        private static Customer CreateRandomCustomer() =>
            CreateCustomerFiller(dateTime: GetRandomDateTime()).Create();

        private static Filler<Customer> CreateCustomerFiller(DateTimeOffset dateTime)
        {
            var filler = new Filler<Customer>();

            filler.Setup()
                .OnType<DateTimeOffset>().Use(dateTime);

            return filler;
        }
    }
}
