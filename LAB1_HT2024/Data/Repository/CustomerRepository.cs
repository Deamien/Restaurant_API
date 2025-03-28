using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Models;
using Microsoft.EntityFrameworkCore;

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
            // Optimerar datahämtning genom att förhindra att entiteter spåras av DbContext, 
            // vilket förbättrar prestandan vid endast läsning av data.
            var CustomerList = await _context.Customers.AsNoTracking().ToListAsync();

            return CustomerList;
        }

        public async Task<Customer> GetCustomerById(int CustomerId)
        {
            var Customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == CustomerId);

            return Customer;
        }

        public async Task RemoveCustomer(int CustomerId)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(C => C.Id == CustomerId);

            if (customer == null)
            {
                throw new KeyNotFoundException("Customer not found.");
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);

            await _context.SaveChangesAsync();
        }
        public async Task AddCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);

            await _context.SaveChangesAsync();
        }

    }
}