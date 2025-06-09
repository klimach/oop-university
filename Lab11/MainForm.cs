using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Lab11
{
    public partial class MainForm : Form
    {
        private SQLiteConnection connection;

        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            connection = new SQLiteConnection("Data Source=airline.db;Version=3;");
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Flights (
                    FlightId INTEGER PRIMARY KEY AUTOINCREMENT,
                    FlightNumber TEXT,
                    DepartureCity TEXT,
                    ArrivalCity TEXT,
                    DepartureTime DATETIME,
                    ArrivalTime DATETIME
                );

                CREATE TABLE IF NOT EXISTS Tickets (
                    TicketId INTEGER PRIMARY KEY AUTOINCREMENT,
                    FlightId INTEGER,
                    PassengerName TEXT,
                    Price REAL,
                    PurchaseDate DATETIME,
                    FOREIGN KEY (FlightId) REFERENCES Flights (FlightId)
                );";
            cmd.ExecuteNonQuery();
        }

        private void btnLoadTestData_Click(object sender, EventArgs e)
        {
            var cmd = connection.CreateCommand();

            cmd.CommandText = @"
            INSERT INTO Flights (FlightNumber, DepartureCity, ArrivalCity, DepartureTime, ArrivalTime)
            VALUES 
            ('PS101', 'Kyiv', 'Warsaw', '2025-06-10 08:00', '2025-06-10 09:30'),
            ('PS102', 'Kyiv', 'Berlin', '2025-06-11 14:15', '2025-06-11 16:00'),
            ('PS103', 'Lviv', 'Paris', '2025-06-12 06:45', '2025-06-12 09:30'),
            ('PS104', 'Odesa', 'Istanbul', '2025-06-10 12:30', '2025-06-10 14:00'),
            ('PS105', 'Kharkiv', 'Vienna', '2025-06-13 09:00', '2025-06-13 11:15');
    
            INSERT INTO Tickets (FlightId, PassengerName, Price, PurchaseDate)
            VALUES
            (1, 'Ivan Petrenko', 120.50, '2025-06-01'),
            (1, 'Olha Shevchenko', 135.00, '2025-06-02'),
            (2, 'Dmytro Bondarenko', 150.00, '2025-06-03'),
            (3, 'Anna Kovalenko', 200.00, '2025-06-04'),
            (3, 'Petro Sydorenko', 210.00, '2025-06-05'),
            (4, 'Natalia Marchenko', 90.00, '2025-06-06'),
            (4, 'Mykola Vasylenko', 95.00, '2025-06-06'),
            (5, 'Kateryna Danylko', 180.00, '2025-06-07');
            ";

            cmd.ExecuteNonQuery();
            MessageBox.Show("Тестові дані додано.");
        }

        private void btnShowTicketReport_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Flights.FlightNumber AS 'Номер польоту', COUNT(Tickets.TicketId) AS 'Кількість білетів'
                             FROM Flights LEFT JOIN Tickets ON Flights.FlightId = Tickets.FlightId
                             GROUP BY Flights.FlightNumber";

            var adapter = new SQLiteDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnShowRevenueReport_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Flights.FlightNumber AS 'Номер польоту', SUM(Tickets.Price) AS 'Загальна виручка ($)'
                             FROM Flights LEFT JOIN Tickets ON Flights.FlightId = Tickets.FlightId
                             GROUP BY Flights.FlightNumber";

            var adapter = new SQLiteDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnOpenAddFlightForm_Click(object sender, EventArgs e)
        {
            var addFlightForm = new AddFlightForm(connection);
            addFlightForm.StartPosition = FormStartPosition.CenterParent;
            addFlightForm.ShowDialog();
        }

        private void btnOpenAddTicketForm_Click(object sender, EventArgs e)
        {
            var addTicketForm = new AddTicketForm(connection);
            addTicketForm.StartPosition = FormStartPosition.CenterParent;
            addTicketForm.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerSearchDate.Value.Date;

            DateTime startOfDay = selectedDate.Date;
            DateTime endOfDay = selectedDate.Date.AddDays(1).AddTicks(-1);

            string query = @"SELECT * FROM Flights 
                     WHERE DepartureTime BETWEEN @startOfDay AND @endOfDay";

            var adapter = new SQLiteDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@startOfDay", startOfDay);
            adapter.SelectCommand.Parameters.AddWithValue("@endOfDay", endOfDay);

            var table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM Flights";
            var adapter = new SQLiteDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}