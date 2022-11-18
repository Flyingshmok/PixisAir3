using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirGroup3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDevin1_Click(object sender, EventArgs e)
        {
            FormDev1 fd1 = new FormDev1();
            FormMain fm = new FormMain();
            fm.Hide();
            fd1.Show();
        }
    }
}
