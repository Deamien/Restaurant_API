using LAB1_HT2024.Models.DTOs.MenuDTOs;
using LAB1_HT2024.Services;
using LAB1_HT2024.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB1_HT2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        [Route("all")]

        public async Task<IActionResult> GetAllMenuItems()
        {
            var menus = await _menuService.GetAllMenuItems();
            return Ok(menus);
        }


        [HttpGet]
        [Route("{MenuItemId}")]
        public async Task<IActionResult> GetMenuItemById(int MenuItemId)
        {
            try
            {
                var menu = await _menuService.GetMenuItemById(MenuItemId);
                if (menu != null)
                {
                    return Ok(menu);
                }
                else
                {
                    return BadRequest("Menu is empty");
                }
            }

            catch (KeyNotFoundException)
            {
                return NotFound("MenuItemId not found");
            }
        }

        [HttpDelete]
        [Route("delete/{MenuItemId}")]

        public async Task<IActionResult> RemoveMenuItem(int MenuItemId)
        {
            try
            {
                await _menuService.RemoveMenuItem(MenuItemId);
                return Ok("Menu Removed");
            }
            catch (KeyNotFoundException)
            {
                return NotFound("MenuItemId not found");
            }
        }

        [HttpPut]
        [Route("update/{MenuItemId}")]

        public async Task<IActionResult> UpdateMenuItem(int MenuItemId, [FromBody] UpdateMenuItemDTO updateMenuItemDTO)
        {
            if (MenuItemId != updateMenuItemDTO.MenuItemId)
            {
                return BadRequest("MenuItemId not found");
            }

            else
            {
                await _menuService.UpdateMenuItem(updateMenuItemDTO);
                return Ok("Menu updated");
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddMenuItem([FromBody] AddMenuItemDTO addMenuItemDTO)
        {
            if (addMenuItemDTO != null)
            {
                await _menuService.AddMenuItem(addMenuItemDTO);
                return Ok("Added a new MenuItem");
            }

            else
            {
                return BadRequest("Please fill out the needed information");
            }
        }
    }
}