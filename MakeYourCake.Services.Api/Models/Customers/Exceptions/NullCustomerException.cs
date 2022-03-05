// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using Xeptions;

namespace MakeYourCake.Services.Api.Models.Customers.Exceptions
{
    public class NullCustomerException : Xeption
    {
        public NullCustomerException()
            : base(message: "Customer is null.")
        { }
    }
}
