using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoshow
{
    public partial class MenuEmployee : Form
    {
        public MenuEmployee()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            labelDated.Text = dateTime1.ToString("D");
            labelTime.Text = dateTime1.ToString("T");
        }

        private void MenuEmployee_Load(object sender, EventArgs e)
        {
            timerDate.Enabled = true;
            timerDate.Interval = 1000;
        }
    }
}
