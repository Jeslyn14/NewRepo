using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SSBFollowWin
{
    class ForgotPassword : Form
    {
        private Panel FPpanel;
        private Button button1;
        private TextBox txtconfirmpassword;
        private TextBox txtnewpassword;
        private TextBox txtusername2;
        private Label lblconfirmpassword;
        private Label lblnewpassword;
        private Label lblusername2;
        private Button btnsubmit2;
        private Label FPtitle;

        private void InitializeComponent()
        {
            this.FPtitle = new System.Windows.Forms.Label();
            this.FPpanel = new System.Windows.Forms.Panel();
            this.btnsubmit2 = new System.Windows.Forms.Button();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtusername2 = new System.Windows.Forms.TextBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lblusername2 = new System.Windows.Forms.Label();
            this.FPpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FPtitle
            // 
            this.FPtitle.AutoSize = true;
            this.FPtitle.BackColor = System.Drawing.Color.SandyBrown;
            this.FPtitle.Location = new System.Drawing.Point(271, 71);
            this.FPtitle.Name = "FPtitle";
            this.FPtitle.Padding = new System.Windows.Forms.Padding(10);
            this.FPtitle.Size = new System.Drawing.Size(135, 35);
            this.FPtitle.TabIndex = 0;
            this.FPtitle.Text = "FORGOT PASSWORD";
            this.FPtitle.Click += new System.EventHandler(this.FPtitle_Click);
            // 
            // FPpanel
            // 
            this.FPpanel.Controls.Add(this.btnsubmit2);
            this.FPpanel.Controls.Add(this.txtconfirmpassword);
            this.FPpanel.Controls.Add(this.txtnewpassword);
            this.FPpanel.Controls.Add(this.txtusername2);
            this.FPpanel.Controls.Add(this.lblconfirmpassword);
            this.FPpanel.Controls.Add(this.lblnewpassword);
            this.FPpanel.Controls.Add(this.lblusername2);
            this.FPpanel.Location = new System.Drawing.Point(184, 131);
            this.FPpanel.Name = "FPpanel";
            this.FPpanel.Size = new System.Drawing.Size(311, 208);
            this.FPpanel.TabIndex = 1;
            // 
            // btnsubmit2
            // 
            this.btnsubmit2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsubmit2.Location = new System.Drawing.Point(112, 162);
            this.btnsubmit2.Name = "btnsubmit2";
            this.btnsubmit2.Padding = new System.Windows.Forms.Padding(5);
            this.btnsubmit2.Size = new System.Drawing.Size(92, 32);
            this.btnsubmit2.TabIndex = 6;
            this.btnsubmit2.Text = "Submit";
            this.btnsubmit2.UseVisualStyleBackColor = false;
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(131, 109);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(120, 23);
            this.txtconfirmpassword.TabIndex = 5;
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(131, 68);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(120, 23);
            this.txtnewpassword.TabIndex = 4;
            // 
            // txtusername2
            // 
            this.txtusername2.Location = new System.Drawing.Point(131, 25);
            this.txtusername2.Name = "txtusername2";
            this.txtusername2.Size = new System.Drawing.Size(120, 23);
            this.txtusername2.TabIndex = 3;
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Location = new System.Drawing.Point(11, 107);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Padding = new System.Windows.Forms.Padding(5);
            this.lblconfirmpassword.Size = new System.Drawing.Size(114, 25);
            this.lblconfirmpassword.TabIndex = 2;
            this.lblconfirmpassword.Text = "Confirm Password";
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Location = new System.Drawing.Point(31, 66);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Padding = new System.Windows.Forms.Padding(5);
            this.lblnewpassword.Size = new System.Drawing.Size(94, 25);
            this.lblnewpassword.TabIndex = 1;
            this.lblnewpassword.Text = "New Password";
            // 
            // lblusername2
            // 
            this.lblusername2.AutoSize = true;
            this.lblusername2.Location = new System.Drawing.Point(40, 28);
            this.lblusername2.Name = "lblusername2";
            this.lblusername2.Padding = new System.Windows.Forms.Padding(5);
            this.lblusername2.Size = new System.Drawing.Size(70, 25);
            this.lblusername2.TabIndex = 0;
            this.lblusername2.Text = "Username";
            // 
            // ForgotPassword
            // 
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(741, 500);
            this.Controls.Add(this.FPpanel);
            this.Controls.Add(this.FPtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ForgotPassword";
            this.FPpanel.ResumeLayout(false);
            this.FPpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FPtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
