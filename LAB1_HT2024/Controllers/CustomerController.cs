﻿using LAB1_HT2024.Models.DTOs.CustomerDTOs;
using LAB1_HT2024.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace LAB1_HT2024.Controllers
{
    //[Authorize]
    [Route("api/customer")]
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

            if (customers != null)
            {
                return Ok(customers);
            }

            else
            {
                return NotFound("There are no registered customers");
            }
        }


        [HttpGet]
        [Route("{CustomerId}")]
        public async Task<IActionResult> GetCustomerById(int CustomerId)
        {
            var customer = await _customerService.GetCustomerById(CustomerId);

            return Ok(customer);
        }

        [HttpDelete]
        [Route("delete/{CustomerId}")]

        public async Task<IActionResult> RemoveCustomer(int CustomerId)
        {
            await _customerService.RemoveCustomer(CustomerId);

            return Ok("Customer Removed");
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
            if (!ModelState.IsValid)
            {
                await _customerService.AddCustomer(addCustomerDTO);
                return BadRequest(ModelState);
            }

            else
            {
                return Ok("Added a new customer");
            }
        }
    }
}



