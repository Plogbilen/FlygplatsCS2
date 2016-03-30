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

        public void updateLbl1()
        {
            incFlightNr1.Content = incomingFlights[0].flightNumber;
            incFlightFuelLvl1.Content = incomingFlights[0].fuelLevel;
            incFlightPsgC1.Content = incomingFlights[0].numberOfPassengers;
        }

        public void updateLbl2()
        {
            updateLbl1();
            incFlightNr2.Content = incomingFlights[1].flightNumber;
            incFlightFuelLvl2.Content = incomingFlights[1].fuelLevel;
            incFlightPsgC2.Content = incomingFlights[1].numberOfPassengers;
        }

        public void updateLbl3()
        {
            updateLbl2();
            incFlightNr3.Content = incomingFlights[2].flightNumber;
            incFlightFuelLvl3.Content = incomingFlights[2].fuelLevel;
            incFlightPsgC3.Content = incomingFlights[2].numberOfPassengers;
        }

        public void updateLbl4()
        {
            updateLbl3();
            incFlightNr4.Content = incomingFlights[3].flightNumber;
            incFlightFuelLvl4.Content = incomingFlights[3].fuelLevel;
            incFlightPsgC4.Content = incomingFlights[3].numberOfPassengers;
        }

        public void updateLbl5()
        {
            updateLbl4();
            incFlightNr5.Content = incomingFlights[4].flightNumber;
            incFlightFuelLvl5.Content = incomingFlights[4].fuelLevel;
            incFlightPsgC5.Content = incomingFlights[4].numberOfPassengers;

        }

        public void updateLbl6()
        {
            updateLbl5();
            incFlightNr6.Content = incomingFlights[5].flightNumber;
            incFlightFuelLvl6.Content = incomingFlights[5].fuelLevel;
            incFlightPsgC6.Content = incomingFlights[5].numberOfPassengers;

        }

        public void updateLbl7()
        {
            updateLbl6();
            incFlightNr7.Content = incomingFlights[6].flightNumber;
            incFlightFuelLvl7.Content = incomingFlights[6].fuelLevel;
            incFlightPsgC7.Content = incomingFlights[6].numberOfPassengers;
        }

        public void updateLbl8()
        {
            updateLbl7();
            incFlightNr8.Content = incomingFlights[7].flightNumber;
            incFlightFuelLvl8.Content = incomingFlights[7].fuelLevel;
            incFlightPsgC8.Content = incomingFlights[7].numberOfPassengers;
        }

        public void updateLbl9()
        {
            updateLbl8();
            incFlightNr9.Content = incomingFlights[8].flightNumber;
            incFlightFuelLvl9.Content = incomingFlights[8].fuelLevel;
            incFlightPsgC9.Content = incomingFlights[8].numberOfPassengers;
        }

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
                    updateLbl1();
                    break;

                case 2:
                    updateLbl2();
                    break;

                case 3:
                    updateLbl3();
                    break;

                case 4:
                    updateLbl4();
                    break;

                case 5:
                    updateLbl5();
                    break;

                case 6:
                    updateLbl6();
                    break;

                case 7:
                    updateLbl7();
                    break;

                case 8:
                    updateLbl8();
                    break;

                case 9:
                    updateLbl9();
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
