using LAB1_HT2024.Models;

namespace LAB1_HT2024.Data.Repository.IRepository
{
    public interface ITableRepository
    {
        Task<IEnumerable<Table>> GetAllTables();

        Task<Table> GetTableById(int TableId);

        Task UpdateTable(Table table);

        Task AddTable(Table table);

        Task<List<Table>> GetAvailableTables(int groupSize, DateTime reservationStart);
    }
}
