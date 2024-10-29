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
    public partial class NotificationsForm : Form
    {
        private int user_id;
        public NotificationsForm(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
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
