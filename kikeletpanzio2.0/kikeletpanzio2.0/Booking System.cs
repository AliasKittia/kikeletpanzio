using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kikeletpanzio2._0
{
    internal class Booking_System(int bookingId, Room room, DateTime startDate, DateTime endDate, int numberOfGuests, double totalPrice)
    {
        public int BookingId { get; set; } = bookingId;
        public Room Room { get; set; } = room;
        public DateTime StartDate { get; set; } = startDate;
        public DateTime EndDate { get; set; } = endDate;
        public int NumberOfGuests { get; set; } = numberOfGuests;
        public double TotalPrice { get; set; } = (endDate - startDate).TotalDays * room.PricePerNight;
    }
}
}
