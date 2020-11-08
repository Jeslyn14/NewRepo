namespace SSBFollowWin
{
    partial class Login
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
            this.SSBFollowUp = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.btnforgotpassword = new System.Windows.Forms.Button();
            this.ckbshowpassword = new System.Windows.Forms.CheckBox();
            this.btnsubmit1 = new System.Windows.Forms.Button();
            this.lbltype = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername1 = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername1 = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SSBFollowUp
            // 
            this.SSBFollowUp.AutoSize = true;
            this.SSBFollowUp.BackColor = System.Drawing.Color.SandyBrown;
            this.SSBFollowUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSBFollowUp.Location = new System.Drawing.Point(297, 38);
            this.SSBFollowUp.Name = "SSBFollowUp";
            this.SSBFollowUp.Padding = new System.Windows.Forms.Padding(10);
            this.SSBFollowUp.Size = new System.Drawing.Size(397, 59);
            this.SSBFollowUp.TabIndex = 0;
            this.SSBFollowUp.Text = "SSB Bazaar FollowUp";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.LoginPanel.Controls.Add(this.btnforgotpassword);
            this.LoginPanel.Controls.Add(this.ckbshowpassword);
            this.LoginPanel.Controls.Add(this.btnsubmit1);
            this.LoginPanel.Controls.Add(this.lbltype);
            this.LoginPanel.Controls.Add(this.cmbtype);
            this.LoginPanel.Controls.Add(this.txtpassword);
            this.LoginPanel.Controls.Add(this.txtusername1);
            this.LoginPanel.Controls.Add(this.lblpassword);
            this.LoginPanel.Controls.Add(this.lblusername1);
            this.LoginPanel.Location = new System.Drawing.Point(284, 137);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(410, 267);
            this.LoginPanel.TabIndex = 1;
            // 
            // btnforgotpassword
            // 
            this.btnforgotpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnforgotpassword.Location = new System.Drawing.Point(235, 187);
            this.btnforgotpassword.Name = "btnforgotpassword";
            this.btnforgotpassword.Padding = new System.Windows.Forms.Padding(5);
            this.btnforgotpassword.Size = new System.Drawing.Size(131, 33);
            this.btnforgotpassword.TabIndex = 8;
            this.btnforgotpassword.Text = "Forgot password";
            this.btnforgotpassword.UseVisualStyleBackColor = false;
            this.btnforgotpassword.Click += new System.EventHandler(this.btnforgotpassword_Click);
            // 
            // ckbshowpassword
            // 
            this.ckbshowpassword.AutoSize = true;
            this.ckbshowpassword.Location = new System.Drawing.Point(173, 111);
            this.ckbshowpassword.Name = "ckbshowpassword";
            this.ckbshowpassword.Size = new System.Drawing.Size(108, 19);
            this.ckbshowpassword.TabIndex = 7;
            this.ckbshowpassword.Text = "Show password";
            this.ckbshowpassword.UseVisualStyleBackColor = true;
            // 
            // btnsubmit1
            // 
            this.btnsubmit1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsubmit1.Location = new System.Drawing.Point(110, 187);
            this.btnsubmit1.Name = "btnsubmit1";
            this.btnsubmit1.Padding = new System.Windows.Forms.Padding(5);
            this.btnsubmit1.Size = new System.Drawing.Size(88, 33);
            this.btnsubmit1.TabIndex = 6;
            this.btnsubmit1.Text = "Submit";
            this.btnsubmit1.UseVisualStyleBackColor = false;
            this.btnsubmit1.Click += new System.EventHandler(this.btnsubmit1_Click);
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.PowderBlue;
            this.lbltype.Location = new System.Drawing.Point(103, 137);
            this.lbltype.Name = "lbltype";
            this.lbltype.Padding = new System.Windows.Forms.Padding(5);
            this.lbltype.Size = new System.Drawing.Size(41, 25);
            this.lbltype.TabIndex = 5;
            this.lbltype.Text = "Type";
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Admin",
            "Salesperson"});
            this.cmbtype.Location = new System.Drawing.Point(173, 139);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(121, 23);
            this.cmbtype.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(173, 81);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(117, 23);
            this.txtpassword.TabIndex = 3;
            // 
            // txtusername1
            // 
            this.txtusername1.Location = new System.Drawing.Point(173, 44);
            this.txtusername1.Name = "txtusername1";
            this.txtusername1.Size = new System.Drawing.Size(118, 23);
            this.txtusername1.TabIndex = 2;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.PowderBlue;
            this.lblpassword.Location = new System.Drawing.Point(77, 79);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Padding = new System.Windows.Forms.Padding(5);
            this.lblpassword.Size = new System.Drawing.Size(67, 25);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // lblusername1
            // 
            this.lblusername1.AutoSize = true;
            this.lblusername1.BackColor = System.Drawing.Color.PowderBlue;
            this.lblusername1.Location = new System.Drawing.Point(74, 42);
            this.lblusername1.Name = "lblusername1";
            this.lblusername1.Padding = new System.Windows.Forms.Padding(5);
            this.lblusername1.Size = new System.Drawing.Size(70, 25);
            this.lblusername1.TabIndex = 0;
            this.lblusername1.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1018, 592);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.SSBFollowUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SSBFollowUp;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername1;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername1;
        private System.Windows.Forms.Button btnsubmit1;
        private System.Windows.Forms.Button btnforgotpassword;
        private System.Windows.Forms.CheckBox ckbshowpassword;
    }
}

