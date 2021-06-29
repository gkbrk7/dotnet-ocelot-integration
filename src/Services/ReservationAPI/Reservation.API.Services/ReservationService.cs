using System;
using System.Threading.Tasks;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public async Task<ReservationDTO> GetReservationById(Guid id)
        {
            return await Task.FromResult(new ReservationDTO { Id = id, Amount = new Random().Next(10000), BookingDate = DateTime.Now, CheckInDate = DateTime.Now.AddDays(30), CheckOutDate = DateTime.Now.AddDays(35), BookingNumber = new Random().Next(999) });
        }
    }
}
