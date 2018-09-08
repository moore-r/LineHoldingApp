namespace Hold_It_App
{
    partial class Home
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(-2, 513);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(90, 90);
            this.HomeButton.TabIndex = 14;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PostButton
            // 
            this.PostButton.Location = new System.Drawing.Point(173, 513);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(90, 90);
            this.PostButton.TabIndex = 17;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(259, 513);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(90, 90);
            this.AccountButton.TabIndex = 16;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(84, 513);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 90);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.HomeButton);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button SearchButton;
    }
}