namespace auth_example
{
    partial class Form1
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
            this.usernametb = new System.Windows.Forms.TextBox();
            this.licensetb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.all_in_onebtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.upgradebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(12, 56);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(295, 23);
            this.usernametb.TabIndex = 0;
            this.usernametb.Text = "username";
            // 
            // licensetb
            // 
            this.licensetb.Location = new System.Drawing.Point(12, 143);
            this.licensetb.Name = "licensetb";
            this.licensetb.Size = new System.Drawing.Size(295, 23);
            this.licensetb.TabIndex = 1;
            this.licensetb.Text = "license";
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(12, 114);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(295, 23);
            this.passwordtb.TabIndex = 2;
            this.passwordtb.Text = "password";
            this.passwordtb.UseSystemPasswordChar = true;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(12, 85);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(295, 23);
            this.emailtb.TabIndex = 3;
            this.emailtb.Text = "email";
            // 
            // all_in_onebtn
            // 
            this.all_in_onebtn.Location = new System.Drawing.Point(12, 231);
            this.all_in_onebtn.Name = "all_in_onebtn";
            this.all_in_onebtn.Size = new System.Drawing.Size(295, 23);
            this.all_in_onebtn.TabIndex = 4;
            this.all_in_onebtn.Text = "License";
            this.all_in_onebtn.UseVisualStyleBackColor = true;
            this.all_in_onebtn.Click += new System.EventHandler(this.all_in_onebtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(12, 202);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(295, 23);
            this.registerbtn.TabIndex = 5;
            this.registerbtn.Text = "register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(12, 173);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(295, 23);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // upgradebtn
            // 
            this.upgradebtn.Location = new System.Drawing.Point(12, 260);
            this.upgradebtn.Name = "upgradebtn";
            this.upgradebtn.Size = new System.Drawing.Size(295, 23);
            this.upgradebtn.TabIndex = 7;
            this.upgradebtn.Text = "Upgrade";
            this.upgradebtn.UseVisualStyleBackColor = true;
            this.upgradebtn.Click += new System.EventHandler(this.upgradebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 320);
            this.Controls.Add(this.upgradebtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.all_in_onebtn);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.licensetb);
            this.Controls.Add(this.usernametb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernametb;
        private TextBox licensetb;
        private TextBox passwordtb;
        private TextBox emailtb;
        private Button all_in_onebtn;
        private Button registerbtn;
        private Button loginbtn;
        private Button upgradebtn;
    }
}