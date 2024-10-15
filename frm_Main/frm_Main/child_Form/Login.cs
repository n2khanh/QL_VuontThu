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
            
            Default form = new Default();
            form.Show();
            this.Close();
        }
    }
}
