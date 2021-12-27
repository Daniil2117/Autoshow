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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            timerDate.Enabled = true;
            timerDate.Interval = 1000;

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            labelDate.Text = dateTime1.ToString("D");
            labelTime.Text = dateTime1.ToString("T");
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            CustomerSelection customer = new CustomerSelection();
            customer.Show();
            this.Hide();
        }

        private void buttonViewInfo_Click(object sender, EventArgs e)
        {
            ViewCar view = new ViewCar();
            view.Show();
            Hide();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Form_Autoriz autoriz = new Form_Autoriz();
            autoriz.Show();
            Hide();
        }
    }
}
