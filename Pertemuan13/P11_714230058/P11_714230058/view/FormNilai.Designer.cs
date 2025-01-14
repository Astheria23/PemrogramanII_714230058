namespace P11_714230058.view
{
    partial class FormNilai
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
            dataNilai = new DataGridView();
            gbForm = new GroupBox();
            textBoxNama = new TextBox();
            textBoxNilai = new TextBox();
            cbNPM = new ComboBox();
            cbKategori = new ComboBox();
            cbMatkul = new ComboBox();
            labelNilai = new Label();
            labelNPM = new Label();
            labelKategori = new Label();
            labelMatkul = new Label();
            gbAction = new GroupBox();
            buttonRubah = new Button();
            buttonHapus = new Button();
            buttonSimpan = new Button();
            buttonRefresh = new Button();
            gbPencarian = new GroupBox();
            cariData = new Label();
            textBoxPencarian = new TextBox();
            button1 = new Button();
            gbTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataNilai).BeginInit();
            gbForm.SuspendLayout();
            gbAction.SuspendLayout();
            gbPencarian.SuspendLayout();
            SuspendLayout();
            // 
            // gbTabel
            // 
            gbTabel.Controls.Add(dataNilai);
            gbTabel.Location = new Point(33, 23);
            gbTabel.Margin = new Padding(6, 5, 6, 5);
            gbTabel.Name = "gbTabel";
            gbTabel.Padding = new Padding(6, 5, 6, 5);
            gbTabel.Size = new Size(1046, 427);
            gbTabel.TabIndex = 0;
            gbTabel.TabStop = false;
            gbTabel.Text = "Tabel Data Mahasiswa";
            // 
            // dataNilai
            // 
            dataNilai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataNilai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataNilai.Location = new Point(23, 37);
            dataNilai.Margin = new Padding(6, 5, 6, 5);
            dataNilai.Name = "dataNilai";
            dataNilai.RowHeadersWidth = 62;
            dataNilai.Size = new Size(994, 355);
            dataNilai.TabIndex = 0;
            dataNilai.CellClick += dataNilai_CellClick;
            // 
            // gbForm
            // 
            gbForm.Controls.Add(textBoxNama);
            gbForm.Controls.Add(textBoxNilai);
            gbForm.Controls.Add(cbNPM);
            gbForm.Controls.Add(cbKategori);
            gbForm.Controls.Add(cbMatkul);
            gbForm.Controls.Add(labelNilai);
            gbForm.Controls.Add(labelNPM);
            gbForm.Controls.Add(labelKategori);
            gbForm.Controls.Add(labelMatkul);
            gbForm.Location = new Point(33, 462);
            gbForm.Margin = new Padding(6, 5, 6, 5);
            gbForm.Name = "gbForm";
            gbForm.Padding = new Padding(6, 5, 6, 5);
            gbForm.Size = new Size(539, 408);
            gbForm.TabIndex = 1;
            gbForm.TabStop = false;
            gbForm.Text = "Form Data Mahasiswa";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(146, 248);
            textBoxNama.Margin = new Padding(4, 5, 4, 5);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.ReadOnly = true;
            textBoxNama.Size = new Size(345, 31);
            textBoxNama.TabIndex = 8;
            // 
            // textBoxNilai
            // 
            textBoxNilai.Location = new Point(146, 313);
            textBoxNilai.Margin = new Padding(4, 5, 4, 5);
            textBoxNilai.Name = "textBoxNilai";
            textBoxNilai.Size = new Size(345, 31);
            textBoxNilai.TabIndex = 7;
            // 
            // cbNPM
            // 
            cbNPM.FormattingEnabled = true;
            cbNPM.Location = new Point(146, 200);
            cbNPM.Margin = new Padding(4, 5, 4, 5);
            cbNPM.Name = "cbNPM";
            cbNPM.Size = new Size(345, 33);
            cbNPM.TabIndex = 6;
            cbNPM.SelectedIndexChanged += cbNPM_SelectedIndexChanged;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Items.AddRange(new object[] { "ATS", "AAS" });
            cbKategori.Location = new Point(146, 125);
            cbKategori.Margin = new Padding(4, 5, 4, 5);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(345, 33);
            cbKategori.TabIndex = 5;
            // 
            // cbMatkul
            // 
            cbMatkul.FormattingEnabled = true;
            cbMatkul.Items.AddRange(new object[] { "Pemrograman I", "Pemrograman II", "Pemrograman III", "Pemrograman IV", "Literasi Data", "Sistem ERP", "RPL", "Metodologi Penelitian", "PKN", "General English I" });
            cbMatkul.Location = new Point(146, 55);
            cbMatkul.Margin = new Padding(4, 5, 4, 5);
            cbMatkul.Name = "cbMatkul";
            cbMatkul.Size = new Size(345, 33);
            cbMatkul.TabIndex = 4;
            // 
            // labelNilai
            // 
            labelNilai.AutoSize = true;
            labelNilai.Location = new Point(36, 318);
            labelNilai.Margin = new Padding(6, 0, 6, 0);
            labelNilai.Name = "labelNilai";
            labelNilai.Size = new Size(46, 25);
            labelNilai.TabIndex = 3;
            labelNilai.Text = "Nilai";
            // 
            // labelNPM
            // 
            labelNPM.AutoSize = true;
            labelNPM.Location = new Point(36, 213);
            labelNPM.Margin = new Padding(6, 0, 6, 0);
            labelNPM.Name = "labelNPM";
            labelNPM.Size = new Size(51, 25);
            labelNPM.TabIndex = 2;
            labelNPM.Text = "NPM";
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(36, 140);
            labelKategori.Margin = new Padding(6, 0, 6, 0);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(78, 25);
            labelKategori.TabIndex = 1;
            labelKategori.Text = "Kategori";
            // 
            // labelMatkul
            // 
            labelMatkul.AutoSize = true;
            labelMatkul.Location = new Point(36, 60);
            labelMatkul.Margin = new Padding(6, 0, 6, 0);
            labelMatkul.Name = "labelMatkul";
            labelMatkul.Size = new Size(66, 25);
            labelMatkul.TabIndex = 0;
            labelMatkul.Text = "Matkul";
            // 
            // gbAction
            // 
            gbAction.Controls.Add(buttonRubah);
            gbAction.Controls.Add(buttonHapus);
            gbAction.Controls.Add(buttonSimpan);
            gbAction.Controls.Add(buttonRefresh);
            gbAction.Location = new Point(601, 644);
            gbAction.Margin = new Padding(6, 5, 6, 5);
            gbAction.Name = "gbAction";
            gbAction.Padding = new Padding(6, 5, 6, 5);
            gbAction.Size = new Size(477, 287);
            gbAction.TabIndex = 2;
            gbAction.TabStop = false;
            gbAction.Text = "Tabel Action";
            // 
            // buttonRubah
            // 
            buttonRubah.Location = new Point(44, 170);
            buttonRubah.Margin = new Padding(6, 5, 6, 5);
            buttonRubah.Name = "buttonRubah";
            buttonRubah.Size = new Size(403, 42);
            buttonRubah.TabIndex = 3;
            buttonRubah.Text = "Rubah";
            buttonRubah.UseVisualStyleBackColor = true;
            buttonRubah.Click += buttonRubah_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(44, 222);
            buttonHapus.Margin = new Padding(6, 5, 6, 5);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(403, 36);
            buttonHapus.TabIndex = 2;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(44, 118);
            buttonSimpan.Margin = new Padding(6, 5, 6, 5);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(403, 42);
            buttonSimpan.TabIndex = 1;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(44, 64);
            buttonRefresh.Margin = new Padding(6, 5, 6, 5);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(403, 44);
            buttonRefresh.TabIndex = 0;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // gbPencarian
            // 
            gbPencarian.Controls.Add(button1);
            gbPencarian.Controls.Add(cariData);
            gbPencarian.Controls.Add(textBoxPencarian);
            gbPencarian.Location = new Point(601, 460);
            gbPencarian.Margin = new Padding(4, 5, 4, 5);
            gbPencarian.Name = "gbPencarian";
            gbPencarian.Padding = new Padding(4, 5, 4, 5);
            gbPencarian.Size = new Size(477, 160);
            gbPencarian.TabIndex = 3;
            gbPencarian.TabStop = false;
            gbPencarian.Text = "Form Pencarian";
            // 
            // cariData
            // 
            cariData.AutoSize = true;
            cariData.Location = new Point(23, 39);
            cariData.Margin = new Padding(4, 0, 4, 0);
            cariData.Name = "cariData";
            cariData.Size = new Size(84, 25);
            cariData.TabIndex = 1;
            cariData.Text = "Cari Data";
            // 
            // textBoxPencarian
            // 
            textBoxPencarian.Location = new Point(110, 34);
            textBoxPencarian.Margin = new Padding(4, 5, 4, 5);
            textBoxPencarian.Name = "textBoxPencarian";
            textBoxPencarian.Size = new Size(337, 31);
            textBoxPencarian.TabIndex = 0;
            textBoxPencarian.TextChanged += textBoxPencarian_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Location = new Point(112, 85);
            button1.Name = "button1";
            button1.Size = new Size(337, 52);
            button1.TabIndex = 2;
            button1.Text = "Export Excel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormNilai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 955);
            Controls.Add(gbPencarian);
            Controls.Add(gbAction);
            Controls.Add(gbForm);
            Controls.Add(gbTabel);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormNilai";
            Text = "FormNilai";
            Load += FormNilai_Load;
            gbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataNilai).EndInit();
            gbForm.ResumeLayout(false);
            gbForm.PerformLayout();
            gbAction.ResumeLayout(false);
            gbPencarian.ResumeLayout(false);
            gbPencarian.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbTabel;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Label labelNilai;
        private System.Windows.Forms.Label labelNPM;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Label labelMatkul;
        private System.Windows.Forms.DataGridView dataNilai;
        private System.Windows.Forms.Button buttonRubah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonRefresh;
        private GroupBox gbPencarian;
        private Label cariData;
        private TextBox textBoxPencarian;
        private ComboBox cbMatkul;
        private TextBox textBoxNilai;
        private ComboBox cbNPM;
        private ComboBox cbKategori;
        private TextBox textBoxNama;
        private Button button1;
    }
}