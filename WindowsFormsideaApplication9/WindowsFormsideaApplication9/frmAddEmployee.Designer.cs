namespace EmployeeManagement
{
    partial class frmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            this.btsave = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.lblEmailid = new System.Windows.Forms.Label();
            this.txtSecondarycontact = new System.Windows.Forms.TextBox();
            this.lblScontact = new System.Windows.Forms.Label();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.lblMname = new System.Windows.Forms.Label();
            this.dtbDoj = new System.Windows.Forms.DateTimePicker();
            this.dtbDDob = new System.Windows.Forms.DateTimePicker();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmalw = new System.Windows.Forms.RadioButton();
            this.txtPrimarycontact = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lbldoj = new System.Windows.Forms.Label();
            this.lblpContactno = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.gbBankDetails = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIfsc = new System.Windows.Forms.TextBox();
            this.txtAccountno = new System.Windows.Forms.TextBox();
            this.lblifscode = new System.Windows.Forms.Label();
            this.lblAccountno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbImage.SuspendLayout();
            this.gbBankDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btsave
            // 
            this.btsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.Image = global::EmployeeManagement.Resource1.btnadd;
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsave.Location = new System.Drawing.Point(296, 439);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 28);
            this.btsave.TabIndex = 17;
            this.btsave.Text = "   Save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Image = global::EmployeeManagement.Resource1.upload;
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(83, 166);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 28);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "    Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbimage
            // 
            this.pbimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbimage.Image = global::EmployeeManagement.Resource1.default_profile;
            this.pbimage.Location = new System.Drawing.Point(34, 22);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(167, 142);
            this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimage.TabIndex = 49;
            this.pbimage.TabStop = false;
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.Image = global::EmployeeManagement.Resource1.delete;
            this.btdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdelete.Location = new System.Drawing.Point(377, 439);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 28);
            this.btdelete.TabIndex = 18;
            this.btdelete.Text = "  Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.rtbComment);
            this.gbInfo.Controls.Add(this.lblComment);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtEmailId);
            this.gbInfo.Controls.Add(this.lblEmailid);
            this.gbInfo.Controls.Add(this.txtSecondarycontact);
            this.gbInfo.Controls.Add(this.lblScontact);
            this.gbInfo.Controls.Add(this.rtbAddress);
            this.gbInfo.Controls.Add(this.txtLastname);
            this.gbInfo.Controls.Add(this.lblLName);
            this.gbInfo.Controls.Add(this.txtMiddlename);
            this.gbInfo.Controls.Add(this.lblMname);
            this.gbInfo.Controls.Add(this.dtbDoj);
            this.gbInfo.Controls.Add(this.dtbDDob);
            this.gbInfo.Controls.Add(this.rbfemale);
            this.gbInfo.Controls.Add(this.rbmalw);
            this.gbInfo.Controls.Add(this.txtPrimarycontact);
            this.gbInfo.Controls.Add(this.txtFirstname);
            this.gbInfo.Controls.Add(this.lbldoj);
            this.gbInfo.Controls.Add(this.lblpContactno);
            this.gbInfo.Controls.Add(this.lblAddress);
            this.gbInfo.Controls.Add(this.lblDoB);
            this.gbInfo.Controls.Add(this.lblGender);
            this.gbInfo.Controls.Add(this.lblFName);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(12, 18);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(421, 415);
            this.gbInfo.TabIndex = 59;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Personal Details";
            // 
            // rtbComment
            // 
            this.rtbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbComment.Location = new System.Drawing.Point(155, 341);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(153, 67);
            this.rtbComment.TabIndex = 12;
            this.rtbComment.Text = "";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(32, 346);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(61, 15);
            this.lblComment.TabIndex = 84;
            this.lblComment.Text = "Comment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(314, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 83;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(314, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 82;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(314, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 81;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(314, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 80;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(314, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(314, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(314, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 77;
            this.label1.Text = "*";
            // 
            // txtEmailId
            // 
            this.txtEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailId.Location = new System.Drawing.Point(155, 287);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(153, 23);
            this.txtEmailId.TabIndex = 10;
            // 
            // lblEmailid
            // 
            this.lblEmailid.AutoSize = true;
            this.lblEmailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailid.Location = new System.Drawing.Point(33, 293);
            this.lblEmailid.Name = "lblEmailid";
            this.lblEmailid.Size = new System.Drawing.Size(52, 15);
            this.lblEmailid.TabIndex = 76;
            this.lblEmailid.Text = "Email Id";
            // 
            // txtSecondarycontact
            // 
            this.txtSecondarycontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondarycontact.Location = new System.Drawing.Point(157, 261);
            this.txtSecondarycontact.Name = "txtSecondarycontact";
            this.txtSecondarycontact.Size = new System.Drawing.Size(153, 23);
            this.txtSecondarycontact.TabIndex = 9;
            // 
            // lblScontact
            // 
            this.lblScontact.AutoSize = true;
            this.lblScontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScontact.Location = new System.Drawing.Point(33, 266);
            this.lblScontact.Name = "lblScontact";
            this.lblScontact.Size = new System.Drawing.Size(112, 15);
            this.lblScontact.TabIndex = 74;
            this.lblScontact.Text = "Secondary Contact ";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAddress.Location = new System.Drawing.Point(156, 143);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(153, 86);
            this.rtbAddress.TabIndex = 7;
            this.rtbAddress.Text = "";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(157, 68);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(153, 20);
            this.txtLastname.TabIndex = 3;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(33, 71);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(64, 15);
            this.lblLName.TabIndex = 71;
            this.lblLName.Text = "LastName";
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.Location = new System.Drawing.Point(157, 41);
            this.txtMiddlename.Multiline = true;
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(153, 20);
            this.txtMiddlename.TabIndex = 2;
            // 
            // lblMname
            // 
            this.lblMname.AutoSize = true;
            this.lblMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMname.Location = new System.Drawing.Point(33, 46);
            this.lblMname.Name = "lblMname";
            this.lblMname.Size = new System.Drawing.Size(82, 15);
            this.lblMname.TabIndex = 69;
            this.lblMname.Text = "Middle Name";
            // 
            // dtbDoj
            // 
            this.dtbDoj.CustomFormat = "dd-MMM-yyyy";
            this.dtbDoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbDoj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbDoj.Location = new System.Drawing.Point(156, 313);
            this.dtbDoj.Name = "dtbDoj";
            this.dtbDoj.Size = new System.Drawing.Size(153, 23);
            this.dtbDoj.TabIndex = 11;
            // 
            // dtbDDob
            // 
            this.dtbDDob.CustomFormat = "dd-MMM-yyyy";
            this.dtbDDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbDDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbDDob.Location = new System.Drawing.Point(155, 117);
            this.dtbDDob.Name = "dtbDDob";
            this.dtbDDob.Size = new System.Drawing.Size(153, 23);
            this.dtbDDob.TabIndex = 6;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(210, 94);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(63, 19);
            this.rbfemale.TabIndex = 5;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmalw
            // 
            this.rbmalw.AutoSize = true;
            this.rbmalw.Location = new System.Drawing.Point(156, 94);
            this.rbmalw.Name = "rbmalw";
            this.rbmalw.Size = new System.Drawing.Size(53, 19);
            this.rbmalw.TabIndex = 4;
            this.rbmalw.TabStop = true;
            this.rbmalw.Text = "Male";
            this.rbmalw.UseVisualStyleBackColor = true;
            // 
            // txtPrimarycontact
            // 
            this.txtPrimarycontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimarycontact.Location = new System.Drawing.Point(157, 235);
            this.txtPrimarycontact.Name = "txtPrimarycontact";
            this.txtPrimarycontact.Size = new System.Drawing.Size(153, 23);
            this.txtPrimarycontact.TabIndex = 8;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(157, 15);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(153, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // lbldoj
            // 
            this.lbldoj.AutoSize = true;
            this.lbldoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoj.Location = new System.Drawing.Point(33, 318);
            this.lbldoj.Name = "lbldoj";
            this.lbldoj.Size = new System.Drawing.Size(89, 15);
            this.lbldoj.TabIndex = 67;
            this.lbldoj.Text = "Date of Joining";
            // 
            // lblpContactno
            // 
            this.lblpContactno.AutoSize = true;
            this.lblpContactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpContactno.Location = new System.Drawing.Point(33, 240);
            this.lblpContactno.Name = "lblpContactno";
            this.lblpContactno.Size = new System.Drawing.Size(92, 15);
            this.lblpContactno.TabIndex = 65;
            this.lblpContactno.Text = "Primay Contact ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(33, 148);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 15);
            this.lblAddress.TabIndex = 62;
            this.lblAddress.Text = "Address";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(33, 122);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(74, 15);
            this.lblDoB.TabIndex = 61;
            this.lblDoB.Text = "Date of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(33, 96);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 60;
            this.lblGender.Text = "Gender";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(35, 18);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 15);
            this.lblFName.TabIndex = 59;
            this.lblFName.Text = "First Name";
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.pbimage);
            this.gbImage.Controls.Add(this.btnUpload);
            this.gbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImage.Location = new System.Drawing.Point(439, 18);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(235, 196);
            this.gbImage.TabIndex = 60;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image";
            // 
            // gbBankDetails
            // 
            this.gbBankDetails.Controls.Add(this.label10);
            this.gbBankDetails.Controls.Add(this.txtSalary);
            this.gbBankDetails.Controls.Add(this.label9);
            this.gbBankDetails.Controls.Add(this.lblSalary);
            this.gbBankDetails.Controls.Add(this.label8);
            this.gbBankDetails.Controls.Add(this.txtIfsc);
            this.gbBankDetails.Controls.Add(this.txtAccountno);
            this.gbBankDetails.Controls.Add(this.lblifscode);
            this.gbBankDetails.Controls.Add(this.lblAccountno);
            this.gbBankDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBankDetails.Location = new System.Drawing.Point(439, 282);
            this.gbBankDetails.Name = "gbBankDetails";
            this.gbBankDetails.Size = new System.Drawing.Size(235, 151);
            this.gbBankDetails.TabIndex = 61;
            this.gbBankDetails.TabStop = false;
            this.gbBankDetails.Text = "Salary Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(207, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 85;
            this.label10.Text = "*";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(101, 32);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 23);
            this.txtSalary.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(207, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 85;
            this.label9.Text = "*";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(10, 37);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(41, 15);
            this.lblSalary.TabIndex = 87;
            this.lblSalary.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(207, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 84;
            this.label8.Text = "*";
            // 
            // txtIfsc
            // 
            this.txtIfsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIfsc.Location = new System.Drawing.Point(101, 104);
            this.txtIfsc.Name = "txtIfsc";
            this.txtIfsc.Size = new System.Drawing.Size(100, 23);
            this.txtIfsc.TabIndex = 16;
            // 
            // txtAccountno
            // 
            this.txtAccountno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountno.Location = new System.Drawing.Point(101, 68);
            this.txtAccountno.Name = "txtAccountno";
            this.txtAccountno.Size = new System.Drawing.Size(100, 23);
            this.txtAccountno.TabIndex = 15;
            // 
            // lblifscode
            // 
            this.lblifscode.AutoSize = true;
            this.lblifscode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblifscode.Location = new System.Drawing.Point(10, 108);
            this.lblifscode.Name = "lblifscode";
            this.lblifscode.Size = new System.Drawing.Size(65, 15);
            this.lblifscode.TabIndex = 1;
            this.lblifscode.Text = "IFSC Code";
            // 
            // lblAccountno
            // 
            this.lblAccountno.AutoSize = true;
            this.lblAccountno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountno.Location = new System.Drawing.Point(10, 72);
            this.lblAccountno.Name = "lblAccountno";
            this.lblAccountno.Size = new System.Drawing.Size(69, 15);
            this.lblAccountno.TabIndex = 0;
            this.lblAccountno.Text = "Account No";
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(728, 469);
            this.Controls.Add(this.gbBankDetails);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btsave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(744, 507);
            this.MinimumSize = new System.Drawing.Size(744, 507);
            this.Name = "frmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.newrec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbImage.ResumeLayout(false);
            this.gbBankDetails.ResumeLayout(false);
            this.gbBankDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DateTimePicker dtbDoj;
        private System.Windows.Forms.DateTimePicker dtbDDob;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmalw;
        private System.Windows.Forms.TextBox txtPrimarycontact;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lbldoj;
        private System.Windows.Forms.Label lblpContactno;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.GroupBox gbBankDetails;
        private System.Windows.Forms.TextBox txtIfsc;
        private System.Windows.Forms.TextBox txtAccountno;
        private System.Windows.Forms.Label lblifscode;
        private System.Windows.Forms.Label lblAccountno;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.Label lblMname;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label lblEmailid;
        private System.Windows.Forms.TextBox txtSecondarycontact;
        private System.Windows.Forms.Label lblScontact;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label10;


    }
}