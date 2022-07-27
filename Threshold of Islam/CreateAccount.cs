using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Threshold_of_Islam
{
    public partial class CreateAccount : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["gg"].ConnectionString;
        string Gender;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void panelU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DesignedByAhnaf_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked) // Where UseSystemPasswordChar False
            {
                Password.UseSystemPasswordChar = false;
                ConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
                ConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }




        private void ButtonCNA_Click(object sender, EventArgs e)
        {
            if (FullName.Text != "" && Email.Text != "" && DOB.Text != "" && Phone.Text != "" && Address.Text != "" && City.Text != "" && Zip.Text != "" && Country.Text != "" && Password.Text != "" && ConfirmPassword.Text != "" && Gender != "") //blank fields matching

            {
                string patternemail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                string patternmobile = "^.*$";
                string patternpassword = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
                if (Regex.IsMatch(Email.Text, patternemail)) //email matching

                {
                    if (Regex.IsMatch(Phone.Text, patternmobile)) //bd mobile matching
                    {

                        if (Regex.IsMatch(Password.Text, patternpassword)) //validation of password
                        {

                            if (ConfirmPassword.Text == Password.Text) //password matching
                            {

                                if (AgreeCheckBox.Checked) //terms agreement matching

                                {
                                    SqlConnection con = new SqlConnection(cs); //con is the connection object
                                    con.Open(); //open the connection 
                                    SqlCommand cmd = con.CreateCommand();
                                    cmd.CommandText = "insert into SignUp_User(Email, FullName, DOB, Phone, Address, City, Zip, Country, Password, Gender) values('" + Email.Text + "', '" + FullName.Text + "', '" + DOB.Text + "', '" + Phone.Text + "', '" + Address.Text + "', '" + City.Text + "', '" + Zip.Text + "', '" + Country.Text + "', '" + Password.Text + "','" + Gender + "')";
                                    if (cmd.ExecuteNonQuery() > 0)
                                    {
                                        MessageBox.Show("SignUp done!");
                                        this.Hide();
                                        Login f1 = new Login();
                                        f1.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sign Up Error!");
                                    }
                                    con.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Please agree the terms !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }

                            else
                            {
                                MessageBox.Show("Password doesn't match!");
                            }
                        }
                        else
                        {
                            MessageBox.Show(" • AT LEAST one upper case english letter & one lower case english letter, must contain one digit & one special character & must be Minimum 8 in length • ", "Error <<Password must have>>", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide a valid Phone Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else
                {
                    MessageBox.Show("Please provide valid Email ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please fill up the required fields");
            }

        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void FullName_Enter(object sender, EventArgs e)
        {
            if (FullName.Text == "Full Name")
            {
                FullName.Text = "";
            }     
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.Text = "";
            }
        }

        private void Phone_Enter(object sender, EventArgs e)
        {
            if (Phone.Text == "Phone")
            {
                Phone.Text = "";
            }
        }

        private void Address_Enter(object sender, EventArgs e)
        {
            if (Address.Text == "Address")
            {
                Address.Text = "";
            }
        }

        private void Zip_Enter(object sender, EventArgs e)
        {
            if (Zip.Text == "Zip / Postal")
            {
                Zip.Text = "";
            }
        }

        private void Country_Enter(object sender, EventArgs e)
        {
            if (Country.Text == "Select Country")
            {
                Country.Text = "";
            }
        }

        private void ConfirmPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            
        }

        private void City_Enter(object sender, EventArgs e)
        {
            if (City.Text == "City")
            {
                City.Text = "";
            }
        }

        private void AgreeCheckBox_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
