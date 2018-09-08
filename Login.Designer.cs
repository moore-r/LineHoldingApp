namespace Hold_It_App
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
            this.CreateAccount = new System.Windows.Forms.LinkLabel();
            this.forgotusername = new System.Windows.Forms.LinkLabel();
            this.forgotpassword = new System.Windows.Forms.LinkLabel();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateAccount
            // 
            this.CreateAccount.AutoSize = true;
            this.CreateAccount.Location = new System.Drawing.Point(121, 549);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(81, 13);
            this.CreateAccount.TabIndex = 31;
            this.CreateAccount.TabStop = true;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.Click += new System.EventHandler(this.Create_Account_Click);
            // 
            // forgotusername
            // 
            this.forgotusername.AutoSize = true;
            this.forgotusername.Location = new System.Drawing.Point(216, 378);
            this.forgotusername.Name = "forgotusername";
            this.forgotusername.Size = new System.Drawing.Size(92, 13);
            this.forgotusername.TabIndex = 30;
            this.forgotusername.TabStop = true;
            this.forgotusername.Text = "Forgot username?";
            // 
            // forgotpassword
            // 
            this.forgotpassword.AutoSize = true;
            this.forgotpassword.Location = new System.Drawing.Point(216, 492);
            this.forgotpassword.Name = "forgotpassword";
            this.forgotpassword.Size = new System.Drawing.Size(91, 13);
            this.forgotpassword.TabIndex = 29;
            this.forgotpassword.TabStop = true;
            this.forgotpassword.Text = "Forgot password?";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Password.Location = new System.Drawing.Point(33, 422);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 28;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Username.Location = new System.Drawing.Point(33, 307);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 27;
            this.Username.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 460);
            this.textBox2.MaxLength = 32;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(271, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 345);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 25;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Title.Location = new System.Drawing.Point(20, 101);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(297, 97);
            this.Title.TabIndex = 32;
            this.Title.Text = "Hold-It";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(124, 512);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 33;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "That Username/password is incorrect. Please try again";
            this.label1.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.forgotusername);
            this.Controls.Add(this.forgotpassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel CreateAccount;
        private System.Windows.Forms.LinkLabel forgotusername;
        private System.Windows.Forms.LinkLabel forgotpassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
    }
}