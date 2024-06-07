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
using System.IO;

namespace kikeletpanzio2._0
{
    /// <summary>
    /// Interaction logic for Log_IN.xaml
    /// </summary>
    public partial class Log_IN : Window
    {
        public Log_IN()
        {
            InitializeComponent();
        }

        private void LOG_IN_Click(object sender, RoutedEventArgs e)
        {
            #region Bejelentkezési adatok ellenőrzése

            string email = EmailTextBox.Text.Trim();
            string password = PasswordBox.Password.Trim();
            string identifier = IdentifierTextBox.Text.Trim(); // Azonosító beolvasása

            // Minden mező kitöltésének ellenőrzése
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(identifier))
            {
                MessageBox.Show("Töltsd ki az összes mezőt!");
                return;
            }

            #endregion

            #region Fájl ellenőrzése és beolvasása

            // Fájl létezésének ellenőrzése
            if (!File.Exists("Panzio.txt"))
            {
                MessageBox.Show("Nincsenek regisztrált felhasználók!");
                return;
            }

            // Összes sor beolvasása a fájlból
            string[] lines = File.ReadAllLines("Panzio.txt");
            bool loginSuccess = false;

            #endregion

            #region Bejelentkezési adatok összehasonlítása

            // Végigmegyünk az összes soron
            for (int i = 0; i < lines.Length; i++)
            {
                // Fehér szóközök és üres sorok eltávolítása
                lines[i] = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                if (lines[i].StartsWith("Azonosító:"))
                {
                    string storedId = lines[i].Substring(10).Trim();
                    string storedEmail = lines[i + 5].Substring(7).Trim();
                    string storedPassword = lines[i + 6].Substring(7).Trim();

                    

                    // Ellenőrizzük, hogy a tárolt email, jelszó és azonosító egyezik-e a megadott értékekkel
                    if (storedEmail == email && storedPassword == password && storedId == identifier)
                    {
                        loginSuccess = true;
                        break;
                    }
                }
            }

            #endregion

            #region Bejelentési eredmény kezelése és üzenet megjelenítése

            // Bejelentés megjelenítése a bejelentkezés sikerességétől függően
            if (loginSuccess)
            {
                MessageBox.Show("Sikeres bejelentkezés!");
            }
            else
            {
                MessageBox.Show("Hibás email cím, jelszó vagy azonosító!");
            }

            #endregion
        }

    }
}
