using RGR.Models;
using System.Data.SQLite;

namespace RGR.Controllers
{
    public class DBController
    {
        private readonly string _connectionString;

        public DBController(string dbPath)
        {
            _connectionString = $"Data Source={dbPath};Version=3;";
            EnsureDatabase();
        }

        private void EnsureDatabase()
        {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();

            string tableCommand = @"
            CREATE TABLE IF NOT EXISTS People (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                FirstName TEXT NOT NULL,
                SecondName TEXT NOT NULL,
                MiddleName TEXT,
                Gender TEXT NOT NULL,
                BirthDate TEXT NOT NULL,
                Address TEXT NOT NULL,
                Phone TEXT NOT NULL,
                Email TEXT NOT NULL,
                PassportNumber TEXT,
                PassportIssueDate TEXT,
                PassportIssuedBy TEXT,
                JobTitle TEXT,
                Organization TEXT
            );";

            using (SQLiteCommand cmd = new(tableCommand, connection))
            {
                cmd.ExecuteNonQuery();
            }

            string countCommand = "SELECT COUNT(*) FROM People;";
            using (SQLiteCommand cmd = new(countCommand, connection))
            {
                long count = (long)cmd.ExecuteScalar();
                if (count == 0)
                {
                    AddTestData();
                }
            }
        }

        public void AddPerson(Person person)
        {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();

            string insertCommand = @"
            INSERT INTO People 
                (FirstName, SecondName, MiddleName, Gender, BirthDate, Address, Phone, Email, PassportNumber, PassportIssueDate, PassportIssuedBy, JobTitle, Organization)
            VALUES 
                (@FirstName, @SecondName, @MiddleName, @Gender, @BirthDate, @Address, @Phone, @Email, @PassportNumber, @PassportIssueDate, @PassportIssuedBy, @JobTitle, @Organization);
            ";

            using SQLiteCommand cmd = new(insertCommand, connection);
            cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
            cmd.Parameters.AddWithValue("@SecondName", person.SecondName);
            cmd.Parameters.AddWithValue("@MiddleName", person.MiddleName ?? "");
            cmd.Parameters.AddWithValue("@Gender", person.Gender);
            cmd.Parameters.AddWithValue("@BirthDate", person.BirthDate);
            cmd.Parameters.AddWithValue("@Address", person.Address);
            cmd.Parameters.AddWithValue("@Phone", person.Phone);
            cmd.Parameters.AddWithValue("@Email", person.Email);
            cmd.Parameters.AddWithValue("@PassportNumber", person.PassportNumber ?? "");
            cmd.Parameters.AddWithValue("@PassportIssueDate", person.PassportIssueDate ?? "");
            cmd.Parameters.AddWithValue("@PassportIssuedBy", person.PassportIssuedBy ?? "");
            cmd.Parameters.AddWithValue("@JobTitle", person.JobTitle ?? "");
            cmd.Parameters.AddWithValue("@Organization", person.Organization ?? "");

            cmd.ExecuteNonQuery();
        }

        public void UpdatePerson(Person person)
        {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();

            string updateCommand = @"
                UPDATE People
                SET 
                    FirstName = @FirstName,
                    SecondName = @SecondName,
                    MiddleName = @MiddleName,
                    Gender = @Gender,
                    BirthDate = @BirthDate,
                    Address = @Address,
                    Phone = @Phone,
                    Email = @Email,
                    PassportNumber = @PassportNumber,
                    PassportIssueDate = @PassportIssueDate,
                    PassportIssuedBy = @PassportIssuedBy,
                    JobTitle = @JobTitle,
                    Organization = @Organization
                WHERE Id = @Id;";

            using SQLiteCommand cmd = new(updateCommand, connection);
            cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
            cmd.Parameters.AddWithValue("@SecondName", person.SecondName);
            cmd.Parameters.AddWithValue("@MiddleName", (object?)person.MiddleName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Gender", person.Gender);
            cmd.Parameters.AddWithValue("@BirthDate", person.BirthDate);
            cmd.Parameters.AddWithValue("@Address", person.Address);
            cmd.Parameters.AddWithValue("@Phone", person.Phone);
            cmd.Parameters.AddWithValue("@Email", person.Email);
            cmd.Parameters.AddWithValue("@PassportNumber", (object?)person.PassportNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@PassportIssueDate", (object?)person.PassportIssueDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@PassportIssuedBy", (object?)person.PassportIssuedBy ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@JobTitle", (object?)person.JobTitle ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Organization", (object?)person.Organization ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Id", person.Id);

            cmd.ExecuteNonQuery();
        }

        public void DeletePerson(int personId)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();

            string deleteCommand = "DELETE FROM People WHERE Id = @Id;";

            using var cmd = new SQLiteCommand(deleteCommand, connection);
            cmd.Parameters.AddWithValue("@Id", personId);
            cmd.ExecuteNonQuery();
        }

        public List<Person> GetAllPeople()
        {
            List<Person> people = [];

            using (SQLiteConnection connection = new(_connectionString))
            {
                connection.Open();

                string selectCommand = "SELECT * FROM People;";
                using SQLiteCommand cmd = new(selectCommand, connection);
                using SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Person person = new()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = reader["FirstName"].ToString()!,
                        SecondName = reader["SecondName"].ToString()!,
                        MiddleName = reader["MiddleName"] == DBNull.Value ? null : reader["MiddleName"].ToString(),
                        Gender = reader["Gender"].ToString()!,
                        BirthDate = reader["BirthDate"].ToString()!,
                        Address = reader["Address"].ToString()!,
                        Phone = reader["Phone"].ToString()!,
                        Email = reader["Email"].ToString()!,
                        PassportNumber = reader["PassportNumber"] == DBNull.Value ? null : reader["PassportNumber"].ToString(),
                        PassportIssueDate = reader["PassportIssueDate"] == DBNull.Value ? null : reader["PassportIssueDate"].ToString(),
                        PassportIssuedBy = reader["PassportIssuedBy"] == DBNull.Value ? null : reader["PassportIssuedBy"].ToString(),
                        JobTitle = reader["JobTitle"] == DBNull.Value ? null : reader["JobTitle"].ToString(),
                        Organization = reader["Organization"] == DBNull.Value ? null : reader["Organization"].ToString()
                    };

                    people.Add(person);
                }
            }

