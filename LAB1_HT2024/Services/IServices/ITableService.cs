using LAB1_HT2024.Models.DTOs.TableDTOs;

namespace LAB1_HT2024.Services.IServices
{
    public interface ITableService
    {
        Task<IEnumerable<GetTableDTO>> GetAllTables();
        Task<GetTableDTO> GetTableById(int TableId);
        Task RemoveTable(int TableId);
        Task UpdateTable(UpdateTableDTO updateTableDTO);
        Task AddTable(AddTableDTO addTableDTO);
    }
}
