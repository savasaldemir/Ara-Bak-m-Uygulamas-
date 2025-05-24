namespace MyProject
{
    partial class araclar_sayfasi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(araclar_sayfasi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Plaka = new System.Windows.Forms.TextBox();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Yil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Adi_Soyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.btn_Arac_Ekle = new System.Windows.Forms.Button();
            this.btn_Arac_Guncelle = new System.Windows.Forms.Button();
            this.btn_Arac_Sil = new System.Windows.Forms.Button();
            this.lbl_Saat = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 533);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 533);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(249, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 100);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 408);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(249, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 433);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Yil);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_Model);
            this.groupBox2.Controls.Add(this.txt_Marka);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Plaka);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 237);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_Telefon);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_Adi_Soyadi);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(0, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 146);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Bilgileri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Arac_Sil);
            this.groupBox4.Controls.Add(this.btn_Arac_Guncelle);
            this.groupBox4.Controls.Add(this.btn_Arac_Ekle);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(0, 383);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 147);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // txt_Plaka
            // 
            this.txt_Plaka.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Plaka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Plaka.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Plaka.Location = new System.Drawing.Point(24, 44);
            this.txt_Plaka.Multiline = true;
            this.txt_Plaka.Name = "txt_Plaka";
            this.txt_Plaka.Size = new System.Drawing.Size(190, 27);
            this.txt_Plaka.TabIndex = 6;
            this.txt_Plaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Marka
            // 
            this.txt_Marka.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Marka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Marka.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Marka.Location = new System.Drawing.Point(24, 93);
            this.txt_Marka.Multiline = true;
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(190, 27);
            this.txt_Marka.TabIndex = 8;
            this.txt_Marka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Model
            // 
            this.txt_Model.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Model.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Model.Location = new System.Drawing.Point(24, 142);
            this.txt_Model.Multiline = true;
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(190, 27);
            this.txt_Model.TabIndex = 9;
            this.txt_Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "YIL";
            // 
            // txt_Yil
            // 
            this.txt_Yil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Yil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Yil.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Yil.Location = new System.Drawing.Point(24, 191);
            this.txt_Yil.Multiline = true;
            this.txt_Yil.Name = "txt_Yil";
            this.txt_Yil.Size = new System.Drawing.Size(190, 27);
            this.txt_Yil.TabIndex = 12;
            this.txt_Yil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adı Soyadı";
            // 
            // txt_Adi_Soyadi
            // 
            this.txt_Adi_Soyadi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Adi_Soyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Adi_Soyadi.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Adi_Soyadi.Location = new System.Drawing.Point(15, 44);
            this.txt_Adi_Soyadi.Multiline = true;
            this.txt_Adi_Soyadi.Name = "txt_Adi_Soyadi";
            this.txt_Adi_Soyadi.Size = new System.Drawing.Size(190, 27);
            this.txt_Adi_Soyadi.TabIndex = 8;
            this.txt_Adi_Soyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefon.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Telefon.Location = new System.Drawing.Point(15, 94);
            this.txt_Telefon.Multiline = true;
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(190, 27);
            this.txt_Telefon.TabIndex = 10;
            this.txt_Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Arac_Ekle
            // 
            this.btn_Arac_Ekle.BackColor = System.Drawing.Color.Silver;
            this.btn_Arac_Ekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Arac_Ekle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Arac_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Arac_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Arac_Ekle.Location = new System.Drawing.Point(3, 19);
            this.btn_Arac_Ekle.Name = "btn_Arac_Ekle";
            this.btn_Arac_Ekle.Size = new System.Drawing.Size(243, 43);
            this.btn_Arac_Ekle.TabIndex = 3;
            this.btn_Arac_Ekle.Text = "Araç Ekle";
            this.btn_Arac_Ekle.UseVisualStyleBackColor = false;
            // 
            // btn_Arac_Guncelle
            // 
            this.btn_Arac_Guncelle.BackColor = System.Drawing.Color.Orange;
            this.btn_Arac_Guncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Arac_Guncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Arac_Guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Arac_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Arac_Guncelle.Location = new System.Drawing.Point(3, 62);
            this.btn_Arac_Guncelle.Name = "btn_Arac_Guncelle";
            this.btn_Arac_Guncelle.Size = new System.Drawing.Size(243, 43);
            this.btn_Arac_Guncelle.TabIndex = 4;
            this.btn_Arac_Guncelle.Text = "Araç Güncelle";
            this.btn_Arac_Guncelle.UseVisualStyleBackColor = false;
            // 
            // btn_Arac_Sil
            // 
            this.btn_Arac_Sil.BackColor = System.Drawing.Color.Red;
            this.btn_Arac_Sil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Arac_Sil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Arac_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Arac_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Arac_Sil.Location = new System.Drawing.Point(3, 105);
            this.btn_Arac_Sil.Name = "btn_Arac_Sil";
            this.btn_Arac_Sil.Size = new System.Drawing.Size(243, 43);
            this.btn_Arac_Sil.TabIndex = 5;
            this.btn_Arac_Sil.Text = "Araç SİL";
            this.btn_Arac_Sil.UseVisualStyleBackColor = false;
            // 
            // lbl_Saat
            // 
            this.lbl_Saat.AutoSize = true;
            this.lbl_Saat.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Saat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Saat.Location = new System.Drawing.Point(19, 28);
            this.lbl_Saat.Name = "lbl_Saat";
            this.lbl_Saat.Size = new System.Drawing.Size(48, 16);
            this.lbl_Saat.TabIndex = 3;
            this.lbl_Saat.Text = "label7";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_Saat);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(477, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 100);
            this.panel4.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MyProject.Properties.Resources.Neşeli_Tamirci_Karakteri;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // araclar_sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(904, 533);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "araclar_sayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araçlar Sayfası";
            this.Load += new System.EventHandler(this.araclar_sayfasi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Plaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Yil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Adi_Soyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.Button btn_Arac_Sil;
        private System.Windows.Forms.Button btn_Arac_Guncelle;
        private System.Windows.Forms.Button btn_Arac_Ekle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}