            return people;
        }

        public void AddTestData()
        {
            List<Person> testPeople =
            [
                new() {
                    FirstName = "Іван",
                    SecondName = "Іванов",
                    MiddleName = "Іванович",
                    Gender = "Він",
                    BirthDate = "1990-05-15",
                    Address = "м. Київ, вул. Хрещатик, 1",
                    Phone = "+380991234567",
                    Email = "ivan.ivanov@example.com",
                    PassportNumber = "АА123456",
                    PassportIssueDate = "2010-06-01",
                    PassportIssuedBy = "ДМС м. Києва",
                    JobTitle = "Інженер-програміст",
                    Organization = "ТОВ 'ІТ-Сервіс'"
                },
                new() {
                    FirstName = "Петро",
                    SecondName = "Петров",
                    MiddleName = null,
                    Gender = "Він",
                    BirthDate = "1985-10-20",
                    Address = "м. Львів, вул. Грушевського, 10",
                    Phone = "+380987654321",
                    Email = "petro.petrov@example.com",
                    PassportNumber = "ВА654321",
                    PassportIssueDate = "2012-09-12",
                    PassportIssuedBy = "ДМС м. Львова",
                    JobTitle = "Менеджер",
                    Organization = "ПП 'Галичина'"
                },
                new() {
                    FirstName = "Оксана",
                    SecondName = "Шевченко",
                    MiddleName = "Василівна",
                    Gender = "Вона",
                    BirthDate = "1995-03-08",
                    Address = "м. Харків, вул. Сумська, 5",
                    Phone = "+380991234000",
                    Email = "oksana.shevchenko@example.com",
                    PassportNumber = "ВС987654",
                    PassportIssueDate = "2015-07-25",
                    PassportIssuedBy = "ДМС м. Харкова",
                    JobTitle = "Бухгалтер",
                    Organization = "ТОВ 'Фінексперт'"
                },
                new() {
                    FirstName = "Марія",
                    SecondName = "Ковальчук",
                    MiddleName = "Петрівна",
                    Gender = "Вона",
                    BirthDate = "1992-12-15",
                    Address = "м. Одеса, вул. Дерибасівська, 20",
                    Phone = "+380931112233",
                    Email = "maria.kovalchuk@example.com",
                    PassportNumber = "АН112233",
                    PassportIssueDate = "2013-11-05",
                    PassportIssuedBy = "ДМС м. Одеси",
                    JobTitle = "Юрист",
                    Organization = "ЮК 'Право і Закон'"
                },
                new() {
                    FirstName = "Олександр",
                    SecondName = "Климов",
                    MiddleName = "Борисович",
                    Gender = "Він",
                    BirthDate = "1980-04-01",
                    Address = "м. Дніпро, проспект Дмитра Яворницького, 100",
                    Phone = "+380672223344",
                    Email = "oleksandr.klymov@example.com",
                    PassportNumber = "КК334455",
                    PassportIssueDate = "2008-02-14",
                    PassportIssuedBy = "ДМС м. Дніпра",
                    JobTitle = "Директор",
                    Organization = "ТОВ 'Будпроект'"
                }
            ];

            foreach (var person in testPeople) AddPerson(person);
        }
    }
}
