using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Models;
using Microsoft.EntityFrameworkCore;
using MiniProjekt_API.Data;

namespace LAB1_HT2024.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly RestaurantContext _context;

        public CustomerRepository(RestaurantContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            var CustomerList = await _context.customer.ToListAsync();

            return CustomerList;
        }

        public async Task<Customer> GetCustomerById(int CustomerId)
        {
            return await _context.customer.FirstOrDefaultAsync(C => C.Id == CustomerId);
        }

        public async Task RemoveCustomer(Customer customer)
        {
            _context.customer.Remove(customer);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomer(Customer customer)
        {
            _context.customer.Update(customer);

            await _context.SaveChangesAsync();
        }
        public async Task AddCustomer(Customer customer)
        {
            await _context.customer.AddAsync(customer);

            await _context.SaveChangesAsync();
        }

    }
}