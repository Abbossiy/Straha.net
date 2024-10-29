using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrahaNet
{
    public partial class ApplicationsForm : Form
    {
        private DataBase StrahaNetDB;
        private int user_id;
        public ApplicationsForm(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            StrahaNetDB = new DataBase();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFlightsData();
        }

        private void LoadFlightsData()
        {
            StrahaNetDB.openConnection();
            SqlConnection connection = StrahaNetDB.GetConnection();

            string query = @"
                SELECT departure_date, departure_time, arrival_date, arrival_time, departure_airport_id, arrival_airport_id
                FROM Flights
                WHERE flight_number = @user_id";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@user_id", user_id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int labelX = 10; // Начальная координата Y для первого Label

                    while (reader.Read())
                    {
                        // Создаем новый Label для каждой записи
                        Label flightLabel = new Label
                        {
                            AutoSize = true,
                            Location = new Point(labelX, 100),
                            Text =  $"Departure Date: {reader["departure_date"]},\n" +
                                    $"Departure Time: {reader["departure_time"]},\n" +
                                    $"Arrival Date: {reader["arrival_date"]},\n" +
                                    $"Arrival Time: {reader["arrival_time"]},\n" +
                                    $"Departure Airport ID: {reader["departure_airport_id"]},\n" +
                                    $"Arrival Airport ID: {reader["arrival_airport_id"]}"
                        };

                        // Добавляем Label на форму
                        this.Controls.Add(flightLabel);

                        // Увеличиваем координату Y для следующего Label
                        labelX += 230;
                    }
                }
            }
        }


    private void toMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm toForm = new MainForm(user_id);
            toForm.ShowDialog();
            this.Close();
        }
    }
}
