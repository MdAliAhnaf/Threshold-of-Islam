using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;

namespace Threshold_of_Islam
{
    
    public partial class PasswordRecoveryCode : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["gg"].ConnectionString;
        string randomcode;
        public static string to;
        public bool x = false;
        public PasswordRecoveryCode()
        {
            InitializeComponent();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f3 = new HomePage();
            f3.Show();
        }

        private void SendCode_Click(object sender, EventArgs e)
        {



            if (Usermail.Text != "")
            {
                string from, pass, messagebody;
                Random rand = new Random(); //generate random
                randomcode = (rand.Next(9999999)).ToString(); //generate 7 digit
                MailMessage message = new MailMessage(); //created message object from MailMessage built in class
                to = (Usermail.Text).ToString(); // mail to the user email

                SqlConnection con = new SqlConnection(cs); // con is the connection object
                SqlCommand cmd = new SqlCommand("select *FROM SignUp_User WHERE Email COLLATE Latin1_general_CS_AS = Email", con);
                con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    int i = 0;
                    SmtpClient smtp = new SmtpClient("smtp.office365.com"); //create smtp client
                    while (i < dt.Rows.Count)
                    {
                        if (to == dt.Rows[i]["Email"].ToString())
                        {
                            from = "gg_coder@hotmail.com"; //sending mail to user through me
                            pass = "GGwp1234"; //my email password
                            messagebody = $"          Threshold of Islam\n Your Reset Code is {randomcode}";
                            message.To.Add(to); // mail to user email 

                            message.From = new MailAddress(from); //from to To
                            message.Body = messagebody;
                            message.Subject = "Password Reset Code <<Threshold of Islam>>";
                            /*SmtpClient smtp = new SmtpClient("smtp.office365.com"); //create smtp client*/
                            smtp.EnableSsl = true; // ssl certificate true
                            smtp.Port = 587; //sending mail through 587 port
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);
                            try
                            {
                                x = false;
                                /*smtp.Send(message);//send message
                                MessageBox.Show("Code has been send Successfully");*/
                            }
                            catch (Exception ex)
                            {
                                x = false;
                                MessageBox.Show(ex.Message); //will show exception
                            }
                            break;

                        }
                        else
                        {
                            x = true;
                            //MessageBox.Show("Email doesn't exists");
                        }
                        i++;


                    }
                    try
                    {
                        if (x == false)
                        {
                            
                            smtp.Send(message);//send message
                            MessageBox.Show("Code has been send Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }

                        else if (x == true)
                        {
                            MessageBox.Show("Email doesn't exist", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (x == false)
                        {

                            MessageBox.Show(ex.Message); //will show exception

                        }

                        else if (x == true)
                        {
                            MessageBox.Show(ex.Message); //will show exception
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No Email exists in the Database-_-");
                }

            }

            else
            {
                MessageBox.Show("Failed, Fill up the field", "Enter valid information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            if (randomcode == (VerifyCode.Text).ToString())
            {
                to = Usermail.Text;
                MessageBox.Show("Your code is successfully verified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ResetPassword rp = new ResetPassword();
                rp.Show();

            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }
    }
}
