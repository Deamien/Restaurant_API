using LAB1_HT2024.Models;
using LAB1_HT2024.Models.DTOs.CustomerDTOs;
using LAB1_HT2024.Models.DTOs.TableDTOs;
using LAB1_HT2024.Services;
using LAB1_HT2024.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LAB1_HT2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("all")]

        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _customerService.GetAllCustomers();
            return Ok(customers);
        }


        [HttpGet]
        [Route("{CustomerId}")]
        public async Task<IActionResult> GetCustomerById(int CustomerId)
        {
            try
            {
                var customer = await _customerService.GetCustomerById(CustomerId);
                if (customer != null)
                {
                    return Ok(customer);
                }
                else 
                {
                    return BadRequest("Customer is empty");
                }
            }

            catch (KeyNotFoundException)
            {
                return NotFound("CustomerId not found");
            }
        }

        [HttpDelete]
        [Route("delete/{CustomerId}")]

        public async Task<IActionResult> RemoveCustomer(int CustomerId)
        {
            try
            {
                await _customerService.RemoveCustomer(CustomerId);
                return Ok("Customer Removed");
            }
            catch (KeyNotFoundException)
            {
                return NotFound("CustomerId not found");
            }
        }

        [HttpPut]
        [Route("update/{CustomerId}")]

        public async Task<IActionResult> UpdateCustomer(int CustomerId, [FromBody] UpdateCustomerDTO updateCustomerDTO)
        {
            if (CustomerId != updateCustomerDTO.CustomerId)
            {
                return BadRequest("CustomerId not found");
            }

            else
            {
                await _customerService.UpdateCustomer(updateCustomerDTO);
                return Ok("Customer updated");
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddCustomer([FromBody] AddCustomerDTO addCustomerDTO)
        {
            if (addCustomerDTO != null)
            {
                await _customerService.AddCustomer(addCustomerDTO);
                return Ok("Added a new customer");
            }

            else
            {
                return BadRequest("Please fill out the needed information");
            }
        }
    }       
}



