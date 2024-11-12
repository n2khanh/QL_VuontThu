using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Main.child_Form
{
    public partial class Animal : Form

    {
        Form currentChildForm;
        public Animal()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form a)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = a;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(currentChildForm);
            panel1.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Area());
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cagee());
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLíThúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new List_Animal());
        }

        private void quảnLíSựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Event());
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null) {currentChildForm.Close();}
        }
    }
}
