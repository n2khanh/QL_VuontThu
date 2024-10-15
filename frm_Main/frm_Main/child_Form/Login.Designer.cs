using System;
using System.Drawing;
using System.Windows.Forms;

namespace frm_Main.child_Form
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSee = new System.Windows.Forms.Button();
            this.btSingUpLogin = new System.Windows.Forms.Button();
            this.lLbForgot = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSingInLogin = new System.Windows.Forms.Button();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUserNameLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btSee);
            this.groupBox1.Controls.Add(this.btSingUpLogin);
            this.groupBox1.Controls.Add(this.lLbForgot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btSingInLogin);
            this.groupBox1.Controls.Add(this.txtPasswordLogin);
            this.groupBox1.Controls.Add(this.txtUserNameLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(383, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(328, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btSee
            // 
            this.btSee.Image = ((System.Drawing.Image)(resources.GetObject("btSee.Image")));
            this.btSee.Location = new System.Drawing.Point(246, 181);
            this.btSee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSee.Name = "btSee";
            this.btSee.Size = new System.Drawing.Size(40, 25);
            this.btSee.TabIndex = 13;
            this.btSee.UseVisualStyleBackColor = true;
            this.btSee.Click += new System.EventHandler(this.btSee_Click);
            // 
            // btSingUpLogin
            // 
            this.btSingUpLogin.BackColor = System.Drawing.Color.Green;
            this.btSingUpLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSingUpLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSingUpLogin.Location = new System.Drawing.Point(179, 235);
            this.btSingUpLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSingUpLogin.Name = "btSingUpLogin";
            this.btSingUpLogin.Size = new System.Drawing.Size(107, 37);
            this.btSingUpLogin.TabIndex = 12;
            this.btSingUpLogin.Text = "Sign Up";
            this.btSingUpLogin.UseVisualStyleBackColor = false;
            // 
            // lLbForgot
            // 
            this.lLbForgot.AutoSize = true;
            this.lLbForgot.LinkColor = System.Drawing.Color.Black;
            this.lLbForgot.Location = new System.Drawing.Point(101, 297);
            this.lLbForgot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLbForgot.Name = "lLbForgot";
            this.lLbForgot.Size = new System.Drawing.Size(116, 16);
            this.lLbForgot.TabIndex = 9;
            this.lLbForgot.TabStop = true;
            this.lLbForgot.Text = "Forgot Password?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // btSingInLogin
            // 
            this.btSingInLogin.BackColor = System.Drawing.Color.Green;
            this.btSingInLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSingInLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSingInLogin.Location = new System.Drawing.Point(45, 235);
            this.btSingInLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSingInLogin.Name = "btSingInLogin";
            this.btSingInLogin.Size = new System.Drawing.Size(107, 37);
            this.btSingInLogin.TabIndex = 4;
            this.btSingInLogin.Text = "Sign In";
            this.btSingInLogin.UseVisualStyleBackColor = false;
            this.btSingInLogin.Click += new System.EventHandler(this.btSingInLogin_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(45, 181);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(199, 22);
            this.txtPasswordLogin.TabIndex = 3;
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserNameLogin.Location = new System.Drawing.Point(45, 124);
            this.txtUserNameLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(239, 22);
            this.txtUserNameLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(246, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 25);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button btSingInLogin;
        private TextBox txtPasswordLogin;
        private TextBox txtUserNameLogin;
        private LinkLabel lLbForgot;
        private Button btSingUpLogin;
        private Button btSee;
        private Button button1;
        private PictureBox pictureBox1;
    }
}