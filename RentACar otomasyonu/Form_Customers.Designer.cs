namespace RentACar_otomasyonu
{
    partial class Form_Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Customers));
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_ehliyet_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.masked_tel = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masked_tc = new System.Windows.Forms.MaskedTextBox();
            this.date_verilis = new System.Windows.Forms.DateTimePicker();
            this.date_duzenlenme = new System.Windows.Forms.DateTimePicker();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_starting_update = new System.Windows.Forms.Button();
            this.radio_the_most_car_renting_customer = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.Location = new System.Drawing.Point(595, 312);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 49);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "KAYDET";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(227, 253);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(274, 22);
            this.txt_name.TabIndex = 1;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(227, 300);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(274, 22);
            this.txt_surname.TabIndex = 2;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(227, 520);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 22);
            this.txt_age.TabIndex = 3;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(227, 436);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(274, 22);
            this.txt_mail.TabIndex = 4;
            // 
            // txt_ehliyet_no
            // 
            this.txt_ehliyet_no.Location = new System.Drawing.Point(227, 474);
            this.txt_ehliyet_no.Name = "txt_ehliyet_no";
            this.txt_ehliyet_no.Size = new System.Drawing.Size(100, 22);
            this.txt_ehliyet_no.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyadınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefon No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yaşınız:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ehliyet No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ehliye Veriliş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 611);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ehliyet Düzenlenme Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "E-mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "TC Kimlik No:";
            // 
            // masked_tel
            // 
            this.masked_tel.Location = new System.Drawing.Point(227, 399);
            this.masked_tel.Mask = "(999) 999 99 99";
            this.masked_tel.Name = "masked_tel";
            this.masked_tel.Size = new System.Drawing.Size(100, 22);
            this.masked_tel.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, -5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1420, 218);
            this.dataGridView1.TabIndex = 19;
            // 
            // masked_tc
            // 
            this.masked_tc.Location = new System.Drawing.Point(227, 351);
            this.masked_tc.Mask = "99999999999";
            this.masked_tc.Name = "masked_tc";
            this.masked_tc.Size = new System.Drawing.Size(100, 22);
            this.masked_tc.TabIndex = 20;
            // 
            // date_verilis
            // 
            this.date_verilis.Location = new System.Drawing.Point(227, 570);
            this.date_verilis.Name = "date_verilis";
            this.date_verilis.Size = new System.Drawing.Size(200, 22);
            this.date_verilis.TabIndex = 21;
            // 
            // date_duzenlenme
            // 
            this.date_duzenlenme.Location = new System.Drawing.Point(227, 611);
            this.date_duzenlenme.Name = "date_duzenlenme";
            this.date_duzenlenme.Size = new System.Drawing.Size(200, 22);
            this.date_duzenlenme.TabIndex = 22;
            // 
            // btn_select
            // 
            this.btn_select.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_select.BackgroundImage")));
            this.btn_select.Location = new System.Drawing.Point(595, 367);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(87, 51);
            this.btn_select.TabIndex = 23;
            this.btn_select.Text = "LİSTELE";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.Location = new System.Drawing.Point(595, 428);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 49);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.Location = new System.Drawing.Point(738, 424);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(117, 42);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_starting_update
            // 
            this.btn_starting_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_starting_update.BackgroundImage")));
            this.btn_starting_update.Location = new System.Drawing.Point(738, 322);
            this.btn_starting_update.Name = "btn_starting_update";
            this.btn_starting_update.Size = new System.Drawing.Size(141, 72);
            this.btn_starting_update.TabIndex = 26;
            this.btn_starting_update.Text = "GÜNCELLEME BAŞLAT";
            this.btn_starting_update.UseVisualStyleBackColor = true;
            this.btn_starting_update.Click += new System.EventHandler(this.btn_starting_update_Click);
            // 
            // radio_the_most_car_renting_customer
            // 
            this.radio_the_most_car_renting_customer.AutoSize = true;
            this.radio_the_most_car_renting_customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radio_the_most_car_renting_customer.BackgroundImage")));
            this.radio_the_most_car_renting_customer.Location = new System.Drawing.Point(584, 278);
            this.radio_the_most_car_renting_customer.Name = "radio_the_most_car_renting_customer";
            this.radio_the_most_car_renting_customer.Size = new System.Drawing.Size(270, 20);
            this.radio_the_most_car_renting_customer.TabIndex = 28;
            this.radio_the_most_car_renting_customer.TabStop = true;
            this.radio_the_most_car_renting_customer.Text = "EN ÇOK  ARABA KİRALAYAN MÜŞTERİ\r\n";
            this.radio_the_most_car_renting_customer.UseVisualStyleBackColor = true;
            this.radio_the_most_car_renting_customer.CheckedChanged += new System.EventHandler(this.radio_the_most_car_renting_customer_CheckedChanged);
            // 
            // Form_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1499, 649);
            this.Controls.Add(this.radio_the_most_car_renting_customer);
            this.Controls.Add(this.btn_starting_update);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.date_duzenlenme);
            this.Controls.Add(this.date_verilis);
            this.Controls.Add(this.masked_tc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.masked_tel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ehliyet_no);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_save);
            this.Name = "Form_Customers";
            this.Text = "Form_Musteriler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_ehliyet_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox masked_tel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox masked_tc;
        private System.Windows.Forms.DateTimePicker date_verilis;
        private System.Windows.Forms.DateTimePicker date_duzenlenme;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_starting_update;
        private System.Windows.Forms.RadioButton radio_the_most_car_renting_customer;
    }
}