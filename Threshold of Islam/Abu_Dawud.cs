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
    public partial class Abu_Dawud : Form
    {
        private Form currentChildForm = null;
        public Abu_Dawud()
        {
            InitializeComponent();
            customizeDesigning();
        }
        private void customizeDesigning()
        {
            panelZakat.Visible = false;
            panelHajj.Visible = false;
            panelJihad.Visible = false;

        }
        private void hideSubMenu() //hide the submenu
        {
            if (panelZakat.Visible == true)
            {
                panelZakat.Visible = false;
            }
            if (panelHajj.Visible == true)
            {
                panelHajj.Visible = false;
            }
            if (panelJihad.Visible == true)
            {
                panelJihad.Visible = false;
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
            panel9.Controls.Add(childForm);
            panel9.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelZakat);
            this.iconButton1.BackColor = Color.Indigo;
            this.panel3.BackColor = Color.Indigo;
            this.panel4.BackColor = Color.Indigo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1556());
            NextButton.Visible = true;
            Prev2.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            Next3.Visible = false;
            Next4.Visible = false;
            Next_57.Visible = false;
            Next_58.Visible = false;

            Prev3.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;

            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1568());
            PrevButton.Visible = true;
            next2.Visible = true;
            NextButton.Visible = false;
            Prev2.Visible = false;


            Next3.Visible = false;
            Next4.Visible = false;
            Next_57.Visible = false;
            Next_58.Visible = false;

            Prev3.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1574());

            Prev2.Visible = true;
            PrevButton.Visible = false;
            next2.Visible = false;
            NextButton.Visible = false;



            Next3.Visible = false;
            Next4.Visible = false;
            Next_57.Visible = false;
            Next_58.Visible = false;

            Prev3.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;
            hideSubMenu();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1574());
            Prev2.Visible = true;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;
            Next3.Visible = false;
            Next4.Visible = false;
            Next_57.Visible = false;
            Next_58.Visible = false;

            Prev3.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1568());
            next2.Visible = true;
            PrevButton.Visible = true;
            NextButton.Visible = false;
            Next3.Visible = false;
            Next4.Visible = false;
            Next_57.Visible = false;
            Next_58.Visible = false;
            Prev2.Visible = false;
            Prev3.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;

        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1556());
            NextButton.Visible = true;
            Prev2.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;

            Next3.Visible = false;
            Next4.Visible = false;
            Next_57.Visible = false;
            Next_58.Visible = false;

            Prev3.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;
        }

        private void Prev2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1568());
            PrevButton.Visible = true;
            next2.Visible = true;
            NextButton.Visible = false;
            Prev2.Visible = false;


            Next3.Visible = false;
            Next4.Visible = false;
            Next_57.Visible = false;
            Next_58.Visible = false;

            Prev3.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;
        }

        private void Prev_56_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_2482());
            Next_57.Visible = true;
            Prev_57.Visible = false;
            Next_58.Visible = false;
            Prev_56.Visible = false;

            Prev4.Visible = false;
            Prev3.Visible = false;
            Next4.Visible = false;
            Next3.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;
            Prev2.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHajj);
            this.iconButton2.BackColor = Color.Brown;
            this.panel3.BackColor = Color.Brown;
            this.panel4.BackColor = Color.Brown;
        }

        private void Prev4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1740());
            Prev3.Visible = true;
            Next4.Visible = true;
            Next3.Visible = false;
            Prev4.Visible = false;


            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;


            Next_57.Visible = false;
            Next_58.Visible = false;
            Prev2.Visible = false;

            Prev_56.Visible = false;
            Prev_57.Visible = false;
        }

        private void Prev3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1729());
            Next3.Visible = true;
            Prev4.Visible = false;
            Next4.Visible = false;
            Prev3.Visible = false;

            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;


            Next_57.Visible = false;
            Next_58.Visible = false;
            Prev2.Visible = false;

            Prev_56.Visible = false;
            Prev_57.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1729());
            Next3.Visible = true;
            Next4.Visible = false;
            Prev3.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;

            Next_58.Visible = false;
            Prev2.Visible = false;
            Next_57.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;

            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1740());
            Prev3.Visible = true;
            Next4.Visible = true;
            Next3.Visible = false;


            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;

            Next_58.Visible = false;
            Prev2.Visible = false;
            Next_57.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1768());

            Prev4.Visible = true;
            Prev3.Visible = false;
            Next4.Visible = false;
            Next3.Visible = false;


            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;

            Next_58.Visible = false;
            Prev2.Visible = false;
            Next_57.Visible = false;

            Prev_56.Visible = false;
            Prev_57.Visible = false;
            hideSubMenu();
        }

        private void Next3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1740());
            Next4.Visible = true;
            Prev3.Visible = true;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;
            Next3.Visible = false;
            Next_58.Visible = false;
            Prev2.Visible = false;
            Next_57.Visible = false;
            Prev4.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;
        }

        private void Next4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_1768());
            Prev4.Visible = true;
            Next4.Visible = false;
            Prev3.Visible = false;
            Next3.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;


            Next_57.Visible = false;
            Next_58.Visible = false;
            Prev2.Visible = false;

            Prev_56.Visible = false;
            Prev_57.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelJihad);
            this.iconButton3.BackColor = Color.DarkKhaki;
            this.panel3.BackColor = Color.DarkKhaki;
            this.panel4.BackColor = Color.DarkKhaki;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_2482());
            Next_57.Visible = true;
            Prev4.Visible = false;
            Prev3.Visible = false;
            Next4.Visible = false;
            Next3.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;
            Next_58.Visible = false;
            Prev2.Visible = false;
            Prev_56.Visible = false;
            Prev_57.Visible = false;
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_2506());
            Prev_56.Visible = true;
            Next_58.Visible = true;
            Next_57.Visible = false;
            Prev4.Visible = false;
            Prev3.Visible = false;
            Next4.Visible = false;
            Next3.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;
            Prev2.Visible = false;
            Prev_57.Visible = false;
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_2507());

            Prev_57.Visible = true;
            Prev_56.Visible = false;
            Next_58.Visible = false;
            Next_57.Visible = false;
            Prev4.Visible = false;
            Prev3.Visible = false;
            Next4.Visible = false;
            Next3.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;
            Prev2.Visible = false;

            hideSubMenu();
        }

        private void Next_57_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_2506());
            Next_58.Visible = true;
            Prev_56.Visible = true;
            Prev_57.Visible = false;
            Next_57.Visible = false;
            Prev4.Visible = false;
            Prev3.Visible = false;
            Next4.Visible = false;
            Next3.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;
            Prev2.Visible = false;
        }

        private void Next_58_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_2507());
            Prev_57.Visible = true;
            Next_58.Visible = false;
            Prev_56.Visible = false;
            Next_57.Visible = false;
            Prev4.Visible = false;
            Prev3.Visible = false;
            Next4.Visible = false;
            Next3.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;
            Prev2.Visible = false;
        }

        private void Prev_57_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dawud_Hadith_2506());
            Prev_56.Visible = true;
            Next_58.Visible = true;
            Next_57.Visible = false;
            Prev_57.Visible = false;
            Prev4.Visible = false;
            Prev3.Visible = false;
            Next4.Visible = false;
            Next3.Visible = false;
            next2.Visible = false;
            PrevButton.Visible = false;
            NextButton.Visible = false;
            Prev2.Visible = false;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hadith_Collection f14 = new Hadith_Collection();
            f14.Show();
        }
    }
}
