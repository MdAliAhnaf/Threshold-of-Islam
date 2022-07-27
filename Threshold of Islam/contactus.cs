using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Threshold_of_Islam
{
    public partial class contactus : Form
    {
        string randomcode;
        public static string to;
        public contactus()
        {
            InitializeComponent();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (enterusername.Text != "")
            {
                if (enteruseremail.Text != "")
                {
                    if (enteruserphone.Text != "")
                    {
                        if (enterusermessage.Text != "")
                        {
                            MailMessage msg = new MailMessage(); //created message object from MailMessage built in class
                            string from, pass, messagebody;

                            string username = enterusername.Text;
                            string enterusermail = enteruseremail.Text;
                            string userphone = enteruserphone.Text;
                            string usermessage = enterusermessage.Text;
                            to = "gg_coder@hotmail.com"; // mail to the admin email
                            from = "threshofislam_supp0rt@hotmail.com"; //support mail 
                            pass = "GGwpSupport"; //support mail password
                            messagebody = $"     <<<<<Threshold of Islam>>>>>\n User name: {username}\n User Email: {enterusermail}\n User Phone Number: {userphone}\n User Message:\n\n {usermessage}";

                            msg.To.Add(to); // mail to admin email
                            msg.From = new MailAddress(from);
                            msg.Body = messagebody;
                            msg.Subject = "User Feedback & Reports";
                            SmtpClient smtp = new SmtpClient("smtp.office365.com");
                            smtp.EnableSsl = true; // ssl certificate true
                            smtp.Port = 587; //sending mail through 587 port
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);
                            try
                            {
                                smtp.Send(msg);//send message
                                MessageBox.Show("Message has been send Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message); //will show exception
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your Message cannot be blank", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter your phone number", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Please enter your mail", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter your Name", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}


