using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace RentACar_otomasyonu
{
    public partial class Form_Salesperson : Form
    {
        private string connectionString;

        public Form_Salesperson()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Rent_A_CarConnectionString"].ConnectionString;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_surname.Text))
            {
                MessageBox.Show("Lütfen Personel Adı ve Soyadını eksiksiz giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (string.IsNullOrEmpty(masked_tel_no.Text) )
            {
                MessageBox.Show("Lütfen Personel Telefon Numarası eksiksiz giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if(string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Lütfen Personel Emailini eksiksiz giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string s_name = txt_name.Text.ToString();
            string s_surname = txt_surname.Text.ToString();
            string s_tel = masked_tel_no.Text.ToString();
            s_tel = s_tel.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            s_tel = "0" + s_tel;
            string s_email = txt_email.Text.ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Sales_Person_Insert_Into",connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@salesperson_name", s_name);
                        cmd.Parameters.AddWithValue("@salesperson_surname", s_surname);
                        cmd.Parameters.AddWithValue("@salesperson_phone_no", s_tel);
                        cmd.Parameters.AddWithValue("@salesperson_email", s_email);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı");



                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Sales_Person_Select", connection))
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int s_id = int.Parse(selectedRow.Cells[0].Value.ToString());
                string s_name = selectedRow.Cells[1].Value.ToString();
                string s_surname = selectedRow.Cells[2].Value.ToString();
                string s_tel = selectedRow.Cells[3].Value.ToString();
                string s_email = selectedRow.Cells[4].Value.ToString();
                if (s_tel.StartsWith("0"))
                {
                    s_tel = s_tel.Remove(0, 1);
                    s_tel = s_tel.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");


                }
                try
                {
                    txt_name.Text = s_name;
                    txt_surname.Text = s_surname;
                    masked_tel_no.Text = s_tel;
                    txt_email.Text = s_email;

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
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_surname.Text))
            {
                MessageBox.Show("Personel Adı veya Soyadı boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrEmpty(masked_tel_no.Text) || string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Personel Telefon Numarası veya Emaili boş bırakılamaz");
                return;
            }
            int selected_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            string s_name = txt_name.Text;
            string s_surname = txt_surname.Text;
            string s_tel = masked_tel_no.Text;
            string s_email = txt_email.Text;
            if (s_tel.StartsWith("0"))
            {
                s_tel = s_tel.Remove(0, 1);
                s_tel = s_tel.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Sales_Person_Update",connection))
                    {
                        cmd .CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@salesperson_id", selected_ID);
                        cmd.Parameters.AddWithValue("@salesperson_name", s_name);
                        cmd.Parameters.AddWithValue("@salesperson_surname", s_surname);
                        cmd.Parameters.AddWithValue("@salesperson_phone_no", s_tel);
                        cmd.Parameters.AddWithValue("@salesperson_email", s_email);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarıyla Güncellendi");
                        txt_name.Clear();
                        txt_surname.Clear();
                        masked_tel_no.Clear();
                        txt_email.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi esnasında hata oluştu: " + ex.Message);

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?");
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        using (SqlCommand cmd = new SqlCommand("sp_Table_Sales_Person_Delete", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@salesperson_id", selectedRowID);

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
    }
}
