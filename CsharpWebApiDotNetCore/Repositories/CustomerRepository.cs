using CsharpWebApiDotNetCore.Data;

namespace CsharpWebApiDotNetCore.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AirDBContext? _context;

        public CustomerRepository(AirDBContext? context)
        {
            _context = context;
        }
    }
}