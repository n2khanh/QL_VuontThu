using frm_Main.LOG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Main.child_Form
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, "^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void button4_Click(object sender, EventArgs e)
        {
            string tentk = txtUserNameSingUp.Text;
            string matkhau = txtPasswordSingUp.Text;
            string xnmatkhau = txtConfirmPasswordSingUp.Text;
            string email = txtEmailSingUp.Text;
            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (xnmatkhau!= matkhau) { MessageBox.Show("Vui lòng nhập xác nhận mật khẩu chính xác!"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if(modify.TaiKhoans("Select * from Account where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác!"); return;
            }

            try
            {
                string query = "Insert into Account values ('" + tentk + "','" + matkhau + "', '" + email + "')";
                modify.Command(query);
                MessageBox.Show("Chúc mừng bạn đăng kí thành công !", "Thông Báo", MessageBoxButtons.OK);
                this.Close();
                txtUserNameSingUp.Text = "";
                txtPasswordSingUp.Text = "";
                txtConfirmPasswordSingUp.Text = "";
                txtEmailSingUp.Text = "";
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
            }
            
        }

        private void SingUp_Load_1(object sender, EventArgs e)
        {

        }
    }
}
