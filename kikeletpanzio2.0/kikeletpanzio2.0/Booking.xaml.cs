using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kikeletpanzio2._0
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        private BookingSystem bookingSystem;

        public Booking()
        {
            InitializeComponent();
            bookingSystem = new BookingSystem();
            InitializeRooms();
        }
        private void InitializeRooms()
        {
            string[] roomData = System.IO.File.ReadAllLines("szobak.txt");
            foreach (string line in roomData)
            {
                string[] parts = line.Split(';');
                int roomNumber = int.Parse(parts[0]);
                int capacity = int.Parse(parts[1]);
                double pricePerNight = double.Parse(parts[2]);
                Room room = new Room(roomNumber, capacity, pricePerNight);
                bookingSystem.AddRoom(room);
            }
            roomListBox.ItemsSource = bookingSystem.Rooms;
        }
        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            // Itt foglalásokat kezelhetnél
            MessageBox.Show("Foglalás(ok) sikeresen létrehozva!");
        }
    }
}
