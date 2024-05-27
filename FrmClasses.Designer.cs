namespace SportHighSchool
{
    partial class FrmClasses
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
            this.LbClass = new System.Windows.Forms.Label();
            this.LbClassID = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.LbEducationalYear = new System.Windows.Forms.Label();
            this.txtEducationalYear = new System.Windows.Forms.TextBox();
            this.ComEducationalBaseID = new System.Windows.Forms.ComboBox();
            this.LbEducationalBaseID = new System.Windows.Forms.Label();
            this.ComSchoolID = new System.Windows.Forms.ComboBox();
            this.LbSchoolID = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.GroupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // LbClass
            // 
            this.LbClass.AutoSize = true;
            this.LbClass.Location = new System.Drawing.Point(328, 107);
            this.LbClass.Name = "LbClass";
            this.LbClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbClass.Size = new System.Drawing.Size(94, 13);
            this.LbClass.TabIndex = 12;
            this.LbClass.Text = "عنوان کلاس درس :";
            // 
            // LbClassID
            // 
            this.LbClassID.AutoSize = true;
            this.LbClassID.Location = new System.Drawing.Point(804, 54);
            this.LbClassID.Name = "LbClassID";
            this.LbClassID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbClassID.Size = new System.Drawing.Size(49, 13);
            this.LbClassID.TabIndex = 9;
            this.LbClassID.Text = "شناسه :";
            // 
            // txtClassID
            // 
            this.txtClassID.Enabled = false;
            this.txtClassID.Location = new System.Drawing.Point(655, 74);
            this.txtClassID.MaxLength = 50;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(200, 21);
            this.txtClassID.TabIndex = 8;
            this.txtClassID.Text = "0";
            this.txtClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(225, 127);
            this.txtClass.MaxLength = 50;
            this.txtClass.Name = "txtClass";
            this.txtClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClass.Size = new System.Drawing.Size(200, 21);
            this.txtClass.TabIndex = 2;
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
            this.BtnSave.TabIndex = 4;
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
            this.BtnDelete.TabIndex = 5;
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
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "بستن";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GroupItem
            // 
            this.GroupItem.Controls.Add(this.LbEducationalYear);
            this.GroupItem.Controls.Add(this.txtEducationalYear);
            this.GroupItem.Controls.Add(this.ComEducationalBaseID);
            this.GroupItem.Controls.Add(this.LbEducationalBaseID);
            this.GroupItem.Controls.Add(this.ComSchoolID);
            this.GroupItem.Controls.Add(this.LbSchoolID);
            this.GroupItem.Controls.Add(this.LbClass);
            this.GroupItem.Controls.Add(this.LbClassID);
            this.GroupItem.Controls.Add(this.txtClassID);
            this.GroupItem.Controls.Add(this.txtClass);
            this.GroupItem.Controls.Add(this.BtnNew);
            this.GroupItem.Controls.Add(this.BtnSave);
            this.GroupItem.Controls.Add(this.BtnDelete);
            this.GroupItem.Controls.Add(this.BtnExit);
            this.GroupItem.Location = new System.Drawing.Point(5, 0);
            this.GroupItem.Margin = new System.Windows.Forms.Padding(10);
            this.GroupItem.Name = "GroupItem";
            this.GroupItem.Size = new System.Drawing.Size(865, 172);
            this.GroupItem.TabIndex = 0;
            this.GroupItem.TabStop = false;
            // 
            // LbEducationalYear
            // 
            this.LbEducationalYear.AutoSize = true;
            this.LbEducationalYear.Location = new System.Drawing.Point(131, 107);
            this.LbEducationalYear.Name = "LbEducationalYear";
            this.LbEducationalYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbEducationalYear.Size = new System.Drawing.Size(76, 13);
            this.LbEducationalYear.TabIndex = 13;
            this.LbEducationalYear.Text = "سال تحصیلی :";
            // 
            // txtEducationalYear
            // 
            this.txtEducationalYear.Location = new System.Drawing.Point(10, 127);
            this.txtEducationalYear.MaxLength = 50;
            this.txtEducationalYear.Name = "txtEducationalYear";
            this.txtEducationalYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEducationalYear.Size = new System.Drawing.Size(200, 21);
            this.txtEducationalYear.TabIndex = 3;
            // 
            // ComEducationalBaseID
            // 
            this.ComEducationalBaseID.DisplayMember = "EducationalBase";
            this.ComEducationalBaseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComEducationalBaseID.FormattingEnabled = true;
            this.ComEducationalBaseID.Location = new System.Drawing.Point(440, 125);
            this.ComEducationalBaseID.Name = "ComEducationalBaseID";
            this.ComEducationalBaseID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComEducationalBaseID.Size = new System.Drawing.Size(200, 21);
            this.ComEducationalBaseID.TabIndex = 1;
            this.ComEducationalBaseID.ValueMember = "EducationalBaseID";
            // 
            // LbEducationalBaseID
            // 
            this.LbEducationalBaseID.AutoSize = true;
            this.LbEducationalBaseID.Location = new System.Drawing.Point(565, 107);
            this.LbEducationalBaseID.Name = "LbEducationalBaseID";
            this.LbEducationalBaseID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbEducationalBaseID.Size = new System.Drawing.Size(72, 13);
            this.LbEducationalBaseID.TabIndex = 11;
            this.LbEducationalBaseID.Text = "پایه آموزشی :";
            // 
            // ComSchoolID
            // 
            this.ComSchoolID.DisplayMember = "SchoolName";
            this.ComSchoolID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComSchoolID.FormattingEnabled = true;
            this.ComSchoolID.Location = new System.Drawing.Point(655, 125);
            this.ComSchoolID.Name = "ComSchoolID";
            this.ComSchoolID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComSchoolID.Size = new System.Drawing.Size(200, 21);
            this.ComSchoolID.TabIndex = 0;
            this.ComSchoolID.ValueMember = "SchoolID";
            // 
            // LbSchoolID
            // 
            this.LbSchoolID.AutoSize = true;
            this.LbSchoolID.Location = new System.Drawing.Point(796, 107);
            this.LbSchoolID.Name = "LbSchoolID";
            this.LbSchoolID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbSchoolID.Size = new System.Drawing.Size(57, 13);
            this.LbSchoolID.TabIndex = 10;
            this.LbSchoolID.Text = "آموزشگاه :";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(570, 185);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(660, 185);
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
            this.DgvList.Location = new System.Drawing.Point(0, 220);
            this.DgvList.MultiSelect = false;
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.RowHeadersVisible = false;
            this.DgvList.RowHeadersWidth = 50;
            this.DgvList.Size = new System.Drawing.Size(874, 366);
            this.DgvList.TabIndex = 3;
            this.DgvList.DoubleClick += new System.EventHandler(this.DgvList_DoubleClick);
            // 
            // FrmClasses
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(874, 586);
            this.ControlBox = false;
            this.Controls.Add(this.GroupItem);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DgvList);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximumSize = new System.Drawing.Size(890, 625);
            this.MinimumSize = new System.Drawing.Size(890, 625);
            this.Name = "FrmClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کلاس های درس";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmClasses_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbClass;
        private System.Windows.Forms.Label LbClassID;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Label LbEducationalYear;
        private System.Windows.Forms.TextBox txtEducationalYear;
        private System.Windows.Forms.ComboBox ComEducationalBaseID;
        private System.Windows.Forms.Label LbEducationalBaseID;
        private System.Windows.Forms.ComboBox ComSchoolID;
        private System.Windows.Forms.Label LbSchoolID;
    }
}