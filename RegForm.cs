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
    public partial class RegForm : Form
    {
        private DataBase StrahaNetDB;
        public RegForm()
        {
            InitializeComponent();
            StrahaNetDB = new DataBase();
        }

        private bool RegisterUser(string login, string password)
        {
            StrahaNetDB.openConnection();
            SqlConnection connection = StrahaNetDB.GetConnection();

            // Проверяем, существует ли уже логин
            string checkQuery = "SELECT COUNT(*) FROM Accounts WHERE login = @login";
            SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
            checkCommand.Parameters.AddWithValue("@login", login);

            int count = (int)checkCommand.ExecuteScalar();
            if (count > 0)
            {
                StrahaNetDB.closeConnection();
                return false; // Логин уже существует
            }

            // Вставляем нового пользователя
            string insertQuery = "INSERT INTO Accounts (login, password) VALUES (@login, @password)";
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("@login", login);
            insertCommand.Parameters.AddWithValue("@password", password);

            int rowsAffected = insertCommand.ExecuteNonQuery();
            StrahaNetDB.closeConnection();

            return rowsAffected > 0; // Успешная вставка
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;
            string passwordRepeat = repeatPassBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (password != passwordRepeat)
            {
                MessageBox.Show("Неверный повтор пароля");
                return;
            }

            if (RegisterUser(login, password))
            {
                MessageBox.Show("Регистрация успешна.");
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации. Возможно, логин уже существует.");
            }
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 toForm = new Form1();
            toForm.ShowDialog();
            this.Close();
        }
    }
}
