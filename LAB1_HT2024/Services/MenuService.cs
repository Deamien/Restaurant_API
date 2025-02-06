using LAB1_HT2024.Data;
using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Models.ViewModels;
using LAB1_HT2024.Services.IServices;
using System.Runtime.CompilerServices;
using LAB1_HT2024.Models.DTOs.MenuDTOs;
using LAB1_HT2024.Models;

namespace LAB1_HT2024.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }


        public async Task<IEnumerable<GetMenuDTO>> GetAllMenuItems() 
        {
           var GetMenuList = await _menuRepository.GetAllMenuItems();

            return GetMenuList.Select(m => new GetMenuDTO
            {
                MenuId = m.Id,
                name = m.Name,
                price = m.Price,
                available = m.Available
            }).ToList();
        }

        public async Task<GetMenuDTO> GetMenuItemById(int MenuItemId)
        {
            var GetMenu = await _menuRepository.GetMenuItemById(MenuItemId);

            return new GetMenuDTO
            {
                MenuId = GetMenu.Id,
                name = GetMenu.Name,
                price = GetMenu.Price,
                available = GetMenu.Available
            };
        }
        
        public async Task RemoveMenuItem(int MenuItemId)
        {
            var GetMenu = await _menuRepository.GetMenuItemById(MenuItemId);

            await _menuRepository.RemoveMenuItem(GetMenu);
        }

        public async Task UpdateMenuItem(UpdateMenuItemDTO updateMenuDTO)
        {
            var Menu = await _menuRepository.GetMenuItemById(updateMenuDTO.MenuItemId);
                {
                    Menu.Id = updateMenuDTO.MenuItemId;
                    Menu.Name = updateMenuDTO.name;
                    Menu.Price = updateMenuDTO.price;
                    Menu.Available = updateMenuDTO.available;
                };
            
            await _menuRepository.UpdateMenuItem(Menu);
        }
        
        public async Task AddMenuItem(AddMenuItemDTO addMenuDTO)
        {
            var NewMenu = new Menu
            {
                Name = addMenuDTO.name,
                Price = addMenuDTO.price,
                Available = addMenuDTO.available,
            };
            
            await _menuRepository.AddMenuItem(NewMenu);
        }
    }
}
