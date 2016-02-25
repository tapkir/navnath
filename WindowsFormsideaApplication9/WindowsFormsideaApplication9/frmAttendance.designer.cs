namespace EmployeeManagement
{
    partial class frmAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendance));
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlCalender = new System.Windows.Forms.Panel();
            this.pbHeaderImage = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pnlHome.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlCalender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.pnlGrid);
            this.pnlHome.Controls.Add(this.pnlButton);
            this.pnlHome.Controls.Add(this.pnlCalender);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(994, 540);
            this.pnlHome.TabIndex = 3;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvAttendance);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 165);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pnlGrid.Size = new System.Drawing.Size(994, 322);
            this.pnlGrid.TabIndex = 8;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeColumns = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.Location = new System.Drawing.Point(0, 3);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAttendance.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(994, 319);
            this.dgvAttendance.TabIndex = 3;
            this.dgvAttendance.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 487);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(994, 53);
            this.pnlButton.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::EmployeeManagement.Resource1.btnadd;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(463, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "    Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlCalender
            // 
            this.pnlCalender.Controls.Add(this.pbHeaderImage);
            this.pnlCalender.Controls.Add(this.monthCalendar1);
            this.pnlCalender.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCalender.Location = new System.Drawing.Point(0, 0);
            this.pnlCalender.Name = "pnlCalender";
            this.pnlCalender.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pnlCalender.Size = new System.Drawing.Size(994, 165);
            this.pnlCalender.TabIndex = 6;
            // 
            // pbHeaderImage
            // 
            this.pbHeaderImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHeaderImage.BackgroundImage")));
            this.pbHeaderImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHeaderImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHeaderImage.Location = new System.Drawing.Point(0, 3);
            this.pbHeaderImage.Name = "pbHeaderImage";
            this.pbHeaderImage.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pbHeaderImage.Size = new System.Drawing.Size(767, 162);
            this.pbHeaderImage.TabIndex = 5;
            this.pbHeaderImage.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.monthCalendar1.Location = new System.Drawing.Point(767, 3);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 540);
            this.Controls.Add(this.pnlHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance System";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlCalender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlCalender;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.PictureBox pbHeaderImage;

    }
}

