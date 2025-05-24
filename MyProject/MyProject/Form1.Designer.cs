namespace MyProject
{
    partial class my_car
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(my_car));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_arac_sayfası = new System.Windows.Forms.Button();
            this.btn_islemler_kayit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Marka = new System.Windows.Forms.ComboBox();
            this.comboBox_Viskozite1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Viskozite2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Yag = new System.Windows.Forms.Label();
            this.lbl_Yakit = new System.Windows.Forms.Label();
            this.lbl_Hava = new System.Windows.Forms.Label();
            this.lbl_Polen = new System.Windows.Forms.Label();
            this.lbl_Antifiriz = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_arac_sayfası);
            this.panel1.Controls.Add(this.btn_islemler_kayit);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(315, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ARAÇ SORGULA";
            // 
            // btn_arac_sayfası
            // 
            this.btn_arac_sayfası.FlatAppearance.BorderSize = 0;
            this.btn_arac_sayfası.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_arac_sayfası.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_arac_sayfası.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arac_sayfası.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arac_sayfası.Location = new System.Drawing.Point(670, 18);
            this.btn_arac_sayfası.Name = "btn_arac_sayfası";
            this.btn_arac_sayfası.Size = new System.Drawing.Size(125, 66);
            this.btn_arac_sayfası.TabIndex = 4;
            this.btn_arac_sayfası.Text = "ARAÇLAR SAYFASINA GİT";
            this.btn_arac_sayfası.UseVisualStyleBackColor = true;
            this.btn_arac_sayfası.Click += new System.EventHandler(this.btn_arac_sayfası_Click);
            // 
            // btn_islemler_kayit
            // 
            this.btn_islemler_kayit.FlatAppearance.BorderSize = 0;
            this.btn_islemler_kayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_islemler_kayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_islemler_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_islemler_kayit.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islemler_kayit.Location = new System.Drawing.Point(511, 18);
            this.btn_islemler_kayit.Name = "btn_islemler_kayit";
            this.btn_islemler_kayit.Size = new System.Drawing.Size(125, 66);
            this.btn_islemler_kayit.TabIndex = 3;
            this.btn_islemler_kayit.Text = "YAPILAN İŞLEMLER KAYIT";
            this.btn_islemler_kayit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(318, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_saat.Location = new System.Drawing.Point(3, 9);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(48, 16);
            this.lbl_saat.TabIndex = 1;
            this.lbl_saat.Text = "label1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(626, 40);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(961, 431);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(951, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 431);
            this.panel2.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 431);
            this.panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Viskozite2);
            this.groupBox1.Controls.Add(this.comboBox_Viskozite1);
            this.groupBox1.Controls.Add(this.comboBox_Marka);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yağ Bilgileri";
            // 
            // comboBox_Marka
            // 
            this.comboBox_Marka.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBox_Marka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Marka.FormattingEnabled = true;
            this.comboBox_Marka.Location = new System.Drawing.Point(6, 37);
            this.comboBox_Marka.Name = "comboBox_Marka";
            this.comboBox_Marka.Size = new System.Drawing.Size(131, 24);
            this.comboBox_Marka.TabIndex = 0;
            this.comboBox_Marka.Text = "MARKA SEÇ";
            // 
            // comboBox_Viskozite1
            // 
            this.comboBox_Viskozite1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBox_Viskozite1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Viskozite1.FormattingEnabled = true;
            this.comboBox_Viskozite1.Location = new System.Drawing.Point(144, 37);
            this.comboBox_Viskozite1.Name = "comboBox_Viskozite1";
            this.comboBox_Viskozite1.Size = new System.Drawing.Size(131, 24);
            this.comboBox_Viskozite1.TabIndex = 1;
            this.comboBox_Viskozite1.Text = "VİSKOZİTE";
            // 
            // comboBox_Viskozite2
            // 
            this.comboBox_Viskozite2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBox_Viskozite2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Viskozite2.FormattingEnabled = true;
            this.comboBox_Viskozite2.Location = new System.Drawing.Point(284, 37);
            this.comboBox_Viskozite2.Name = "comboBox_Viskozite2";
            this.comboBox_Viskozite2.Size = new System.Drawing.Size(131, 24);
            this.comboBox_Viskozite2.TabIndex = 2;
            this.comboBox_Viskozite2.Text = "VİSKOZİTE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.checkBox10);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_Antifiriz);
            this.groupBox2.Controls.Add(this.lbl_Hava);
            this.groupBox2.Controls.Add(this.lbl_Polen);
            this.groupBox2.Controls.Add(this.lbl_Yakit);
            this.groupBox2.Controls.Add(this.lbl_Yag);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "DEĞİŞTİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "DEĞİŞMEDİ";
            // 
            // lbl_Yag
            // 
            this.lbl_Yag.AutoSize = true;
            this.lbl_Yag.Location = new System.Drawing.Point(47, 65);
            this.lbl_Yag.Name = "lbl_Yag";
            this.lbl_Yag.Size = new System.Drawing.Size(90, 16);
            this.lbl_Yag.TabIndex = 2;
            this.lbl_Yag.Text = "Yağ Filtresi";
            // 
            // lbl_Yakit
            // 
            this.lbl_Yakit.AutoSize = true;
            this.lbl_Yakit.Location = new System.Drawing.Point(35, 92);
            this.lbl_Yakit.Name = "lbl_Yakit";
            this.lbl_Yakit.Size = new System.Drawing.Size(102, 16);
            this.lbl_Yakit.TabIndex = 3;
            this.lbl_Yakit.Text = "Yakıt Filtresi\r\n";
            // 
            // lbl_Hava
            // 
            this.lbl_Hava.AutoSize = true;
            this.lbl_Hava.Location = new System.Drawing.Point(37, 119);
            this.lbl_Hava.Name = "lbl_Hava";
            this.lbl_Hava.Size = new System.Drawing.Size(100, 16);
            this.lbl_Hava.TabIndex = 5;
            this.lbl_Hava.Text = "Hava Filtresi";
            // 
            // lbl_Polen
            // 
            this.lbl_Polen.AutoSize = true;
            this.lbl_Polen.Location = new System.Drawing.Point(35, 149);
            this.lbl_Polen.Name = "lbl_Polen";
            this.lbl_Polen.Size = new System.Drawing.Size(102, 16);
            this.lbl_Polen.TabIndex = 4;
            this.lbl_Polen.Text = "Polen Filtresi";
            // 
            // lbl_Antifiriz
            // 
            this.lbl_Antifiriz.AutoSize = true;
            this.lbl_Antifiriz.Location = new System.Drawing.Point(5, 177);
            this.lbl_Antifiriz.Name = "lbl_Antifiriz";
            this.lbl_Antifiriz.Size = new System.Drawing.Size(132, 16);
            this.lbl_Antifiriz.TabIndex = 6;
            this.lbl_Antifiriz.Text = "Antifiriz Değişimi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(4, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Açıklama";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox1.Location = new System.Drawing.Point(181, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox2.Location = new System.Drawing.Point(304, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 20);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox3.Location = new System.Drawing.Point(181, 92);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 20);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox4.Location = new System.Drawing.Point(304, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(98, 20);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox5.Location = new System.Drawing.Point(181, 119);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(98, 20);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox6.Location = new System.Drawing.Point(304, 116);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(98, 20);
            this.checkBox6.TabIndex = 13;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox7.Location = new System.Drawing.Point(181, 148);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(98, 20);
            this.checkBox7.TabIndex = 14;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox8.Location = new System.Drawing.Point(304, 145);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(98, 20);
            this.checkBox8.TabIndex = 15;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox9.Location = new System.Drawing.Point(181, 173);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(98, 20);
            this.checkBox9.TabIndex = 16;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox10.Location = new System.Drawing.Point(304, 174);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(106, 20);
            this.checkBox10.TabIndex = 17;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(12, 248);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(398, 79);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Şanzıman Yağı Eklendi. Değişti. \r\nHidrolik Yağı Eklendi.";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_saat);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(822, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 100);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MyProject.Properties.Resources.Neşeli_Tamirci_Karakteri;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // my_car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(961, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "my_car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Bakım Onarım";
            this.Load += new System.EventHandler(this.my_car_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_arac_sayfası;
        private System.Windows.Forms.Button btn_islemler_kayit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Viskozite2;
        private System.Windows.Forms.ComboBox comboBox_Viskozite1;
        private System.Windows.Forms.ComboBox comboBox_Marka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Antifiriz;
        private System.Windows.Forms.Label lbl_Hava;
        private System.Windows.Forms.Label lbl_Polen;
        private System.Windows.Forms.Label lbl_Yakit;
        private System.Windows.Forms.Label lbl_Yag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

