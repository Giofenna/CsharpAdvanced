using CsharpWebApiDotNetCore.Models;
namespace CsharpWebApiDotNetCore.Services
{
    public interface ICustomerService
    {
        public Task<Customer> GetCustomer(string email);
    }
}
