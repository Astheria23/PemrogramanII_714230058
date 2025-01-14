namespace P11_714230058.view
{
    partial class FormTransaksi
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
            dataTransaksi = new DataGridView();
            gbForm = new GroupBox();
            labelTotal = new Label();
            labelHarga = new Label();
            comboBoxID = new ComboBox();
            textBoxQuantity = new TextBox();
            textBoxHarga = new TextBox();
            textBoxNama = new TextBox();
            textBoxTotal = new TextBox();
            labelAlamat = new Label();
            labelNama = new Label();
            labelID = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataTransaksi).BeginInit();
            gbForm.SuspendLayout();
            gbAction.SuspendLayout();
            gbPencarian.SuspendLayout();
            SuspendLayout();
            // 
            // gbTabel
            // 
            gbTabel.Controls.Add(dataTransaksi);
            gbTabel.Location = new Point(33, 23);
            gbTabel.Margin = new Padding(6, 5, 6, 5);
            gbTabel.Name = "gbTabel";
            gbTabel.Padding = new Padding(6, 5, 6, 5);
            gbTabel.Size = new Size(1046, 427);
            gbTabel.TabIndex = 0;
            gbTabel.TabStop = false;
            gbTabel.Text = "Tabel Data Transaksi";
            // 
            // dataTransaksi
            // 
            dataTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTransaksi.Location = new Point(23, 37);
            dataTransaksi.Margin = new Padding(6, 5, 6, 5);
            dataTransaksi.Name = "dataTransaksi";
            dataTransaksi.RowHeadersWidth = 62;
            dataTransaksi.Size = new Size(994, 355);
            dataTransaksi.TabIndex = 0;
            dataTransaksi.CellClick += dataTransaksi_CellClick;
            // 
            // gbForm
            // 
            gbForm.Controls.Add(labelTotal);
            gbForm.Controls.Add(labelHarga);
            gbForm.Controls.Add(comboBoxID);
            gbForm.Controls.Add(textBoxQuantity);
            gbForm.Controls.Add(textBoxHarga);
            gbForm.Controls.Add(textBoxNama);
            gbForm.Controls.Add(textBoxTotal);
            gbForm.Controls.Add(labelAlamat);
            gbForm.Controls.Add(labelNama);
            gbForm.Controls.Add(labelID);
            gbForm.Location = new Point(33, 462);
            gbForm.Margin = new Padding(6, 5, 6, 5);
            gbForm.Name = "gbForm";
            gbForm.Padding = new Padding(6, 5, 6, 5);
            gbForm.Size = new Size(539, 477);
            gbForm.TabIndex = 1;
            gbForm.TabStop = false;
            gbForm.Text = "Form Data Transaksi";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(36, 325);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(49, 25);
            labelTotal.TabIndex = 13;
            labelTotal.Text = "Total";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(36, 198);
            labelHarga.Margin = new Padding(4, 0, 4, 0);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(120, 25);
            labelHarga.TabIndex = 12;
            labelHarga.Text = "Harga Barang";
            // 
            // comboBoxID
            // 
            comboBoxID.FormattingEnabled = true;
            comboBoxID.Location = new Point(157, 55);
            comboBoxID.Margin = new Padding(4, 5, 4, 5);
            comboBoxID.Name = "comboBoxID";
            comboBoxID.Size = new Size(325, 33);
            comboBoxID.TabIndex = 11;
            comboBoxID.SelectedIndexChanged += comboBoxID_SelectedIndexChanged;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(157, 257);
            textBoxQuantity.Margin = new Padding(6, 5, 6, 5);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(325, 31);
            textBoxQuantity.TabIndex = 10;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(157, 190);
            textBoxHarga.Margin = new Padding(6, 5, 6, 5);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.ReadOnly = true;
            textBoxHarga.Size = new Size(325, 31);
            textBoxHarga.TabIndex = 9;
            textBoxHarga.Text = "Rp. ";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(157, 123);
            textBoxNama.Margin = new Padding(6, 5, 6, 5);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.ReadOnly = true;
            textBoxNama.Size = new Size(325, 31);
            textBoxNama.TabIndex = 7;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(157, 323);
            textBoxTotal.Margin = new Padding(6, 5, 6, 5);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(325, 31);
            textBoxTotal.TabIndex = 6;
            textBoxTotal.Text = "Rp. ";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(36, 265);
            labelAlamat.Margin = new Padding(6, 0, 6, 0);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(80, 25);
            labelAlamat.TabIndex = 3;
            labelAlamat.Text = "Quantity";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(36, 132);
            labelNama.Margin = new Padding(6, 0, 6, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(119, 25);
            labelNama.TabIndex = 1;
            labelNama.Text = "Nama Barang";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(36, 60);
            labelID.Margin = new Padding(6, 0, 6, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(90, 25);
            labelID.TabIndex = 0;
            labelID.Text = "ID Barang";
            // 
            // gbAction
            // 
            gbAction.Controls.Add(buttonRubah);
            gbAction.Controls.Add(buttonHapus);
            gbAction.Controls.Add(buttonSimpan);
            gbAction.Controls.Add(buttonRefresh);
            gbAction.Location = new Point(601, 622);
            gbAction.Margin = new Padding(6, 5, 6, 5);
            gbAction.Name = "gbAction";
            gbAction.Padding = new Padding(6, 5, 6, 5);
            gbAction.Size = new Size(477, 309);
            gbAction.TabIndex = 2;
            gbAction.TabStop = false;
            gbAction.Text = "Tabel Action";
            // 
            // buttonRubah
            // 
            buttonRubah.Location = new Point(44, 183);
            buttonRubah.Margin = new Padding(6, 5, 6, 5);
            buttonRubah.Name = "buttonRubah";
            buttonRubah.Size = new Size(403, 32);
            buttonRubah.TabIndex = 3;
            buttonRubah.Text = "Rubah";
            buttonRubah.UseVisualStyleBackColor = true;
            buttonRubah.Click += buttonRubah_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(44, 251);
            buttonHapus.Margin = new Padding(6, 5, 6, 5);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(403, 32);
            buttonHapus.TabIndex = 2;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(44, 108);
            buttonSimpan.Margin = new Padding(6, 5, 6, 5);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(403, 32);
            buttonSimpan.TabIndex = 1;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(44, 34);
            buttonRefresh.Margin = new Padding(6, 5, 6, 5);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(403, 32);
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
            gbPencarian.Size = new Size(477, 152);
            gbPencarian.TabIndex = 3;
            gbPencarian.TabStop = false;
            gbPencarian.Text = "Form Pencarian";
            // 
            // cariData
            // 
            cariData.AutoSize = true;
            cariData.Location = new Point(25, 39);
            cariData.Margin = new Padding(4, 0, 4, 0);
            cariData.Name = "cariData";
            cariData.Size = new Size(84, 25);
            cariData.TabIndex = 1;
            cariData.Text = "Cari Data";
            // 
            // textBoxPencarian
            // 
            textBoxPencarian.Location = new Point(112, 34);
            textBoxPencarian.Margin = new Padding(4, 5, 4, 5);
            textBoxPencarian.Name = "textBoxPencarian";
            textBoxPencarian.Size = new Size(337, 31);
            textBoxPencarian.TabIndex = 0;
            textBoxPencarian.TextChanged += textBoxPencarian_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.Location = new Point(44, 89);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(403, 39);
            button1.TabIndex = 4;
            button1.Text = "Export Excel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 955);
            Controls.Add(gbPencarian);
            Controls.Add(gbAction);
            Controls.Add(gbForm);
            Controls.Add(gbTabel);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormTransaksi";
            Text = "FormTransaksi";
            Load += FormTransaksi_Load;
            gbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTransaksi).EndInit();
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
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelAngkatan;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.DataGridView dataTransaksi;
        private System.Windows.Forms.Button buttonRubah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonRefresh;
        private GroupBox gbPencarian;
        private Label cariData;
        private TextBox textBoxPencarian;
        private ComboBox comboBoxID;
        private Label labelTotal;
        private Label labelHarga;
        private Button button1;
    }
}