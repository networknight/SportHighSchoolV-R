using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmClasses : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader Dr;

        public FrmClasses()
        {
            InitializeComponent();
        }

        private void FrmClasses_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT C.ClassID AS N'شناسه',S.SchoolName AS N'نام آموزشگاه',E.EducationalBase AS N'پایه تحصیلی',C.Class AS N'کلاس',C.EducationalYear AS N'سال تحصیلی' FROM Schools S INNER JOIN Classes C ON S.SchoolID=C.SchoolID INNER JOIN EducationalBases E ON C.EducationalBaseID=E.EducationalBaseID Where Convert(nvarchar(50),C.ClassID)+' '+S.SchoolName+' '+E.EducationalBase+' '+C.Class+' '+C.EducationalYear LIKE N'%'+@Search+'%' ORDER BY S.SchoolID DESC", con);
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
            try
            {
                txtClassID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                if (txtClassID.Text != "0")
                {
                    txtClassID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();

                    com = new SqlCommand("SELECT ClassID,SchoolID,EducationalBaseID,Class,EducationalYear FROM Classes Where ClassID=@ClassID", con);
                    com.CommandTimeout = 3600;
                    com.Parameters.AddWithValue("@ClassID", txtClassID.Text);
                    Dr = com.ExecuteReader();
                    if (Dr.Read())
                    {
                        ComSchoolID.SelectedValue = Dr["SchoolID"].ToString();
                        ComEducationalBaseID.SelectedValue = Dr["EducationalBaseID"].ToString();
                        txtClass.Text = Dr["Class"].ToString();
                        txtEducationalYear.Text = Dr["EducationalYear"].ToString();
                    }
                    else
                    {
                        BtnNew_Click(null, null);
                    }
                    Dr.Close();

                    con.Close(); con.Dispose();



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

            Ad = new SqlDataAdapter("SELECT SchoolID,SchoolName FROM Schools", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            ComSchoolID.DataSource = DS.Tables["DT"];


            con = new SqlConnection(FrmMain.ConnectionString); con.Open();

            Ad = new SqlDataAdapter("SELECT EducationalBaseID,EducationalBase FROM EducationalBases", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            ComEducationalBaseID.DataSource = DS.Tables["DT"];

            txtClassID.Text = "0";
            txtClass.Text = "";
            txtEducationalYear.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtClassID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO Classes (SchoolID,EducationalBaseID,Class,EducationalYear) VALUES (@SchoolID,@EducationalBaseID,@Class,@EducationalYear)", con);
                    com.Parameters.AddWithValue("@SchoolID", ComSchoolID.SelectedValue);
                    com.Parameters.AddWithValue("@EducationalBaseID", ComEducationalBaseID.SelectedValue);
                    com.Parameters.AddWithValue("@Class", txtClass.Text);
                    com.Parameters.AddWithValue("@EducationalYear", txtEducationalYear.Text);
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
                    com = new SqlCommand("UPDATE Classes SET SchoolID=@SchoolID,EducationalBaseID=@EducationalBaseID,Class=@Class,EducationalYear=@EducationalYear Where ClassID=@ClassID", con);
                    com.Parameters.AddWithValue("@ClassID", txtClassID.Text);
                    com.Parameters.AddWithValue("@SchoolID", ComSchoolID.SelectedValue);
                    com.Parameters.AddWithValue("@EducationalBaseID", ComEducationalBaseID.SelectedValue);
                    com.Parameters.AddWithValue("@Class", txtClass.Text);
                    com.Parameters.AddWithValue("@EducationalYear", txtEducationalYear.Text);
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
            if (txtClassID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM Classes Where ClassID=@ClassID", con);
                        com.Parameters.AddWithValue("@ClassID", txtClassID.Text);
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

        private void GroupItem_Enter(object sender, EventArgs e)
        {

        }
    }
}
