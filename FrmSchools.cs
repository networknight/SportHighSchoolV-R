using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmSchools : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlDataReader Dr;
        SqlConnection con;
        SqlCommand com;

        public FrmSchools()
        {
            InitializeComponent();
        }

        private void FrmSchools_Load(object sender, EventArgs e)
        {
            BtnSearch_Click(null, null);
            BtnNew_Click(null, null);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;

            if (msg.Msg == WM_KEYDOWN && keyData == (Keys.Escape))
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(FrmMain.ConnectionString); con.Open();

            Ad = new SqlDataAdapter("SELECT S.SchoolID AS N'شناسه',P.Province AS N'استان',C.City AS N'شهر',S.SchoolName AS N'نام آموزشگاه',S.Area AS N'منطقه / ناحیه',S.StudyPeriod AS N'دوره تحصیلی',S.PhysicalEducationTeacher AS N'معلم تربیت بدنی',S.Manager AS N'مدیر',S.CountStudent AS N'تعداد دانش آموزان',S.CountClass AS N'تعداد کلاس',S.AmountTeaching AS N'میزان ساعت تدریس' FROM Schools S INNER JOIN Citys C ON S.CityID = C.CityID INNER JOIN Provinces P ON C.ProvinceID = P.ProvinceID Where Convert(nvarchar(50),S.SchoolID)+' '+P.Province+' '+C.City+' '+S.SchoolName+' '+S.Area+' '+S.StudyPeriod+' '+S.PhysicalEducationTeacher+' '+S.Manager+' '+Convert(nvarchar(50),S.CountStudent)+' '+Convert(nvarchar(50),S.CountClass)+' '+Convert(nvarchar(50),S.AmountTeaching) LIKE N'%'+@Search+'%' ORDER BY S.SchoolID DESC", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            Ad.SelectCommand.Parameters.AddWithValue("@Search", txtSearch.Text);
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            DgvList.DataSource = DS.Tables["DT"];
            DgvList.Refresh();
        }

        private void DgvList_DoubleClick(object sender, EventArgs e)
        {
            Int16 CityID = 0;

            try
            {
                txtSchoolID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                if (txtSchoolID.Text != "0")
                {
                    txtSchoolID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();

                    com = new SqlCommand("SELECT SchoolID,CityID,SchoolName,Area,StudyPeriod,PhysicalEducationTeacher,Manager,CountStudent,CountClass,AmountTeaching FROM Schools Where SchoolID=@SchoolID", con);
                    com.CommandTimeout = 3600;
                    com.Parameters.AddWithValue("@SchoolID", txtSchoolID.Text);
                    Dr = com.ExecuteReader();
                    if (Dr.Read())
                    {
                        txtSchoolID.Text = Dr["SchoolID"].ToString();
                        CityID = Convert.ToInt16(Dr["CityID"]);
                        txtSchoolName.Text = Dr["SchoolName"].ToString();
                        txtArea.Text = Dr["Area"].ToString();
                        txtStudyPeriod.Text = Dr["StudyPeriod"].ToString();
                        txtPhysicalEducationTeacher.Text = Dr["PhysicalEducationTeacher"].ToString();
                        txtManager.Text = Dr["Manager"].ToString();
                        txtCountStudent.Text = Dr["CountStudent"].ToString();
                        txtCountClass.Text = Dr["CountClass"].ToString();
                        txtAmountTeaching.Text = Dr["AmountTeaching"].ToString();
                    }
                    else
                    {
                        BtnNew_Click(null, null);
                    }
                    Dr.Close();

                    con.Close(); con.Dispose();



                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();

                    com = new SqlCommand("SELECT ProvinceID FROM Citys Where CityID=@CityID", con);
                    com.CommandTimeout = 3600;
                    com.Parameters.AddWithValue("@CityID", CityID);
                    Dr = com.ExecuteReader();
                    if (Dr.Read())
                        ComProvinceID.SelectedValue = Dr["ProvinceID"].ToString();
                    else
                        ComProvinceID.SelectedIndex = 0;
                    Dr.Close();

                    con.Close(); con.Dispose();

                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();

                    Ad = new SqlDataAdapter("SELECT CityID,City FROM Citys Where ProvinceID=@ProvinceID", con);
                    Ad.SelectCommand.CommandTimeout = 3600;
                    Ad.SelectCommand.Parameters.AddWithValue("@ProvinceID", ComProvinceID.SelectedValue);
                    DS = new DataSet();
                    Ad.Fill(DS, "DT");
                    con.Close(); con.Dispose();
                    ComCityID.DataSource = DS.Tables["DT"];

                    ComCityID.SelectedValue = CityID;


                    BtnDelete.Enabled = true;
                }
                else
                {
                    BtnNew_Click(null, null);
                }
            }
            catch
            {

            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(FrmMain.ConnectionString); con.Open();

            Ad = new SqlDataAdapter("SELECT ProvinceID,Province FROM Provinces", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            ComProvinceID.DataSource = DS.Tables["DT"];

            ComProvinceID.SelectedIndex = 0;


            con = new SqlConnection(FrmMain.ConnectionString); con.Open();

            Ad = new SqlDataAdapter("SELECT CityID,City FROM Citys Where ProvinceID=@ProvinceID", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            Ad.SelectCommand.Parameters.AddWithValue("@ProvinceID", ComProvinceID.SelectedValue);
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            ComCityID.DataSource = DS.Tables["DT"];

            txtSchoolID.Text = "0";
            txtArea.Text = "";
            txtStudyPeriod.Text = "";
            txtPhysicalEducationTeacher.Text = "";
            txtManager.Text = "";
            txtCountStudent.Text = "";
            txtCountClass.Text = "";
            txtAmountTeaching.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtSchoolID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO Schools (CityID,SchoolName,Area,StudyPeriod,PhysicalEducationTeacher,Manager,CountStudent,CountClass,AmountTeaching) VALUES (@CityID,@SchoolName,@Area,@StudyPeriod,@PhysicalEducationTeacher,@Manager,@CountStudent,@CountClass,@AmountTeaching)", con);
                    com.Parameters.AddWithValue("@CityID", ComCityID.SelectedValue);
                    com.Parameters.AddWithValue("@SchoolName", txtSchoolName.Text);
                    com.Parameters.AddWithValue("@Area", txtArea.Text);
                    com.Parameters.AddWithValue("@StudyPeriod", txtStudyPeriod.Text);
                    com.Parameters.AddWithValue("@PhysicalEducationTeacher", txtPhysicalEducationTeacher.Text);
                    com.Parameters.AddWithValue("@Manager", txtManager.Text);
                    com.Parameters.AddWithValue("@CountStudent", txtCountStudent.Text);
                    com.Parameters.AddWithValue("@CountClass", txtCountClass.Text);
                    com.Parameters.AddWithValue("@AmountTeaching", txtAmountTeaching.Text);
                    com.ExecuteNonQuery();
                    con.Close(); con.Dispose();

                    MessageBox.Show("اطلاعات با موفقیت ثبت گردید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnSearch_Click(null, null);
                    BtnNew_Click(null, null);
                }
            }
            else
            {
                if (MessageBox.Show("آیا از ویرایش اطلاعات مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("UPDATE Schools SET CityID=@CityID,SchoolName=@SchoolName,Area=@Area,StudyPeriod=@StudyPeriod,PhysicalEducationTeacher=@PhysicalEducationTeacher,Manager=@Manager,CountStudent=@CountStudent,CountClass=@CountClass,AmountTeaching=@AmountTeaching Where SchoolID=@SchoolID", con);
                    com.Parameters.AddWithValue("@SchoolID", txtSchoolID.Text);
                    com.Parameters.AddWithValue("@CityID", ComCityID.SelectedValue);
                    com.Parameters.AddWithValue("@SchoolName", txtSchoolName.Text);
                    com.Parameters.AddWithValue("@Area", txtArea.Text);
                    com.Parameters.AddWithValue("@StudyPeriod", txtStudyPeriod.Text);
                    com.Parameters.AddWithValue("@PhysicalEducationTeacher", txtPhysicalEducationTeacher.Text);
                    com.Parameters.AddWithValue("@Manager", txtManager.Text);
                    com.Parameters.AddWithValue("@CountStudent", txtCountStudent.Text);
                    com.Parameters.AddWithValue("@CountClass", txtCountClass.Text);
                    com.Parameters.AddWithValue("@AmountTeaching", txtAmountTeaching.Text);
                    com.ExecuteNonQuery();
                    con.Close(); con.Dispose();

                    MessageBox.Show("اطلاعات با موفقیت ویرایش گردید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnSearch_Click(null, null);
                    BtnNew_Click(null, null);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtSchoolID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM Schools Where SchoolID=@SchoolID", con);
                        com.Parameters.AddWithValue("@SchoolID", txtSchoolID.Text);
                        com.ExecuteNonQuery();
                        con.Close(); con.Dispose();

                        MessageBox.Show("اطلاعات با موفقیت حذف گردید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnSearch_Click(null, null);
                        BtnNew_Click(null, null);
                    }
                    catch
                    {
                        MessageBox.Show("حذف رکورد امکان پذیر نمی باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComProvinceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(FrmMain.ConnectionString); con.Open();

            Ad = new SqlDataAdapter("SELECT CityID,City FROM Citys Where ProvinceID=@ProvinceID", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            Ad.SelectCommand.Parameters.AddWithValue("@ProvinceID", ComProvinceID.SelectedValue);
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            ComCityID.DataSource = DS.Tables["DT"];
        }
    }
}
