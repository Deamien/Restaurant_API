using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Services.IServices;
using LAB1_HT2024.Models.ViewModels;
using LAB1_HT2024.Models.DTOs.TableDTOs;
using LAB1_HT2024.Models;


namespace LAB1_HT2024.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepository _tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public async Task<IEnumerable<TableViewModel>> GetAllTables() 
        {
            var GetTableList = await _tableRepository.GetAllTables();

            return GetTableList.Select(t => new TableViewModel
            {
                TableId = t.Id,
                seats = t.Seats
            });
        }

        public async Task<TableViewModel> GetTableById(int TableId)
        {
            var GetTable = await _tableRepository.GetTableById(TableId);

            return new TableViewModel
            {
                TableId = GetTable.Id,
                seats = GetTable.Seats
            };
        }

        public async Task RemoveTable(int TableId)
        {
            var GetTable = await _tableRepository.GetTableById(TableId);

            await _tableRepository.RemoveTable(GetTable);
        }

        public async Task UpdateTable(UpdateTableDTO updateTableDTO)
        {
            var table = await _tableRepository.GetTableById(updateTableDTO.TableId);
            {
                table.Id = updateTableDTO.TableId;
                table.Seats = updateTableDTO.seats;
            }
           
            await _tableRepository.UpdateTable(table);
        }

        public async Task AddTable(AddTableDTO addTableDTO)
        {
            var NewTable = new Table
            {
                Seats = addTableDTO.seats
            };
            
            await _tableRepository.AddTable(NewTable);
        }
    }
}
