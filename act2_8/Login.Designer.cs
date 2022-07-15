namespace act2_8
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usernameLabel.Location = new System.Drawing.Point(109, 53);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(329, 46);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username or Email";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(15, 10);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(434, 22);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(12, 12);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(434, 22);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordLabel.Location = new System.Drawing.Point(184, 177);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(176, 46);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(163)))), ((int)(((byte)(231)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginButton.Location = new System.Drawing.Point(191, 298);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(163, 57);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.notificationLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.notificationLabel.Location = new System.Drawing.Point(107, 440);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(343, 33);
            this.notificationLabel.TabIndex = 6;
            this.notificationLabel.Text = "Enter your username and password";
            this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.notificationLabel.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Location = new System.Drawing.Point(41, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 46);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Location = new System.Drawing.Point(41, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 46);
            this.panel2.TabIndex = 32;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(175)))), ((int)(((byte)(148)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(191, 370);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(163, 57);
            this.exitButton.TabIndex = 33;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(548, 519);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitButton;
    }
}