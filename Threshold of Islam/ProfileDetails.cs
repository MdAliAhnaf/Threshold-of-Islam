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
    public partial class ProfileDetails : Form
    {
        public ProfileDetails()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            FullNameLabel.Text = Login.FN;
            DOBLabel.Text = Login.DB;
            EmailLabel.Text = Login.EL;
            PhoneLabel.Text = Login.PL;
            AddressLabel.Text = Login.AL;
            ZipLabel.Text = Login.ZL;
            CountryLabel.Text = Login.CL;
            CityLabel.Text = Login.CTL;
            GenderLabel.Text = Login.GL;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f3 = new HomePage();
            f3.Show();
        }
    }
}
