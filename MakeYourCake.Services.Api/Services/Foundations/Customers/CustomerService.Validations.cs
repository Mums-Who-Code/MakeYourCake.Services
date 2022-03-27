// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using MakeYourCake.Services.Api.Models.Customers;
using MakeYourCake.Services.Api.Models.Customers.Exceptions;

namespace MakeYourCake.Services.Api.Services.Foundations.Customers
{
    public partial class CustomerService
    {
        private static void ValidateCustomer(Customer customer)
        {
            ValidateCustomerIsNotNull(customer);
        }
        
        private static void ValidateCustomerIsNotNull(Customer customer)
        {
            if (customer == null)
            {
                throw new NullCustomerException();
            }
        }
    }
}
