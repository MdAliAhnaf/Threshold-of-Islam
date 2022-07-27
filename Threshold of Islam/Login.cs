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
using System.Configuration;
using System.Data.SqlClient;

namespace Threshold_of_Islam
{
    
    public partial class Login : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["gg"].ConnectionString;
        public static string FN;
        public static string DB;
        public static string EL;
        public static string PL;
        public static string AL;
        public static string ZL;
        public static string CL;
        public static string CTL;
        public static string GL;
        //public static Image dp;

        public static string pass;
        public Login()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount f2 = new CreateAccount();
            f2.Show();
        }

        private void pictureBoxHidePass_MouseClick(object sender, MouseEventArgs e)
        {
            textpasslog.UseSystemPasswordChar = false;
            pictureBoxHidePass.Visible = false;
            pictureBoxShowPass.Visible = true;
        }

        private void pictureBoxShowPass_MouseClick(object sender, MouseEventArgs e)
        {
            textpasslog.UseSystemPasswordChar = true;
            pictureBoxHidePass.Visible = true;
            pictureBoxShowPass.Visible = false;
        }

        private void textpasslog_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxHidePass.Visible = true;
            textpasslog.UseSystemPasswordChar = true;
        }

        private void textEmaillog_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxHidePass.Visible = false;
            pictureBoxShowPass.Visible = false;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            textEmailAdmin.Visible = false;
            textpassAdmin.Visible = false;
            ButtonAdminLogin.Visible = false;
            textEmaillog.Visible = true;
            textpasslog.Visible = true;
            ButtonUserLogin.Visible = true;
            label1.Visible = true;
            ForgotPassword.Visible = true;
            ButtonCNA.Visible = true;
            panelU.Visible = true;
            panelA.Visible = false;
            pictureBoxHidePassAd.Visible = false;
            pictureBoxShowPassAd.Visible = false;
            pictureBoxHidePass.Visible = false;
            pictureBoxShowPass.Visible = false;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            textEmailAdmin.Visible = true;
            textpassAdmin.Visible = true;
            ButtonAdminLogin.Visible = true;
            textEmaillog.Visible = false;
            textpasslog.Visible = false;
            ButtonUserLogin.Visible = false;
            label1.Visible = false;
            ForgotPassword.Visible = false;
            ButtonCNA.Visible = false;
            panelU.Visible = false;
            panelA.Visible = true;
            pictureBoxHidePassAd.Visible = false;
            pictureBoxShowPassAd.Visible = false;
            pictureBoxHidePass.Visible = false;
            pictureBoxShowPass.Visible = false;
        }

        private void pictureBoxHidePassAd_MouseClick(object sender, MouseEventArgs e)
        {
            textpasslog.UseSystemPasswordChar = false;
            pictureBoxShowPassAd.Visible = false;
            pictureBoxHidePassAd.Visible = true;
        }

        private void textpassAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxHidePass.Visible = true;
            textpasslog.UseSystemPasswordChar = true;
        }

        private void ButtonAdminLogin_Click(object sender, EventArgs e)
        {
            if (textEmailAdmin.Text == "gg_coder@hotmail.com" && textpassAdmin.Text== "GGwp1234")
            {
                this.Hide();
                AdminPanel f99 = new AdminPanel();
                f99.Show();
            }
            else
            {
                MessageBox.Show("Log in failed, doesn't match Admin email or Password", "Enter valid information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonUserLogin_Click(object sender, EventArgs e) //user
        {
            if (textEmaillog.Text != "" && textpasslog.Text != "")
            {
                SqlConnection con = new SqlConnection(cs); // con is the connection object

                SqlCommand cmd = new SqlCommand("select *FROM SignUp_User WHERE Email COLLATE Latin1_general_CS_AS = @Email  and Password COLLATE Latin1_general_CS_AS =@Password  ", con);

                con.Open();
                cmd.Parameters.Add(new SqlParameter("Email ", textEmaillog.Text));
                cmd.Parameters.Add(new SqlParameter("Password ", textpasslog.Text));

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FN = dt.Rows[0]["FullName"].ToString();
                    DB = dt.Rows[0]["DOB"].ToString();
                    EL = dt.Rows[0]["Email"].ToString();
                    PL = dt.Rows[0]["Phone"].ToString();
                    AL = dt.Rows[0]["Address"].ToString();
                    ZL = dt.Rows[0]["Zip"].ToString();
                    CL = dt.Rows[0]["Country"].ToString();
                    CTL = dt.Rows[0]["City"].ToString();
                    GL = dt.Rows[0]["Gender"].ToString();
                    //dp = getPhoto((byte[])dt.Rows[0]["Picture"]);
                    // pass = dt.Rows[0]["SetPass"].ToString();
                    this.Hide();
                    HomePage f3 = new HomePage();
                    f3.Show();
                    
                }
                else
                {
                    MessageBox.Show("Log in failed, doesn't match Email or Password", "Enter valid information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else { MessageBox.Show("Please insert your email or Password"); }
        }


        private void pictureBoxShowPassAd_Click(object sender, EventArgs e)
        {

        }

        private void panelU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxHidePass_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxShowPass_Click(object sender, EventArgs e)
        {

        }

        private void textpassAdmin_MouseClick_1(object sender, MouseEventArgs e)
        {
            pictureBoxHidePassAd.Visible = true;
            textpassAdmin.UseSystemPasswordChar = true;
        }

        private void textEmailAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxHidePassAd.Visible = false;
            pictureBoxShowPassAd.Visible = false;
        }

        private void pictureBoxShowPassAd_MouseClick(object sender, MouseEventArgs e)
        {
            textpassAdmin.UseSystemPasswordChar = true;
            pictureBoxHidePassAd.Visible = true;
            pictureBoxShowPassAd.Visible = false;
        }

        private void pictureBoxHidePassAd_MouseClick_1(object sender, MouseEventArgs e)
        {
            textpassAdmin.UseSystemPasswordChar = false;
            pictureBoxHidePassAd.Visible = false;
            pictureBoxShowPassAd.Visible = true;
        }

        private void textpassAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordRecoveryCode f97 = new PasswordRecoveryCode();
            f97.Show();

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            about ab = new about();
            ab.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/RPhn6C2ZQs");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/ahnafggwp/");
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCdykLcNSRzzKSTGov7vViWQ/"); 
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MdAliAhnaf");
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/MdAliAhnaf/");
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactus cu = new contactus();
            cu.Show();
        }
    }
}
