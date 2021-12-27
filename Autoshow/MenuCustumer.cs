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
    public partial class MenuCustumer : Form
    {
        public MenuCustumer()
        {
            InitializeComponent();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            labelDated.Text = dateTime1.ToString("D");
            labelTime.Text = dateTime1.ToString("T");
        }

        private void MenuCustumer_Load(object sender, EventArgs e)
        {
            timerDate.Enabled = true;
            timerDate.Interval = 1000;
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
