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
    public partial class Muslim : Form
    {
        private Form currentChildForm = null;
        public Muslim()
        {
            InitializeComponent();
            customizeDesigning();
        }
        private void customizeDesigning()
        {
            panelFaith.Visible = false;
            panelPurification.Visible = false;
            panelPrayer.Visible = false;

        }
        private void hideSubMenu() //hide the submenu
        {
            if (panelFaith.Visible == true)
            {
                panelFaith.Visible = false;
            }
            if (panelPurification.Visible == true)
            {
                panelPurification.Visible = false;
            }
            if (panelPrayer.Visible == true)
            {
                panelPrayer.Visible = false;
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
            showSubMenu(panelFaith);
            this.iconButton1.BackColor = Color.Black;
            this.panel3.BackColor = Color.Black;
            this.panel4.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadish_2());
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
            OpenChildForm(new Muslim_Hadith_5());
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
            
            OpenChildForm(new Muslim_Hadith_10());
            
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

        private void NextButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadith_5());
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
            Prev_56.Visible =false;
            Prev_57.Visible = false;

        }

        private void next2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadith_10());
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

        private void PrevButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadish_2());
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
            OpenChildForm(new Muslim_Hadith_5());
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

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hadith_Collection f13 = new Hadith_Collection();
            f13.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPurification);
            this.iconButton2.BackColor = Color.DarkOliveGreen;
            this.panel3.BackColor = Color.DarkOliveGreen;
            this.panel4.BackColor = Color.DarkOliveGreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadith_0432());
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
            OpenChildForm(new Muslim_Hadith_0433());
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
            OpenChildForm(new Muslim_Hadith_0435());
            
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
            OpenChildForm(new Muslim_Hadith_0433());
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
            OpenChildForm(new Muslim_Hadith_0435());
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

        private void Prev3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadith_0432());
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

        private void Prev4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadith_0433());
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

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadith_No_735());
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
            OpenChildForm(new Muslim_Hadith_No_0736());
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
            OpenChildForm(new Muslim_Hadith_No_0740());
            
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
            OpenChildForm(new Muslim_Hadith_No_0736());
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
            OpenChildForm(new Muslim_Hadith_No_0740());
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

        private void Prev_56_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadith_No_735());
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

        private void Prev_57_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Muslim_Hadith_No_0736());
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

        private void iconButton3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPrayer);
            this.iconButton3.BackColor = Color.Red;
            this.panel3.BackColor = Color.Red;
            this.panel4.BackColor = Color.Red;
        }
    }
}
