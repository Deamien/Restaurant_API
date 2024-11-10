using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Models;
using LAB1_HT2024.Models.DTOs.CustomerDTOs;
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
                CustomerId = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                EmailAddress = c.EmailAddress,
                PhoneNumber = c.PhoneNumber,
            }).ToList();

            return CustomerList;
        }

        public async Task RemoveCustomer(int CustomerId)
        {
            var
        }
        public async Task UpdateCustomer(CustomerDTO UpdateCustomerDTO)
        {
            var updatedcustomer = await _customerRepository.GetCustomerById(UpdateCustomerDTO.Id); //tar emot använder metoden från repository för att hämta customerid
            {
                updatedcustomer.FirstName = UpdateCustomerDTO.FirstName;
                updatedcustomer.LastName = UpdateCustomerDTO.LastName;
                updatedcustomer.EmailAddress = UpdateCustomerDTO.EmailAddress;
                updatedcustomer.PhoneNumber = UpdateCustomerDTO.PhoneNumber;
            }

            await _customerRepository.UpdateCustomer(updatedcustomer); //den skickar variablen till metoden i Repository för att senare köra en update till Databas
        }

        public async Task AddCustomer(CreateCustomerDTO AddCustomerDTO)
        {
            var NewCustomer = new Customer
            {
                FirstName = AddCustomerDTO.FirstName,
                LastName = AddCustomerDTO.LastName,
                EmailAddress = AddCustomerDTO.EmailAddress,
                PhoneNumber = AddCustomerDTO.PhoneNumber,
            };

            await _customerRepository.AddCustomer(NewCustomer);
        }
    }
}


