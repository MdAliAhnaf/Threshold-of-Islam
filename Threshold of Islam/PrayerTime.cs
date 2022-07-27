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
    public partial class PrayerTime : Form
    {
        public PrayerTime()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           /* if (comboBox1.SelectedItem == "Dhaka")
            {
                label2.Text = "05:45 AM";
                label4.Text = "01:20 PM";
                label6.Text = "03:50 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:25 PM";
                

            }

            else if (comboBox1.SelectedItem == "Rajshahi")
            {
                label2.Text = "05:46 AM";
                label4.Text = "01:22 PM";
                label6.Text = "03:51 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:27 PM";
            }

            else if (comboBox1.SelectedItem == "Mymenshingh")
            {
                label2.Text = "05:47 AM";
                label4.Text = "01:24 PM";
                label6.Text = "03:52 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:29 PM";
            }

            else if (comboBox1.SelectedItem == "Khulna")
            {
                label2.Text = "05:48 AM";
                label4.Text = "01:26 PM";
                label6.Text = "03:53 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:31 PM";
            }

            else if (comboBox1.SelectedItem == "Barisal")
            {
                label2.Text = "05:49 AM";
                label4.Text = "01:28 PM";
                label6.Text = "03:54 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:32 PM";
            }

            else if (comboBox1.SelectedItem == "Rangpur")
            {
                label2.Text = "05:50 AM";
                label4.Text = "01:30 PM";
                label6.Text = "03:55 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:35 PM";
            }

            else if (comboBox1.SelectedItem == "Chittagong")
            {
                label2.Text = "05:51 AM";
                label4.Text = "01:32 PM";
                label6.Text = "03:56 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:37 PM";
            }

            else if (comboBox1.SelectedItem == "Sylhet")
            {
                label2.Text = "05:52 AM";
                label4.Text = "01:34 PM";
                label6.Text = "03:57 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:39 PM";
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == "Dhaka")
            {
                label2.Text = "05:45 AM";
                label4.Text = "01:20 PM";
                label6.Text = "03:50 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:25 PM";
                label14.Text = "05:30 PM";
                label15.Text = "06:10 AM";
                this.guna2Panel4.BackColor = Color.ForestGreen;
            }

            else if (comboBox1.SelectedItem == "Rajshahi")
            {
                label2.Text = "05:46 AM";
                label4.Text = "01:22 PM";
                label6.Text = "03:51 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:27 PM";
                label14.Text = "05:31 PM";
                label15.Text = "06:22 AM";
                this.guna2Panel4.BackColor = Color.Lavender;
            }

            else if (comboBox1.SelectedItem == "Mymenshingh")
            {
                label2.Text = "05:47 AM";
                label4.Text = "01:24 PM";
                label6.Text = "03:52 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:29 PM";
                label14.Text = "05:32 PM";
                label15.Text = "06:25 AM";
                this.guna2Panel4.BackColor = Color.LightBlue;
            }

            else if (comboBox1.SelectedItem == "Khulna")
            {
                label2.Text = "05:48 AM";
                label4.Text = "01:26 PM";
                label6.Text = "03:53 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:31 PM";
                label14.Text = "05:33 PM";
                label15.Text = "06:20 AM";
                this.guna2Panel4.BackColor = Color.Aqua;
            }

            else if (comboBox1.SelectedItem == "Barisal")
            {
                label2.Text = "05:49 AM";
                label4.Text = "01:28 PM";
                label6.Text = "03:54 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:32 PM";
                label14.Text = "05:34 PM";
                label15.Text = "06:19 AM";
                this.guna2Panel4.BackColor = Color.LightSeaGreen;
            }

            else if (comboBox1.SelectedItem == "Rangpur")
            {
                label2.Text = "05:50 AM";
                label4.Text = "01:30 PM";
                label6.Text = "03:55 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:35 PM";
                label14.Text = "05:37 PM";
                label15.Text = "06:22 AM";
                this.guna2Panel4.BackColor = Color.ForestGreen;
            }

            else if (comboBox1.SelectedItem == "Chittagong")
            {
                label2.Text = "05:51 AM";
                label4.Text = "01:32 PM";
                label6.Text = "03:56 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:37 PM";
                label14.Text = "05:39 PM";
                label15.Text = "06:25 AM";
                this.guna2Panel4.BackColor = Color.DarkCyan;
            }

            else if (comboBox1.SelectedItem == "Sylhet")
            {
                label2.Text = "05:52 AM";
                label4.Text = "01:34 PM";
                label6.Text = "03:57 PM";
                label8.Text = "05:20 PM";
                label10.Text = "07:39 PM";
                label14.Text = "05:30 PM";
                label15.Text = "06:20 AM";
                this.guna2Panel4.BackColor = Color.CornflowerBlue;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Hide();
            HomePage f3 = new HomePage();
            f3.Show();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            TimeSpan result = this.dateTimePicker2.Value - this.dateTimePicker1.Value;
            this.label11.Text = result.ToString();
            string s = label11.Text;
            string[] tmparray = label11.Text.Split('.');
            label11.Text = tmparray[0];
            label11.Visible = true;
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToLongDateString();
            guna2Panel3.BackColor = Color.FromArgb(120, 0, 0, 0);
            label19.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox2.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
