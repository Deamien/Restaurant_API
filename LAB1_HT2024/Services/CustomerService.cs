using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Models;
using LAB1_HT2024.Models.DTOs.CustomerDTOs;
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

        public async Task<IEnumerable<GetCustomerDTO>> GetAllCustomers()
        {
            var GetCustomerList = await _customerRepository.GetAllCustomers();

            return GetCustomerList.Select(c => new GetCustomerDTO
            {
                CustomerId = c.Id,
                firstName = c.FirstName,
                lastName = c.LastName,
                emailAddress = c.EmailAddress,
                phoneNumber = c.PhoneNumber
            }).ToList();
        }

        public async Task<GetCustomerDTO> GetCustomerById(int CustomerId)
        {
            var GetCustomer = await _customerRepository.GetCustomerById(CustomerId);

            return new GetCustomerDTO
            {
                CustomerId = GetCustomer.Id,
                firstName = GetCustomer.FirstName,
                lastName = GetCustomer.LastName,
                emailAddress = GetCustomer.EmailAddress,
                phoneNumber = GetCustomer.PhoneNumber
            };
        }

        public async Task RemoveCustomer(int CustomerId)
        {
            await _customerRepository.GetCustomerById(CustomerId);

            await _customerRepository.RemoveCustomer(CustomerId);
        }

        public async Task UpdateCustomer(UpdateCustomerDTO updateCustomerDTO)
        {
            var customer = await _customerRepository.GetCustomerById(updateCustomerDTO.CustomerId); //tar emot använder metoden från repository för att hämta customerid som matchar CustomerId från DTOn
            {
                customer.FirstName = updateCustomerDTO.firstName;
                customer.LastName = updateCustomerDTO.lastName;
                customer.EmailAddress = updateCustomerDTO.emailAddress;
                customer.PhoneNumber = updateCustomerDTO.phoneNumber;
            }

            await _customerRepository.UpdateCustomer(customer); //den skickar variablen till metoden i Repository för att senare köra en update till Databas
        }

        public async Task AddCustomer(AddCustomerDTO addCustomerDTO)
        {
            var NewCustomer = new Customer
            {
                FirstName = addCustomerDTO.firstName,
                LastName = addCustomerDTO.lastName,
                EmailAddress = addCustomerDTO.emailAddress,
                PhoneNumber = addCustomerDTO.phoneNumber
            };

            await _customerRepository.AddCustomer(NewCustomer);
        }
    }
}


