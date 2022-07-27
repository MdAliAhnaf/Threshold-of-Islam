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

    public partial class AdminPanel : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["gg"].ConnectionString;
        //string x;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            UserList();
        }

        void UserList()
        {

            SqlConnection con = new SqlConnection(cs); //con is the connection object

            string query = "SELECT *  FROM SignUp_User";
            SqlDataAdapter sda = new SqlDataAdapter(query, con); //passing query and con through SqlDataAdapter


            DataTable dt = new DataTable(); //dt datatable object

            sda.Fill(dt); //filling data through sda using Fill method

            UserListDataGridView.DataSource = dt; // In datagrid datasource from dt object of datatable

        }

        private void UserListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void City1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            Email1.Clear();
            FullName1.Clear();
            //DOB1.Clear();
            Phone1.Clear();
            Address1.Clear();
            City1.Clear();
            Zip1.Clear();
            Country1.Clear();
            Password1.Clear();
            /*if (Gender1.Text == "Male")
            {
                Gender1.Text = "";
            }
            else if (Gender1.Text == "Female")
            {
                Gender1.Text = "";
            }*/
        }

        private void DOB1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UserListDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Email1.Text = UserListDataGridView.SelectedRows[0].Cells[0].Value.ToString(); //Cells 0 means first column (textbox is string thats why we are converting the value to string)
            FullName1.Text = UserListDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            DOB1.Text = UserListDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Phone1.Text = UserListDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Address1.Text = UserListDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            City1.Text = UserListDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Zip1.Text = UserListDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            Country1.Text = UserListDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            Password1.Text = UserListDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            Gender1.Text = UserListDataGridView.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs); //con is the connection object
            con.Open(); //open the connection
            string query = "update SignUp_User set FullName = @FullName, DOB = @DOB, Phone = @Phone, Address = @Address, City = @City , Zip = @Zip, Country = @Country, Password = @Password, Gender = @Gender where Email = @Email";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Email", Email1.Text);
            cmd.Parameters.AddWithValue("@FullName", FullName1.Text);
            cmd.Parameters.AddWithValue("@DOB", DOB1.Text);
            cmd.Parameters.AddWithValue("@Phone", Phone1.Text);
            cmd.Parameters.AddWithValue("@Address", Address1.Text);
            cmd.Parameters.AddWithValue("@City", City1.Text);
            cmd.Parameters.AddWithValue("@Zip", Zip1.Text);
            cmd.Parameters.AddWithValue("@Country", Country1.Text);
            cmd.Parameters.AddWithValue("@Password", Password1.Text);
            cmd.Parameters.AddWithValue("@Gender", Gender1.Text);
       
            
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("User Data Updated!");
                UserList();
                ResetControl();
            }
            else
            {
                MessageBox.Show("User Data Update Failed!");
            }
            con.Close();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs); //con is the connection object
            con.Open(); //open the connection 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into SignUp_User(Email, FullName, DOB, Phone, Address, City, Zip, Country, Password, Gender) values('" + Email1.Text + "', '" + FullName1.Text + "', '" + DOB1.Text + "', '" + Phone1.Text + "', '" + Address1.Text + "', '" + City1.Text + "', '" + Zip1.Text + "', '" + Country1.Text + "', '" + Password1.Text + "','" + Gender1.Text + "')";
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("User Data Inserted!");
                UserList();
                ResetControl();
            }
            else
            {
                MessageBox.Show("User Data Insertion Failed!");
            }
            con.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs); //con is the connection object
            con.Open(); //open the connection
            string query = "delete from SignUp_User where Email = @Email";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Email", Email1.Text);
            /*cmd.Parameters.AddWithValue("@FullName", FullName1.Text);
            cmd.Parameters.AddWithValue("@DOB", DOB1.Text);
            cmd.Parameters.AddWithValue("@Phone", Phone1.Text);
            cmd.Parameters.AddWithValue("@Address", Address1.Text);
            cmd.Parameters.AddWithValue("@City", City1.Text);
            cmd.Parameters.AddWithValue("@Zip", Zip1.Text);
            cmd.Parameters.AddWithValue("@Country", Country1.Text);
            cmd.Parameters.AddWithValue("@Password", Password1.Text);
            cmd.Parameters.AddWithValue("@Gender", Gender1.Text);*/

            
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("User Data Deleted Successfully!");
                UserList();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Failed to delete User Data!");
            }
            con.Close();
        }

        private void FullName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserListDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
