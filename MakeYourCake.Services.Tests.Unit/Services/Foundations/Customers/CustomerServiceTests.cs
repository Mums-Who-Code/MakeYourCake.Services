﻿// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using MakeYourCake.Services.Api.Brokers.DateTimes;
using MakeYourCake.Services.Api.Brokers.Loggings;
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
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly Mock<IDateTimeBroker> dateTimeBrokerMock;
        private readonly ICustomerService customerService;

        public CustomerServiceTests()
        { 
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();
            this.dateTimeBrokerMock = new Mock<IDateTimeBroker>();

            this.customerService = new CustomerService(
                storageBroker: this.storageBrokerMock.Object,
                loggingBroker: this.loggingBrokerMock.Object);
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

        private static Expression<Func<Exception, bool>> SameExceptionAs(Exception expectedException)
        { 
            return actualException =>
                actualException.Message == expectedException.Message
                && actualException.InnerException.Message == expectedException.InnerException.Message;
        }
    }
}