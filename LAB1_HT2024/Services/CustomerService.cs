using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Models.ViewModels;
using LAB1_HT2024.Services.IServices;


namespace LAB1_HT2024.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<CustomerViewModel>> GetAllCustomers()
        {
            var customerList = await _customerRepository.GetAllCustomers();

            var CustomerList = customerList.Select(c => new CustomerViewModel
            {
                CustomerId = c.CustomerId,
                FirstName = c.FirstName,
                LastName = c.LastName,
                EmailAddress = c.EmailAddress,
                PhoneNumber = c.PhoneNumber,
            }).ToList();

            return CustomerList;
        }
    }
}

