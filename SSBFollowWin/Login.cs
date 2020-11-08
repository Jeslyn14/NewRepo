using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace SSBFollowWin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnsubmit1_Click(object sender, EventArgs e)
        {
            if (txtusername1.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            } 
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\FollowUpSSB\FollowUpSSB\NewRepo\SSBFollowWin\adminfollow.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Sales_Person where salesperson_username='" +txtusername1 +"' and sales_password='" +txtpassword +"' and usertype='" +cmbtype + "'",con);
                DataTable ds = new DataTable();
                sda.Fill(ds);
                //If count is greater than 1, than show Adminpanel form
                if (ds.Rows.Count >= 1) 
                {
                    this.Hide();
                    Adminpanel fm = new Adminpanel();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnforgotpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
        }
    }
}
