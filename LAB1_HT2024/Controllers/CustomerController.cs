using LAB1_HT2024.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace LAB1_HT2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly ICustomerService _costumerService;

        public CustomerController(ICustomerService costumerService)
        {
            _costumerService = costumerService;
        }
    }




