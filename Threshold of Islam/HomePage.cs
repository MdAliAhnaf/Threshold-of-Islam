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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            
        }

        private void ToDoList_Click(object sender, EventArgs e)
        {
            this.Hide();
            To_Do_List f9 = new To_Do_List();
            f9.Show();

        }
        private void PrayerTimes_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrayerTime f4 = new PrayerTime();
            f4.Show();

        }

        private void DUASCollection_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DuaCollection f5 = new DuaCollection();
            f5.Show();
        }

        private void HadithCollection_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Hadith_Collection f6 = new Hadith_Collection();
            f6.Show();
        }

        private void NamesofALLAH_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Names99 f7 = new Names99();
            f7.Show();
        }

        private void KALIMAS_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Kalimas f8 = new Kalimas();
            f8.Show();
        }

        private void ToDoList_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            To_Do_List f9 = new To_Do_List();
            f9.Show();
        }

        private void Recitation_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Surah f10 = new Surah();
            f10.Show();
        }

        private void Conversations_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Conversations_of_scholarship f11 = new Conversations_of_scholarship();
            f11.Show();
        }

        private void ProfileDetails_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ProfileDetails f98 = new ProfileDetails();
            f98.Show();
        }

        private void guna2ImageButton1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }
    }
}
