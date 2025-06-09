using System.Data.SQLite;

namespace Lab11
{
    public partial class AddFlightForm : Form
    {
        private SQLiteConnection connection;

        public AddFlightForm(SQLiteConnection dbConnection)
        {
            InitializeComponent();
            connection = dbConnection;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Flights 
                (FlightNumber, DepartureCity, ArrivalCity, DepartureTime, ArrivalTime) 
                VALUES (@flightNumber, @departureCity, @arrivalCity, @depTime, @arrTime)";

            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@flightNumber", txtFlightNumber.Text);
            cmd.Parameters.AddWithValue("@departureCity", txtDepartureCity.Text);
            cmd.Parameters.AddWithValue("@arrivalCity", txtArrivalCity.Text);
            cmd.Parameters.AddWithValue("@depTime", dateTimePickerDep.Value);
            cmd.Parameters.AddWithValue("@arrTime", dateTimePickerArr.Value);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Політ додано.");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
