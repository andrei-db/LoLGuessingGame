namespace LeagueOfLegendsGuessingGame
{
    partial class LoginRegisterForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameLoginTB = new System.Windows.Forms.TextBox();
            this.passwordLoginTB = new System.Windows.Forms.TextBox();
            this.usernameRegisterTB = new System.Windows.Forms.TextBox();
            this.passwordRegisterTB = new System.Windows.Forms.TextBox();
            this.usernameRegister = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.passwordRegister = new System.Windows.Forms.Label();
            this.passwordLogin = new System.Windows.Forms.Label();
            this.usernameLogin = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(150, 269);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameLoginTB
            // 
            this.usernameLoginTB.Location = new System.Drawing.Point(136, 153);
            this.usernameLoginTB.Name = "usernameLoginTB";
            this.usernameLoginTB.Size = new System.Drawing.Size(100, 20);
            this.usernameLoginTB.TabIndex = 1;
            // 
            // passwordLoginTB
            // 
            this.passwordLoginTB.Location = new System.Drawing.Point(136, 211);
            this.passwordLoginTB.Name = "passwordLoginTB";
            this.passwordLoginTB.PasswordChar = '*';
            this.passwordLoginTB.Size = new System.Drawing.Size(100, 20);
            this.passwordLoginTB.TabIndex = 2;
            // 
            // usernameRegisterTB
            // 
            this.usernameRegisterTB.Location = new System.Drawing.Point(621, 153);
            this.usernameRegisterTB.Name = "usernameRegisterTB";
            this.usernameRegisterTB.Size = new System.Drawing.Size(100, 20);
            this.usernameRegisterTB.TabIndex = 3;
            // 
            // passwordRegisterTB
            // 
            this.passwordRegisterTB.Location = new System.Drawing.Point(621, 211);
            this.passwordRegisterTB.Name = "passwordRegisterTB";
            this.passwordRegisterTB.PasswordChar = '*';
            this.passwordRegisterTB.Size = new System.Drawing.Size(100, 20);
            this.passwordRegisterTB.TabIndex = 4;
            // 
            // usernameRegister
            // 
            this.usernameRegister.AutoSize = true;
            this.usernameRegister.Location = new System.Drawing.Point(653, 137);
            this.usernameRegister.Name = "usernameRegister";
            this.usernameRegister.Size = new System.Drawing.Size(55, 13);
            this.usernameRegister.TabIndex = 5;
            this.usernameRegister.Text = "Username";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(634, 279);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // passwordRegister
            // 
            this.passwordRegister.AutoSize = true;
            this.passwordRegister.Location = new System.Drawing.Point(653, 195);
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.Size = new System.Drawing.Size(53, 13);
            this.passwordRegister.TabIndex = 7;
            this.passwordRegister.Text = "Password";
            // 
            // passwordLogin
            // 
            this.passwordLogin.AutoSize = true;
            this.passwordLogin.Location = new System.Drawing.Point(170, 195);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.Size = new System.Drawing.Size(53, 13);
            this.passwordLogin.TabIndex = 8;
            this.passwordLogin.Text = "Password";
            // 
            // usernameLogin
            // 
            this.usernameLogin.AutoSize = true;
            this.usernameLogin.Location = new System.Drawing.Point(170, 137);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(55, 13);
            this.usernameLogin.TabIndex = 9;
            this.usernameLogin.Text = "Username";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(161, 49);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Login";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Location = new System.Drawing.Point(653, 64);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(46, 13);
            this.registerLabel.TabIndex = 11;
            this.registerLabel.Text = "Register";
            // 
            // LoginRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 506);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.usernameLogin);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.usernameRegister);
            this.Controls.Add(this.passwordRegisterTB);
            this.Controls.Add(this.usernameRegisterTB);
            this.Controls.Add(this.passwordLoginTB);
            this.Controls.Add(this.usernameLoginTB);
            this.Controls.Add(this.loginBtn);
            this.Name = "LoginRegisterForm";
            this.Text = "LoginRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameLoginTB;
        private System.Windows.Forms.TextBox passwordLoginTB;
        private System.Windows.Forms.TextBox usernameRegisterTB;
        private System.Windows.Forms.TextBox passwordRegisterTB;
        private System.Windows.Forms.Label usernameRegister;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label passwordRegister;
        private System.Windows.Forms.Label passwordLogin;
        private System.Windows.Forms.Label usernameLogin;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label registerLabel;
    }
}