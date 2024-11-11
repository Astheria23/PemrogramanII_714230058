using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P5_4_714230058
{
    public partial class Form1 : Form
    {
        string jenisKelamin, tanggalLahir, kelas, jadwal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string nama = namaForm.Text;
            tanggalLahir = tanggalLahirForm.Value.ToString("dd MMMM yyyy");
            jenisKelamin = jenisKelaminForm.Text.Trim();

            if (!(rbSeninRabu.Checked || rbSelasaKamis.Checked || rbSabtuMinggu.Checked || rbMinggu.Checked))
            {
                MessageBox.Show("Harus Memilih salah satu pilihan jadwal.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(cbBasket.Checked || cbBuluTangkis.Checked || cbPanahan.Checked || cbRenang.Checked ||
                  cbSepakBola.Checked || cbTenis.Checked || cbVoli.Checked || cbYoga.Checked))
            {
                MessageBox.Show("Harus memilih salah satu pilihan kelas.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> selectedJadwal = new List<string>();

            if (cbBasket.Checked) selectedJadwal.Add("Basket");
            if (cbBuluTangkis.Checked) selectedJadwal.Add("Bulu Tangkis");
            if (cbPanahan.Checked) selectedJadwal.Add("Panahan");
            if (cbRenang.Checked) selectedJadwal.Add("Renang");
            if (cbSepakBola.Checked) selectedJadwal.Add("Sepak Bola");
            if (cbTenis.Checked) selectedJadwal.Add("Tenis");
            if (cbVoli.Checked) selectedJadwal.Add("Voli");
            if (cbYoga.Checked) selectedJadwal.Add("Yoga");
            string jadwal = string.Join(", ", selectedJadwal);

            if (rbSeninRabu.Checked == true)
            {
                kelas = "Senin s/d Rabu, 14:00 - 16:00";
            }
            else if (rbSelasaKamis.Checked == true)
            {
                kelas = "Selasa s/d Kamis, 14:00 - 16:00";
            }
            else if (rbSabtuMinggu.Checked == true)
            {
                kelas = "Sabtu s/d Minggu, 09:00 - 11:00";
            }
            else if (rbMinggu.Checked == true)
            {
                kelas = "Minggu, 13:00 - 20:00";
            }
            else {
            }
            MessageBox.Show(

                $" Nama: {nama}\n Jenis Kelamin: {jenisKelamin}\n tanggalLahir: {tanggalLahir}\n Pilihan Kelas: {kelas}\n Pilihan Jadwal: {jadwal}", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
