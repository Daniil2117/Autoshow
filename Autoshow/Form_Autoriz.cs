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

namespace Autoshow
{
    public partial class Form_Autoriz : Form
    {
        public Form_Autoriz()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CustomerSelection customer = new CustomerSelection();
            customer.Show();
            Close();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            labelDated.Text = dateTime1.ToString("D");
            labelTime.Text = dateTime1.ToString("T");
        }

        private void Form_Autoriz_Load(object sender, EventArgs e)
        {
            timerDate.Enabled = true;
            timerDate.Interval = 1000;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            Close();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.connection.Open();
                string sqlExp = "Select [Email],[Password],[RoleId] from [dbo].[User] where [Email] = @email";
                SqlCommand cmd = new SqlCommand(sqlExp, Connect.connection);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if ((string)reader[1] == textBoxPassword.Text)
                    {
                        Connect.userLogin = textBoxEmail.Text;
                        switch ((string)reader[2])
                        {
                            case "E":
                                MenuEmployee em = new MenuEmployee();
                                em.Show();
                                this.Close();
                                break;
                            case "C":
                                MenuCustumer cm = new MenuCustumer();
                                cm.Show();
                                this.Close();
                                break;
                            default:
                                MessageBox.Show("Нет такой роли");
                                break;
                        }
                    }
                    else { MessageBox.Show("Неверный пароль"); }

                }
                else { MessageBox.Show("Неверный логин"); }
                reader.Close();
            }
            catch (SqlException exp) { MessageBox.Show(exp.Message); }
            Connect.connection.Close();
        }
    }
}
