using LAB1_HT2024.Models;


namespace LAB1_HT2024.Data.Repository.IRepository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int CustomerId);
        Task DeleteCustomer();
        Task UpdateCustomer();
        Task AddCustomer(Customer customer);

    }
}
