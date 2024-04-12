using System.Collections.ObjectModel;

namespace mini6
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Flight> ReascentFlights { get; set; }
        public MainPage()
        {
            InitializeComponent();

            ReascentFlights = new ObservableCollection<Flight>();

            // Add Flights
            ReascentFlights.Add(new Flight { ID = 1, Location = "New York", CheckIn = DateTime.Now.AddDays(-5), CheckOut = DateTime.Now.AddDays(-3) });
            ReascentFlights.Add(new Flight { ID = 2, Location = "Bratislava", CheckIn = DateTime.Now.AddDays(-2), CheckOut = DateTime.Now.AddDays(-1) });
            ReascentFlights.Add(new Flight { ID = 3, Location = "Praha", CheckIn = DateTime.Now.AddDays(-7), CheckOut = DateTime.Now.AddDays(-4) });
            ReascentFlights.Add(new Flight { ID = 4, Location = "Kosice", CheckIn = DateTime.Now.AddDays(-10), CheckOut = DateTime.Now.AddDays(-3) });
            ReascentFlights.Add(new Flight { ID = 5, Location = "Budapest", CheckIn = DateTime.Now.AddDays(-4), CheckOut = DateTime.Now});

            listView.ItemsSource = ReascentFlights;
        }

        public class Flight
        {
            public int ID { get; set; }
            public string Location { get; set; }
            public DateTime CheckIn { get; set; }
            public DateTime CheckOut { get; set; }

        }

        private void refresh_Refreshing(object sender, EventArgs e)
        {
            ReascentFlights.Clear(); // Clear the existing list

            // Add new flights or re-fetch the data from your data source
            ReascentFlights.Add(new Flight { ID = 1, Location = "London", CheckIn = DateTime.Now.AddDays(-3), CheckOut = DateTime.Now.AddDays(-2) });
            ReascentFlights.Add(new Flight { ID = 2, Location = "Paris", CheckIn = DateTime.Now.AddDays(-2), CheckOut = DateTime.Now.AddDays(-1) });

            // After your refresh logic is complete, set IsRefreshing to false
            refresh.IsRefreshing = false;
        }
    }
}
