using LAB1_HT2024.Models;
using LAB1_HT2024.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace LAB1_HT2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableService _tableServices;

        public TableController(ITableService tableServices)
        {
            _tableServices = tableServices;
        }

        [Route("GetTableById/{tableId}")]
        public async Task<ActionResult<Table>> GetTableById(int tableId)
        {
            var table = await _tableServices.GetTableByIdAsync(tableId);

            return Ok(table);
        }
    }
}
