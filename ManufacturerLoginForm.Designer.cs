namespace VP_Midterm_Project
{
    partial class ManufacturerLoginForm
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
            this.LoginToYourAccount = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginToYourAccount
            // 
            this.LoginToYourAccount.AutoSize = true;
            this.LoginToYourAccount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginToYourAccount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LoginToYourAccount.Location = new System.Drawing.Point(72, 167);
            this.LoginToYourAccount.Name = "LoginToYourAccount";
            this.LoginToYourAccount.Size = new System.Drawing.Size(303, 36);
            this.LoginToYourAccount.TabIndex = 0;
            this.LoginToYourAccount.Text = "Login to your account";
            this.LoginToYourAccount.Click += new System.EventHandler(this.LoginToYourAccount_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Username.Location = new System.Drawing.Point(75, 217);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(85, 21);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // usernametextbox
            // 
            this.usernametextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernametextbox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.usernametextbox.Location = new System.Drawing.Point(78, 241);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(297, 34);
            this.usernametextbox.TabIndex = 2;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordtextbox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.passwordtextbox.Location = new System.Drawing.Point(78, 315);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(297, 34);
            this.passwordtextbox.TabIndex = 4;
            this.passwordtextbox.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Password.Location = new System.Drawing.Point(75, 291);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(81, 21);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Indigo;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(78, 378);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(297, 39);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VP_Midterm_Project.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(148, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Indigo;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 32);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ManufacturerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 477);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LoginToYourAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManufacturerLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManufacturerLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginToYourAccount;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
    }
}

