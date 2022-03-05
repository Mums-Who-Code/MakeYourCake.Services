// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using MakeYourCake.Services.Api.Models.Customers;
using MakeYourCake.Services.Api.Models.Customers.Exceptions;
using Moq;
using Xunit;

namespace MakeYourCake.Services.Tests.Unit.Services.Foundations.Customers
{
    public partial class CustomerServiceTests
    {
        [Fact]
        public async Task ShouldThrowValidationExceptionOnAddIfCustomerIsNullAndLogItAsync()
        {
            //given
            Customer nullCustomer = null;

            var nullCustomerException =
                new NullCustomerException();

            var expectedCustomerValidationException =
                new CustomerValidationException(nullCustomerException);

            //when
            ValueTask<Customer> addCustomerTask = 
                this.customerService.AddCustomerAsync(nullCustomer);

            //then
            await Assert.ThrowsAsync<CustomerValidationException>(() =>
                addCustomerTask.AsTask());

            this.loggingBrokerMock.Verify(broker =>
                broker.LogError(It.Is(SameExceptionAs(
                    expectedCustomerValidationException))),
                    Times.Once());

            this.storageBrokerMock.Verify(broker =>
                broker.InsertCustomerAsync(It.IsAny<Customer>()),
                    Times.Never);

            this.loggingBrokerMock.VerifyNoOtherCalls();
            this.storageBrokerMock.VerifyNoOtherCalls();
            this.dateTimeBrokerMock.VerifyNoOtherCalls();
        }
    }
}
