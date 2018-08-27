namespace Library_management_software
{
    partial class Form1
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
            this.userIdTF = new System.Windows.Forms.TextBox();
            this.passTF = new System.Windows.Forms.TextBox();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userIdTF
            // 
            this.userIdTF.BackColor = System.Drawing.Color.Gray;
            this.userIdTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTF.ForeColor = System.Drawing.SystemColors.Window;
            this.userIdTF.Location = new System.Drawing.Point(147, 154);
            this.userIdTF.Multiline = true;
            this.userIdTF.Name = "userIdTF";
            this.userIdTF.Size = new System.Drawing.Size(174, 23);
            this.userIdTF.TabIndex = 0;
            // 
            // passTF
            // 
            this.passTF.BackColor = System.Drawing.Color.Gray;
            this.passTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTF.ForeColor = System.Drawing.SystemColors.Window;
            this.passTF.Location = new System.Drawing.Point(147, 209);
            this.passTF.Multiline = true;
            this.passTF.Name = "passTF";
            this.passTF.Size = new System.Drawing.Size(174, 22);
            this.passTF.TabIndex = 1;
            // 
            // userIdLbl
            // 
            this.userIdLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userIdLbl.Location = new System.Drawing.Point(32, 151);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(77, 23);
            this.userIdLbl.TabIndex = 2;
            this.userIdLbl.Text = "user id";
            // 
            // passLbl
            // 
            this.passLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passLbl.Location = new System.Drawing.Point(32, 206);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(109, 23);
            this.passLbl.TabIndex = 3;
            this.passLbl.Text = "password";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Gray;
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogIn.Image = global::Library_management_software.Properties.Resources.Capture;
            this.btnLogIn.Location = new System.Drawing.Point(57, 274);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(119, 40);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.TabStop = false;
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbSearch.Location = new System.Drawing.Point(116, 61);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 21);
            this.cbSearch.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(182, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.cbSearch);
            this.panel3.Controls.Add(this.btnLogIn);
            this.panel3.Controls.Add(this.passLbl);
            this.panel3.Controls.Add(this.userIdLbl);
            this.panel3.Controls.Add(this.passTF);
            this.panel3.Controls.Add(this.userIdTF);
            this.panel3.Location = new System.Drawing.Point(359, 1);
            this.panel3.MaximumSize = new System.Drawing.Size(353, 396);
            this.panel3.MinimumSize = new System.Drawing.Size(353, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 396);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(364, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 393);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 394);
            this.panel1.TabIndex = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Silver;
            this.titleLbl.Location = new System.Drawing.Point(66, 89);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(259, 160);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Library Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 395);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(724, 434);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIdTF;
        private System.Windows.Forms.TextBox passTF;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLbl;




    }
}

