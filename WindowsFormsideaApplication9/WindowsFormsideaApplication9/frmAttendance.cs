using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagement
{
    public partial class frmAttendance : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        int oldSelectedColumnIndex;
        DateTime gridDate;
        DataTable oldData;
        DataTable newData;

        public frmAttendance()
        {
            InitializeComponent();
        }


        private void frmAttendance_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            gridDate = DateTime.Now.AddMonths(1);
            btnSave.Location = new Point((this.Width - btnSave.Width) / 2,13);
            UpdateAttendanceGrid();
        }


        private void UpdateColumnSize()
        {
            foreach (DataGridViewColumn dgc in dgvAttendance.Columns)
            {
                if (!(dgc.Name.Equals("First Name") || dgc.Name.Equals("Middle Name") || dgc.Name.Equals("Last Name")))
                {
                    dgc.Width = 30;
                }
            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dgvAttendance.Columns[gridDate.Day.ToString()].DefaultCellStyle.BackColor = Color.White;
            UpdateAttendanceGrid();
        }


        private void UpdateAttendanceGrid()
        {   
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            if (gridDate.Month != selectedDate.Month)
            {
                dgvAttendance.CellEnter -= dataGridView1_CellEnter;
                dgvAttendance.DataSource = null;
                dgvAttendance.Columns.Clear();

                newData = new DataTable();
                string query = "SELECT Id, Firstname AS 'First Name', Middlename AS 'Middle Name', Lastname AS 'Last Name' FROM Employee";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(newData);
                
                int total = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);

                for (int i = 1; i <= total; i++)
                {
                    DataColumn dc = new DataColumn(i.ToString(), typeof(bool));
                    int readOnlyDate = GetReadOnlyDay();
                    if (i > readOnlyDate)
                    {
                        dc.DefaultValue = false;
                    }
                    else
                    {
                        dc.DefaultValue = true;
                    }
                    
                    newData.Columns.Add(dc);
                }

                dgvAttendance.DataSource = newData;
                dgvAttendance.Columns["Id"].Visible = false;
                UpdateColumnSize();
                MakeReadOnlyDate();
                MarkEmployeeAbsentee();
                oldData = newData.Copy();
                dgvAttendance.Columns["First Name"].Frozen = true;
                dgvAttendance.Columns["Middle Name"].Frozen = true;
                dgvAttendance.Columns["Last Name"].Frozen = true;
                dgvAttendance.CellEnter += dataGridView1_CellEnter;
                dgvAttendance.Columns["First Name"].Width = dgvAttendance.Columns["Middle Name"].Width = dgvAttendance.Columns["Last Name"].Width = (dgvAttendance.Width - (total * 30) - 4) / 3;
            }

            dgvAttendance.CurrentCell = dgvAttendance[selectedDate.Day.ToString(), 0];
            gridDate = selectedDate;
            oldSelectedColumnIndex = dgvAttendance.CurrentCell.ColumnIndex;
            dgvAttendance.Columns[oldSelectedColumnIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }


         private void MakeReadOnlyDate()
         {
             int readonlyDay = GetReadOnlyDay();
             int total = DateTime.DaysInMonth(monthCalendar1.SelectionRange.Start.Year, monthCalendar1.SelectionRange.Start.Month);
             for (int i = readonlyDay + 1; i <= total; i++)
             {
                 dgvAttendance.Columns[i.ToString()].ReadOnly = true;
             }
         }


        private int GetReadOnlyDay()
        {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            int readOnlyDay = 0;
            if (selectedDate.Month == DateTime.Now.Month && selectedDate.Year == DateTime.Now.Year)
            {
                readOnlyDay = DateTime.Now.Day;
            }
            else if (selectedDate < DateTime.Now)
            {
                readOnlyDay = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
            }
            return readOnlyDay;
        }


        private void MarkEmployeeAbsentee()
        {
            StringBuilder query = new StringBuilder();
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            DateTime startDate = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(0).AddHours(-1).AddMinutes(59).AddSeconds(59);

            query.AppendLine("SELECT EmpId, DATEPART(DAY,AbsentDate) AS DAY FROM AbsentRecords");
            query.AppendLine(string.Format("WHERE AbsentDate BETWEEN '{0}' AND '{1}'", startDate, endDate));
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query.ToString(), con);
            sda.Fill(dt);

            foreach (DataRow dgr in newData.Rows)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dgr["Id"].ToString().Equals(dr["EmpId"].ToString()))
                    {
                        dgr[dr["DAY"].ToString()] = false;
                    }
                }
            }
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            int rowCount = oldData.Rows.Count;
            int readOnlyCout = GetReadOnlyDay();
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;

            StringBuilder query = new StringBuilder();

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 1; j <= readOnlyCout; j++)
                {
                    if (oldData.Rows[i][j.ToString()].ToString().Equals("True") &&
                        newData.Rows[i][j.ToString()].ToString().Equals("False"))
                    {

                        string Date = new DateTime(selectedDate.Year, selectedDate.Month, j).ToString("MM/dd/yyyy");
                        query.AppendLine(string.Format("INSERT INTO AbsentRecords VALUES({0}, '{1}', 0)",
                        newData.Rows[i]["Id"].ToString(),
                        Date));
                    }
                    else if (newData.Rows[i][j.ToString()].ToString().Equals("True") &&
                             oldData.Rows[i][j.ToString()].ToString().Equals("False"))
                    {
                        string Date = new DateTime(selectedDate.Year, selectedDate.Month, j).ToString("MM/dd/yyyy");
                        query.AppendLine(string.Format("DELETE FROM AbsentRecords WHERE CONVERT(VARCHAR(10), AbsentDate, 101) = CONVERT(VARCHAR(10), '{0}', 101)  AND EmpId = {1}",
                        Date,
                        newData.Rows[i]["Id"].ToString()));
                    }

                }
            }
            if (!query.ToString().Equals(string.Empty))
            {
                SqlCommand cmd = new SqlCommand(query.ToString(), con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            oldData = newData.Copy();
            MessageBox.Show("Attendance Updated Successfully");
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (oldSelectedColumnIndex <= 32)
            {
                dgvAttendance.Columns[oldSelectedColumnIndex].DefaultCellStyle.BackColor = Color.White;
                oldSelectedColumnIndex = e.ColumnIndex;
                dgvAttendance.Columns[oldSelectedColumnIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }


    }
}
