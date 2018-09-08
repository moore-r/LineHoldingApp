namespace Hold_It_App
{
    partial class Search
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
            System.Windows.Forms.Label Address;
            System.Windows.Forms.Label Label1;
            this.PostButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchAddress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            Address = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            Address.Location = new System.Drawing.Point(30, 46);
            Address.Name = "Address";
            Address.Size = new System.Drawing.Size(68, 20);
            Address.TabIndex = 28;
            Address.Text = "Address";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = System.Drawing.SystemColors.Highlight;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(39, 130);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(54, 13);
            Label1.TabIndex = 35;
            Label1.Text = "Address - ";
            Label1.Visible = false;
            // 
            // PostButton
            // 
            this.PostButton.Location = new System.Drawing.Point(173, 513);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(90, 90);
            this.PostButton.TabIndex = 16;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(259, 513);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(90, 90);
            this.AccountButton.TabIndex = 15;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(84, 513);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 90);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(-2, 513);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(90, 90);
            this.HomeButton.TabIndex = 13;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 17;
            // 
            // SearchAddress
            // 
            this.SearchAddress.Location = new System.Drawing.Point(231, 69);
            this.SearchAddress.Name = "SearchAddress";
            this.SearchAddress.Size = new System.Drawing.Size(75, 20);
            this.SearchAddress.TabIndex = 29;
            this.SearchAddress.Text = "Search";
            this.SearchAddress.UseVisualStyleBackColor = true;
            this.SearchAddress.Click += new System.EventHandler(this.Search_Address_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(108, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "Search";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(29, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 58);
            this.label8.TabIndex = 32;
            this.label8.Text = "     Address not found, make a post or try again.";
            this.label8.UseMnemonic = false;
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(34, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 107);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Event_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(43, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Spots Available";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(58, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(42, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(56, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "Spot Purchased!!";
            this.label5.UseMnemonic = false;
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(29, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 38);
            this.label7.TabIndex = 37;
            this.label7.Text = "You are posting a Spot!";
            this.label7.UseMnemonic = false;
            this.label7.Visible = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(Label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchAddress);
            this.Controls.Add(Address);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.button1);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchAddress;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
    }
}