using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threshold_of_Islam
{
    public partial class Kalimas : Form
    {
        public Kalimas()
        {
            InitializeComponent();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f3 = new HomePage();
            f3.Show();
        }
    }
}
