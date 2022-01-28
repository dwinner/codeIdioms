﻿using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Northwind.SqlDataAccess
{
   [UsedImplicitly]
   public class Mapper
   {
      public Core.Customer Map([CanBeNull] Customer customer)
      {
         if (customer == null)
         {
            return null;
         }

         return new Core.Customer
         {
            Id = customer.Customer_ID,
            City = customer.City,
            CompanyName = customer.Company_Name,
            Phone = customer.Phone,
            PostalCode = customer.Postal_Code
         };
      }

      public Customer Map([CanBeNull] Core.Customer customer)
      {
         if (customer == null)
         {
            return null;
         }

         return new Customer
         {
            Customer_ID = customer.Id,
            City = customer.City,
            Company_Name = customer.CompanyName,
            Phone = customer.Phone,
            Postal_Code = customer.PostalCode
         };
      }

      public IEnumerable<Core.Customer> Map([NotNull] IEnumerable<Customer> customers) => customers.Select(Map);
   }
}