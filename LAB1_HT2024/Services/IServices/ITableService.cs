using LAB1_HT2024.Models.DTOs.TableDTOs;
using LAB1_HT2024.Models.ViewModels;

namespace LAB1_HT2024.Services.IServices
{
    public interface ITableService
    {
        Task<IEnumerable<TableViewModel>> GetAllTables();
        Task<TableViewModel> GetTableById(int TableId);
        Task RemoveTable(int TableId);
        Task UpdateTable(TableDTO updateTableDTO);
        Task AddTable(AddTableDTO addTableDTO);
    }
}
