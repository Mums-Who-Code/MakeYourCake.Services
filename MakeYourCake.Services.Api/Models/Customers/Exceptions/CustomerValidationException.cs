// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using Xeptions;

namespace MakeYourCake.Services.Api.Models.Customers.Exceptions
{
    public class CustomerValidationException : Xeption
    {
        public CustomerValidationException(Xeption innerException)
            : base(message: "Customer validation errors occurred, please try again.", innerException)
        { } 
    }
}
