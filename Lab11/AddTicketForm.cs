using System.Data;
using System.Data.SQLite;

namespace Lab11
{
    public partial class AddTicketForm : Form
    {
        private SQLiteConnection connection;

        public AddTicketForm(SQLiteConnection dbConnection)
        {
            InitializeComponent();
            connection = dbConnection;
            LoadFlights();
        }

        private void LoadFlights()
        {
            string query = "SELECT FlightId, FlightNumber FROM Flights";

            using var cmd = new SQLiteCommand(query, connection);
            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable flightsTable = new();
            adapter.Fill(flightsTable);

            comboFlights.DataSource = flightsTable;
            comboFlights.DisplayMember = "FlightNumber";
            comboFlights.ValueMember = "FlightId";
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            try
            {
                int flightId = Convert.ToInt32(comboFlights.SelectedValue);
                string passengerName = txtPassengerName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                DateTime purchaseDate = dateTimePickerPurchase.Value;

                string query = @"INSERT INTO Tickets 
                    (FlightId, PassengerName, Price, PurchaseDate) 
                    VALUES (@flightId, @passengerName, @price, @purchaseDate)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@flightId", flightId);
                    cmd.Parameters.AddWithValue("@passengerName", passengerName);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@purchaseDate", purchaseDate);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Білет додано");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
