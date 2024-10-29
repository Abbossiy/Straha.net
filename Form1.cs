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
    public partial class Form1 : Form
    {
        public DataBase StrahaNetDB;
        public int user_id;
        public Form1()
        {
            InitializeComponent();
            StrahaNetDB = new DataBase();
        }

        public bool tryEnter(string login, string password)
        {
            if (login == null || password == null)
            {
                return false;
            }
            StrahaNetDB.openConnection();
            SqlConnection connection = StrahaNetDB.GetConnection();

            string query = "SELECT user_id FROM Accounts WHERE login = @login AND password = @password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            object result = command.ExecuteScalar();
            StrahaNetDB.closeConnection();

            if (result != null)
            {
                user_id = Convert.ToInt32(result);
                return true;
            }
            else
            {
                return false;
            }

        }

        public void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            if (tryEnter(login, password))
            {
                this.Hide();
                MainForm mainForm = new MainForm(user_id);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }

        public void regLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm mainForm = new RegForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
