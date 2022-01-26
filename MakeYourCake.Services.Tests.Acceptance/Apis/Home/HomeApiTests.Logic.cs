// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace MakeYourCake.Services.Tests.Acceptance.Apis.Home
{
    public partial class HomeApiTests
    {
        [Fact]
        public async Task ShouldReturnHomeMessageAsync()
        {
            //given
            string expectedHomeMessage =
                "Hello from Make Your Cake Services Api!";

            //when
            string actualHomeMessage =
                await this.makeYourCakeApiBroker.GetHomeMessageAsync();

            //then
            actualHomeMessage.Should().BeEquivalentTo(expectedHomeMessage);
        }
    }
}
