// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Net.Http;
using MakeYourCake.Services.Api;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;

namespace MakeYourCake.Services.Tests.Acceptance.Brokers
{
    public partial class MakeYourCakeApiBroker
    {
        private readonly WebApplicationFactory<Startup> webApplicationFactory;
        private readonly HttpClient httpClient;
        private readonly IRESTFulApiFactoryClient apiFactoryClient;

        public MakeYourCakeApiBroker()
        {
            this.webApplicationFactory = new WebApplicationFactory<Startup>();
            this.httpClient = this.webApplicationFactory.CreateClient();
            this.apiFactoryClient = new RESTFulApiFactoryClient(this.httpClient);
        }
    }
}
