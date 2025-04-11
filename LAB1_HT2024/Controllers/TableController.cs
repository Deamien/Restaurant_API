using LAB1_HT2024.Models.DTOs.TableDTOs;
using LAB1_HT2024.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace LAB1_HT2024.Controllers
{
    //[Authorize]
    [Route("api/table")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllTables()
        {
            var tables = await _tableService.GetAllTables();

            if (tables != null)
            {
                return Ok(tables);
            }

            else
            {
                return NotFound("No Tables");
            }
        }

        [HttpGet]
        [Route("{TableId}")]
        public async Task<IActionResult> GetTableById(int TableId)
        {
            try
            {
                var table = await _tableService.GetTableById(TableId);

                if (table != null)
                {
                    return Ok(table);
                }
                else
                {
                    return NotFound("Table is empty");
                }
            }
            catch (KeyNotFoundException)
            {
                return NotFound("TableId not found");
            }
        }

        [HttpDelete]
        [Route("delete/{TableId}")]
        public async Task<IActionResult> RemoveTable(int TableId)
        {
            try
            {
                await _tableService.RemoveTable(TableId);
                return Ok("Table Removed");
            }
            catch (KeyNotFoundException)
            {
                return NotFound("TableId not found");
            }
        }

        [HttpPut]
        [Route("update/{TableId}")]
        public async Task<IActionResult> UpdateTable(int TableId, [FromBody] UpdateTableDTO updateTableDTO)
        {
            if (TableId != updateTableDTO.TableId)
            {
                return BadRequest("TableId not found");
            }

            else
            {
                await _tableService.UpdateTable(updateTableDTO);
                return Ok("Table Updated");
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddTable([FromBody] AddTableDTO addTableDTO)
        {
            if (addTableDTO.seats != null)
            {
                await _tableService.AddTable(addTableDTO);
                return Ok("Added a new table");
            }

            else
            {
                return BadRequest("Please fill out the amount of seats");
            }
        }
    }
}

