using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagement
{
    public partial class frmSalarySlip : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        ReportDocument cry = new ReportDocument();
        public frmSalarySlip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salaryMonth = -1;
            if (!cbMonth.SelectedIndex.Equals(-1) && !cbYear.SelectedIndex.Equals(-1))
            {
                if (Convert.ToInt32(cbYear.Text) < DateTime.Now.Year)
                {
                    salaryMonth = 12;
                }
                else if (Convert.ToInt32(cbYear.Text).Equals(DateTime.Now.Year))
                {
                    salaryMonth = DateTime.Now.Month;
                }
            }

            if ( salaryMonth != -1)
            {
                cry.Load(ConfigurationManager.AppSettings["reportPath"].ToString());
                DateTime startDate = new DateTime(Convert.ToInt32(cbYear.Text), cbMonth.SelectedIndex + 1, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(0).AddHours(-1).AddMinutes(59).AddSeconds(59);
               
                cry.SetParameterValue("Month", "Payslip For The Month Of  " + cbMonth.Text + "  " + cbYear.Text);
                cry.SetParameterValue("@startDate", startDate);
                cry.SetParameterValue("@endDate", endDate);
                crystalReportViewer1.ReportSource = cry;
            }
            else
            {
                MessageBox.Show("Please Select Month And Year", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmSalarySlip_Load(object sender, EventArgs e)
        {

        }

    }
}
