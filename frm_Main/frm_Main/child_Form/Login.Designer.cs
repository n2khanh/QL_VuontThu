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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btSee);
            this.groupBox1.Controls.Add(this.btSingUpLogin);
            this.groupBox1.Controls.Add(this.lLbForgot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btSingInLogin);
            this.groupBox1.Controls.Add(this.txtPasswordLogin);
            this.groupBox1.Controls.Add(this.txtUserNameLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(287, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btSee
            // 
            this.btSee.Location = new System.Drawing.Point(183, 147);
            this.btSee.Name = "btSee";
            this.btSee.Size = new System.Drawing.Size(30, 20);
            this.btSee.TabIndex = 13;
            this.btSee.UseVisualStyleBackColor = true;
            // 
            // btSingUpLogin
            // 
            this.btSingUpLogin.BackColor = System.Drawing.Color.Green;
            this.btSingUpLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSingUpLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSingUpLogin.Location = new System.Drawing.Point(134, 191);
            this.btSingUpLogin.Name = "btSingUpLogin";
            this.btSingUpLogin.Size = new System.Drawing.Size(80, 30);
            this.btSingUpLogin.TabIndex = 12;
            this.btSingUpLogin.Text = "Sign Up";
            this.btSingUpLogin.UseVisualStyleBackColor = false;
            // 
            // lLbForgot
            // 
            this.lLbForgot.AutoSize = true;
            this.lLbForgot.LinkColor = System.Drawing.Color.Black;
            this.lLbForgot.Location = new System.Drawing.Point(76, 241);
            this.lLbForgot.Name = "lLbForgot";
            this.lLbForgot.Size = new System.Drawing.Size(92, 13);
            this.lLbForgot.TabIndex = 9;
            this.lLbForgot.TabStop = true;
            this.lLbForgot.Text = "Forgot Password?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // btSingInLogin
            // 
            this.btSingInLogin.BackColor = System.Drawing.Color.Green;
            this.btSingInLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSingInLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSingInLogin.Location = new System.Drawing.Point(34, 191);
            this.btSingInLogin.Name = "btSingInLogin";
            this.btSingInLogin.Size = new System.Drawing.Size(80, 30);
            this.btSingInLogin.TabIndex = 4;
            this.btSingInLogin.Text = "Sign In";
            this.btSingInLogin.UseVisualStyleBackColor = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(34, 147);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(150, 20);
            this.txtPasswordLogin.TabIndex = 3;
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserNameLogin.Location = new System.Drawing.Point(34, 101);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(180, 20);
            this.txtUserNameLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 356);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

    }
}