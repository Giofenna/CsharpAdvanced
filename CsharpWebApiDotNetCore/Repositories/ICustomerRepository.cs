using CsharpWebApiDotNetCore.Models;

namespace CsharpWebApiDotNetCore.Repositories
{
    public interface ICustomerRepository
    {
        public Task<Customer> GetCustomer(string email);

        public Task CreateCustomer(Customer customer);

    }
}
