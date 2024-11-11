using frm_Main.LOG;
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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btSingInLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = "Password: " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Email này chưa được đăng ký";
                }
            }
            //MessageBox.Show("Vui lòng kiểm tra email của bạn và làm theo hướng dẫn ! ", "Thông Báo" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
