using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace EmployeeManagement
{
    public partial class frmEmployee : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        DataTable dt = new DataTable();

        public bool IsLogout = false;
        public frmEmployee()
        {
            InitializeComponent();
        }


        public void Showrecord()
        {
            dt.Clear();
            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT");
            query.AppendLine("Id, Firstname AS 'First Name',");
            query.AppendLine("Middlename AS 'Middle Name', Lastname AS 'Last Name',");
            query.AppendLine("gender AS 'Gender', dob AS 'Date Of Birth',");
            query.AppendLine("address, primarycontact AS 'Contact Number',");
            query.AppendLine("secondarycontact AS 'Alternate Number', emailid AS 'Email Id',");
            query.AppendLine("dateofjoin AS 'Date Of Joining', AccountNo,");
            query.AppendLine("IFSCcode, Comment, Salary");
            query.AppendLine("from Employee");
            query.AppendLine("WHERE IsDeleted = 0");
            query.AppendLine("ORDER BY Id DESC");
            SqlDataAdapter sda = new SqlDataAdapter(query.ToString(), con);
            sda.Fill(dt);
            dgvEmployeeInfo.DataSource = dt;
            dgvEmployeeInfo.Columns["Id"].Visible = false;
            dgvEmployeeInfo.Columns["address"].Visible = false;
            dgvEmployeeInfo.Columns["AccountNo"].Visible = false;
            dgvEmployeeInfo.Columns["IFSCcode"].Visible = false;
            dgvEmployeeInfo.Columns["Comment"].Visible = false;
            dgvEmployeeInfo.Columns["Salary"].Visible = false;
            dgvEmployeeInfo.Columns["Gender"].Width = 100 ;
        }


        private void attendance_Load(object sender, EventArgs e)
        {
            Showrecord();
        }


        private void dgvEmployeeInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetEmployeeInfo();
        }


        private void GetEmployeeInfo()
        {
            if (dgvEmployeeInfo.SelectedRows.Count > 0 && dgvEmployeeInfo.CurrentCell != null)
            {
                int rowId = dgvEmployeeInfo.CurrentCell.RowIndex;
                frmAddEmployee newrecObj = new frmAddEmployee(dgvEmployeeInfo.Rows[rowId].Cells["Id"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["First Name"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["Middle Name"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["Last Name"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["Gender"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["Date Of Birth"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["address"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["Contact Number"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["Alternate Number"].Value.ToString(),
                     dgvEmployeeInfo.Rows[rowId].Cells["Email Id"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["Date Of Joining"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["AccountNo"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["IFSCcode"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["Comment"].Value.ToString(),
                    dgvEmployeeInfo.Rows[rowId].Cells["Salary"].Value.ToString());

                newrecObj.ShowDialog();
                Showrecord();
            }
            else
            {
                MessageBox.Show("Please select row for update","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetEmployeeInfo();
        }


        private void txtLast_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "Last Name", txtLastName.Text.Trim());
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "First Name", txtName.Text.Trim());
        }


        private void txtContactno_TextChanged(object sender, EventArgs e)
        {
            long result;
            if (long.TryParse(txtContactno.Text.Trim(), out result))
            {
                dt.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "Contact Number", txtContactno.Text.Trim());
            }
            else if(!txtContactno.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter valid mobile no", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassObj = new frmChangePassword();
            frmChangePassObj.ShowDialog();
        }


        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddEmployee nw = new frmAddEmployee();
            nw.ShowDialog();
            Showrecord();
        }


        private void addAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendance frmAttendanceObj = new frmAttendance();
            frmAttendanceObj.ShowDialog();
        }


        private void paidLeavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePaidLeave frmPaidLeaveObj = new frmUpdatePaidLeave();
            frmPaidLeaveObj.ShowDialog();
        }


        private void insentivesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSalaryComponent frmSalaryComponentObj = new frmSalaryComponent();
            frmSalaryComponentObj.ShowDialog();
        }


        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //crystalreport cr = new crystalreport();
            //cr.ShowDialog();
            frmSalarySlip sslip = new frmSalarySlip();
            sslip.ShowDialog();
        }


        private void viewHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHelp Ht = new frmHelp();
            Ht.ShowDialog();
        }


        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (result.Equals(DialogResult.Yes))
            {
                IsLogout = true;
                this.Close();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearSearchFields();
            dt.DefaultView.RowFilter = string.Empty;
        }

        private void ClearSearchFields()
        {
            txtName.Clear();
            txtContactno.Clear();
            txtLastName.Clear();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            ClearSearchFields();
        }

    }
}
