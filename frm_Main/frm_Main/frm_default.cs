using frm_Main.child_Form;
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


namespace frm_Main
{
    public partial class frm_default : Form
    {
        Form childForm;
        public frm_default()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form a)
        {
            if (childForm != null) { childForm.Close(); }
            childForm = a;
            childForm.TopLevel = false;
            panel2.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();        
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {this.Close(); }
        }

        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (childForm != null)
            {
                childForm.Close();
            }
        }

        private void bunifuPictureBox9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Home());
        }

        private void bunifuPictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.facebook.com/profile.php?id=100021529632707&locale=vi_VN") { UseShellExecute = true });
        }
    }
}
