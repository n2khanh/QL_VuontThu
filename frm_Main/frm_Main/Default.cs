using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frm_Main.child_Form;


namespace frm_Main
{
    public partial class Default : Form
    {
        Form currentChildForm;
        public Default()
        {
            InitializeComponent();
            timer1.Start();
            label5.Text = DateTime.Now.ToString("hh:mm:ss");
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanSu());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.google.com") { UseShellExecute = true });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes) { Application.Exit(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void Default_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { Application.Exit(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null) { currentChildForm.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Animal());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Warehouse());
        }

        private void Default_Load(object sender, EventArgs e)
        {

        }
    }
}
