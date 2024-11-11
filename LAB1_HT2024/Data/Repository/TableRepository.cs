using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Data;

namespace LAB1_HT2024.Data.Repository
{
    public class TableRepository : ITableRepository
    {
        private readonly RestaurantContext _context;

        public TableRepository(RestaurantContext context)
        {
            _context = context;
        }
    }
}
