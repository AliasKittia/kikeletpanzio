using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Sign_in.xaml
    /// </summary>
    public partial class Sign_in : Window
    {
        List<Guest> vendegek = new List<Guest>();

        public Sign_in()
        {
            InitializeComponent();

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            #region adatok

            string firstname = FirstName.Text;
            string lastname = LastName.Text;
            DateTime? birthdate = Birthdate.SelectedDate;
            string birthplace = BirthPlace.Text;
            string phonenumber = Phonenumber.Text;
            string email = Email.Text;
            string password1 = Password1.Password; // PasswordBox
            string password2 = Password2.Password; // PasswordBox
            string vip = RB_Yes.IsChecked == true ? "Igen" : "Nem";

            #endregion

            #region ellenőrzés, hogy minden ki van e töltve

            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("A vezetéknév nem került kitöltésre!");
                return;
            }

            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("A keresztnév nem került kitöltésre!");
                return;
            }

            if (!birthdate.HasValue)
            {
                MessageBox.Show("A születési dátum nem megfelelő vagy nem került kitöltésre!");
                return;
            }

            if (string.IsNullOrWhiteSpace(birthplace))
            {
                MessageBox.Show("A születési hely nem került kitöltésre!");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Az email cím nem került kitöltésre!");
                return;
            }

            if (string.IsNullOrWhiteSpace(password1))
            {
                MessageBox.Show("A jelszó nem került kitöltésre!");
                return;
            }
            if (string.IsNullOrWhiteSpace(password2))
            {
                MessageBox.Show("A jelszó nem került kitöltésre!");
                return;
            }

            #endregion

            #region jelszavak egyezése

            if (password1 != password2)
            {
                MessageBox.Show("A jelszavak nem egyeznek!");
                return;
            }

            #endregion

            #region azonosító kiírása a felhasználó számára

            string identifier = CreateIdentifier(firstname, lastname);
            MessageBox.Show("Az ön azonosítója: " + identifier, "Kérem jegyezze meg az azonosítóját!", MessageBoxButton.OK, MessageBoxImage.Warning);

            #endregion

            #region adatok hozzáadása a listához

            //vendegek.Add(new Guest(identifier, firstname, lastname, phonenumber, birthdate, birthplace, email, password1, vip));

            #endregion

            #region Adatok írása a fájlba

            using (StreamWriter writer = new StreamWriter("Panzio.txt", true))
            {
                writer.WriteLine($"Azonosító: {identifier}");
                writer.WriteLine($"Vezetéknév: {firstname}");
                writer.WriteLine($"Keresztnév: {lastname}");
                writer.WriteLine($"Születési hely: {birthplace}");
                writer.WriteLine($"Születési dátum: {birthdate.Value.ToShortDateString()}");
                writer.WriteLine($"Email: {email}");
                writer.WriteLine($"Jelszó: {password1}");
                writer.WriteLine($"VIP tag: {vip}");
                writer.WriteLine(); // Új vendég adatait egy új sorba írjuk
            }

            #endregion

            #region Sikeres mentés üzenet megjelenítése

            MessageBox.Show("Az adatok sikeresen mentve lettek.", "Mentés");

            if (RB_Yes.IsChecked == true)
            {
                MessageBox.Show("ÖN ezennel VIP felhasználó!");
            }

            #endregion
        }

        #region azonosító készítés

        private string CreateIdentifier(string firstname, string lastname)
        {
            return $"{firstname}{DateTime.Now:yyyy}";
        }

        #endregion
    }
}

