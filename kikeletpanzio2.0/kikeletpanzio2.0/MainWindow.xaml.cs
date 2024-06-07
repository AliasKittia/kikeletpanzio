using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kikeletpanzio2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuI_Booking_Click(object sender, RoutedEventArgs e)
        {
            Booking newWindow = new Booking();
            newWindow.Show();
        }

        private void MenuI_LogIn_Click(object sender, RoutedEventArgs e)
        {
            Log_IN newWindow = new Log_IN();
            newWindow.Show();
        }

        private void MenuI_SignIn_Click(object sender, RoutedEventArgs e)
        {
            Sign_in newWindow = new Sign_in();
            newWindow.Show();
        }

        private void MenuI_Statistic_Click(object sender, RoutedEventArgs e)
        {
            Statistic newWindow = new Statistic();
            newWindow.Show();

        }
    }
}