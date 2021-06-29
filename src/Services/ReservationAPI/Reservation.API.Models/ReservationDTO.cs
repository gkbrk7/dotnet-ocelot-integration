using System;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public Guid Id { get; set; }
        public int BookingNumber { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? BookingDate { get; set; }
        public double Amount { get; set; }
    }
}
