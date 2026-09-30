using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

namespace RentACar_otomasyonu
{
   
    public partial class Form1 : Form
    {
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Rent_A_CarConnectionString"].ConnectionString;
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("1 saniye sonra yönlendirileceksiniz", "Bağlantı AÇIK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Thread.Sleep(1000);
                Form_Customers Form_Musteriler = new Form_Customers();
                    this.Hide();
                    Form_Musteriler.ShowDialog();
                    this.Close();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Hata =" + ex);
            }
        }

        private void btn_connection_rentals_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("1 saniye sonra yönlendirileceksiniz", "Bağlantı AÇIK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Thread.Sleep(1000);
                Form_Rentals Form_Kiralama = new Form_Rentals();
                this.Hide();
                Form_Kiralama.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata =" + ex);
            }
        }

        private void btn_connection_cars_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("1 saniye sonra yönlendirileceksiniz", "Bağlantı AÇIK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Thread.Sleep(1000);
                Form_Cars Form_Arabalar = new Form_Cars();
                this.Hide();
                Form_Arabalar.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata =" + ex);
            }

        }

        private void btn_connection_salesperson_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("1 saniye sonra yönlendirileceksiniz", "Bağlantı AÇIK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Thread.Sleep(1000);
                Form_Salesperson Form_Saticilar = new Form_Salesperson();
                this.Hide();
                Form_Saticilar.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata =" + ex);
            }
        }
    }
}
