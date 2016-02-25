using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagement
{
    public partial class frmUpdatePaidLeave : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        DataTable dtAbsentRecords;

        public frmUpdatePaidLeave()
        {
            InitializeComponent();
        }

        private void frmUpdatePaidLeave_Load(object sender, EventArgs e)
        {
            StringBuilder sbSqlQuery = new StringBuilder();
            sbSqlQuery.AppendLine("SELECT");
            sbSqlQuery.AppendLine("Emp.Firstname AS 'First Name',");
            sbSqlQuery.AppendLine("Emp.Middlename AS 'Middle Name',");
            sbSqlQuery.AppendLine("Emp.Lastname AS 'Last Name',");
            sbSqlQuery.AppendLine("AbsEmp.Id AS 'AbsId',");
            sbSqlQuery.AppendLine("CONVERT(VARCHAR(12),AbsEmp.AbsentDate,113) AS 'Leave Date',");
            sbSqlQuery.AppendLine("AbsEmp.IsPaidLeave AS 'Paid Leave'");
            sbSqlQuery.AppendLine("FROM");
            sbSqlQuery.AppendLine("AbsentRecords AbsEmp");
            sbSqlQuery.AppendLine("INNER JOIN Employee Emp ON AbsEmp.EmpId = Emp.Id");
            sbSqlQuery.AppendLine("ORDER BY");
            sbSqlQuery.AppendLine("AbsEmp.AbsentDate DESC");
            
            SqlDataAdapter sqlDa = new SqlDataAdapter(sbSqlQuery.ToString(), con);
            dtAbsentRecords = new DataTable();
            sqlDa.Fill(dtAbsentRecords);
            dgvSalaryComponent.DataSource = dtAbsentRecords;
            dgvSalaryComponent.Columns["AbsId"].Visible = false;
            dgvSalaryComponent.Columns["First Name"].ReadOnly = true;
            dgvSalaryComponent.Columns["Middle Name"].ReadOnly = true;
            dgvSalaryComponent.Columns["Last Name"].ReadOnly = true;
            dgvSalaryComponent.Columns["Leave Date"].ReadOnly = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder sbSqlQuery = new StringBuilder();
            foreach (DataRow dr in dtAbsentRecords.Rows)
            {
                sbSqlQuery.AppendLine(string.Format("UPDATE AbsentRecords SET IsPaidLeave = {0} WHERE Id = {1}", 
                    Convert.ToBoolean(dr["Paid Leave"]) == true? 1:0, 
                    dr["AbsId"]));
            }

            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand(sbSqlQuery.ToString(), con);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
