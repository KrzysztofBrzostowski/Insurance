using Insurance.IRepositories;
using Insurance.Models;
using Insurance.Models.SearchCriterias;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Insurance.FakeRepositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        private List<Customer> customers;
        public FakeCustomerRepository()
        {
            customers = new List<Customer>();
            customers.Add(new Customer() { Id = 1, FirstName = "Jan", LastName = "Kowalski", Pesel = "12345678901" });
            customers.Add(new Customer() { Id = 2, FirstName = "Anna", LastName = "Kowalska", Pesel = "80345678900" });
            customers.Add(new Customer() { Id = 3, FirstName = "Kazimierz", LastName = "Nowak", Pesel = "90345678901" });
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public List<Customer> Get()
        {
            return customers;
        }

        public List<Customer> GetCustomerList(CustomerSearchCriteria searchCriteria)
        {
            return customers.Where(cust => cust.FirstName == searchCriteria.FirstName &&
            cust.LastName == searchCriteria.LastName && cust.Pesel == searchCriteria.Pesel).ToList();
        }
    }
}
