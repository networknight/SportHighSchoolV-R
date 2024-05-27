namespace SportHighSchool
{
    partial class FrmStudents
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
            this.LbStudentMobile = new System.Windows.Forms.Label();
            this.ComMedicalExpertiseID = new System.Windows.Forms.ComboBox();
            this.LbStudentAddress = new System.Windows.Forms.Label();
            this.LbStudentNationalCode = new System.Windows.Forms.Label();
            this.LbStudentCode = new System.Windows.Forms.Label();
            this.LbMedicalExpertiseID = new System.Windows.Forms.Label();
            this.LbStudentName = new System.Windows.Forms.Label();
            this.LbStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.txtStudentMobile = new System.Windows.Forms.TextBox();
            this.txtStudentNationalCode = new System.Windows.Forms.TextBox();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.GroupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // LbStudentMobile
            // 
            this.LbStudentMobile.AutoSize = true;
            this.LbStudentMobile.Location = new System.Drawing.Point(811, 165);
            this.LbStudentMobile.Name = "LbStudentMobile";
            this.LbStudentMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbStudentMobile.Size = new System.Drawing.Size(42, 13);
            this.LbStudentMobile.TabIndex = 16;
            this.LbStudentMobile.Text = "همراه :";
            // 
            // ComMedicalExpertiseID
            // 
            this.ComMedicalExpertiseID.DisplayMember = "MedicalExpertiseName";
            this.ComMedicalExpertiseID.FormattingEnabled = true;
            this.ComMedicalExpertiseID.Location = new System.Drawing.Point(440, 125);
            this.ComMedicalExpertiseID.Name = "ComMedicalExpertiseID";
            this.ComMedicalExpertiseID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComMedicalExpertiseID.Size = new System.Drawing.Size(200, 21);
            this.ComMedicalExpertiseID.TabIndex = 1;
            this.ComMedicalExpertiseID.ValueMember = "MedicalExpertiseID";
            // 
            // LbStudentAddress
            // 
            this.LbStudentAddress.AutoSize = true;
            this.LbStudentAddress.Location = new System.Drawing.Point(598, 165);
            this.LbStudentAddress.Name = "LbStudentAddress";
            this.LbStudentAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbStudentAddress.Size = new System.Drawing.Size(39, 13);
            this.LbStudentAddress.TabIndex = 17;
            this.LbStudentAddress.Text = "آدرس :";
            // 
            // LbStudentNationalCode
            // 
            this.LbStudentNationalCode.AutoSize = true;
            this.LbStudentNationalCode.Location = new System.Drawing.Point(158, 106);
            this.LbStudentNationalCode.Name = "LbStudentNationalCode";
            this.LbStudentNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbStudentNationalCode.Size = new System.Drawing.Size(49, 13);
            this.LbStudentNationalCode.TabIndex = 15;
            this.LbStudentNationalCode.Text = "کد ملی :";
            // 
            // LbStudentCode
            // 
            this.LbStudentCode.AutoSize = true;
            this.LbStudentCode.Location = new System.Drawing.Point(315, 105);
            this.LbStudentCode.Name = "LbStudentCode";
            this.LbStudentCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbStudentCode.Size = new System.Drawing.Size(107, 13);
            this.LbStudentCode.TabIndex = 14;
            this.LbStudentCode.Text = "شماره نظام پزشکی :";
            // 
            // LbMedicalExpertiseID
            // 
            this.LbMedicalExpertiseID.AutoSize = true;
            this.LbMedicalExpertiseID.Location = new System.Drawing.Point(591, 105);
            this.LbMedicalExpertiseID.Name = "LbMedicalExpertiseID";
            this.LbMedicalExpertiseID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbMedicalExpertiseID.Size = new System.Drawing.Size(46, 13);
            this.LbMedicalExpertiseID.TabIndex = 13;
            this.LbMedicalExpertiseID.Text = "تخصص :";
            // 
            // LbStudentName
            // 
            this.LbStudentName.AutoSize = true;
            this.LbStudentName.Location = new System.Drawing.Point(757, 105);
            this.LbStudentName.Name = "LbStudentName";
            this.LbStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbStudentName.Size = new System.Drawing.Size(96, 13);
            this.LbStudentName.TabIndex = 12;
            this.LbStudentName.Text = "نام و نام خانوادگی :";
            // 
            // LbStudentID
            // 
            this.LbStudentID.AutoSize = true;
            this.LbStudentID.Location = new System.Drawing.Point(804, 54);
            this.LbStudentID.Name = "LbStudentID";
            this.LbStudentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbStudentID.Size = new System.Drawing.Size(49, 13);
            this.LbStudentID.TabIndex = 10;
            this.LbStudentID.Text = "شناسه :";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Enabled = false;
            this.txtStudentID.Location = new System.Drawing.Point(655, 74);
            this.txtStudentID.MaxLength = 50;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 21);
            this.txtStudentID.TabIndex = 11;
            this.txtStudentID.Text = "0";
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(10, 185);
            this.txtStudentAddress.MaxLength = 450;
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentAddress.Size = new System.Drawing.Size(630, 21);
            this.txtStudentAddress.TabIndex = 5;
            // 
            // txtStudentMobile
            // 
            this.txtStudentMobile.Location = new System.Drawing.Point(655, 185);
            this.txtStudentMobile.MaxLength = 11;
            this.txtStudentMobile.Name = "txtStudentMobile";
            this.txtStudentMobile.Size = new System.Drawing.Size(200, 21);
            this.txtStudentMobile.TabIndex = 4;
            // 
            // txtStudentNationalCode
            // 
            this.txtStudentNationalCode.Location = new System.Drawing.Point(10, 125);
            this.txtStudentNationalCode.MaxLength = 10;
            this.txtStudentNationalCode.Name = "txtStudentNationalCode";
            this.txtStudentNationalCode.Size = new System.Drawing.Size(200, 21);
            this.txtStudentNationalCode.TabIndex = 3;
            this.txtStudentNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(225, 125);
            this.txtStudentCode.MaxLength = 10;
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(200, 21);
            this.txtStudentCode.TabIndex = 2;
            this.txtStudentCode.Text = "1000";
            this.txtStudentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(655, 125);
            this.txtStudentName.MaxLength = 50;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.Size = new System.Drawing.Size(200, 21);
            this.txtStudentName.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::SportHighSchool.Properties.Resources.New;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNew.Location = new System.Drawing.Point(320, 20);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(100, 50);
            this.BtnNew.TabIndex = 7;
            this.BtnNew.Text = "ایجاد";
            this.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::SportHighSchool.Properties.Resources.Save;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(215, 20);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 50);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "ثبت";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::SportHighSchool.Properties.Resources.Delete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(110, 20);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 50);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Image = global::SportHighSchool.Properties.Resources.Exit;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(5, 20);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 50);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "بستن";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GroupItem
            // 
            this.GroupItem.Controls.Add(this.LbStudentMobile);
            this.GroupItem.Controls.Add(this.ComMedicalExpertiseID);
            this.GroupItem.Controls.Add(this.LbStudentAddress);
            this.GroupItem.Controls.Add(this.LbStudentNationalCode);
            this.GroupItem.Controls.Add(this.LbStudentCode);
            this.GroupItem.Controls.Add(this.LbMedicalExpertiseID);
            this.GroupItem.Controls.Add(this.LbStudentName);
            this.GroupItem.Controls.Add(this.LbStudentID);
            this.GroupItem.Controls.Add(this.txtStudentID);
            this.GroupItem.Controls.Add(this.txtStudentAddress);
            this.GroupItem.Controls.Add(this.txtStudentMobile);
            this.GroupItem.Controls.Add(this.txtStudentNationalCode);
            this.GroupItem.Controls.Add(this.txtStudentCode);
            this.GroupItem.Controls.Add(this.txtStudentName);
            this.GroupItem.Controls.Add(this.BtnNew);
            this.GroupItem.Controls.Add(this.BtnSave);
            this.GroupItem.Controls.Add(this.BtnDelete);
            this.GroupItem.Controls.Add(this.BtnExit);
            this.GroupItem.Location = new System.Drawing.Point(5, 0);
            this.GroupItem.Margin = new System.Windows.Forms.Padding(10);
            this.GroupItem.Name = "GroupItem";
            this.GroupItem.Size = new System.Drawing.Size(865, 225);
            this.GroupItem.TabIndex = 4;
            this.GroupItem.TabStop = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(570, 246);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(660, 246);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(200, 21);
            this.txtSearch.TabIndex = 5;
            // 
            // DgvList
            // 
            this.DgvList.AllowUserToAddRows = false;
            this.DgvList.AllowUserToDeleteRows = false;
            this.DgvList.AllowUserToResizeColumns = false;
            this.DgvList.AllowUserToResizeRows = false;
            this.DgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvList.Location = new System.Drawing.Point(0, 295);
            this.DgvList.MultiSelect = false;
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.RowHeadersVisible = false;
            this.DgvList.RowHeadersWidth = 50;
            this.DgvList.Size = new System.Drawing.Size(874, 366);
            this.DgvList.TabIndex = 7;
            this.DgvList.DoubleClick += new System.EventHandler(this.DgvList_DoubleClick);
            // 
            // FrmStudents
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(874, 661);
            this.ControlBox = false;
            this.Controls.Add(this.GroupItem);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DgvList);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximumSize = new System.Drawing.Size(890, 700);
            this.MinimumSize = new System.Drawing.Size(890, 700);
            this.Name = "FrmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دانش آموزان";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbStudentMobile;
        private System.Windows.Forms.ComboBox ComMedicalExpertiseID;
        private System.Windows.Forms.Label LbStudentAddress;
        private System.Windows.Forms.Label LbStudentNationalCode;
        private System.Windows.Forms.Label LbStudentCode;
        private System.Windows.Forms.Label LbMedicalExpertiseID;
        private System.Windows.Forms.Label LbStudentName;
        private System.Windows.Forms.Label LbStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.TextBox txtStudentMobile;
        private System.Windows.Forms.TextBox txtStudentNationalCode;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DgvList;
    }
}