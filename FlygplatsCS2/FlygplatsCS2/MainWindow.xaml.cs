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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlygplatsCS2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Airport Simulator";
        }

        private bool plane_appears()
        {
            if ((rnd.Next(0, 11)) == 0)
                return true;
            return false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Flight> incomingFlights = new List<Flight>();
            List<Flight> outgoingFlights = new List<Flight>();
            int used = 0, unused = 0, occ = 0, laps = 0, incomingCrashedLowFuel = 0, incomingCrashedAccident = 0, outgoingCrashedAccident = 0, planesOut = 0, planesIn = 0;
            bool occupied = false;
            Flight f = new Flight();
        }
    }
}
