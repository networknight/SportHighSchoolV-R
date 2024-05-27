using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmSafetyReports : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmSafetyReports()
        {
            InitializeComponent();
        }

        private void FrmSafetyReports_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT SR.SafetyReportID AS N'شناسه',S.SchoolName AS N'آموزشگاه',SR.SafetyReport AS N'عنوان',SR.Description AS N'توضیحات' FROM SafetyReports SR INNER JOIN Schools S ON SR.SchoolID=S.SchoolID Where Convert(nvarchar(50),SR.SafetyReportID)+' '+S.SchoolName+' '+SR.SafetyReport+' '+SR.Description LIKE N'%'+@Search+'%' ORDER BY SR.SafetyReportID DESC", con);
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
                txtSafetyReportID.Text = DgvList.CurrentRow.Cells["SafetyReportID"].Value.ToString();

                if (txtSafetyReportID.Text != "0")
                {
                    //txtSafetyReportID.Text = DgvList.CurrentRow.Cells["SafetyReportID"].Value.ToString();
                    //ComMedicalExpertiseID.Text = DgvList.CurrentRow.Cells["MedicalExpertiseName"].Value.ToString();
                    //txtSafetyReportCode.Text = DgvList.CurrentRow.Cells["SafetyReportCode"].Value.ToString();
                    //txtSafetyReportName.Text = DgvList.CurrentRow.Cells["SafetyReportName"].Value.ToString();
                    //txtSafetyReportNationalCode.Text = DgvList.CurrentRow.Cells["SafetyReportNationalCode"].Value.ToString();
                    //txtSafetyReportMobile.Text = DgvList.CurrentRow.Cells["SafetyReportMobile"].Value.ToString();
                    //txtSafetyReportAddress.Text = DgvList.CurrentRow.Cells["SafetyReportAddress"].Value.ToString();

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

            //txtSafetyReportID.Text = "0";
            //txtSafetyReportCode.Text = "";
            //txtSafetyReportName.Text = "";
            //txtSafetyReportNationalCode.Text = "";
            //txtSafetyReportMobile.Text = "";
            //txtSafetyReportAddress.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtSafetyReportID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    //com = new SqlCommand("INSERT INTO SafetyReports (SafetyReportCode,SafetyReportName,SafetyReportNationalCode,SafetyReportMobile,SafetyReportAddress,MedicalExpertiseID) VALUES (@SafetyReportCode,@SafetyReportName,@SafetyReportNationalCode,@SafetyReportMobile,@SafetyReportAddress,@MedicalExpertiseID)", con);
                    //com.Parameters.AddWithValue("@SafetyReportCode", txtSafetyReportCode.Text);
                    //com.Parameters.AddWithValue("@SafetyReportName", txtSafetyReportName.Text);
                    //com.Parameters.AddWithValue("@SafetyReportNationalCode", txtSafetyReportNationalCode.Text);
                    //com.Parameters.AddWithValue("@SafetyReportMobile", txtSafetyReportMobile.Text);
                    //com.Parameters.AddWithValue("@SafetyReportAddress", txtSafetyReportAddress.Text);
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
                    //com = new SqlCommand("UPDATE SafetyReports SET SafetyReportCode=@SafetyReportCode,SafetyReportName=@SafetyReportName,SafetyReportNationalCode=@SafetyReportNationalCode,SafetyReportMobile=@SafetyReportMobile,SafetyReportAddress=@SafetyReportAddress,MedicalExpertiseID=@MedicalExpertiseID Where SafetyReportID=@SafetyReportID", con);
                    //com.Parameters.AddWithValue("@SafetyReportID", txtSafetyReportID.Text);
                    //com.Parameters.AddWithValue("@SafetyReportCode", txtSafetyReportCode.Text);
                    //com.Parameters.AddWithValue("@SafetyReportName", txtSafetyReportName.Text);
                    //com.Parameters.AddWithValue("@SafetyReportNationalCode", txtSafetyReportNationalCode.Text);
                    //com.Parameters.AddWithValue("@SafetyReportMobile", txtSafetyReportMobile.Text);
                    //com.Parameters.AddWithValue("@SafetyReportAddress", txtSafetyReportAddress.Text);
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
            if (txtSafetyReportID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM SafetyReports Where SafetyReportID=@SafetyReportID", con);
                        com.Parameters.AddWithValue("@SafetyReportID", txtSafetyReportID.Text);
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
