namespace SportHighSchool
{
    partial class FrmSchools
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
            this.ComProvinceID = new System.Windows.Forms.ComboBox();
            this.LbProvinceID = new System.Windows.Forms.Label();
            this.LbSchoolID = new System.Windows.Forms.Label();
            this.txtSchoolID = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.LbAmountTeaching = new System.Windows.Forms.Label();
            this.txtAmountTeaching = new System.Windows.Forms.TextBox();
            this.LbCountClass = new System.Windows.Forms.Label();
            this.txtCountClass = new System.Windows.Forms.TextBox();
            this.LbCountStudent = new System.Windows.Forms.Label();
            this.txtCountStudent = new System.Windows.Forms.TextBox();
            this.LbManager = new System.Windows.Forms.Label();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.LbPhysicalEducationTeacher = new System.Windows.Forms.Label();
            this.txtPhysicalEducationTeacher = new System.Windows.Forms.TextBox();
            this.LbStudyPeriod = new System.Windows.Forms.Label();
            this.txtStudyPeriod = new System.Windows.Forms.TextBox();
            this.LbArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.LbSchoolName = new System.Windows.Forms.Label();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.ComCityID = new System.Windows.Forms.ComboBox();
            this.LbCityID = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.GroupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // ComProvinceID
            // 
            this.ComProvinceID.DisplayMember = "Province";
            this.ComProvinceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComProvinceID.FormattingEnabled = true;
            this.ComProvinceID.Location = new System.Drawing.Point(657, 125);
            this.ComProvinceID.Name = "ComProvinceID";
            this.ComProvinceID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComProvinceID.Size = new System.Drawing.Size(200, 21);
            this.ComProvinceID.TabIndex = 0;
            this.ComProvinceID.ValueMember = "ProvinceID";
            this.ComProvinceID.SelectedIndexChanged += new System.EventHandler(this.ComProvinceID_SelectedIndexChanged);
            // 
            // LbProvinceID
            // 
            this.LbProvinceID.AutoSize = true;
            this.LbProvinceID.Location = new System.Drawing.Point(815, 107);
            this.LbProvinceID.Name = "LbProvinceID";
            this.LbProvinceID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbProvinceID.Size = new System.Drawing.Size(42, 13);
            this.LbProvinceID.TabIndex = 16;
            this.LbProvinceID.Text = "استان :";
            // 
            // LbSchoolID
            // 
            this.LbSchoolID.AutoSize = true;
            this.LbSchoolID.Location = new System.Drawing.Point(808, 54);
            this.LbSchoolID.Name = "LbSchoolID";
            this.LbSchoolID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbSchoolID.Size = new System.Drawing.Size(49, 13);
            this.LbSchoolID.TabIndex = 14;
            this.LbSchoolID.Text = "شناسه :";
            // 
            // txtSchoolID
            // 
            this.txtSchoolID.Enabled = false;
            this.txtSchoolID.Location = new System.Drawing.Point(657, 75);
            this.txtSchoolID.MaxLength = 50;
            this.txtSchoolID.Name = "txtSchoolID";
            this.txtSchoolID.Size = new System.Drawing.Size(200, 21);
            this.txtSchoolID.TabIndex = 15;
            this.txtSchoolID.Text = "0";
            this.txtSchoolID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::SportHighSchool.Properties.Resources.New;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNew.Location = new System.Drawing.Point(320, 20);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(100, 50);
            this.BtnNew.TabIndex = 11;
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
            this.BtnSave.TabIndex = 10;
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
            this.BtnDelete.TabIndex = 12;
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
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "بستن";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GroupItem
            // 
            this.GroupItem.Controls.Add(this.LbAmountTeaching);
            this.GroupItem.Controls.Add(this.txtAmountTeaching);
            this.GroupItem.Controls.Add(this.LbCountClass);
            this.GroupItem.Controls.Add(this.txtCountClass);
            this.GroupItem.Controls.Add(this.LbCountStudent);
            this.GroupItem.Controls.Add(this.txtCountStudent);
            this.GroupItem.Controls.Add(this.LbManager);
            this.GroupItem.Controls.Add(this.txtManager);
            this.GroupItem.Controls.Add(this.LbPhysicalEducationTeacher);
            this.GroupItem.Controls.Add(this.txtPhysicalEducationTeacher);
            this.GroupItem.Controls.Add(this.LbStudyPeriod);
            this.GroupItem.Controls.Add(this.txtStudyPeriod);
            this.GroupItem.Controls.Add(this.LbArea);
            this.GroupItem.Controls.Add(this.txtArea);
            this.GroupItem.Controls.Add(this.LbSchoolName);
            this.GroupItem.Controls.Add(this.txtSchoolName);
            this.GroupItem.Controls.Add(this.ComCityID);
            this.GroupItem.Controls.Add(this.LbCityID);
            this.GroupItem.Controls.Add(this.ComProvinceID);
            this.GroupItem.Controls.Add(this.LbProvinceID);
            this.GroupItem.Controls.Add(this.LbSchoolID);
            this.GroupItem.Controls.Add(this.txtSchoolID);
            this.GroupItem.Controls.Add(this.BtnNew);
            this.GroupItem.Controls.Add(this.BtnSave);
            this.GroupItem.Controls.Add(this.BtnDelete);
            this.GroupItem.Controls.Add(this.BtnExit);
            this.GroupItem.Location = new System.Drawing.Point(5, 0);
            this.GroupItem.Margin = new System.Windows.Forms.Padding(10);
            this.GroupItem.Name = "GroupItem";
            this.GroupItem.Size = new System.Drawing.Size(865, 265);
            this.GroupItem.TabIndex = 0;
            this.GroupItem.TabStop = false;
            // 
            // LbAmountTeaching
            // 
            this.LbAmountTeaching.AutoSize = true;
            this.LbAmountTeaching.Location = new System.Drawing.Point(524, 215);
            this.LbAmountTeaching.Name = "LbAmountTeaching";
            this.LbAmountTeaching.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbAmountTeaching.Size = new System.Drawing.Size(111, 13);
            this.LbAmountTeaching.TabIndex = 25;
            this.LbAmountTeaching.Text = "میزان ساعت تدرسی :";
            // 
            // txtAmountTeaching
            // 
            this.txtAmountTeaching.Location = new System.Drawing.Point(438, 235);
            this.txtAmountTeaching.MaxLength = 50;
            this.txtAmountTeaching.Name = "txtAmountTeaching";
            this.txtAmountTeaching.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmountTeaching.Size = new System.Drawing.Size(200, 21);
            this.txtAmountTeaching.TabIndex = 9;
            // 
            // LbCountClass
            // 
            this.LbCountClass.AutoSize = true;
            this.LbCountClass.Location = new System.Drawing.Point(787, 215);
            this.LbCountClass.Name = "LbCountClass";
            this.LbCountClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCountClass.Size = new System.Drawing.Size(66, 13);
            this.LbCountClass.TabIndex = 24;
            this.LbCountClass.Text = "تعداد کلاس :";
            // 
            // txtCountClass
            // 
            this.txtCountClass.Location = new System.Drawing.Point(657, 235);
            this.txtCountClass.MaxLength = 50;
            this.txtCountClass.Name = "txtCountClass";
            this.txtCountClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCountClass.Size = new System.Drawing.Size(200, 21);
            this.txtCountClass.TabIndex = 8;
            // 
            // LbCountStudent
            // 
            this.LbCountStudent.AutoSize = true;
            this.LbCountStudent.Location = new System.Drawing.Point(104, 160);
            this.LbCountStudent.Name = "LbCountStudent";
            this.LbCountStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCountStudent.Size = new System.Drawing.Size(96, 13);
            this.LbCountStudent.TabIndex = 23;
            this.LbCountStudent.Text = "تعداد دانش آموزان :";
            // 
            // txtCountStudent
            // 
            this.txtCountStudent.Location = new System.Drawing.Point(11, 180);
            this.txtCountStudent.MaxLength = 50;
            this.txtCountStudent.Name = "txtCountStudent";
            this.txtCountStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCountStudent.Size = new System.Drawing.Size(200, 21);
            this.txtCountStudent.TabIndex = 7;
            // 
            // LbManager
            // 
            this.LbManager.AutoSize = true;
            this.LbManager.Location = new System.Drawing.Point(368, 160);
            this.LbManager.Name = "LbManager";
            this.LbManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbManager.Size = new System.Drawing.Size(50, 13);
            this.LbManager.TabIndex = 22;
            this.LbManager.Text = "نام مدیر :";
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(222, 180);
            this.txtManager.MaxLength = 50;
            this.txtManager.Name = "txtManager";
            this.txtManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtManager.Size = new System.Drawing.Size(200, 21);
            this.txtManager.TabIndex = 6;
            // 
            // LbPhysicalEducationTeacher
            // 
            this.LbPhysicalEducationTeacher.AutoSize = true;
            this.LbPhysicalEducationTeacher.Location = new System.Drawing.Point(540, 160);
            this.LbPhysicalEducationTeacher.Name = "LbPhysicalEducationTeacher";
            this.LbPhysicalEducationTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbPhysicalEducationTeacher.Size = new System.Drawing.Size(93, 13);
            this.LbPhysicalEducationTeacher.TabIndex = 21;
            this.LbPhysicalEducationTeacher.Text = "مربی تربیت بدنی :";
            // 
            // txtPhysicalEducationTeacher
            // 
            this.txtPhysicalEducationTeacher.Location = new System.Drawing.Point(437, 180);
            this.txtPhysicalEducationTeacher.MaxLength = 50;
            this.txtPhysicalEducationTeacher.Name = "txtPhysicalEducationTeacher";
            this.txtPhysicalEducationTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhysicalEducationTeacher.Size = new System.Drawing.Size(200, 21);
            this.txtPhysicalEducationTeacher.TabIndex = 5;
            // 
            // LbStudyPeriod
            // 
            this.LbStudyPeriod.AutoSize = true;
            this.LbStudyPeriod.Location = new System.Drawing.Point(772, 160);
            this.LbStudyPeriod.Name = "LbStudyPeriod";
            this.LbStudyPeriod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbStudyPeriod.Size = new System.Drawing.Size(81, 13);
            this.LbStudyPeriod.TabIndex = 20;
            this.LbStudyPeriod.Text = "مقطع تحصیلی :";
            // 
            // txtStudyPeriod
            // 
            this.txtStudyPeriod.Location = new System.Drawing.Point(657, 180);
            this.txtStudyPeriod.MaxLength = 50;
            this.txtStudyPeriod.Name = "txtStudyPeriod";
            this.txtStudyPeriod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudyPeriod.Size = new System.Drawing.Size(200, 21);
            this.txtStudyPeriod.TabIndex = 4;
            // 
            // LbArea
            // 
            this.LbArea.AutoSize = true;
            this.LbArea.Location = new System.Drawing.Point(130, 105);
            this.LbArea.Name = "LbArea";
            this.LbArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbArea.Size = new System.Drawing.Size(77, 13);
            this.LbArea.TabIndex = 19;
            this.LbArea.Text = "ناحیه / منطقه :";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(11, 125);
            this.txtArea.MaxLength = 50;
            this.txtArea.Name = "txtArea";
            this.txtArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtArea.Size = new System.Drawing.Size(200, 21);
            this.txtArea.TabIndex = 3;
            // 
            // LbSchoolName
            // 
            this.LbSchoolName.AutoSize = true;
            this.LbSchoolName.Location = new System.Drawing.Point(345, 105);
            this.LbSchoolName.Name = "LbSchoolName";
            this.LbSchoolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbSchoolName.Size = new System.Drawing.Size(73, 13);
            this.LbSchoolName.TabIndex = 18;
            this.LbSchoolName.Text = "نام آموزشگاه :";
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(222, 125);
            this.txtSchoolName.MaxLength = 50;
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSchoolName.Size = new System.Drawing.Size(200, 21);
            this.txtSchoolName.TabIndex = 2;
            // 
            // ComCityID
            // 
            this.ComCityID.DisplayMember = "City";
            this.ComCityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComCityID.FormattingEnabled = true;
            this.ComCityID.Location = new System.Drawing.Point(437, 125);
            this.ComCityID.Name = "ComCityID";
            this.ComCityID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComCityID.Size = new System.Drawing.Size(200, 21);
            this.ComCityID.TabIndex = 1;
            this.ComCityID.ValueMember = "CityID";
            // 
            // LbCityID
            // 
            this.LbCityID.AutoSize = true;
            this.LbCityID.Location = new System.Drawing.Point(601, 107);
            this.LbCityID.Name = "LbCityID";
            this.LbCityID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCityID.Size = new System.Drawing.Size(36, 13);
            this.LbCityID.TabIndex = 17;
            this.LbCityID.Text = "شهر :";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(570, 280);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(660, 280);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(200, 21);
            this.txtSearch.TabIndex = 1;
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
            this.DgvList.Location = new System.Drawing.Point(0, 311);
            this.DgvList.MultiSelect = false;
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.RowHeadersVisible = false;
            this.DgvList.RowHeadersWidth = 50;
            this.DgvList.Size = new System.Drawing.Size(874, 350);
            this.DgvList.TabIndex = 3;
            this.DgvList.DoubleClick += new System.EventHandler(this.DgvList_DoubleClick);
            // 
            // FrmSchools
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
            this.Name = "FrmSchools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آموزشگاه";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSchools_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComProvinceID;
        private System.Windows.Forms.Label LbProvinceID;
        private System.Windows.Forms.Label LbSchoolID;
        private System.Windows.Forms.TextBox txtSchoolID;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.ComboBox ComCityID;
        private System.Windows.Forms.Label LbCityID;
        private System.Windows.Forms.Label LbSchoolName;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Label LbCountStudent;
        private System.Windows.Forms.TextBox txtCountStudent;
        private System.Windows.Forms.Label LbManager;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label LbPhysicalEducationTeacher;
        private System.Windows.Forms.TextBox txtPhysicalEducationTeacher;
        private System.Windows.Forms.Label LbStudyPeriod;
        private System.Windows.Forms.TextBox txtStudyPeriod;
        private System.Windows.Forms.Label LbArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label LbCountClass;
        private System.Windows.Forms.TextBox txtCountClass;
        private System.Windows.Forms.Label LbAmountTeaching;
        private System.Windows.Forms.TextBox txtAmountTeaching;
    }
}