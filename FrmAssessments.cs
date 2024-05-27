using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmAssessments : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmAssessments()
        {
            InitializeComponent();
        }

        private void FrmAssessments_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT A.AssessmentID AS N'شناسه',S.FirstName+' '+S.LastName AS N'نام و نام خانوادگی',A.HealthStatus AS N'وضعیت سلامت',A.GroupEvaluationScore AS N'نمره ارزشیابی گروهی',A.AttitudinalField AS N'حیطه نگرشی',A.LifeTopics AS N'موضوعات زندگی',A.ConceptsSkillPhysicalFitness AS N'مفاهیم مهارتی و آمادگی جسمانی' FROM Assessments A INNER JOIN Students S ON A.StudentID = S.StudentID Where Convert(nvarchar(50),A.AssessmentID)+' '+S.FirstName+' '+S.LastName+' '+A.HealthStatus+' '+A.GroupEvaluationScore+' '+A.AttitudinalField+' '+A.LifeTopics+' '+A.ConceptsSkillPhysicalFitness  LIKE N'%'+@Search+'%' ORDER BY A.AssessmentID DESC", con);
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
                txtAssessmentID.Text = DgvList.CurrentRow.Cells["AssessmentID"].Value.ToString();

                if (txtAssessmentID.Text != "0")
                {
                    //txtAssessmentID.Text = DgvList.CurrentRow.Cells["AssessmentID"].Value.ToString();
                    //ComMedicalExpertiseID.Text = DgvList.CurrentRow.Cells["MedicalExpertiseName"].Value.ToString();
                    //txtAssessmentCode.Text = DgvList.CurrentRow.Cells["AssessmentCode"].Value.ToString();
                    //txtAssessmentName.Text = DgvList.CurrentRow.Cells["AssessmentName"].Value.ToString();
                    //txtAssessmentNationalCode.Text = DgvList.CurrentRow.Cells["AssessmentNationalCode"].Value.ToString();
                    //txtAssessmentMobile.Text = DgvList.CurrentRow.Cells["AssessmentMobile"].Value.ToString();
                    //txtAssessmentAddress.Text = DgvList.CurrentRow.Cells["AssessmentAddress"].Value.ToString();

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

            //txtAssessmentID.Text = "0";
            //txtAssessmentCode.Text = "";
            //txtAssessmentName.Text = "";
            //txtAssessmentNationalCode.Text = "";
            //txtAssessmentMobile.Text = "";
            //txtAssessmentAddress.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtAssessmentID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    //com = new SqlCommand("INSERT INTO Assessments (AssessmentCode,AssessmentName,AssessmentNationalCode,AssessmentMobile,AssessmentAddress,MedicalExpertiseID) VALUES (@AssessmentCode,@AssessmentName,@AssessmentNationalCode,@AssessmentMobile,@AssessmentAddress,@MedicalExpertiseID)", con);
                    //com.Parameters.AddWithValue("@AssessmentCode", txtAssessmentCode.Text);
                    //com.Parameters.AddWithValue("@AssessmentName", txtAssessmentName.Text);
                    //com.Parameters.AddWithValue("@AssessmentNationalCode", txtAssessmentNationalCode.Text);
                    //com.Parameters.AddWithValue("@AssessmentMobile", txtAssessmentMobile.Text);
                    //com.Parameters.AddWithValue("@AssessmentAddress", txtAssessmentAddress.Text);
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
                    //com = new SqlCommand("UPDATE Assessments SET AssessmentCode=@AssessmentCode,AssessmentName=@AssessmentName,AssessmentNationalCode=@AssessmentNationalCode,AssessmentMobile=@AssessmentMobile,AssessmentAddress=@AssessmentAddress,MedicalExpertiseID=@MedicalExpertiseID Where AssessmentID=@AssessmentID", con);
                    //com.Parameters.AddWithValue("@AssessmentID", txtAssessmentID.Text);
                    //com.Parameters.AddWithValue("@AssessmentCode", txtAssessmentCode.Text);
                    //com.Parameters.AddWithValue("@AssessmentName", txtAssessmentName.Text);
                    //com.Parameters.AddWithValue("@AssessmentNationalCode", txtAssessmentNationalCode.Text);
                    //com.Parameters.AddWithValue("@AssessmentMobile", txtAssessmentMobile.Text);
                    //com.Parameters.AddWithValue("@AssessmentAddress", txtAssessmentAddress.Text);
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
            if (txtAssessmentID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM Assessments Where AssessmentID=@AssessmentID", con);
                        com.Parameters.AddWithValue("@AssessmentID", txtAssessmentID.Text);
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
