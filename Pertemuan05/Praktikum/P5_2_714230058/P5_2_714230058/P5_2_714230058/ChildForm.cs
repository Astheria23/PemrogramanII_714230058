using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_714230058
{
    public partial class ChildForm : Form
    {
        String outputText;
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = outputText;
        }

        private void DataOption_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");

        }

        private void TimeOption_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("t");
        }
    }
}
