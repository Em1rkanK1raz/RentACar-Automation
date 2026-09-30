namespace RentACar_otomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_connection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_connection_rentals = new System.Windows.Forms.Button();
            this.btn_connection_cars = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_connection_salesperson = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_connection
            // 
            this.btn_connection.BackColor = System.Drawing.Color.Gray;
            this.btn_connection.Location = new System.Drawing.Point(137, 232);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(95, 62);
            this.btn_connection.TabIndex = 0;
            this.btn_connection.Text = "BAĞLAN";
            this.btn_connection.UseVisualStyleBackColor = false;
            this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteriler Tablosu\'na Gitmek İçin Tıklayınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(436, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiralama Tablosu\'na Gitmek İçin Tıklayınız";
            // 
            // btn_connection_rentals
            // 
            this.btn_connection_rentals.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_connection_rentals.Location = new System.Drawing.Point(507, 232);
            this.btn_connection_rentals.Name = "btn_connection_rentals";
            this.btn_connection_rentals.Size = new System.Drawing.Size(88, 62);
            this.btn_connection_rentals.TabIndex = 3;
            this.btn_connection_rentals.Text = "BAĞLAN";
            this.btn_connection_rentals.UseVisualStyleBackColor = false;
            this.btn_connection_rentals.Click += new System.EventHandler(this.btn_connection_rentals_Click);
            // 
            // btn_connection_cars
            // 
            this.btn_connection_cars.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_connection_cars.Location = new System.Drawing.Point(144, 368);
            this.btn_connection_cars.Name = "btn_connection_cars";
            this.btn_connection_cars.Size = new System.Drawing.Size(88, 62);
            this.btn_connection_cars.TabIndex = 4;
            this.btn_connection_cars.Text = "BAĞLAN";
            this.btn_connection_cars.UseVisualStyleBackColor = false;
            this.btn_connection_cars.Click += new System.EventHandler(this.btn_connection_cars_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(81, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arablar\'ın Tablosu\'na Gitmek İçin Tıklayınız";
            // 
            // btn_connection_salesperson
            // 
            this.btn_connection_salesperson.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_connection_salesperson.Location = new System.Drawing.Point(507, 368);
            this.btn_connection_salesperson.Name = "btn_connection_salesperson";
            this.btn_connection_salesperson.Size = new System.Drawing.Size(88, 62);
            this.btn_connection_salesperson.TabIndex = 6;
            this.btn_connection_salesperson.Text = "BAĞLAN";
            this.btn_connection_salesperson.UseVisualStyleBackColor = false;
            this.btn_connection_salesperson.Click += new System.EventHandler(this.btn_connection_salesperson_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(435, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Satıcılar\'ın Tablosu\'na Gitmek İçin Tıklayınız";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(729, 614);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_connection_salesperson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_connection_cars);
            this.Controls.Add(this.btn_connection_rentals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connection_rentals;
        private System.Windows.Forms.Button btn_connection_cars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_connection_salesperson;
        private System.Windows.Forms.Label label4;
    }
}

