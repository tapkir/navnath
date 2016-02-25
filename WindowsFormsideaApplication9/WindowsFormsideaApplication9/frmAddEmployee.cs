using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;
using System.Text.RegularExpressions;


namespace EmployeeManagement
{
    public partial class frmAddEmployee : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        string emp_id = "";
        string firstname, Middlename, lastname, gender, dob, address, primarycontact, secondarycontact, emailid, dateofjoin,AccountNo,IFSCcode, comment, salary;
        byte[] imageArray;
        MemoryStream ms;
        SqlCommand cmd ;

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        public frmAddEmployee(string emp_id,
            string firstname, string Middlename,string lastname, string  gender, 
            string dob, string address,  string primarycontact, 
            string secondarycontact, string emailid,  string dateofjoin,
            string AccountNo, string IFSCcode, string comment, string salary)
        {
            InitializeComponent();
            this.emp_id = emp_id;
            this.firstname = firstname;
            this.Middlename = Middlename;
            this.lastname = lastname;
            this.gender = gender;
            this.dob = dob;
            this.address = address;
            this.primarycontact = primarycontact;
            this.secondarycontact = secondarycontact;
            this.emailid = emailid;
            this.dateofjoin = dateofjoin;
            this.AccountNo = AccountNo;
            this.IFSCcode = IFSCcode;
            this.comment = comment;
            this.salary = salary;
         }
       

