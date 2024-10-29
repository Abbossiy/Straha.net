using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrahaNet
{
    public partial class MainForm : Form
    {
        private DataBase StrahaNetDB;
        private int userId;
        public MainForm(int user_id)
        {
            InitializeComponent();
            StrahaNetDB = new DataBase();
            userId = user_id;
        }

        private void notificationsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotificationsForm toForm = new NotificationsForm(userId);
            toForm.ShowDialog();
            this.Close();
        }

        private void myAppsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationsForm toForm = new ApplicationsForm(userId);
            toForm.ShowDialog();
            this.Close();
        }
        
        private void createAppButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateApplicationForm toForm = new CreateApplicationForm(userId);
            toForm.ShowDialog();
            this.Close();
        }
    }
}
