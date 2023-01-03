namespace eLibrary.Forms
{
    partial class Registation
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
            this.registrationBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.usernameTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmPasswordTbx = new System.Windows.Forms.TextBox();
            this.showpasswordCh = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // registrationBtn
            // 
            this.registrationBtn.Location = new System.Drawing.Point(84, 302);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(156, 23);
            this.registrationBtn.TabIndex = 11;
            this.registrationBtn.Text = "Registration";
            this.registrationBtn.UseVisualStyleBackColor = true;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(12, 44);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(26, 23);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "<";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // passwordTbx
            // 
            this.passwordTbx.Location = new System.Drawing.Point(84, 189);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(156, 20);
            this.passwordTbx.TabIndex = 7;
            // 
            // usernameTbx
            // 
            this.usernameTbx.Location = new System.Drawing.Point(84, 141);
            this.usernameTbx.Name = "usernameTbx";
            this.usernameTbx.Size = new System.Drawing.Size(156, 20);
            this.usernameTbx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // lastNameTbx
            // 
            this.lastNameTbx.Location = new System.Drawing.Point(84, 92);
            this.lastNameTbx.Name = "lastNameTbx";
            this.lastNameTbx.Size = new System.Drawing.Size(156, 20);
            this.lastNameTbx.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "First Name";
            // 
            // firstNameTbx
            // 
            this.firstNameTbx.Location = new System.Drawing.Point(84, 44);
            this.firstNameTbx.Name = "firstNameTbx";
            this.firstNameTbx.Size = new System.Drawing.Size(156, 20);
            this.firstNameTbx.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Confirm password";
            // 
            // confirmPasswordTbx
            // 
            this.confirmPasswordTbx.Location = new System.Drawing.Point(84, 240);
            this.confirmPasswordTbx.Name = "confirmPasswordTbx";
            this.confirmPasswordTbx.Size = new System.Drawing.Size(156, 20);
            this.confirmPasswordTbx.TabIndex = 16;
            // 
            // showpasswordCh
            // 
            this.showpasswordCh.AutoSize = true;
            this.showpasswordCh.Location = new System.Drawing.Point(85, 262);
            this.showpasswordCh.Name = "showpasswordCh";
            this.showpasswordCh.Size = new System.Drawing.Size(99, 17);
            this.showpasswordCh.TabIndex = 18;
            this.showpasswordCh.Text = "show password";
            this.showpasswordCh.UseVisualStyleBackColor = true;
            this.showpasswordCh.CheckedChanged += new System.EventHandler(this.showpasswordCh_CheckedChanged);
            // 
            // Registation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.showpasswordCh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmPasswordTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNameTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameTbx);
            this.Controls.Add(this.registrationBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.usernameTbx);
            this.Name = "Registation";
            this.Text = "Registation";
            this.Load += new System.EventHandler(this.Registation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.TextBox usernameTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmPasswordTbx;
        private System.Windows.Forms.CheckBox showpasswordCh;
    }
}