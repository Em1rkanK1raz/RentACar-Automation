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
    public partial class Form_Customers : Form
    {
        private string connectionString;
        public Form_Customers()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Rent_A_CarConnectionString"].ConnectionString;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string c_name = txt_name.Text.ToString();
            string c_surname = txt_surname.Text.ToString();

            string c_tc_no = masked_tc.Text.ToString();
            string c_tel = masked_tel.Text.ToString();
            c_tel = c_tel.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            c_tel = "0" + c_tel;


            string c_mail = txt_mail.Text.ToString();

            string c_license_number = txt_ehliyet_no.Text.ToString();

            int c_age = int.Parse(txt_age.Text.ToString());

           

            DateTime c_license_issue_date = date_verilis.Value.Date;

            DateTime c_license_expiry_date = date_duzenlenme.Value.Date;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Customers_Insert_Into", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@customer_name", c_name);
                        cmd.Parameters.AddWithValue("@customer_surname", c_surname);
                        cmd.Parameters.AddWithValue("@customer_TC_no", c_tc_no);
                        cmd.Parameters.AddWithValue("@customer_phone_no", c_tel);
                        cmd.Parameters.AddWithValue("@customer_email", c_mail);
                        cmd.Parameters.AddWithValue("@customer_license_number", c_license_number);
                        cmd.Parameters.AddWithValue("@customer_age", int.Parse(txt_age.Text.ToString()));
                        cmd.Parameters.AddWithValue("@license_issue_date", c_license_issue_date);
                        cmd.Parameters.AddWithValue("@license_expiry_date", c_license_expiry_date);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message); 
            }
          
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                   using (SqlCommand cmd = new SqlCommand("sp_Table_Customers_Select", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable dt = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        connection.Open();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btn_starting_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int c_id = int.Parse(selectedRow.Cells[0].Value.ToString());
                string c_name = selectedRow.Cells[1].Value.ToString();
                string c_surname = selectedRow.Cells[2].Value.ToString();
                string c_tc_no = selectedRow.Cells[3].Value.ToString();
                string c_tel = selectedRow.Cells[4].Value.ToString();
                string c_mail = selectedRow.Cells[5].Value.ToString();  
                string c_license_number = selectedRow.Cells[6].Value.ToString();    
                string c_age = selectedRow.Cells[7].Value.ToString();   
                DateTime c_license_issue_date = Convert.ToDateTime(selectedRow.Cells[8].Value);
                DateTime c_license_expiry_date = Convert.ToDateTime(selectedRow.Cells[8].Value);

                if (c_tel.StartsWith ("0"))
                {
                
                    c_tel= c_tel.Remove(0, 1);
                    c_tel = c_tel.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

                }
                try
                {
                    txt_name.Text = c_name;
                    txt_surname.Text = c_surname;
                    masked_tc.Text = c_tc_no;
                    masked_tel.Text = c_tel;
                    txt_mail.Text = c_mail;
                    txt_ehliyet_no.Text = c_license_number;
                    txt_age.Text = c_age;
                    date_verilis.Value = (c_license_issue_date);
                    date_duzenlenme.Value = (c_license_expiry_date);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Aktarma işlemi sırasında hata oluştu: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İçin Bir Kayıt Seçiniz");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selected_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            string c_name = txt_name.Text;
            string c_surname = txt_surname.Text;

            string c_tc_no = masked_tc.Text;
            string c_tel = masked_tel.Text;
            string c_mail = txt_mail.Text;
            string c_license_number = txt_ehliyet_no.Text;
            int c_age = int.Parse(txt_age.Text);


            DateTime c_license_issue_date = date_verilis.Value.Date;

            DateTime c_license_expiry_date = date_duzenlenme.Value.Date;
            if (c_tel.StartsWith("0"))
            {

                c_tel = c_tel.Remove(0, 1);
                c_tel = c_tel.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            }

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Customers_Update",connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@customer_id", selected_ID );
                        cmd.Parameters.AddWithValue("@customer_name", c_name);
                        cmd.Parameters.AddWithValue("@customer_surname", c_surname);
                        cmd.Parameters.AddWithValue("@customer_TC_no", c_tc_no);
                        cmd.Parameters.AddWithValue("@customer_phone_no", c_tel);
                        cmd.Parameters.AddWithValue("@customer_email", c_mail);
                        cmd.Parameters.AddWithValue("@customer_license_number", c_license_number );
                        cmd.Parameters.AddWithValue("@customer_age", int.Parse(txt_age.Text.ToString()));
                        cmd.Parameters.AddWithValue("@license_issue_date", c_license_issue_date);
                        cmd.Parameters.AddWithValue("@license_expiry_date", c_license_expiry_date);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarıyla Güncellendi");
                        txt_age.Clear();
                        txt_name.Clear();
                        txt_surname.Clear();
                        txt_mail.Clear();
                        txt_ehliyet_no.Clear();
                        masked_tc.Clear();
                        masked_tel.Clear();
                        date_verilis.Value = DateTime.Now;
                        date_duzenlenme.Value = DateTime.Now;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi esnasında hata oluştu: " + ex.Message);
               
            }
        }


        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                  MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?");
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        using (SqlCommand cmd = new SqlCommand("sp_Table_Customers_Delete", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@customer_id", selectedRowID);

                            connection.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kayıt başarıyla silindi.");

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi esnasında bir sorun oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir kayıt seçiniz");
            }
        }

        private void radio_the_most_car_renting_customer_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_the_most_car_renting_customer", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    connection.Open();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

        }   
    }
} 
