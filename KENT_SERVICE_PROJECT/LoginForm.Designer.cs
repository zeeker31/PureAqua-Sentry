namespace KENT_SERVICE_PROJECT
{
    partial class LoginForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgotPwd = new System.Windows.Forms.Button();
            this.btnCreateLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(263, 162);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(215, 26);
            this.txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(263, 214);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(215, 26);
            this.txtpassword.TabIndex = 3;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(221, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(157, 131);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 4;
            this.pictureBoxIcon.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(136, 301);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 66);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForgotPwd
            // 
            this.btnForgotPwd.Location = new System.Drawing.Point(331, 301);
            this.btnForgotPwd.Name = "btnForgotPwd";
            this.btnForgotPwd.Size = new System.Drawing.Size(117, 66);
            this.btnForgotPwd.TabIndex = 6;
            this.btnForgotPwd.Text = "Forgot Password?";
            this.btnForgotPwd.UseVisualStyleBackColor = true;
            this.btnForgotPwd.Click += new System.EventHandler(this.btnForgotPwd_Click);
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Location = new System.Drawing.Point(136, 418);
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.Size = new System.Drawing.Size(312, 66);
            this.btnCreateLogin.TabIndex = 7;
            this.btnCreateLogin.Text = "Don\'t Have An Account? Create Now";
            this.btnCreateLogin.UseVisualStyleBackColor = true;
            this.btnCreateLogin.Click += new System.EventHandler(this.btnCreateLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(619, 652);
            this.Controls.Add(this.btnCreateLogin);
            this.Controls.Add(this.btnForgotPwd);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForgotPwd;
        private System.Windows.Forms.Button btnCreateLogin;
    }
}