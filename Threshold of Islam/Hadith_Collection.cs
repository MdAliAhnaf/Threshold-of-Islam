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
    public partial class Hadith_Collection : Form
    {
        public Hadith_Collection()
        {
            InitializeComponent();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f8 = new HomePage();
            f8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bukhari f9 = new Bukhari();
            f9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Muslim f12 = new Muslim();
            f12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abu_Dawud f14 = new Abu_Dawud();
            f14.Show();
        }

        private void Hadith_Collection_Load(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(120, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(120, 0, 0, 0);
            panel8.BackColor = Color.FromArgb(120, 0, 0, 0);
        }
    }
}
