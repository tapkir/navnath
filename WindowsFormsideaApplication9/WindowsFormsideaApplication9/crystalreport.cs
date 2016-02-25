using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace EmployeeManagement
{
    public partial class crystalreport : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        ReportDocument cry = new ReportDocument();
        public crystalreport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cry.Load(@"C:\Users\wintech\Documents\Visual Studio 2010\Projects\WindowsFormsideaApplication9\WindowsFormsideaApplication9\CrystalReport1.rpt");
            //SqlDataAdapter sda = new SqlDataAdapter("select ER.Id, ER.Firstname,AR.Absentdate,CS.Name,CS.percentage from Employee ER left join AbsentRecords AR on ER.Id=AR.EmpId left join SalaryComponent CS on AR.EmpId=CS.Id ", con);
            SqlDataAdapter sda = new SqlDataAdapter("select ER.Id,ER.Firstname,AR.Absentdate,CS.Name,CS.Percentage from Employee ER join AbsentRecords AR on ER.Id=AR.EmpId ,SalaryComponent CS ", con);           

            DataTable dt = new DataTable();
            sda.Fill(dt);
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
