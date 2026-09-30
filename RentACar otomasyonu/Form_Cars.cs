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
    public partial class Form_Cars : Form
    {
        private string connectionString;

        public Form_Cars()
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
                    string query1 = "SELECT BrandID,BrandName FROM Brands";
                    SqlDataAdapter da1 = new SqlDataAdapter(query1, connection);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    combo_brand.DataSource = dt1;
                    combo_brand.DisplayMember = "BrandName";
                    combo_brand.ValueMember = "BrandID";

                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query2 = "SELECT ModelID,ModelName FROM Models";
                    SqlDataAdapter da1 = new SqlDataAdapter(query2, connection);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    combo_model.DataSource = dt1;
                    combo_model.DisplayMember = "ModelName";
                    combo_model.ValueMember = "ModelID";

                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query3 = "SELECT FuelID,FuelName FROM FuelTypes";
                    SqlDataAdapter da1 = new SqlDataAdapter(query3, connection);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    combo_fuel_type.DataSource = dt1;
                    combo_fuel_type.DisplayMember = "FuelName";
                    combo_fuel_type.ValueMember = "FuelID";
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query4 = "SELECT GearID,GearName FROM GearTypes";
                    SqlDataAdapter da1 = new SqlDataAdapter(query4, connection);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                 
                    combo_gear_type.DataSource = dt1;
                    combo_gear_type.DisplayMember = "GearName";
                    combo_gear_type.ValueMember = "GearID";
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query5 = "SELECT StatusID,StatusName FROM CarStatuses";
                    SqlDataAdapter da1 = new SqlDataAdapter(query5, connection);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    combo_status.DataSource = dt1;
                    combo_status.DisplayMember = "StatusName";
                    combo_status.ValueMember = "StatusID";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {



            int car_brand = Convert.ToInt32(combo_brand.SelectedValue);
            int car_model = Convert.ToInt32(combo_model.SelectedValue);
            int car_fuel = Convert.ToInt32(combo_fuel_type.SelectedValue);
            int car_gear = Convert.ToInt32(combo_gear_type.SelectedValue);
            int car_status = Convert.ToInt32(combo_status.SelectedValue);


            string car_plate_number = txt_plate_number.Text.ToUpper();

            try 
            {

                int car_year = int.Parse(txt_production_year.Text);
                decimal car_daily_price = decimal.Parse(txt_daily_price.Text);
                int car_kilometer = int.Parse(txt_kilometer.Text);




                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand("sp_Table_Cars_Insert_Into", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@car_brand", car_brand);
                        cmd.Parameters.AddWithValue("@car_model", car_model);
                        cmd.Parameters.AddWithValue("@car_plate_number", car_plate_number);
                        cmd.Parameters.AddWithValue("@car_year", car_year);
                        cmd.Parameters.AddWithValue("@fuel_type", car_fuel);
                        cmd.Parameters.AddWithValue("@gear_type", car_gear);
                        cmd.Parameters.AddWithValue("@daily_price", car_daily_price);
                        cmd.Parameters.AddWithValue("@kilometer", car_kilometer);
                        cmd.Parameters.AddWithValue("@status", car_status);

                        connection.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Araç başarıyla kaydedildi!");
                    }
                }  
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void Form_Cars_Load(object sender, EventArgs e)
        {
            ComboLoadData();
            combo_brand.SelectedIndex = -1;
            combo_fuel_type.SelectedIndex = -1;
            combo_gear_type.SelectedIndex = -1;
            combo_model.SelectedIndex = -1;
            combo_status.SelectedIndex = -1;


        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Cars_Select", connection))
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

                    string car_id = selectedRow.Cells[0].Value.ToString();       
                    string car_brand = selectedRow.Cells[1].Value.ToString();    
                    string car_model = selectedRow.Cells[2].Value.ToString();   
                    string car_plate_number = selectedRow.Cells[3].Value.ToString();    
                    string car_year = selectedRow.Cells[4].Value.ToString();     
                    string car_fuel = selectedRow.Cells[5].Value.ToString();    
                    string car_gear = selectedRow.Cells[6].Value.ToString();     
                    string car_daily_price = selectedRow.Cells[7].Value.ToString();    
                    string car_kilometer = selectedRow.Cells[8].Value.ToString();       
                    string car_status = selectedRow.Cells[9].Value.ToString();   
                    try
                { 
                    combo_brand.Text = car_brand;     
                    combo_model.Text = car_model;
                    txt_plate_number.Text = car_plate_number;
                    txt_production_year.Text = car_year;
                    txt_daily_price.Text = car_daily_price;
                    txt_kilometer.Text = car_kilometer;
                    combo_fuel_type.Text = car_fuel;
                    combo_gear_type.Text = car_gear;
                    combo_status.Text = car_status;

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aktarma işlemi sırasında hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İçin Bir Araç Seçiniz");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            int car_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            int car_brand = Convert.ToInt32(combo_brand.SelectedValue);
            int car_model = Convert.ToInt32(combo_model.SelectedValue);
            int car_fuel = Convert.ToInt32(combo_fuel_type.SelectedValue);
            int car_gear = Convert.ToInt32(combo_gear_type.SelectedValue);
            int car_status = Convert.ToInt32(combo_status.SelectedValue);



            try
            {
                string car_plate = txt_plate_number.Text.ToUpper();

                int car_km = int.Parse(txt_kilometer.Text);

                int car_year = int.Parse(txt_production_year.Text);
                decimal car_price = decimal.Parse(txt_daily_price.Text);
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        SqlCommand cmd = new SqlCommand("sp_Table_Cars_Update", connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@car_id", car_id); 
                        cmd.Parameters.AddWithValue("@car_brand", car_brand);
                        cmd.Parameters.AddWithValue("@car_model", car_model);
                        cmd.Parameters.AddWithValue("@car_plate_number", car_plate);
                        cmd.Parameters.AddWithValue("@car_year", car_year);
                        cmd.Parameters.AddWithValue("@fuel_type", car_fuel);
                        cmd.Parameters.AddWithValue("@gear_type", car_gear);
                        cmd.Parameters.AddWithValue("@daily_price", car_price);
                        cmd.Parameters.AddWithValue("@kilometer", car_km);
                        cmd.Parameters.AddWithValue("@status", car_status);

                        connection.Open();
    
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Araç bilgileri başarıyla güncellendi.");

                       
                        txt_plate_number.Clear();
                        txt_production_year.Clear();
                        txt_kilometer.Clear();
                        txt_daily_price.Clear();

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message);
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

                        using (SqlCommand cmd = new SqlCommand("sp_Table_Cars_Delete", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@car_id", selectedRowID);

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
