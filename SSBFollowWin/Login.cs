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

namespace SSBFollowWin
{
    public partial class Login : Form
    {
        String cs = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|adminfollow.mdf; Integrated Security = True";
        public Login()
        {
            InitializeComponent();
        }

        private void submitbutton1_Click(object sender, EventArgs e)
        {
            if (txtusername1.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }   
            try
            {
               /* SqlDataAdapter cmd = new SqlDataAdapter("Select * from follow_up where UserName=@username and Password=@password", cs);
                cmd.Parameters.AddWithValue("@username", txtusername1.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                } */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
