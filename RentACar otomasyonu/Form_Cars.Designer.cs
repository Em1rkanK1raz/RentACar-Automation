namespace RentACar_otomasyonu
{
    partial class Form_Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cars));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_starting_update = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_production_year = new System.Windows.Forms.TextBox();
            this.txt_kilometer = new System.Windows.Forms.TextBox();
            this.txt_daily_price = new System.Windows.Forms.TextBox();
            this.combo_brand = new System.Windows.Forms.ComboBox();
            this.combo_model = new System.Windows.Forms.ComboBox();
            this.combo_fuel_type = new System.Windows.Forms.ComboBox();
            this.combo_gear_type = new System.Windows.Forms.ComboBox();
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.txt_plate_number = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(798, 334);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 67);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "KAYDET";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(798, 511);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 67);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_starting_update
            // 
            this.btn_starting_update.Location = new System.Drawing.Point(951, 328);
            this.btn_starting_update.Name = "btn_starting_update";
            this.btn_starting_update.Size = new System.Drawing.Size(108, 79);
            this.btn_starting_update.TabIndex = 2;
            this.btn_starting_update.Text = "GÜNCELLEME BAŞLAT";
            this.btn_starting_update.UseVisualStyleBackColor = true;
            this.btn_starting_update.Click += new System.EventHandler(this.btn_starting_update_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(963, 459);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 67);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(798, 419);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(96, 67);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "LİSTELE";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Markası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modeli:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plakası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Üretim Yılı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yakıt Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vites Türü:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Günlük Ücreti:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kilometresi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 554);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Durumu:";
            // 
            // txt_production_year
            // 
            this.txt_production_year.Location = new System.Drawing.Point(609, 493);
            this.txt_production_year.Name = "txt_production_year";
            this.txt_production_year.Size = new System.Drawing.Size(100, 22);
            this.txt_production_year.TabIndex = 14;
            // 
            // txt_kilometer
            // 
            this.txt_kilometer.Location = new System.Drawing.Point(192, 495);
            this.txt_kilometer.Name = "txt_kilometer";
            this.txt_kilometer.Size = new System.Drawing.Size(100, 22);
            this.txt_kilometer.TabIndex = 16;
            // 
            // txt_daily_price
            // 
            this.txt_daily_price.Location = new System.Drawing.Point(192, 449);
            this.txt_daily_price.Name = "txt_daily_price";
            this.txt_daily_price.Size = new System.Drawing.Size(100, 22);
            this.txt_daily_price.TabIndex = 17;
            // 
            // combo_brand
            // 
            this.combo_brand.FormattingEnabled = true;
            this.combo_brand.Location = new System.Drawing.Point(609, 335);
            this.combo_brand.Name = "combo_brand";
            this.combo_brand.Size = new System.Drawing.Size(121, 24);
            this.combo_brand.TabIndex = 19;
            // 
            // combo_model
            // 
            this.combo_model.FormattingEnabled = true;
            this.combo_model.Location = new System.Drawing.Point(609, 377);
            this.combo_model.Name = "combo_model";
            this.combo_model.Size = new System.Drawing.Size(121, 24);
            this.combo_model.TabIndex = 20;
            // 
            // combo_fuel_type
            // 
            this.combo_fuel_type.FormattingEnabled = true;
            this.combo_fuel_type.Location = new System.Drawing.Point(609, 558);
            this.combo_fuel_type.Name = "combo_fuel_type";
            this.combo_fuel_type.Size = new System.Drawing.Size(121, 24);
            this.combo_fuel_type.TabIndex = 21;
            // 
            // combo_gear_type
            // 
            this.combo_gear_type.FormattingEnabled = true;
            this.combo_gear_type.Location = new System.Drawing.Point(192, 395);
            this.combo_gear_type.Name = "combo_gear_type";
            this.combo_gear_type.Size = new System.Drawing.Size(121, 24);
            this.combo_gear_type.TabIndex = 22;
            // 
            // combo_status
            // 
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Location = new System.Drawing.Point(192, 550);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(121, 24);
            this.combo_status.TabIndex = 23;
            // 
            // txt_plate_number
            // 
            this.txt_plate_number.Location = new System.Drawing.Point(609, 441);
            this.txt_plate_number.Name = "txt_plate_number";
            this.txt_plate_number.Size = new System.Drawing.Size(100, 22);
            this.txt_plate_number.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1383, 290);
            this.dataGridView1.TabIndex = 25;
            // 
            // Form_Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1413, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_plate_number);
            this.Controls.Add(this.combo_status);
            this.Controls.Add(this.combo_gear_type);
            this.Controls.Add(this.combo_fuel_type);
            this.Controls.Add(this.combo_model);
            this.Controls.Add(this.combo_brand);
            this.Controls.Add(this.txt_daily_price);
            this.Controls.Add(this.txt_kilometer);
            this.Controls.Add(this.txt_production_year);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_starting_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Name = "Form_Cars";
            this.Text = "Form_Cars";
            this.Load += new System.EventHandler(this.Form_Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_starting_update;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_production_year;
        private System.Windows.Forms.TextBox txt_kilometer;
        private System.Windows.Forms.TextBox txt_daily_price;
        private System.Windows.Forms.ComboBox combo_brand;
        private System.Windows.Forms.ComboBox combo_model;
        private System.Windows.Forms.ComboBox combo_fuel_type;
        private System.Windows.Forms.ComboBox combo_gear_type;
        private System.Windows.Forms.ComboBox combo_status;
        private System.Windows.Forms.TextBox txt_plate_number;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}