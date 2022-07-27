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
    public partial class To_Do_List : Form
    {
        public To_Do_List()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void gunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            gunaCircleProgressBar1.Value = 0;
            timer1.Start();
            if(guna2ToggleSwitch1.Checked==true)
            {
                gunaCircleProgressBar1.Value = 50;
                timer1.Stop();
            }
            if (guna2ToggleSwitch2.Checked == true)
            {
                gunaCircleProgressBar1.Value = 100;
                timer1.Stop();
            }
            if (guna2ToggleSwitch3.Checked == true)
            {
                gunaCircleProgressBar1.Value = 150;
                timer1.Stop();
            }
            if (guna2ToggleSwitch4.Checked == true)
            {
                gunaCircleProgressBar1.Value = 200;
                timer1.Stop();
            }
            if (guna2ToggleSwitch5.Checked == true)
            {
                gunaCircleProgressBar1.Value = 250;
                timer1.Stop();
            }
            if (guna2ToggleSwitch6.Checked == true)
            {
                gunaCircleProgressBar1.Value = 300;
                timer1.Stop();
            }
            if (guna2ToggleSwitch8.Checked == true)
            {
                gunaCircleProgressBar1.Value = 350;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaCircleProgressBar1.Increment(1);
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void To_Do_List_Load(object sender, EventArgs e)
        {
            gunaCircleProgressBar1.Value = 0;
        }
    }
}
