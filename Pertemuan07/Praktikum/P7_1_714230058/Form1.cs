using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230058
{
    public partial class cb : Form
    {
        public cb()
        {
            InitializeComponent();
            Size = new Size(335, 252);
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();
            if (String.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage.Append("Nama Harus Diisi");
            }
            if (String.IsNullOrWhiteSpace(tbKelas.Text))
            {
                errorMessage.Append("\nNama Harus Diisi");
            }
            if (comboBoxAngkatan.SelectedIndex == -1) {
                errorMessage.Append("\nAngkatan Harus Diisi");
            }
            string errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(
                    "Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                Size = new Size(351, 519);
            }
            else
            {
                MessageBox.Show(
                    errorMsg.Trim(), "error", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );

            }
        }

        private void rbWeekday_CheckedChanged(object sender, EventArgs e)
        {

            if (rbWeekday.Checked)
            {
                cbLiburan.Enabled = false; cbLiburan.Checked = false;
                cbTidur.Enabled = true; 
                cbKuliah.Enabled = true; cbKuliah.Checked = false;
            }

        }

        private void rbWeekend_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWeekend.Checked)
            {
                cbLiburan.Enabled = true; cbLiburan.Checked = false;
                cbTidur.Enabled = true;
                cbKuliah.Enabled = false; cbKuliah.Checked = false;
            } 
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            //String hari = null;
            //string kegiatan = null;

            //foreach(Control control in Controls)
            //{
            //    if (control is RadioButton radioButton && radioButton.Checked)
            //    {
            //        hari = radioButton.Text;
            //        break;
            //    }
            //}

            //foreach (Control control in Controls)
            //{
            //    if (control is CheckBox checkBox && checkBox.Checked) 
            //    {
            //        if (!string.IsNullOrEmpty(kegiatan))
            //        {
            //            kegiatan += ", ";
            //        }
            //        kegiatan += checkBox.Text;
            //    }
            //}}

            //LINQ
            string hari = Controls.OfType<RadioButton>()
            .FirstOrDefault(rb => rb.Checked)?.Text;
            string kegiatan = string.Join(",", Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text));



            MessageBox.Show(
                "Nama :" + textBoxNama.Text + "\n" +
                "Angkatan :" + comboBoxAngkatan.Text + "\n" +
                "Kelas :" + tbKelas.Text + "\n" +
                "================================\n" +
                "Hari :" + hari + "\nKegiatan: " + kegiatan ,
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                if (control is RadioButton radiobutton)
                {
                    radiobutton.Checked = false;
                }
                if (control is CheckBox checkbox)
                {
                    checkbox.Checked = false;
                    checkbox.Enabled = true;
                }
            }

            MessageBox.Show("Berhasil Di Reset", 
                "Informasi", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            Size = new Size(335, 252);



        }
    }
}
