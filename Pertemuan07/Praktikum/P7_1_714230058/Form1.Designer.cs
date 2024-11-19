namespace P7_1_714230058
{
    partial class cb
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
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.tbKelas = new System.Windows.Forms.TextBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbWeekday = new System.Windows.Forms.RadioButton();
            this.rbWeekend = new System.Windows.Forms.RadioButton();
            this.cbKuliah = new System.Windows.Forms.CheckBox();
            this.cbTidur = new System.Windows.Forms.CheckBox();
            this.cbLiburan = new System.Windows.Forms.CheckBox();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(105, 30);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(176, 20);
            this.textBoxNama.TabIndex = 3;
            // 
            // tbKelas
            // 
            this.tbKelas.Location = new System.Drawing.Point(105, 104);
            this.tbKelas.Multiline = true;
            this.tbKelas.Name = "tbKelas";
            this.tbKelas.Size = new System.Drawing.Size(176, 53);
            this.tbKelas.TabIndex = 4;
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBoxAngkatan.Location = new System.Drawing.Point(105, 67);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(176, 21);
            this.comboBoxAngkatan.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(105, 177);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Cek";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(206, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Tutup";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "KEGIATAN";
            // 
            // rbWeekday
            // 
            this.rbWeekday.AutoSize = true;
            this.rbWeekday.Location = new System.Drawing.Point(34, 272);
            this.rbWeekday.Name = "rbWeekday";
            this.rbWeekday.Size = new System.Drawing.Size(91, 17);
            this.rbWeekday.TabIndex = 9;
            this.rbWeekday.TabStop = true;
            this.rbWeekday.Text = "Senin - Jum\'at";
            this.rbWeekday.UseVisualStyleBackColor = true;
            this.rbWeekday.CheckedChanged += new System.EventHandler(this.rbWeekday_CheckedChanged);
            // 
            // rbWeekend
            // 
            this.rbWeekend.AutoSize = true;
            this.rbWeekend.Location = new System.Drawing.Point(34, 295);
            this.rbWeekend.Name = "rbWeekend";
            this.rbWeekend.Size = new System.Drawing.Size(97, 17);
            this.rbWeekend.TabIndex = 10;
            this.rbWeekend.TabStop = true;
            this.rbWeekend.Text = "Sabtu - Minggu";
            this.rbWeekend.UseVisualStyleBackColor = true;
            this.rbWeekend.CheckedChanged += new System.EventHandler(this.rbWeekend_CheckedChanged);
            // 
            // cbKuliah
            // 
            this.cbKuliah.AutoSize = true;
            this.cbKuliah.Location = new System.Drawing.Point(34, 333);
            this.cbKuliah.Name = "cbKuliah";
            this.cbKuliah.Size = new System.Drawing.Size(55, 17);
            this.cbKuliah.TabIndex = 11;
            this.cbKuliah.Text = "Kuliah";
            this.cbKuliah.UseVisualStyleBackColor = true;
            // 
            // cbTidur
            // 
            this.cbTidur.AutoSize = true;
            this.cbTidur.Location = new System.Drawing.Point(34, 356);
            this.cbTidur.Name = "cbTidur";
            this.cbTidur.Size = new System.Drawing.Size(50, 17);
            this.cbTidur.TabIndex = 12;
            this.cbTidur.Text = "Tidur";
            this.cbTidur.UseVisualStyleBackColor = true;
            // 
            // cbLiburan
            // 
            this.cbLiburan.AutoSize = true;
            this.cbLiburan.Location = new System.Drawing.Point(34, 379);
            this.cbLiburan.Name = "cbLiburan";
            this.cbLiburan.Size = new System.Drawing.Size(61, 17);
            this.cbLiburan.TabIndex = 13;
            this.cbLiburan.Text = "Liburan";
            this.cbLiburan.UseVisualStyleBackColor = true;
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(105, 445);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 23);
            this.btnCetak.TabIndex = 14;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(206, 445);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(354, 480);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.cbLiburan);
            this.Controls.Add(this.cbTidur);
            this.Controls.Add(this.cbKuliah);
            this.Controls.Add(this.rbWeekend);
            this.Controls.Add(this.rbWeekday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.comboBoxAngkatan);
            this.Controls.Add(this.tbKelas);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "cb";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox tbKelas;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbWeekday;
        private System.Windows.Forms.RadioButton rbWeekend;
        private System.Windows.Forms.CheckBox cbKuliah;
        private System.Windows.Forms.CheckBox cbTidur;
        private System.Windows.Forms.CheckBox cbLiburan;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnReset;
    }
}

