using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagement
{
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM Login WHERE username='" + txtName.Text.Trim() + "'AND password='" + txtpassword.Text.Trim() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                frmEmployee ss = new frmEmployee();
                ss.ShowDialog();
                if (ss.IsLogout)
                {
                    txtpassword.Clear();
                    this.Show();
                }
                else
                {
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtpassword.Clear();
                txtName.Clear();
                txtName.Focus();
            }   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Enter))
            {
                btnLogin.PerformClick();
            }
        }

    }
}
