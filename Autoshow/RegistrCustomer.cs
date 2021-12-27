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
    public partial class RegistrCustomer : Form
    {
        Profile Prof = new Profile();
        public RegistrCustomer()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CustomerSelection customer = new CustomerSelection();
            customer.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            labelDated.Text = dateTime1.ToString("D");
            labelTime.Text = dateTime1.ToString("T");
        }

        private void RegistrCustomer_Load(object sender, EventArgs e)
        {
            timerDate.Enabled = true;
            timerDate.Interval = 1000;
        }
        public void InsertUser()
        {
            try
            {
                Connect.connection.Open();
                string sqlExp = "insert [dbo].[User]([Email],[Password],[FirstName],[LastName],[RoleId]) values(@Email,@Password,@FirstName,@LastName,'C')";

                SqlCommand cmd = new SqlCommand(sqlExp, Connect.connection);

                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);

                int y = cmd.ExecuteNonQuery();

                string sqlExp1 = "insert [dbo].[Customers]([email],[city],[address],[tel],[lastname]) values(@Email,@City,@Address,@Tel,@Lastname)";

                SqlCommand cmd2 = new SqlCommand(sqlExp1, Connect.connection);
                cmd2.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd2.Parameters.AddWithValue("@City", textBoxCity.Text);
                cmd2.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                cmd2.Parameters.AddWithValue("@Tel", textBoxtTel.Text);
                cmd2.Parameters.AddWithValue("@Lastname", textBoxLastName.Text);

                int y1 = cmd2.ExecuteNonQuery();

                if (y == 1 && y1 == 1)
                {
                    MessageBox.Show("Вы успешно зарегистрированы в системе!");
                    Connect.userLogin = textBoxEmail.Text;
                    MenuCustumer cm = new MenuCustumer();
                    cm.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Ошибка при добавлении в таблицу User");
            }
            catch (SqlException Exp)
            {
                if (Exp.Number == 2627)
                    MessageBox.Show("Такой пользователь уже существует");
                else
                    MessageBox.Show(Exp.Message);
            }
            Connect.connection.Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != "" && textBoxPassword.Text != "" && textBoxPasswordCheck.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxCity.Text != "" && textBoxAddress.Text != "" && textBoxtTel.Text != "")
            {
                if (Prof.CheckPsw(textBoxPassword.Text))
                {
                    if (Prof.Psw_pod(textBoxPassword.Text, textBoxPasswordCheck.Text))
                    {
                            InsertUser();
                    }
                    else
                        MessageBox.Show("Пароли не совпадают");
                }
                else
                    MessageBox.Show(@"Пароль должен отвечать следующим требованиям:
                Минимум 6 символов
                Минимум 1 прописная буква
                Минимум 1 цифра
                Один из следующих символов: ! @ # $ % ^");
            }
            else
                MessageBox.Show("Заполните все поля");
        }
    }
}
