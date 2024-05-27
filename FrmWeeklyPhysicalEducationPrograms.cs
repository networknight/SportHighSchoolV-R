using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmWeeklyPhysicalEducationPrograms : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmWeeklyPhysicalEducationPrograms()
        {
            InitializeComponent();
        }

        private void FrmWeeklyPhysicalEducationPrograms_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT W.WeeklyPhysicalEducationProgramID AS N'شناسه',S.SchoolName AS N'نام آموزشگاه',W.WeekName AS N'ایام هفته',W.ClassHour1 AS N'ساعت اول',W.ClassHour2 AS N'ساعت دوم',W.ClassHour3 AS N'ساعت سوم',W.ClassHour4 AS N'ساعت چهارم' FROM WeeklyPhysicalEducationPrograms AS W INNER JOIN Schools AS S ON W.SchoolID=S.SchoolID Where Convert(nvarchar(50),W.WeeklyPhysicalEducationProgramID)+' '+S.SchoolName+' '+W.WeekName+' '+W.ClassHour1+' '+W.ClassHour2+' '+W.ClassHour3+' '+W.ClassHour4 LIKE N'%'+@Search+'%' ORDER BY W.WeeklyPhysicalEducationProgramID DESC", con);
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
                txtWeeklyPhysicalEducationProgramID.Text = DgvList.CurrentRow.Cells["WeeklyPhysicalEducationProgramID"].Value.ToString();

                if (txtWeeklyPhysicalEducationProgramID.Text != "0")
                {
                    //txtWeeklyPhysicalEducationProgramID.Text = DgvList.CurrentRow.Cells["WeeklyPhysicalEducationProgramID"].Value.ToString();
                    //ComMedicalExpertiseID.Text = DgvList.CurrentRow.Cells["MedicalExpertiseName"].Value.ToString();
                    //txtWeeklyPhysicalEducationProgramCode.Text = DgvList.CurrentRow.Cells["WeeklyPhysicalEducationProgramCode"].Value.ToString();
                    //txtWeeklyPhysicalEducationProgramName.Text = DgvList.CurrentRow.Cells["WeeklyPhysicalEducationProgramName"].Value.ToString();
                    //txtWeeklyPhysicalEducationProgramNationalCode.Text = DgvList.CurrentRow.Cells["WeeklyPhysicalEducationProgramNationalCode"].Value.ToString();
                    //txtWeeklyPhysicalEducationProgramMobile.Text = DgvList.CurrentRow.Cells["WeeklyPhysicalEducationProgramMobile"].Value.ToString();
                    //txtWeeklyPhysicalEducationProgramAddress.Text = DgvList.CurrentRow.Cells["WeeklyPhysicalEducationProgramAddress"].Value.ToString();

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
            //con = new SqlConnection(FrmMain.ConnectionString); con.Open();

            //Ad = new SqlDataAdapter("SELECT MedicalExpertiseID,MedicalExpertiseName FROM MedicalExpertises", con);
            //Ad.SelectCommand.CommandTimeout = 3600;
            //DS = new DataSet();
            //Ad.Fill(DS, "DT");
            //con.Close(); con.Dispose();
            //ComMedicalExpertiseID.DataSource = DS.Tables["DT"];

            //txtWeeklyPhysicalEducationProgramID.Text = "0";
            //txtWeeklyPhysicalEducationProgramCode.Text = "";
            //txtWeeklyPhysicalEducationProgramName.Text = "";
            //txtWeeklyPhysicalEducationProgramNationalCode.Text = "";
            //txtWeeklyPhysicalEducationProgramMobile.Text = "";
            //txtWeeklyPhysicalEducationProgramAddress.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtWeeklyPhysicalEducationProgramID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    //com = new SqlCommand("INSERT INTO WeeklyPhysicalEducationPrograms (WeeklyPhysicalEducationProgramCode,WeeklyPhysicalEducationProgramName,WeeklyPhysicalEducationProgramNationalCode,WeeklyPhysicalEducationProgramMobile,WeeklyPhysicalEducationProgramAddress,MedicalExpertiseID) VALUES (@WeeklyPhysicalEducationProgramCode,@WeeklyPhysicalEducationProgramName,@WeeklyPhysicalEducationProgramNationalCode,@WeeklyPhysicalEducationProgramMobile,@WeeklyPhysicalEducationProgramAddress,@MedicalExpertiseID)", con);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramCode", txtWeeklyPhysicalEducationProgramCode.Text);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramName", txtWeeklyPhysicalEducationProgramName.Text);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramNationalCode", txtWeeklyPhysicalEducationProgramNationalCode.Text);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramMobile", txtWeeklyPhysicalEducationProgramMobile.Text);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramAddress", txtWeeklyPhysicalEducationProgramAddress.Text);
                    //com.Parameters.AddWithValue("@MedicalExpertiseID", ComMedicalExpertiseID.SelectedValue);
                    //com.ExecuteNonQuery();
                    //con.Close(); con.Dispose();

                    MessageBox.Show("اطلاعات با موفقیت ثبت گردید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnSearch_Click(null, null);
                    BtnNew_Click(null, null);
                }
            }
            else
            {
                if (MessageBox.Show("آیا از ویرایش اطلاعات مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    //com = new SqlCommand("UPDATE WeeklyPhysicalEducationPrograms SET WeeklyPhysicalEducationProgramCode=@WeeklyPhysicalEducationProgramCode,WeeklyPhysicalEducationProgramName=@WeeklyPhysicalEducationProgramName,WeeklyPhysicalEducationProgramNationalCode=@WeeklyPhysicalEducationProgramNationalCode,WeeklyPhysicalEducationProgramMobile=@WeeklyPhysicalEducationProgramMobile,WeeklyPhysicalEducationProgramAddress=@WeeklyPhysicalEducationProgramAddress,MedicalExpertiseID=@MedicalExpertiseID Where WeeklyPhysicalEducationProgramID=@WeeklyPhysicalEducationProgramID", con);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramID", txtWeeklyPhysicalEducationProgramID.Text);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramCode", txtWeeklyPhysicalEducationProgramCode.Text);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramName", txtWeeklyPhysicalEducationProgramName.Text);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramNationalCode", txtWeeklyPhysicalEducationProgramNationalCode.Text);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramMobile", txtWeeklyPhysicalEducationProgramMobile.Text);
                    //com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramAddress", txtWeeklyPhysicalEducationProgramAddress.Text);
                    //com.Parameters.AddWithValue("@MedicalExpertiseID", ComMedicalExpertiseID.SelectedValue);
                    //com.ExecuteNonQuery();
                    //con.Close(); con.Dispose();

                    MessageBox.Show("اطلاعات با موفقیت ویرایش گردید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnSearch_Click(null, null);
                    BtnNew_Click(null, null);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtWeeklyPhysicalEducationProgramID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM WeeklyPhysicalEducationPrograms Where WeeklyPhysicalEducationProgramID=@WeeklyPhysicalEducationProgramID", con);
                        com.Parameters.AddWithValue("@WeeklyPhysicalEducationProgramID", txtWeeklyPhysicalEducationProgramID.Text);
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
    }
}
