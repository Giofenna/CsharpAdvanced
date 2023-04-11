using AutoMapper;
using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Repositories;

namespace CsharpWebApiDotNetCore.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository CustomerRepository, IMapper mapper)
        {
            _CustomerRepository = CustomerRepository;
            _mapper = mapper;
        }
        public async Task<Customer> GetCustomer(string email)
        {
            return await _CustomerRepository.GetCustomer(email);
            
        }
        public async Task CreateCustomer(Customer customer)
        {
            await _CustomerRepository.CreateCustomer(customer);

        }
    }
}
