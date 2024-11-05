using LAB1_HT2024.Models.DTOs.CustomerDTOs;
using LAB1_HT2024.Models.ViewModels;

namespace LAB1_HT2024.Services.IServices
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerViewModel>> GetAllCustomers();
        Task<CustomerViewModel> GetAllCustomerById(int CustomerId);
        Task UpdateCustomer(CustomerDTO customerUpdate);
        Task DeleteCustomerById(int CustomerId);
        Task CreateCustomer(CustomerDTO customerCreate);

        //Kanske behöver skapa en ny DTO för att några value inte är relevanta
    }
}
