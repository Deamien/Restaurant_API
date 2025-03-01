using LAB1_HT2024.Models.DTOs.AdminDTO;
using LAB1_HT2024.Services.IServices;
using Microsoft.AspNetCore.Mvc;


namespace LAB1_HT2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AdminDTO adminDTO)
        {
            var token = await _adminService.Authenticate(adminDTO);

            if (token == null)
                return Unauthorized("Invalid username or password");

            return Ok(new { Token = token });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AdminDTO adminDTO) 
        {
            if (adminDTO != null) 
            {
                await _adminService.RegisterAdmin(adminDTO);
                return Ok("Admin registered successfully.");
            }
            else
            {
                return BadRequest("Please fill out the needed information");
            }

        }  
    }
}