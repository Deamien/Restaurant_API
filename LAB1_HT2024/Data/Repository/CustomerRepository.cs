using LAB1_HT2024.Models;
using LAB1_HT2024.Data.Repository.IRepository;
using MiniProjekt_API.Data;
using Arch.EntityFrameworkCore;

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
    }