        void conv_photo()
        {
            if (pbimage.Image != null)
            {
                ms = new MemoryStream();
                pbimage.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }
        
        
        private void btsave_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                StringBuilder query = new StringBuilder();
                if (emp_id.Equals(string.Empty))
                {
                    string gender = rbfemale.Checked == true ? "Female" :"Male";
                    query.AppendLine(string.Format("INSERT INTO Employee (Firstname, Middlename, Lastname, gender, dob, address, primarycontact, secondarycontact, emailId, dateofjoin, AccountNo, IFSCcode, Comment, Salary) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}')",
                        txtFirstname.Text.Trim(),
                        txtMiddlename.Text.Trim(),
                        txtLastname.Text.Trim(),
                        gender,
                        dtbDDob.Text.Trim(),
                        rtbAddress.Text.Trim(),
                        txtPrimarycontact.Text.Trim(),
                        txtSecondarycontact.Text.Trim(),
                        txtEmailId.Text.Trim(),          
                        dtbDoj.Text.Trim(),
                        txtAccountno.Text.Trim(),
                        txtIfsc.Text.Trim(),
                        rtbComment.Text.Trim(),
                        txtSalary.Text.Trim()
                        ));
                    query.AppendLine(string.Format("INSERT INTO EmployeeImage (BinaryImage, EmpId) VALUES (@photo, (SELECT ident_current ('Employee')))"));                    
                    cmd = new SqlCommand(query.ToString(), con);
                    conv_photo();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    string gender = rbfemale.Checked == true ? "Female" : "Male";
                    query.AppendLine(string.Format("UPDATE Employee SET Firstname = '{0}', Middlename = '{1}', Lastname = '{2}', gender = '{3}', dob = '{4}', address = '{5}', primarycontact = '{6}', secondarycontact = '{7}' , emailId = '{8}', dateofjoin = '{9}', AccountNo = '{10}', IFSCcode = '{11}', Comment = '{12}', Salary = {13} WHERE Id = {14}",
                        txtFirstname.Text.Trim(),
                        txtMiddlename.Text.Trim(),
                        txtLastname.Text.Trim(),
                        gender,
                        dtbDDob.Text.Trim(),
                        rtbAddress.Text.Trim(),
                        txtPrimarycontact.Text.Trim(),
                        txtSecondarycontact.Text.Trim(),
                        txtEmailId.Text.Trim(),          
                        dtbDoj.Text.Trim(),
                        txtAccountno.Text.Trim(),
                        txtIfsc.Text.Trim(),
                        rtbComment.Text.Trim(),
                        txtSalary.Text.Trim(),
                        emp_id
                        ));
                    query.AppendLine(string.Format("DELETE FROM EmployeeImage WHERE EmpId={0}", emp_id));
                    query.AppendLine(string.Format("INSERT INTO EmployeeImage (BinaryImage, EmpId) VALUES(@photo, {0})", emp_id));
                    cmd = new SqlCommand(query.ToString(), con);
                    conv_photo();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Data Saved Successfully", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }

        }


        private bool IsValidInput()
        {
            float result;
            Regex nameExpr = new Regex(@"^[a-zA-Z\s]+$");
            Regex MobileExpr = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}[7-9][0-9](\s){0,1}(\-){0,1}(\s){0,1}[0-9]{1}[0-9]{7}$");
            
            if (txtFirstname.Text.Trim().Equals(string.Empty) ||
                txtLastname.Text.Trim().Equals(string.Empty) ||
                rtbAddress.Text.Trim().Equals(string.Empty) ||              
                txtPrimarycontact.Text.Trim().Equals(string.Empty) ||   
                dtbDDob.Text.Trim().Equals(string.Empty) ||               
                dtbDoj.Text.Trim().Equals(string.Empty) ||  
                txtAccountno.Text.Trim().Equals(string.Empty)||
                txtIfsc.Text.Trim().Equals(string.Empty) ||
                !float.TryParse(txtSalary.Text.Trim(), out result) ||
                !nameExpr.IsMatch(txtFirstname.Text.Trim()) ||
                !(txtMiddlename.Text.Trim().Equals(string.Empty) || nameExpr.IsMatch(txtMiddlename.Text.Trim()))  ||
                !nameExpr.IsMatch(txtLastname.Text.Trim()) ||
                !MobileExpr.IsMatch(txtPrimarycontact.Text.Trim())||
                rbfemale.Checked == false &&
                rbmalw.Checked == false)
            {
                MessageBox.Show("Please Enter Valid Data", "Invalid Input", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }

        
        private void btdelete_Click(object sender, EventArgs e)
        {
               DialogResult result = MessageBox.Show("Do You Want To Delete", "Employee Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
               if (result.Equals(DialogResult.Yes))
               {
                   StringBuilder query = new StringBuilder();
                   query.AppendLine(string.Format("UPDATE Employee SET IsDeleted = 1 WHERE Id = {0}", emp_id));
                   SqlCommand cmd = new SqlCommand(query.ToString(), con);
                   con.Open();
                   cmd.ExecuteNonQuery();
                   con.Close();
                   this.Close();
               }
        }

        
        private void newrec_Load(object sender, EventArgs e)
        {
            if (!emp_id.Equals(string.Empty))
            {
                txtFirstname.Text = firstname;
                txtMiddlename.Text = Middlename;
                txtLastname.Text = lastname;                           
                dtbDDob.Text = dob;
                rtbAddress.Text = address;
                txtPrimarycontact.Text = primarycontact;
                txtSecondarycontact.Text = secondarycontact;
                txtEmailId.Text = emailid;
                dtbDoj.Text = dateofjoin;             
                txtAccountno.Text=AccountNo;
                txtIfsc.Text=IFSCcode;
                txtSalary.Text = salary;
                rtbComment.Text = comment;
                if (gender.Trim().Equals("Female"))
                {
                    rbfemale.Checked = true;
                }
                else
                {
                    rbmalw.Checked = true;
                }
                string query = "SELECT BinaryImage FROM EmployeeImage WHERE EmpId = "+ emp_id;
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                imageArray = (byte[])dt.Rows[0]["BinaryImage"];
                ms = new MemoryStream(imageArray);
                pbimage.Image = Image.FromStream(ms);
            }
            else
            {
                 btdelete.Visible = false;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            DialogResult result = ofdImage.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                string path = ofdImage.FileName;
                pbimage.Image = Image.FromFile(path);

            }
        }


        }
    }


    
