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
    public partial class ViewCar : Form
    {
        public ViewCar()
        {
            InitializeComponent();
        }

        private void textBoxCar_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCar.Rows.Clear();
            try
            {
                Connect.connection.Open();
                string sqlExp = "SELECT [key_model],[modelcar],[speed_km/h],[fuel_consumption_л/100km],[transmission],[engines_type],[year_of_issue],[CountryName]" +
                    " FROM [dbo].[Carmodels],[dbo].[Country]" +
                    " WHERE [dbo].[Carmodels].[CountryCode] = [dbo].[Country].[CountryCode]" +
                    $" AND [modelcar] LIKE '{textBoxCar.Text}%'";

                SqlCommand cmd = new SqlCommand(sqlExp, Connect.connection);


                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        dataGridViewCar.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString());
                    }
                }

                Connect.connection.Close();
            }
            catch (SqlException Exp)
            {
                MessageBox.Show(Exp.Message);
            }
        }

        private void textBoxCountry_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCar.Rows.Clear();
            try
            {
                Connect.connection.Open();
                string sqlExp = "SELECT [key_model],[modelcar],[speed_km/h],[fuel_consumption_л/100km],[transmission],[engines_type],[year_of_issue],[CountryName]" +
                    " FROM [dbo].[Carmodels],[dbo].[Country]" +
                    " WHERE [dbo].[Carmodels].[CountryCode] = [dbo].[Country].[CountryCode]" +
                    $" AND [CountryName] LIKE '{textBoxCountry.Text}%'";

                SqlCommand cmd = new SqlCommand(sqlExp, Connect.connection);


                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        dataGridViewCar.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString());
                    }
                }

                Connect.connection.Close();
            }
            catch (SqlException Exp)
            {
                MessageBox.Show(Exp.Message);
            }
        }

        public void VivodDannix()
        {
            try
            {
                Connect.connection.Open();
                string sqlExp = "SELECT [key_model],[modelcar],[speed_km/h],[fuel_consumption_л/100km],[transmission],[engines_type],[year_of_issue],[CountryName]" +
                    " FROM [dbo].[Carmodels],[dbo].[Country]" +
                    " WHERE [dbo].[Carmodels].[CountryCode] = [dbo].[Country].[CountryCode]";

                SqlCommand cmd = new SqlCommand(sqlExp, Connect.connection);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        dataGridViewCar.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString());
                    }
                }
                else
                    MessageBox.Show("Нет данных");
                rd.Close();

                Connect.connection.Close();
            }
            catch (SqlException Exp)
            {
                MessageBox.Show(Exp.Message);
            }
        }
        public void VivodPicture()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.ConnectionStr))
                {
                    connect.Open();
                    string sqlExp = "Select [photocar] from [dbo].[Carmodels]" +
                                    $"where {dataGridViewCar.Rows[dataGridViewCar.CurrentRow.Index].Cells[0].Value} = [key_model]";
                    SqlCommand command = new SqlCommand(sqlExp, connect);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    pictureCar.Image = (Bitmap)Image.FromFile($@"../../image/{reader[0]}");
                    reader.Close();
                }
            }
            catch (SqlException Exp)
            {
                MessageBox.Show(Exp.Message);
            }
        }
        
        private void ViewCar_Load(object sender, EventArgs e)
        {
            VivodDannix();
            VivodPicture();
        }

        private void dataGridViewCar_SelectionChanged(object sender, EventArgs e)
        {
            VivodPicture();
            labelNameCar.Text = (string)dataGridViewCar.Rows[dataGridViewCar.CurrentRow.Index].Cells[1].Value;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            Close();
        }
    }
}
