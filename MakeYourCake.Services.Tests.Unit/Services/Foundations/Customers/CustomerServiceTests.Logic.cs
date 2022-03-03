// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using FluentAssertions;
using Force.DeepCloner;
using MakeYourCake.Services.Api.Models.Customers;
using Moq;
using Xunit;

namespace MakeYourCake.Services.Tests.Unit.Services.Foundations.Customers
{
    public partial class CustomerServiceTests
    {
        [Fact]
        public async Task ShouldAddCustomerAsync()
        {
            //given
            Customer randomCustomer = CreateRandomCustomer();
            Customer inputCustomer = randomCustomer;
            Customer persistedCustomer = inputCustomer;
            Customer expectedCustomer = persistedCustomer.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertCustomerAsync(inputCustomer))
                    .ReturnsAsync(persistedCustomer);

            //when
            Customer actualCustomer =
                await this.customerService.AddCustomerAsync(inputCustomer);

            //then
            actualCustomer.Should().BeEquivalentTo(expectedCustomer);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertCustomerAsync(inputCustomer),
                    Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }

    }
}
