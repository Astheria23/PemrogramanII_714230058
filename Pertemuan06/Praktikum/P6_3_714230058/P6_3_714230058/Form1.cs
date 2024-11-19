using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714230058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessages(txtHuruf, "Textbox Huruf tidak boleh kosong!", "", "");
            }
            else if(txtHuruf.Text.All(Char.IsLetter)){
                SetErrorMessages(txtHuruf, "", "", "Betul!");

            }
            else
            {
                SetErrorMessages(txtHuruf, "", "Inputannya Hanya Boleh Huruf", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessages(txtAngka, "Textbox tidak boleh kosong", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber)) {
                SetErrorMessages(txtAngka, "","","Mantap");
            }
            else
            {
                SetErrorMessages(txtAngka, "", "Inputan Hanya Boleh Angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email Tidak Boleh Kosong!","","");
            }
            else if (Regex.IsMatch(txtEmail.Text,@"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul");
            }
            else
            {
                SetErrorMessages(txtEmail,"","Format Email Salah! \nContoh: a@b.com","");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Textbox angka 2 tidak boleh kosong!", "", "");
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            int angka1Val;
            int angka2Val;
            int.TryParse(txtAngka1.Text, out angka1Val);
            int.TryParse(txtAngka2.Text, out angka2Val);
            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtAngka2, "Textbox angka 1 tidak boleh kosong!", "", "");
            }
            else
            {

                if (angka2Val > angka1Val) SetErrorMessages(txtAngka2, "", "Angka 1 harus lebih besar dari angka 2", "");
                else SetErrorMessages(txtAngka2, "", "", "Betul!");
                 SetErrorMessages(txtAngka1, "", "", "Betul!");
            }
        }

    }
}
