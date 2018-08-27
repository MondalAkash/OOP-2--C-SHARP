namespace LibraryManagementSystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.warnLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.passTF = new System.Windows.Forms.TextBox();
            this.userIdTF = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(835, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 553);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.warnLabel);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.passTF);
            this.panel2.Controls.Add(this.userIdTF);
            this.panel2.Controls.Add(this.passLbl);
            this.panel2.Controls.Add(this.userIdLbl);
            this.panel2.Controls.Add(this.cbSearch);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(391, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 515);
            this.panel2.TabIndex = 5;
            // 
            // warnLabel
            // 
            this.warnLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnLabel.ForeColor = System.Drawing.Color.Crimson;
            this.warnLabel.Location = new System.Drawing.Point(105, 387);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(259, 31);
            this.warnLabel.TabIndex = 14;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(48, 300);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(159, 46);
            this.loginButton.TabIndex = 13;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(237, 300);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(145, 46);
            this.backButton.TabIndex = 12;
            this.backButton.TabStop = false;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // passTF
            // 
            this.passTF.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTF.ForeColor = System.Drawing.SystemColors.Window;
            this.passTF.Location = new System.Drawing.Point(190, 229);
            this.passTF.Name = "passTF";
            this.passTF.PasswordChar = '*';
            this.passTF.Size = new System.Drawing.Size(174, 21);
            this.passTF.TabIndex = 10;
            // 
            // userIdTF
            // 
            this.userIdTF.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userIdTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTF.ForeColor = System.Drawing.SystemColors.Window;
            this.userIdTF.Location = new System.Drawing.Point(190, 176);
            this.userIdTF.Name = "userIdTF";
            this.userIdTF.Size = new System.Drawing.Size(174, 21);
            this.userIdTF.TabIndex = 9;
            // 
            // passLbl
            // 
            this.passLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passLbl.Location = new System.Drawing.Point(70, 229);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(108, 25);
            this.passLbl.TabIndex = 8;
            this.passLbl.Text = "Password";
            // 
            // userIdLbl
            // 
            this.userIdLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userIdLbl.Location = new System.Drawing.Point(70, 176);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(77, 23);
            this.userIdLbl.TabIndex = 7;
            this.userIdLbl.Text = "User id";
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.DimGray;
            this.cbSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ForeColor = System.Drawing.Color.White;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbSearch.Location = new System.Drawing.Point(162, 74);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 28);
            this.cbSearch.TabIndex = 6;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Silver;
            this.titleLbl.Location = new System.Drawing.Point(84, 142);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(259, 160);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "Library Management System";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 514);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(835, 553);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox passTF;
        private System.Windows.Forms.TextBox userIdTF;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label warnLabel;


    }
}