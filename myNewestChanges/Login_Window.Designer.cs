﻿namespace Login_Window
{
    partial class Login_Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Window));
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txb_userName = new System.Windows.Forms.TextBox();
            this.txb_passWord = new System.Windows.Forms.TextBox();
            this.cbx_remeberMe = new System.Windows.Forms.CheckBox();
            this.lnk_forgotPassword = new System.Windows.Forms.LinkLabel();
            this.lbl_softwareName = new System.Windows.Forms.Label();
            this.cbx_showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // lbl_userName
            // 
            resources.ApplyResources(this.lbl_userName, "lbl_userName");
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_password
            // 
            resources.ApplyResources(this.lbl_password, "lbl_password");
            this.lbl_password.Name = "lbl_password";
            // 
            // txb_userName
            // 
            resources.ApplyResources(this.txb_userName, "txb_userName");
            this.txb_userName.Name = "txb_userName";
            this.txb_userName.TextChanged += new System.EventHandler(this.txb_userName_TextChanged);
            // 
            // txb_passWord
            // 
            resources.ApplyResources(this.txb_passWord, "txb_passWord");
            this.txb_passWord.Name = "txb_passWord";
            this.txb_passWord.UseSystemPasswordChar = true;
            this.txb_passWord.TextChanged += new System.EventHandler(this.txb_passWord_TextChanged);
            // 
            // cbx_remeberMe
            // 
            resources.ApplyResources(this.cbx_remeberMe, "cbx_remeberMe");
            this.cbx_remeberMe.Name = "cbx_remeberMe";
            this.cbx_remeberMe.UseVisualStyleBackColor = true;
            this.cbx_remeberMe.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lnk_forgotPassword
            // 
            resources.ApplyResources(this.lnk_forgotPassword, "lnk_forgotPassword");
            this.lnk_forgotPassword.Name = "lnk_forgotPassword";
            this.lnk_forgotPassword.TabStop = true;
            // 
            // lbl_softwareName
            // 
            resources.ApplyResources(this.lbl_softwareName, "lbl_softwareName");
            this.lbl_softwareName.Name = "lbl_softwareName";
            // 
            // cbx_showPassword
            // 
            resources.ApplyResources(this.cbx_showPassword, "cbx_showPassword");
            this.cbx_showPassword.Name = "cbx_showPassword";
            this.cbx_showPassword.UseVisualStyleBackColor = true;
            // 
            // Login_Window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbx_showPassword);
            this.Controls.Add(this.lbl_softwareName);
            this.Controls.Add(this.lnk_forgotPassword);
            this.Controls.Add(this.cbx_remeberMe);
            this.Controls.Add(this.txb_passWord);
            this.Controls.Add(this.txb_userName);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.btn_login);
            this.Name = "Login_Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_login;
        private Label lbl_userName;
        private Label lbl_password;
        private TextBox txb_userName;
        private TextBox txb_passWord;
        private CheckBox cbx_remeberMe;
        private LinkLabel lnk_forgotPassword;
        private Label lbl_softwareName;
        private CheckBox cbx_showPassword;
    }
}