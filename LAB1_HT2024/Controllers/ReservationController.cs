using LAB1_HT2024.Models.DTOs.ReservationDTOs;
using LAB1_HT2024.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace LAB1_HT2024.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllReservations()
        {
            var reservations = await _reservationService.GetAllReservations();

            if (reservations != null)
            {
                return Ok(reservations);
            }

            else
            {
                return NotFound("There are no reservations");
            }
        }


        [HttpGet]
        [Route("{ReservationId}")]
        public async Task<IActionResult> GetReservationById(int ReservationId)
        {
            try
            {
                var reservation = await _reservationService.GetReservationById(ReservationId);
                if (reservation != null)
                {
                    return Ok(reservation);
                }
                else
                {
                    return BadRequest("Reservation is empty");
                }
            }

            catch (KeyNotFoundException)
            {
                return NotFound("ReservationId not found");
            }
        }

        [HttpDelete]
        [Route("delete/{ReservationId}")]
        public async Task<IActionResult> RemoveReservation(int ReservationId)
        {
            try
            {
                await _reservationService.RemoveReservation(ReservationId);
                return Ok("Reservation Removed");
            }
            catch (KeyNotFoundException)
            {
                return NotFound("ReservationId not found");
            }
        }

        [HttpPut]
        [Route("update/{ReservationId}")]
        public async Task<IActionResult> UpdateReservation(int ReservationId, [FromBody] UpdateReservationDTO updateReservationDTO)
        {
            if (ReservationId != updateReservationDTO.ReservationId)
            {
                return BadRequest("ReservationId not found");
            }

            else
            {
                await _reservationService.UpdateReservation(updateReservationDTO);
                return Ok("Reservation updated");
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddReservation([FromBody] AddReservationDTO addReservationDTO)
        {
            if (addReservationDTO != null)
            {
                await _reservationService.AddReservation(addReservationDTO);
                return Ok("Added a new Reservation");
            }

            else
            {
                return BadRequest("Please fill out the needed information");
            }
        }
    }
}


