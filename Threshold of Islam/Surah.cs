using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Threshold_of_Islam
{
    
    public partial class Surah : Form
    {
        
        public Surah()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Surah_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
        
            System.Diagnostics.Process.Start("https://youtu.be/KRg6zxfw6ns");
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f3 = new HomePage();
            f3.Show();
        }       

        private void Yasin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/KRg6zxfw6ns");
        }

        private void Fatiha_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/-PqP0BCiTlE");
        }

        private void Baqara_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/Z5zh5QCsjYY");
        }

        private void Baqarah_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/Z5zh5QCsjYY");
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rahman_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/SBAuCo3d2cc");
        }

        private void Shams_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/a77YrcF3QNg");
        }

        private void Tin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/S4RN6imMO8Y");
        }

        private void Alaq_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/2R30TkTj1tY");
        }

        private void Fil_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/Y2sfUdJ4e6o");
        }

        private void Ikhlas_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/R3t9ePIzleU");
        }

        private void Nas_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/AcVtT2d8-kk");
        }
    }
}
