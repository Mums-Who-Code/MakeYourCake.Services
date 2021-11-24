// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using MakeYourCake.Services.Tests.Acceptance.Brokers;
using Xunit;

namespace MakeYourCake.Services.Tests.Acceptance.Apis.Home
{
    [Collection(nameof(ApiTestCollection))]
    public partial class HomeApiTests
    {
        private readonly MakeYourCakeApiBroker makeYourCakeApiBroker;

        public HomeApiTests(MakeYourCakeApiBroker makeYourCakeApiBroker) =>
            this.makeYourCakeApiBroker = makeYourCakeApiBroker;
    }
}
