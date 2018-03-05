using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Reverse.POCO.Generator;

namespace Tester.BusinessLogic
{
    public interface ICustomersRepository
    {
        IQueryable<Customer> GetTop10();
        Task<List<Customer>> GetTop10Async();
        int Count();
        Customer FindById(string id);
        Customer Find(string id);
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}