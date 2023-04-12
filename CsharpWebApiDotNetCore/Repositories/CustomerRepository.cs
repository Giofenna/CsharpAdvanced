using CsharpWebApiDotNetCore.Data;
using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace CsharpWebApiDotNetCore.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AirDBContext? _context;

        public CustomerRepository(AirDBContext? context)
        {
            _context = context;
        }
        public async Task<Customer> GetCustomer(string email)
        {
            return await _context.Customer.FirstOrDefaultAsync(x=>x.Email == email);

        }
        public async Task CreateCustomer(Customer customer)
        {
            await _context.Customer.AddAsync(customer);
            _context.SaveChanges();
        }
    }
}