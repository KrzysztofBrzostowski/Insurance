using Insurance.IRepositories;
using Insurance.Models;
using Insurance.Models.SearchCriterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.EFRepositories
{
    public class DbCustomerRepository : ICustomerRepository
    {
        private InsuranceContext context;

        public DbCustomerRepository(InsuranceContext context)
        {
            this.context = context;
        }

        public void Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public List<Customer> Get()
        {
            return context.Customers.ToList();
        }

        public List<Customer> GetCustomerList(CustomerSearchCriteria searchCriteria)
        {
            IQueryable<Customer> query = context.Customers.AsQueryable();
            if (!string.IsNullOrEmpty(searchCriteria.FirstName))
            {
                query = query.Where(c => c.FirstName == searchCriteria.FirstName);
            }
            if (!string.IsNullOrEmpty(searchCriteria.LastName))
            {
                query = query.Where(c => c.LastName == searchCriteria.LastName);
            }


            return query.ToList();
        }
    }
}
