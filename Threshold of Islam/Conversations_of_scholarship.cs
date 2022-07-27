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
    public partial class Conversations_of_scholarship : Form
    {
        private Form currentChildForm = null;
        public Conversations_of_scholarship()
        {
            InitializeComponent();
            
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
            panelComversation.Controls.Add(childForm);
            panelComversation.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Zakir_Naiik_lecture());
            this.iconButton1.BackColor = Color.ForestGreen;
            this.panel3.BackColor = Color.ForestGreen;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ismail_ibn_Musa_Menk());
            this.iconButton2.BackColor = Color.DarkOliveGreen;
            this.panel3.BackColor = Color.DarkOliveGreen;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Mizanur_Rahman_Azhari());
            this.iconButton3.BackColor = Color.Brown;
            this.panel3.BackColor = Color.Brown;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f5 = new HomePage();
            f5.Show();
        }
    }
}
