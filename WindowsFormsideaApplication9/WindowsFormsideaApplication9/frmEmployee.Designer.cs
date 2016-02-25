namespace EmployeeManagement
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtContactno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblprimaryContact = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mnuHome = new System.Windows.Forms.MenuStrip();
            this.llToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paidLeavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insentivesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paidLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insentivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlHome.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mnuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.pnlGrid);
            this.pnlHome.Controls.Add(this.pnlSearch);
            this.pnlHome.Controls.Add(this.mnuHome);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlHome.Size = new System.Drawing.Size(866, 405);
            this.pnlHome.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvEmployeeInfo);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(4, 87);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(5);
            this.pnlGrid.Size = new System.Drawing.Size(858, 318);
            this.pnlGrid.TabIndex = 3;
            // 
            // dgvEmployeeInfo
            // 
            this.dgvEmployeeInfo.AllowUserToAddRows = false;
            this.dgvEmployeeInfo.AllowUserToDeleteRows = false;
            this.dgvEmployeeInfo.AllowUserToResizeColumns = false;
            this.dgvEmployeeInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployeeInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(5, 5);
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.ReadOnly = true;
            this.dgvEmployeeInfo.RowHeadersVisible = false;
            this.dgvEmployeeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(848, 308);
            this.dgvEmployeeInfo.TabIndex = 2;
            this.dgvEmployeeInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeInfo_CellDoubleClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbSearch);
            this.pnlSearch.Controls.Add(this.panel1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(4, 27);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSearch.Size = new System.Drawing.Size(858, 60);
            this.pnlSearch.TabIndex = 2;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnRefresh);
            this.gbSearch.Controls.Add(this.txtContactno);
            this.gbSearch.Controls.Add(this.txtName);
            this.gbSearch.Controls.Add(this.txtLastName);
            this.gbSearch.Controls.Add(this.lblprimaryContact);
            this.gbSearch.Controls.Add(this.lblname);
            this.gbSearch.Controls.Add(this.lblLastName);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(5, 5);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(783, 50);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "SearchBy KYC";
            // 
            // txtContactno
            // 
            this.txtContactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactno.Location = new System.Drawing.Point(565, 18);
            this.txtContactno.Name = "txtContactno";
            this.txtContactno.Size = new System.Drawing.Size(100, 23);
            this.txtContactno.TabIndex = 3;
            this.txtContactno.TextChanged += new System.EventHandler(this.txtContactno_TextChanged);
            this.txtContactno.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(151, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(345, 18);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLast_TextChanged);
            this.txtLastName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // lblprimaryContact
            // 
            this.lblprimaryContact.AutoSize = true;
            this.lblprimaryContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprimaryContact.Location = new System.Drawing.Point(469, 21);
            this.lblprimaryContact.Name = "lblprimaryContact";
            this.lblprimaryContact.Size = new System.Drawing.Size(96, 15);
            this.lblprimaryContact.TabIndex = 8;
            this.lblprimaryContact.Text = "Primary Contact ";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(82, 21);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(67, 15);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(275, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 15);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLogOut);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(788, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 50);
            this.panel1.TabIndex = 4;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.Location = new System.Drawing.Point(12, 30);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(45, 13);
            this.lblLogOut.TabIndex = 12;
            this.lblLogOut.Text = "Log Out";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::EmployeeManagement.Resource1.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(23, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(20, 20);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // mnuHome
            // 
            this.mnuHome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.llToolStripMenuItem,
            this.employeeToolStripMenuItem1,
            this.attendanceToolStripMenuItem,
            this.salaryToolStripMenuItem,
            this.reportToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.mnuHome.Location = new System.Drawing.Point(4, 0);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(858, 27);
            this.mnuHome.TabIndex = 0;
            this.mnuHome.Text = "menuStrip1";
            // 
            // llToolStripMenuItem
            // 
            this.llToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem1});
            this.llToolStripMenuItem.Image = global::EmployeeManagement.Resource1.acc_status;
            this.llToolStripMenuItem.Name = "llToolStripMenuItem";
            this.llToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.llToolStripMenuItem.Text = "Login";
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Image = global::EmployeeManagement.Resource1.IconLogin;
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(187, 24);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.employeeToolStripMenuItem1.Image = global::EmployeeManagement.Resource1.dealer;
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(96, 23);
            this.employeeToolStripMenuItem1.Text = "Employee";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::EmployeeManagement.Resource1.btnadd;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.newToolStripMenuItem.Text = "Add New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAttendanceToolStripMenuItem,
            this.paidLeavesToolStripMenuItem});
            this.attendanceToolStripMenuItem.Image = global::EmployeeManagement.Resource1.expire;
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(107, 23);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // addAttendanceToolStripMenuItem
            // 
            this.addAttendanceToolStripMenuItem.Image = global::EmployeeManagement.Resource1.addBtn_web;
            this.addAttendanceToolStripMenuItem.Name = "addAttendanceToolStripMenuItem";
            this.addAttendanceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addAttendanceToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.addAttendanceToolStripMenuItem.Text = "Add Attendance";
            this.addAttendanceToolStripMenuItem.Click += new System.EventHandler(this.addAttendanceToolStripMenuItem_Click);
            // 
            // paidLeavesToolStripMenuItem
            // 
            this.paidLeavesToolStripMenuItem.Image = global::EmployeeManagement.Resource1._true;
            this.paidLeavesToolStripMenuItem.Name = "paidLeavesToolStripMenuItem";
            this.paidLeavesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.paidLeavesToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.paidLeavesToolStripMenuItem.Text = "Paid Leaves";
            this.paidLeavesToolStripMenuItem.Click += new System.EventHandler(this.paidLeavesToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insentivesToolStripMenuItem1});
            this.salaryToolStripMenuItem.Image = global::EmployeeManagement.Resource1.DTWeb_logo;
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // insentivesToolStripMenuItem1
            // 
            this.insentivesToolStripMenuItem1.Image = global::EmployeeManagement.Resource1._20_20_4da56c6e4199ee90672a68bb2f18884f_Browser;
            this.insentivesToolStripMenuItem1.Name = "insentivesToolStripMenuItem1";
            this.insentivesToolStripMenuItem1.Size = new System.Drawing.Size(139, 24);
            this.insentivesToolStripMenuItem1.Text = "Insentives";
            this.insentivesToolStripMenuItem1.Click += new System.EventHandler(this.insentivesToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem2});
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(62, 23);
            this.reportToolStripMenuItem1.Text = "Report";
            // 
            // employeeToolStripMenuItem2
            // 
            this.employeeToolStripMenuItem2.Name = "employeeToolStripMenuItem2";
            this.employeeToolStripMenuItem2.Size = new System.Drawing.Size(152, 24);
            this.employeeToolStripMenuItem2.Text = "Employee";
            this.employeeToolStripMenuItem2.Click += new System.EventHandler(this.employeeToolStripMenuItem2_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem1});
            this.helpToolStripMenuItem1.Image = global::EmployeeManagement.Resource1.iconQuestionMarkRed;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(65, 23);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // viewHelpToolStripMenuItem1
            // 
            this.viewHelpToolStripMenuItem1.Image = global::EmployeeManagement.Resource1.search;
            this.viewHelpToolStripMenuItem1.Name = "viewHelpToolStripMenuItem1";
            this.viewHelpToolStripMenuItem1.Size = new System.Drawing.Size(139, 24);
            this.viewHelpToolStripMenuItem1.Text = "View Help";
            this.viewHelpToolStripMenuItem1.Click += new System.EventHandler(this.viewHelpToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::EmployeeManagement.Resource1.IconLogin;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // mnuEmployee
            // 
            this.mnuEmployee.Name = "mnuEmployee";
            this.mnuEmployee.Size = new System.Drawing.Size(71, 20);
            this.mnuEmployee.Text = "Employee";
            // 
            // mnuNew
            // 
            this.mnuNew.Image = global::EmployeeManagement.Resource1.new_file_btn;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(152, 22);
            this.mnuNew.Text = "New";
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.payrollToolStripMenuItem.Text = "Attendance";
            // 
            // basicSalaryToolStripMenuItem
            // 
            this.basicSalaryToolStripMenuItem.Image = global::EmployeeManagement.Resource1.addBtn_web;
            this.basicSalaryToolStripMenuItem.Name = "basicSalaryToolStripMenuItem";
            this.basicSalaryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.basicSalaryToolStripMenuItem.Text = "Add Attendance";
            // 
            // paidLeaveToolStripMenuItem
            // 
            this.paidLeaveToolStripMenuItem.Image = global::EmployeeManagement.Resource1.acc_status;
            this.paidLeaveToolStripMenuItem.Name = "paidLeaveToolStripMenuItem";
            this.paidLeaveToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.paidLeaveToolStripMenuItem.Text = "Paid Leave";
            // 
            // salaryToolStripMenuItem1
            // 
            this.salaryToolStripMenuItem1.Name = "salaryToolStripMenuItem1";
            this.salaryToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.salaryToolStripMenuItem1.Text = "Salary";
            // 
            // insentivesToolStripMenuItem
            // 
            this.insentivesToolStripMenuItem.Image = global::EmployeeManagement.Resource1.dealer;
            this.insentivesToolStripMenuItem.Name = "insentivesToolStripMenuItem";
            this.insentivesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insentivesToolStripMenuItem.Text = "Insentives";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // allEmployeeToolStripMenuItem
            // 
            this.allEmployeeToolStripMenuItem.Name = "allEmployeeToolStripMenuItem";
            this.allEmployeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allEmployeeToolStripMenuItem.Text = "Pay Slip";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem1.Text = "Login";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // attendenceToolStripMenuItem
            // 
            this.attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            this.attendenceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendenceToolStripMenuItem.Text = "Attendence";
            // 
            // loginToolStripMenuItem2
            // 
            this.loginToolStripMenuItem2.Name = "loginToolStripMenuItem2";
            this.loginToolStripMenuItem2.Size = new System.Drawing.Size(46, 20);
            this.loginToolStripMenuItem2.Text = "login";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::EmployeeManagement.Resource1._5;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(680, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 26);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "      Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 405);
            this.Controls.Add(this.pnlHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuHome;
            this.MinimumSize = new System.Drawing.Size(860, 443);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.attendance_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuHome.ResumeLayout(false);
            this.mnuHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.MenuStrip mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployee;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem basicSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEmployeeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paidLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insentivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem llToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paidLeavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insentivesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtContactno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblprimaryContact;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnRefresh;
    }
}