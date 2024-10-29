using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrahaNet
{
    public partial class CreateApplicationForm : Form
    {
        private DataBase StrahaNetDB;
        private int userId;
        public CreateApplicationForm(int user_id)
        {
            InitializeComponent();
            StrahaNetDB = new DataBase();
            userId = user_id;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Собираем данные из полей формы
            string countryStart = countryStartBox.Text;
            string countryEnd = countryEndBox.Text;
            DateTime departureDate = dateStart.Value.Date;
            TimeSpan departureTime = dateStart.Value.TimeOfDay;
            DateTime arrivalDate = dateReturn.Value.Date;
            TimeSpan arrivalTime = dateReturn.Value.TimeOfDay;

            int departureAirportId = GetAirportIdByCountry(countryStart); // Замените на реальный ID аэропорта

            if (departureAirportId == -1)
            {
                MessageBox.Show("Ошибка при получении airport_id: Нет аэропорта для страны " + countryStart);
            }

            int arrivalAirportId = GetAirportIdByCountry(countryEnd); // Замените на реальный ID аэропорта

            if (departureAirportId == -1)
            {
                MessageBox.Show("Ошибка при получении airport_id: Нет аэропорта для страны " + countryEnd);
            }

            // Вызываем метод для сохранения данных в базу
            SaveFlightToDatabase(departureDate, departureTime,
                arrivalDate, arrivalTime, departureAirportId, arrivalAirportId);
        }

        private int GetAirportIdByCountry(string countryName)
        {
            int airportId = -1; // Значение по умолчанию, если аэропорт не найден

            StrahaNetDB.openConnection();
            SqlConnection connection = StrahaNetDB.GetConnection();

            string query = @"
                        SELECT TOP 1 airport_id
                        FROM Airports
                        WHERE country = @countryName";

            SqlCommand checkCommand = new SqlCommand(query, connection);
            checkCommand.Parameters.AddWithValue("@countryName", countryName);

            object result = checkCommand.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                airportId = Convert.ToInt32(result);
            }

            return airportId;
        }

        private bool SaveFlightToDatabase(DateTime departureDate, TimeSpan departureTime,
            DateTime arrivalDate, TimeSpan arrivalTime, int departureAirportId, int arrivalAirportId)
        {
            StrahaNetDB.openConnection();
            SqlConnection connection = StrahaNetDB.GetConnection();

            string insertQuery = @"
                        INSERT INTO Flights (flight_number, departure_date, departure_time, arrival_date, arrival_time, departure_airport_id, arrival_airport_id)
                        VALUES (@flightNumber, @departureDate, @departureTime, @arrivalDate, @arrivalTime, @departureAirportId, @arrivalAirportId)";
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

            insertCommand.Parameters.AddWithValue("@flightNumber", userId);
            insertCommand.Parameters.AddWithValue("@departureDate", departureDate);
            insertCommand.Parameters.AddWithValue("@departureTime", departureTime);
            insertCommand.Parameters.AddWithValue("@arrivalDate", arrivalDate);
            insertCommand.Parameters.AddWithValue("@arrivalTime", arrivalTime);
            insertCommand.Parameters.AddWithValue("@departureAirportId", departureAirportId);
            insertCommand.Parameters.AddWithValue("@arrivalAirportId", arrivalAirportId);

            int rowsAffected = insertCommand.ExecuteNonQuery();

            StrahaNetDB.closeConnection();

            return rowsAffected > 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm toForm = new MainForm(userId);
            toForm.ShowDialog();
            this.Close();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
