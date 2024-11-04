using LAB1_HT2024.Models;

namespace LAB1_HT2024.Services.IServices
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
    }
}
