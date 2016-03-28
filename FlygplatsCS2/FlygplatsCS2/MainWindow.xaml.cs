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
using System.Windows.Threading;

namespace FlygplatsCS2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Airport Simulator";

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(timerTick);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(20);
            dispatcherTimer.Start();


        }

        Random rnd = new Random();
        List<Flight> incomingFlights = new List<Flight>();
        List<Flight> outgoingFlights = new List<Flight>();
        int incFlights = 0, outFlights = 0, occfor = 0, laps = 0;
        bool occupied = false;

        public void timerTick(object sender, EventArgs e)
        {
            lapsValLbl.Content = ++laps;
            if (rnd.Next(10) == 0)
            {
                incomingFlightsValLbl.Content = ++incFlights;
                incomingFlights.Add(new Flight());
            }
            if (rnd.Next(10) == 0)
            {
                outgoingFlightsValLbl.Content = ++outFlights;
                outgoingFlights.Add(new Flight());
            }
            
            switch(incomingFlights.Count)
            {
                case 1:
                    incFlightNr1.Content = incomingFlights[0].flightNumber;
                    incFlightFuelLvl1.Content = incomingFlights[0].fuelLevel;
                    incFlightPsgC1.Content = incomingFlights[0].numberOfPassengers;
                    break;

                case 2:
                    incFlightNr1.Content = incomingFlights[0].flightNumber;
                    incFlightFuelLvl1.Content = incomingFlights[0].fuelLevel;
                    incFlightPsgC1.Content = incomingFlights[0].numberOfPassengers;

                    incFlightNr2.Content = incomingFlights[1].flightNumber;
                    incFlightFuelLvl2.Content = incomingFlights[1].fuelLevel;
                    incFlightPsgC2.Content = incomingFlights[1].numberOfPassengers;
                    break;

                case 3:
                    incFlightNr1.Content = incomingFlights[0].flightNumber;
                    incFlightFuelLvl1.Content = incomingFlights[0].fuelLevel;
                    incFlightPsgC1.Content = incomingFlights[0].numberOfPassengers;

                    incFlightNr2.Content = incomingFlights[1].flightNumber;
                    incFlightFuelLvl2.Content = incomingFlights[1].fuelLevel;
                    incFlightPsgC2.Content = incomingFlights[1].numberOfPassengers;

                    incFlightNr3.Content = incomingFlights[2].flightNumber;
                    incFlightFuelLvl3.Content = incomingFlights[2].fuelLevel;
                    incFlightPsgC3.Content = incomingFlights[2].numberOfPassengers;
                    break;

                case 4:
                    incFlightNr1.Content = incomingFlights[0].flightNumber;
                    incFlightFuelLvl1.Content = incomingFlights[0].fuelLevel;
                    incFlightPsgC1.Content = incomingFlights[0].numberOfPassengers;

                    incFlightNr2.Content = incomingFlights[1].flightNumber;
                    incFlightFuelLvl2.Content = incomingFlights[1].fuelLevel;
                    incFlightPsgC2.Content = incomingFlights[1].numberOfPassengers;

                    incFlightNr3.Content = incomingFlights[2].flightNumber;
                    incFlightFuelLvl3.Content = incomingFlights[2].fuelLevel;
                    incFlightPsgC3.Content = incomingFlights[2].numberOfPassengers;

                    incFlightNr4.Content = incomingFlights[3].flightNumber;
                    incFlightFuelLvl4.Content = incomingFlights[3].fuelLevel;
                    incFlightPsgC4.Content = incomingFlights[3].numberOfPassengers;
                    break;

                default:
                    System.Console.Write("Hello");
                    break;

            }

            switch(outgoingFlights.Count)
            {
                case 1:
                    System.Console.Write("Hello");
                    break;
                default:
                    System.Console.Write("Hello");
                    break;
            }
 
        }

        
    }
}
