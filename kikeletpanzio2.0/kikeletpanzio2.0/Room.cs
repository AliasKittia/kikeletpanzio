using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kikeletpanzio2._0
{
    public class BookingSystem : INotifyPropertyChanged
    {
        public List<Room> Rooms { get; set; }
        private List<Booking> bookings;

        public BookingSystem()
        {
            Rooms = new List<Room>();
            bookings = new List<Booking>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
            OnPropertyChanged("Rooms");
        }

        public List<Room> ListRooms()
        {
            return Rooms;
        }

        public void MakeBooking(Booking booking)
        {
            int newBookingId = bookings.Count + 1;
            bookings.Add(new Booking(newBookingId, booking.Room, booking.StartDate, booking.EndDate, booking.NumberOfGuests, booking.TotalPrice));
            OnPropertyChanged("Bookings");
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public partial class Booking
    {
        public Booking(int bookingId, Room room, DateTime startDate, DateTime endDate, int numberOfGuests, double totalPrice)
        {
            BookingId = bookingId;
            Room = room;
            StartDate = startDate;
            EndDate = endDate;
            NumberOfGuests = numberOfGuests;
            TotalPrice = totalPrice;
        }

        public Booking(int bookingId, Room room, DateTime startDate, DateTime endDate)
        {
            BookingId = bookingId;
            Room = room;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int BookingId { get; set; }
        public Room? Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfGuests { get; set; }
        public double TotalPrice { get; set; }

        public override string ToString()
        {
            return $"Booking {BookingId} - Room: {Room.RoomNumber}, Start Date: {StartDate}, End Date: {EndDate}, Number of Guests: {NumberOfGuests}, Total Price: {TotalPrice:C}";
        }
    }

    public class Room
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }

        public Room(int roomId, string roomType, double pricePerNight)
        {
            RoomId = roomId;
            RoomType = roomType;
            PricePerNight = pricePerNight;
        }

        public Room(int roomNumber, int capacity, double pricePerNight)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            PricePerNight = pricePerNight;
        }

        public override string ToString()
        {
            return $"Szoba {RoomNumber} - Kapacitás: {Capacity}, Ár: {PricePerNight:C}";
        }
    }
}