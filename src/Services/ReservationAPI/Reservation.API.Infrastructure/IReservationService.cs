using System;
using System.Threading.Tasks;
using Reservation.API.Models;

namespace Reservation.API.Infrastructure
{
    public interface IReservationService
    {
        Task<ReservationDTO> GetReservationById(Guid id);
    }
}
