using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Services.IServices;
using LAB1_HT2024.Models.ViewModels;


namespace LAB1_HT2024.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepository _tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

      
    }
}
