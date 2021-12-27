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
    public partial class CustomerSelection : Form
    {
        public CustomerSelection()
        {
            InitializeComponent();
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            labelDated.Text = dateTime1.ToString("D");
            labelTime.Text = dateTime1.ToString("T");
        }

        private void CustomerSelection_Load(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            timerDate.Enabled = true;
            timerDate.Interval = 1000;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
        }

        private void pictureBoxInformation_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            Form_Autoriz autoriz = new Form_Autoriz();
            autoriz.Show();
            this.Hide();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            RegistrCustomer registr = new RegistrCustomer();
            registr.Show();
            Hide();
        }

        private void panelColor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
