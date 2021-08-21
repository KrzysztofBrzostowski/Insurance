using Insurance.Models;
using Insurance.Models.SearchCriterias;
using System;
using System.Collections.Generic;

namespace Insurance.IRepositories
{
    public interface ICustomerRepository
    {
        List<Customer> Get();

        List<Customer> GetCustomerList(CustomerSearchCriteria searchCriteria);
        void Add(Customer customer);
    }
}
