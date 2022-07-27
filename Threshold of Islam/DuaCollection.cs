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
    public partial class DuaCollection : Form
    {
        private Form currentChildForm=null;
        public DuaCollection()
        {
            InitializeComponent();
            customizeDesigning();
            
        }
        private void customizeDesigning()
        {
            PanelMorning.Visible = false;
            panelHajj.Visible = false;
            panelPrayer.Visible = false;
            panelTravel.Visible = false;
        }
        private void hideSubMenu() //hide the submenu
        {
            if(PanelMorning.Visible==true)
            {
                PanelMorning.Visible = false;
            }
            if (panelHajj.Visible == true)
            {
                panelHajj.Visible = false;
            }
            if (panelPrayer.Visible == true)
            {
                panelPrayer.Visible = false;
            }
            if (panelTravel.Visible == true)
            {
                panelTravel.Visible = false;
            }

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelMorning);
            this.iconButton1.BackColor = Color.ForestGreen;
            this.panel2.BackColor = Color.ForestGreen;
            
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Before_Sleeping());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new When_Woke_Up());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Morning_Evening_Dua());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Protection_from_Allah());
            hideSubMenu();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHajj);
            this.iconButton4.BackColor = Color.LightBlue;
            this.panel2.BackColor = Color.LightBlue;
            
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelPrayer);
            this.iconButton2.BackColor = Color.Crimson;
            this.panel2.BackColor = Color.Crimson;
            
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelTravel);
            this.iconButton3.BackColor = Color.MediumSlateBlue;
            this.panel2.BackColor = Color.MediumSeaGreen;
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Mosque());
            hideSubMenu();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new After_Prayer());
            hideSubMenu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Hearing_Athan());
            hideSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Tashahhud());
            hideSubMenu();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Travel());
            hideSubMenu();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Return());
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Market());
            hideSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Lodging());
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Talbiya());
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Arafah());
            hideSubMenu();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Safa_Marwah());
            hideSubMenu();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Rabbana());
            hideSubMenu();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f6 = new HomePage();
            f6.Show();
        }
    }
}
