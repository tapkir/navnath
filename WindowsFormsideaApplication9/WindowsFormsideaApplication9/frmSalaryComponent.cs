using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagement
{
    public partial class frmSalaryComponent : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        DataTable dtSalaryComponent;
        SqlDataAdapter sqlDa;

        public frmSalaryComponent()
        {
            InitializeComponent();
        }

        private void SalaryComponent_Load(object sender, EventArgs e)
        {
            sqlDa = new SqlDataAdapter("SELECT Id, Name, Percentage FROM SalaryComponent", con);
            dtSalaryComponent = new DataTable();
            sqlDa.Fill(dtSalaryComponent);
            dgvSalaryComponent.DataSource = dtSalaryComponent;
            dgvSalaryComponent.Columns["Id"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsSalaryComponentValid())
            {
                DataTable changeData = new DataTable();
                changeData = dtSalaryComponent.GetChanges();
                SqlCommandBuilder sqlCmdBuilder = new SqlCommandBuilder(sqlDa);
                sqlDa.Update(dtSalaryComponent);
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsSalaryComponentValid()
        {
            List<string> lstSalaryComponents = new List<string>();
            double totalPercentage = 0;
            double percentage;
            DataTable dtUpdatedSalaryComponent = dtSalaryComponent.Copy();
            dtUpdatedSalaryComponent.AcceptChanges();
            foreach (DataRow dr in dtUpdatedSalaryComponent.Rows)
            {
                string salaryComponet = Convert.ToString(dr["Name"]);
                if (lstSalaryComponents.Any(x => x.ToLower().Equals(salaryComponet.ToLower())))
                {
                    MessageBox.Show(string.Format("{0} Salary Componet already exists", salaryComponet), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    lstSalaryComponents.Add(salaryComponet);
                    if (double.TryParse(Convert.ToString(dr["Percentage"]), out percentage))
                    {
                        totalPercentage += percentage;
                    }
                    else
                    {
                        MessageBox.Show("Please provide valid percentage value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            if (totalPercentage != 100)
            {
                MessageBox.Show(string.Format("Total Percentage is {0}%. Sum must be equal to 100%", totalPercentage), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void dgvSalaryComponent_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please provide valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = false;
        }
    }
}
