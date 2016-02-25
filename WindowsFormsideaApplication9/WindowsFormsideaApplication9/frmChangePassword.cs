using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagement
{
    public partial class frmChangePassword : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        public frmChangePassword()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                string query = string.Format("UPDATE Login SET password = '{0}' WHERE password = '{1}'",
                    txtNewPassword.Text.Trim(),
                    txtOldPassword.Text.Trim());
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
               int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Please enter correct Old Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOldPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Password Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }


        private bool IsValidInput()
        {
            if (txtOldPassword.Text.Trim().Replace("'", "").Equals(string.Empty) ||
                 txtNewPassword.Text.Trim().Replace("'", "").Equals(string.Empty) ||
                 txtConfirmPassword.Text.Trim().Replace("'", "").Equals(string.Empty))
            {
                MessageBox.Show("Please fill the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (txtOldPassword.Text.Trim().Replace("'", "").Equals(string.Empty))
                {
                    txtOldPassword.Focus();
                }
                else if (txtNewPassword.Text.Trim().Replace("'", "").Equals(string.Empty))
                {
                    txtNewPassword.Focus();
                }
                else
                {
                    txtConfirmPassword.Focus();
                }
                return false;
            }


            else if(!txtNewPassword.Text.Trim().Equals(txtConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("New and Confirm Password not Match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNewPassword.Focus();
                txtConfirmPassword.Focus();
                return false;
            }
            return true;
        }


        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                btnSave.PerformClick();
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
