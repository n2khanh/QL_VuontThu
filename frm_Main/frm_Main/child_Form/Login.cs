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
    public partial class Login : Form
    {
        Form frm_defaults;
        Form frm_sigup;
        Form frm_QMK;
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btSee_Click(object sender, EventArgs e)
        {
            txtPasswordLogin.PasswordChar = '\0';
            button1.Visible = true;
            txtPasswordLogin.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPasswordLogin.PasswordChar = '*';
            btSee.Visible  = true;
            button1.Visible = false;
            txtPasswordLogin.Focus();
        }
        Modify modify = new Modify();
        private void btSingInLogin_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //frm_defaults = new Default();
            //frm_defaults.Show();
            string tentk = txtUserNameLogin.Text;
            string matkhau = txtPasswordLogin.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    frm_defaults = new Default();
                    frm_defaults.Show();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khấu không chính xác!" ,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btSingUpLogin_Click(object sender, EventArgs e)
        {
            frm_sigup = new SingUp();
            frm_sigup.ShowDialog();
        }

        private void lLbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_QMK = new ForgotPassword();
            frm_QMK.ShowDialog();
        }
    }
}
