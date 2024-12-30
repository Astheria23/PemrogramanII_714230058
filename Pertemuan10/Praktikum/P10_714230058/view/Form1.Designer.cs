namespace P10_714230058
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
            gbTabel = new GroupBox();
            DataMahasiswa = new DataGridView();
            gbForm = new GroupBox();
            comboBoxAngkatan = new ComboBox();
            textBoxHP = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAlamat = new TextBox();
            textBoxNama = new TextBox();
            textBoxNPM = new TextBox();
            labelHP = new Label();
            labelEmail = new Label();
            labelAlamat = new Label();
            labelAngkatan = new Label();
            labelNama = new Label();
            labelNPM = new Label();
            gbAction = new GroupBox();
            buttonRubah = new Button();
            buttonHapus = new Button();
            buttonSimpan = new Button();
            buttonRefresh = new Button();
            gbTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataMahasiswa).BeginInit();
            gbForm.SuspendLayout();
            gbAction.SuspendLayout();
            SuspendLayout();
            // 
            // gbTabel
            // 
            gbTabel.Controls.Add(DataMahasiswa);
            gbTabel.Location = new Point(26, 19);
            gbTabel.Margin = new Padding(5, 4, 5, 4);
            gbTabel.Name = "gbTabel";
            gbTabel.Padding = new Padding(5, 4, 5, 4);
            gbTabel.Size = new Size(837, 341);
            gbTabel.TabIndex = 0;
            gbTabel.TabStop = false;
            gbTabel.Text = "Tabel Data Mahasiswa";
            // 
            // DataMahasiswa
            // 
            DataMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataMahasiswa.Location = new Point(18, 29);
            DataMahasiswa.Margin = new Padding(5, 4, 5, 4);
            DataMahasiswa.Name = "DataMahasiswa";
            DataMahasiswa.RowHeadersWidth = 51;
            DataMahasiswa.Size = new Size(795, 284);
            DataMahasiswa.TabIndex = 0;
            DataMahasiswa.CellClick += DataMahasiswa_CellClick;
            // 
            // gbForm
            // 
            gbForm.Controls.Add(comboBoxAngkatan);
            gbForm.Controls.Add(textBoxHP);
            gbForm.Controls.Add(textBoxEmail);
            gbForm.Controls.Add(textBoxAlamat);
            gbForm.Controls.Add(textBoxNama);
            gbForm.Controls.Add(textBoxNPM);
            gbForm.Controls.Add(labelHP);
            gbForm.Controls.Add(labelEmail);
            gbForm.Controls.Add(labelAlamat);
            gbForm.Controls.Add(labelAngkatan);
            gbForm.Controls.Add(labelNama);
            gbForm.Controls.Add(labelNPM);
            gbForm.Location = new Point(26, 369);
            gbForm.Margin = new Padding(5, 4, 5, 4);
            gbForm.Name = "gbForm";
            gbForm.Padding = new Padding(5, 4, 5, 4);
            gbForm.Size = new Size(431, 381);
            gbForm.TabIndex = 1;
            gbForm.TabStop = false;
            gbForm.Text = "Form Data Mahasiswa";
            // 
            // comboBoxAngkatan
            // 
            comboBoxAngkatan.FormattingEnabled = true;
            comboBoxAngkatan.Items.AddRange(new object[] { "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            comboBoxAngkatan.Location = new Point(126, 132);
            comboBoxAngkatan.Margin = new Padding(5, 4, 5, 4);
            comboBoxAngkatan.Name = "comboBoxAngkatan";
            comboBoxAngkatan.Size = new Size(261, 28);
            comboBoxAngkatan.TabIndex = 11;
            // 
            // textBoxHP
            // 
            textBoxHP.Location = new Point(126, 309);
            textBoxHP.Margin = new Padding(5, 4, 5, 4);
            textBoxHP.Name = "textBoxHP";
            textBoxHP.Size = new Size(261, 27);
            textBoxHP.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(126, 264);
            textBoxEmail.Margin = new Padding(5, 4, 5, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(261, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(126, 181);
            textBoxAlamat.Margin = new Padding(5, 4, 5, 4);
            textBoxAlamat.Multiline = true;
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(261, 67);
            textBoxAlamat.TabIndex = 8;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(126, 88);
            textBoxNama.Margin = new Padding(5, 4, 5, 4);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(261, 27);
            textBoxNama.TabIndex = 7;
            // 
            // textBoxNPM
            // 
            textBoxNPM.Location = new Point(126, 43);
            textBoxNPM.Margin = new Padding(5, 4, 5, 4);
            textBoxNPM.Name = "textBoxNPM";
            textBoxNPM.Size = new Size(261, 27);
            textBoxNPM.TabIndex = 6;
            // 
            // labelHP
            // 
            labelHP.AutoSize = true;
            labelHP.Location = new Point(22, 313);
            labelHP.Margin = new Padding(5, 0, 5, 0);
            labelHP.Name = "labelHP";
            labelHP.Size = new Size(52, 20);
            labelHP.TabIndex = 5;
            labelHP.Text = "No HP";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(21, 269);
            labelEmail.Margin = new Padding(5, 0, 5, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(22, 191);
            labelAlamat.Margin = new Padding(5, 0, 5, 0);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(57, 20);
            labelAlamat.TabIndex = 3;
            labelAlamat.Text = "Alamat";
            // 
            // labelAngkatan
            // 
            labelAngkatan.AutoSize = true;
            labelAngkatan.Location = new Point(22, 137);
            labelAngkatan.Margin = new Padding(5, 0, 5, 0);
            labelAngkatan.Name = "labelAngkatan";
            labelAngkatan.Size = new Size(72, 20);
            labelAngkatan.TabIndex = 2;
            labelAngkatan.Text = "Angkatan";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(22, 92);
            labelNama.Margin = new Padding(5, 0, 5, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(49, 20);
            labelNama.TabIndex = 1;
            labelNama.Text = "Nama";
            // 
            // labelNPM
            // 
            labelNPM.AutoSize = true;
            labelNPM.Location = new Point(22, 48);
            labelNPM.Margin = new Padding(5, 0, 5, 0);
            labelNPM.Name = "labelNPM";
            labelNPM.Size = new Size(41, 20);
            labelNPM.TabIndex = 0;
            labelNPM.Text = "NPM";
            // 
            // gbAction
            // 
            gbAction.Controls.Add(buttonRubah);
            gbAction.Controls.Add(buttonHapus);
            gbAction.Controls.Add(buttonSimpan);
            gbAction.Controls.Add(buttonRefresh);
            gbAction.Location = new Point(481, 463);
            gbAction.Margin = new Padding(5, 4, 5, 4);
            gbAction.Name = "gbAction";
            gbAction.Padding = new Padding(5, 4, 5, 4);
            gbAction.Size = new Size(382, 283);
            gbAction.TabIndex = 2;
            gbAction.TabStop = false;
            gbAction.Text = "Tabel Action";
            // 
            // buttonRubah
            // 
            buttonRubah.Location = new Point(38, 157);
            buttonRubah.Margin = new Padding(5, 4, 5, 4);
            buttonRubah.Name = "buttonRubah";
            buttonRubah.Size = new Size(322, 36);
            buttonRubah.TabIndex = 3;
            buttonRubah.Text = "Rubah";
            buttonRubah.UseVisualStyleBackColor = true;
            buttonRubah.Click += buttonRubah_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(38, 212);
            buttonHapus.Margin = new Padding(5, 4, 5, 4);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(322, 36);
            buttonHapus.TabIndex = 2;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(38, 97);
            buttonSimpan.Margin = new Padding(5, 4, 5, 4);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(322, 36);
            buttonSimpan.TabIndex = 1;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(38, 39);
            buttonRefresh.Margin = new Padding(5, 4, 5, 4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(322, 36);
            buttonRefresh.TabIndex = 0;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 764);
            Controls.Add(gbAction);
            Controls.Add(gbForm);
            Controls.Add(gbTabel);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataMahasiswa).EndInit();
            gbForm.ResumeLayout(false);
            gbForm.PerformLayout();
            gbAction.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbTabel;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelAngkatan;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNPM;
        private System.Windows.Forms.TextBox textBoxHP;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNPM;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.Button buttonRubah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

