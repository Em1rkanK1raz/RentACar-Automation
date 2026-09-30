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
using RentACar_otomasyonu.Rent_A_CarDataSetTableAdapters;


namespace RentACar_otomasyonu
{
    public partial class Form_Rentals : Form
    {
        private string connectionString;


        public Form_Rentals()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Rent_A_CarConnectionString"].ConnectionString;

        }
        private void ComboLoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query1 = "SELECT Customer_id, Customer_name + ' ' + Customer_surname as customer_name FROM Table_Customers";
                    SqlDataAdapter da1 = new SqlDataAdapter(query1, connection);
                    DataTable dt1 = new DataTable();
                    da1 .Fill(dt1);  
                    combo_customer_id.DataSource = dt1;
                    combo_customer_id.DisplayMember = "customer_name";
                    combo_customer_id.ValueMember = "Customer_id";
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query2 = "exec sp_Table_Cars_Select";
                    SqlDataAdapter da2 = new SqlDataAdapter(query2, connection);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dt2.Columns.Add("TamAd", typeof(string), "MARKA + ' - ' + MODEL + ' (' + PLAKA + ')'");
                    combo_car_id.DataSource = dt2;
                    combo_car_id.DisplayMember = "TamAd";
                    combo_car_id.ValueMember = "Car_id";    
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query3 = "SELECT Salesperson_id, Salesperson_name + ' ' + Salesperson_surname as salesperson_name FROM Table_Sales_person";
                    SqlDataAdapter da3 = new SqlDataAdapter(query3, connection);
                    DataTable dt3 = new DataTable();
                    da3.Fill(dt3);
                    combo_salesperson_id.DataSource = dt3;
                    combo_salesperson_id.DisplayMember = "Salesperson_name";
                    combo_salesperson_id.ValueMember = "Salesperson_id";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            int r_car_id = Convert.ToInt32(combo_car_id.SelectedValue);
            if (ChecktheCar(r_car_id) == true)
            {
                MessageBox.Show("HATA: Bu araç şu an zaten kirada! Teslim edilmeden tekrar kiralanamaz.", "Araç Müsait Değil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int r_customer_id = Convert.ToInt32(combo_customer_id.SelectedValue);

            int r_salesperson_id = Convert.ToInt32(combo_salesperson_id.SelectedValue);


            DateTime r_rent_date = date_rent_date.Value;



            try
            {
                int r_start_km = int.Parse(txt_start_kilometer.Text);

                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Rentals_Insert_Into", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@customer_id", r_customer_id);
                        cmd.Parameters.AddWithValue("@car_id", r_car_id);
                        cmd.Parameters.AddWithValue("@salesperson_id", r_salesperson_id);
                        cmd.Parameters.AddWithValue("@rent_date", r_rent_date);
                        cmd.Parameters.AddWithValue("@start_kilometer", r_start_km);

                       
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kiralama Kaydı Başarılı!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

      
        bool ChecktheCar(int carID)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Table_Cars WHERE Car_id = @car_id AND Status in (2,3)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@car_id", carID);
                    int entry = (int)cmd.ExecuteScalar();

                    if (entry > 0)
                    {
                        result = true;
                    }
                }
            }

            return result; 
        }

        private void Form_Rentals_Load(object sender, EventArgs e)
        {
            ComboLoadData();
            combo_car_id.SelectedIndex = -1;
            combo_customer_id.SelectedIndex = -1;
            combo_salesperson_id.SelectedIndex = -1;

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Rentals_Select", connection))
                    {
                        cmd.CommandType= CommandType.StoredProcedure;

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
                 int r_rental_id = int.Parse(selectedRow.Cells[0].Value.ToString());
                 string r_car_id = (selectedRow.Cells[5].Value.ToString());
                if (selectedRow.Cells[8].Value != null &&selectedRow.Cells[8].Value != DBNull.Value &&!string.IsNullOrWhiteSpace(selectedRow.Cells[8].Value.ToString()))
                {
                    DateTime r_return_date;
                    if (DateTime.TryParse(selectedRow.Cells[8].Value.ToString(), out r_return_date))
                    {
                        date_return_date.Value = r_return_date;
                    }
                }

                string r_end_kilometer = (selectedRow.Cells[7].Value.ToString());
                string r_total_price = selectedRow.Cells[9].Value.ToString();

                try
                {
                    combo_car_id.SelectedIndex = combo_car_id.FindStringExact(r_car_id);
                    
                    txt_end_kilometer.Text = r_end_kilometer;
                    txt_total_price.Text = r_total_price;
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
            int r_car_id = Convert.ToInt32(combo_car_id.SelectedValue);

            DateTime r_return_date = date_return_date.Value;
            try
            {
                string r_end_kilometer = txt_end_kilometer.Text;

                int selected_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                decimal r_total_price = decimal.Parse(txt_total_price.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Rentals_Update",connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@rental_id", selected_ID);
                        cmd.Parameters.AddWithValue("@car_id", r_car_id);
                        cmd.Parameters.AddWithValue("@end_kilometer", r_end_kilometer);
                        cmd.Parameters.AddWithValue("@return_date", r_return_date);
                        cmd.Parameters.AddWithValue("@total_price", r_total_price);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarıyla Güncellendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

                        using (SqlCommand cmd = new SqlCommand("sp_Table_Rentals_Delete", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@rental_id", selectedRowID);

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

        private void radio_mos_rented_car_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_Get_Most_Rented_Car", connection);
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
