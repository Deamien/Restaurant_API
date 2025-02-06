using LAB1_HT2024.Models.DTOs.CustomerDTOs;

namespace LAB1_HT2024.Services.IServices
{
    public interface ICustomerService
    {
        Task<IEnumerable<GetCustomerDTO>> GetAllCustomers();
        Task<GetCustomerDTO> GetCustomerById(int CustomerId);
        Task RemoveCustomer(int CustomerId);
        Task UpdateCustomer(UpdateCustomerDTO updateCustomerDTO);
        Task AddCustomer(AddCustomerDTO addCustomerDTO);

        //Kanske behöver skapa en ny DTO för att några value inte är relevanta
    }
}
