using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;

namespace Reservation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService reservationService;
        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;

        }
        [HttpGet("{id}", Name = "GetReservationById")]
        public async Task<IActionResult> GetReservationById(Guid id)
        {
            return Ok(await reservationService.GetReservationById(id));
        }
    }
}