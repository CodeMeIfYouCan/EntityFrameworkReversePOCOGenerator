using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Reverse.POCO.Generator;

namespace Tester.BusinessLogic
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly IMyDbContext _context;

        public CustomersRepository(IMyDbContext context)
        {
            if(context == null)
                throw new ArgumentNullException("context");

            _context = context;
        }

        public IQueryable<Customer> GetTop10()
        {
            return _context.Customers.Take(10).OrderBy(x => x.CustomerId);
        }

        public async Task<List<Customer>> GetTop10Async()
        {
            //todo:emrahdi check test this method
            //return await GetTop10().ToListAsync();
            return await GetTop10().ToAsyncEnumerable<Customer>().ToList();
        }

        public int Count()
        {
            return _context.Customers.Count();
        }

        public Customer FindById(string id)
        {
            return _context.Customers.FirstOrDefault(x => x.CustomerId == id);
        }

        public Customer Find(string id)
        {
            return _context.Customers.Find(id);
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}