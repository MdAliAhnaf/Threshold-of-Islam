using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Threshold_of_Islam
{
    public partial class ResetPassword : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["gg"].ConnectionString;
        string useremail = PasswordRecoveryCode.to; //stored (user mail)-which consist verfied mail code to string useremail
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            string patternpassword = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            string passwordd = ConfirmPassword.Text;
            if (Regex.IsMatch(passwordd, patternpassword)) //validation of password
            {
                if (NewPassword.Text == passwordd)
                {
                    SqlConnection con = new SqlConnection(cs); //con is the connection object
                    con.Open(); //open the connection
                    string query = "update SignUp_User set Password = @Password where Email = @Email";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Email", useremail);
                    cmd.Parameters.AddWithValue("@Password", passwordd);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Password changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Login f1 = new Login();
                    f1.Show();

                }

                else
                {
                    MessageBox.Show("Password doesn't match");
                }
            }
            else
            {
                MessageBox.Show(" • AT LEAST one upper case english letter & one lower case english letter, must contain one digit & one special character & must be Minimum 8 in length • ", "Error <<Password must have>>", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
