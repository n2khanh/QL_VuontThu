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

        private void btSingInLogin_Click(object sender, EventArgs e)
        {           
            this.Visible = false;
            frm_defaults = new Default();
            frm_defaults.Show();
            
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
