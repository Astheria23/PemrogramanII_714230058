using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714230058.view
{
    public partial class startUp : Form
    {
        public startUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ParentForm frm = new ParentForm();
            progressBar2.Value += 10;
            if (progressBar2.Value == 100)
            {
                timer1.Dispose();
                Close();
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
