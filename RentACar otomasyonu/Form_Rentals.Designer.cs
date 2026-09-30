namespace RentACar_otomasyonu
{
    partial class Form_Rentals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rentals));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total_price = new System.Windows.Forms.TextBox();
            this.txt_start_kilometer = new System.Windows.Forms.TextBox();
            this.txt_end_kilometer = new System.Windows.Forms.TextBox();
            this.combo_customer_id = new System.Windows.Forms.ComboBox();
            this.combo_car_id = new System.Windows.Forms.ComboBox();
            this.combo_salesperson_id = new System.Windows.Forms.ComboBox();
            this.date_return_date = new System.Windows.Forms.DateTimePicker();
            this.date_rent_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_starting_update = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.radio_mos_rented_car = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araba ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satıcı ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kiralama Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dönüş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Toplam Tutar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Başlangıç Kilometresi:";
            // 
            // txt_total_price
            // 
            this.txt_total_price.Location = new System.Drawing.Point(294, 538);
            this.txt_total_price.Name = "txt_total_price";
            this.txt_total_price.Size = new System.Drawing.Size(100, 22);
            this.txt_total_price.TabIndex = 7;
            // 
            // txt_start_kilometer
            // 
            this.txt_start_kilometer.Location = new System.Drawing.Point(294, 583);
            this.txt_start_kilometer.Name = "txt_start_kilometer";
            this.txt_start_kilometer.Size = new System.Drawing.Size(100, 22);
            this.txt_start_kilometer.TabIndex = 8;
            // 
            // txt_end_kilometer
            // 
            this.txt_end_kilometer.Location = new System.Drawing.Point(294, 631);
            this.txt_end_kilometer.Name = "txt_end_kilometer";
            this.txt_end_kilometer.Size = new System.Drawing.Size(100, 22);
            this.txt_end_kilometer.TabIndex = 9;
            // 
            // combo_customer_id
            // 
            this.combo_customer_id.FormattingEnabled = true;
            this.combo_customer_id.Location = new System.Drawing.Point(294, 303);
            this.combo_customer_id.Name = "combo_customer_id";
            this.combo_customer_id.Size = new System.Drawing.Size(200, 24);
            this.combo_customer_id.TabIndex = 10;
            // 
            // combo_car_id
            // 
            this.combo_car_id.FormattingEnabled = true;
            this.combo_car_id.Location = new System.Drawing.Point(294, 351);
            this.combo_car_id.Name = "combo_car_id";
            this.combo_car_id.Size = new System.Drawing.Size(200, 24);
            this.combo_car_id.TabIndex = 11;
            // 
            // combo_salesperson_id
            // 
            this.combo_salesperson_id.FormattingEnabled = true;
            this.combo_salesperson_id.Location = new System.Drawing.Point(294, 394);
            this.combo_salesperson_id.Name = "combo_salesperson_id";
            this.combo_salesperson_id.Size = new System.Drawing.Size(200, 24);
            this.combo_salesperson_id.TabIndex = 12;
            // 
            // date_return_date
            // 
            this.date_return_date.Location = new System.Drawing.Point(294, 492);
            this.date_return_date.Name = "date_return_date";
            this.date_return_date.Size = new System.Drawing.Size(200, 22);
            this.date_return_date.TabIndex = 13;
            // 
            // date_rent_date
            // 
            this.date_rent_date.Location = new System.Drawing.Point(294, 442);
            this.date_rent_date.Name = "date_rent_date";
            this.date_rent_date.Size = new System.Drawing.Size(200, 22);
            this.date_rent_date.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 639);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bitiş Kilometresi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1337, 250);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(546, 299);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 76);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "KAYDET";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(546, 457);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 62);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_starting_update
            // 
            this.btn_starting_update.Location = new System.Drawing.Point(724, 369);
            this.btn_starting_update.Name = "btn_starting_update";
            this.btn_starting_update.Size = new System.Drawing.Size(114, 79);
            this.btn_starting_update.TabIndex = 19;
            this.btn_starting_update.Text = "GÜNCELLEME BAŞLAT";
            this.btn_starting_update.UseVisualStyleBackColor = true;
            this.btn_starting_update.Click += new System.EventHandler(this.btn_starting_update_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(546, 381);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(101, 62);
            this.btn_select.TabIndex = 20;
            this.btn_select.Text = "LİSTELE";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(724, 296);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(114, 67);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // radio_mos_rented_car
            // 
            this.radio_mos_rented_car.AutoSize = true;
            this.radio_mos_rented_car.Location = new System.Drawing.Point(706, 478);
            this.radio_mos_rented_car.Name = "radio_mos_rented_car";
            this.radio_mos_rented_car.Size = new System.Drawing.Size(163, 20);
            this.radio_mos_rented_car.TabIndex = 22;
            this.radio_mos_rented_car.TabStop = true;
            this.radio_mos_rented_car.Text = "En Çok Kiralana Araba";
            this.radio_mos_rented_car.UseVisualStyleBackColor = true;
            this.radio_mos_rented_car.CheckedChanged += new System.EventHandler(this.radio_mos_rented_car_CheckedChanged);
            // 
            // Form_Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1374, 743);
            this.Controls.Add(this.radio_mos_rented_car);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_starting_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.date_rent_date);
            this.Controls.Add(this.date_return_date);
            this.Controls.Add(this.combo_salesperson_id);
            this.Controls.Add(this.combo_car_id);
            this.Controls.Add(this.combo_customer_id);
            this.Controls.Add(this.txt_end_kilometer);
            this.Controls.Add(this.txt_start_kilometer);
            this.Controls.Add(this.txt_total_price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Rentals";
            this.Text = "Form_Kiralama";
            this.Load += new System.EventHandler(this.Form_Rentals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_total_price;
        private System.Windows.Forms.TextBox txt_start_kilometer;
        private System.Windows.Forms.TextBox txt_end_kilometer;
        private System.Windows.Forms.ComboBox combo_customer_id;
        private System.Windows.Forms.ComboBox combo_car_id;
        private System.Windows.Forms.ComboBox combo_salesperson_id;
        private System.Windows.Forms.DateTimePicker date_return_date;
        private System.Windows.Forms.DateTimePicker date_rent_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_starting_update;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.RadioButton radio_mos_rented_car;
    }
}