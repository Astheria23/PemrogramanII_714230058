namespace P5_4_714230058
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.namaForm = new System.Windows.Forms.TextBox();
            this.jenisKelaminForm = new System.Windows.Forms.ComboBox();
            this.tanggalLahirForm = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPanahan = new System.Windows.Forms.CheckBox();
            this.cbVoli = new System.Windows.Forms.CheckBox();
            this.cbBuluTangkis = new System.Windows.Forms.CheckBox();
            this.cbBasket = new System.Windows.Forms.CheckBox();
            this.cbYoga = new System.Windows.Forms.CheckBox();
            this.cbTenis = new System.Windows.Forms.CheckBox();
            this.cbRenang = new System.Windows.Forms.CheckBox();
            this.cbSepakBola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.rbSabtuMinggu = new System.Windows.Forms.RadioButton();
            this.rbSelasaKamis = new System.Windows.Forms.RadioButton();
            this.rbSeninRabu = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(202, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(202, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jens Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(202, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(264, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "FORM PENDAFTARAN";
            // 
            // namaForm
            // 
            this.namaForm.Location = new System.Drawing.Point(337, 80);
            this.namaForm.Name = "namaForm";
            this.namaForm.Size = new System.Drawing.Size(192, 20);
            this.namaForm.TabIndex = 4;
            // 
            // jenisKelaminForm
            // 
            this.jenisKelaminForm.FormattingEnabled = true;
            this.jenisKelaminForm.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.jenisKelaminForm.Location = new System.Drawing.Point(337, 115);
            this.jenisKelaminForm.Name = "jenisKelaminForm";
            this.jenisKelaminForm.Size = new System.Drawing.Size(192, 21);
            this.jenisKelaminForm.TabIndex = 5;
            this.jenisKelaminForm.Text = "--Pilih Jenis Kelamin--";
            // 
            // tanggalLahirForm
            // 
            this.tanggalLahirForm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tanggalLahirForm.Location = new System.Drawing.Point(337, 152);
            this.tanggalLahirForm.Name = "tanggalLahirForm";
            this.tanggalLahirForm.Size = new System.Drawing.Size(212, 20);
            this.tanggalLahirForm.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPanahan);
            this.groupBox1.Controls.Add(this.cbVoli);
            this.groupBox1.Controls.Add(this.cbBuluTangkis);
            this.groupBox1.Controls.Add(this.cbBasket);
            this.groupBox1.Controls.Add(this.cbYoga);
            this.groupBox1.Controls.Add(this.cbTenis);
            this.groupBox1.Controls.Add(this.cbRenang);
            this.groupBox1.Controls.Add(this.cbSepakBola);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(69, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // cbPanahan
            // 
            this.cbPanahan.AutoSize = true;
            this.cbPanahan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbPanahan.Location = new System.Drawing.Point(143, 157);
            this.cbPanahan.Name = "cbPanahan";
            this.cbPanahan.Size = new System.Drawing.Size(69, 17);
            this.cbPanahan.TabIndex = 7;
            this.cbPanahan.Text = "Panahan";
            this.cbPanahan.UseVisualStyleBackColor = true;
            // 
            // cbVoli
            // 
            this.cbVoli.AutoSize = true;
            this.cbVoli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbVoli.Location = new System.Drawing.Point(143, 118);
            this.cbVoli.Name = "cbVoli";
            this.cbVoli.Size = new System.Drawing.Size(43, 17);
            this.cbVoli.TabIndex = 6;
            this.cbVoli.Text = "Voli";
            this.cbVoli.UseVisualStyleBackColor = true;
            // 
            // cbBuluTangkis
            // 
            this.cbBuluTangkis.AutoSize = true;
            this.cbBuluTangkis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbBuluTangkis.Location = new System.Drawing.Point(143, 79);
            this.cbBuluTangkis.Name = "cbBuluTangkis";
            this.cbBuluTangkis.Size = new System.Drawing.Size(88, 17);
            this.cbBuluTangkis.TabIndex = 5;
            this.cbBuluTangkis.Text = "Bulu Tangkis";
            this.cbBuluTangkis.UseVisualStyleBackColor = true;
            // 
            // cbBasket
            // 
            this.cbBasket.AutoSize = true;
            this.cbBasket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbBasket.Location = new System.Drawing.Point(143, 41);
            this.cbBasket.Name = "cbBasket";
            this.cbBasket.Size = new System.Drawing.Size(59, 17);
            this.cbBasket.TabIndex = 4;
            this.cbBasket.Text = "Basket";
            this.cbBasket.UseVisualStyleBackColor = true;
            // 
            // cbYoga
            // 
            this.cbYoga.AutoSize = true;
            this.cbYoga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbYoga.Location = new System.Drawing.Point(21, 157);
            this.cbYoga.Name = "cbYoga";
            this.cbYoga.Size = new System.Drawing.Size(51, 17);
            this.cbYoga.TabIndex = 3;
            this.cbYoga.Text = "Yoga";
            this.cbYoga.UseVisualStyleBackColor = true;
            // 
            // cbTenis
            // 
            this.cbTenis.AutoSize = true;
            this.cbTenis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbTenis.Location = new System.Drawing.Point(21, 118);
            this.cbTenis.Name = "cbTenis";
            this.cbTenis.Size = new System.Drawing.Size(52, 17);
            this.cbTenis.TabIndex = 2;
            this.cbTenis.Text = "Tenis";
            this.cbTenis.UseVisualStyleBackColor = true;
            // 
            // cbRenang
            // 
            this.cbRenang.AutoSize = true;
            this.cbRenang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbRenang.Location = new System.Drawing.Point(21, 79);
            this.cbRenang.Name = "cbRenang";
            this.cbRenang.Size = new System.Drawing.Size(64, 17);
            this.cbRenang.TabIndex = 1;
            this.cbRenang.Text = "Renang";
            this.cbRenang.UseVisualStyleBackColor = true;
            // 
            // cbSepakBola
            // 
            this.cbSepakBola.AutoSize = true;
            this.cbSepakBola.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbSepakBola.Location = new System.Drawing.Point(21, 41);
            this.cbSepakBola.Name = "cbSepakBola";
            this.cbSepakBola.Size = new System.Drawing.Size(81, 17);
            this.cbSepakBola.TabIndex = 0;
            this.cbSepakBola.Text = "Sepak Bola";
            this.cbSepakBola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMinggu);
            this.groupBox2.Controls.Add(this.rbSabtuMinggu);
            this.groupBox2.Controls.Add(this.rbSelasaKamis);
            this.groupBox2.Controls.Add(this.rbSeninRabu);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(409, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 208);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilhan Jadwal";
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbMinggu.Location = new System.Drawing.Point(23, 156);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(129, 17);
            this.rbMinggu.TabIndex = 3;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu, 13:00 - 20:00";
            this.rbMinggu.UseVisualStyleBackColor = true;
            // 
            // rbSabtuMinggu
            // 
            this.rbSabtuMinggu.AutoSize = true;
            this.rbSabtuMinggu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbSabtuMinggu.Location = new System.Drawing.Point(23, 117);
            this.rbSabtuMinggu.Name = "rbSabtuMinggu";
            this.rbSabtuMinggu.Size = new System.Drawing.Size(179, 17);
            this.rbSabtuMinggu.TabIndex = 2;
            this.rbSabtuMinggu.TabStop = true;
            this.rbSabtuMinggu.Text = "Sabtu s/d Minggu, 09:00 - 11:00";
            this.rbSabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // rbSelasaKamis
            // 
            this.rbSelasaKamis.AutoSize = true;
            this.rbSelasaKamis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbSelasaKamis.Location = new System.Drawing.Point(23, 78);
            this.rbSelasaKamis.Name = "rbSelasaKamis";
            this.rbSelasaKamis.Size = new System.Drawing.Size(176, 17);
            this.rbSelasaKamis.TabIndex = 1;
            this.rbSelasaKamis.TabStop = true;
            this.rbSelasaKamis.Text = "Selasa s/d Kamis, 14:00 - 16:00";
            this.rbSelasaKamis.UseVisualStyleBackColor = true;
            // 
            // rbSeninRabu
            // 
            this.rbSeninRabu.AutoSize = true;
            this.rbSeninRabu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbSeninRabu.Location = new System.Drawing.Point(23, 40);
            this.rbSeninRabu.Name = "rbSeninRabu";
            this.rbSeninRabu.Size = new System.Drawing.Size(172, 17);
            this.rbSeninRabu.TabIndex = 0;
            this.rbSeninRabu.TabStop = true;
            this.rbSeninRabu.Text = "Senin s/d Rabu, 14:00 -  16:00\r\n";
            this.rbSeninRabu.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(285, 435);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 9;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(409, 435);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 10;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tanggalLahirForm);
            this.Controls.Add(this.jenisKelaminForm);
            this.Controls.Add(this.namaForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ULBI SPORT SCHOOL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namaForm;
        private System.Windows.Forms.ComboBox jenisKelaminForm;
        private System.Windows.Forms.DateTimePicker tanggalLahirForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPanahan;
        private System.Windows.Forms.CheckBox cbVoli;
        private System.Windows.Forms.CheckBox cbBuluTangkis;
        private System.Windows.Forms.CheckBox cbBasket;
        private System.Windows.Forms.CheckBox cbYoga;
        private System.Windows.Forms.CheckBox cbTenis;
        private System.Windows.Forms.CheckBox cbRenang;
        private System.Windows.Forms.CheckBox cbSepakBola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.RadioButton rbSabtuMinggu;
        private System.Windows.Forms.RadioButton rbSelasaKamis;
        private System.Windows.Forms.RadioButton rbSeninRabu;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
    }
}

