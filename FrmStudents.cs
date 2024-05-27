using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmStudents : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT StudentID AS N'شناسه',FirstName AS N'نام',LastName AS N'نام خانوادگی',FatherName AS N'نام پدر',NationalCode AS N'کد ملی',Mobile AS N'شماره همراه' FROM Students Where Convert(nvarchar(50),StudentID)+' '+FirstName+' '+LastName+' '+FatherName+' '+NationalCode+' '+Mobile LIKE N'%'+@Search+'%' ORDER BY StudentID DESC", con);
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
                txtStudentID.Text = DgvList.CurrentRow.Cells["StudentID"].Value.ToString();

                if (txtStudentID.Text != "0")
                {
                    txtStudentID.Text = DgvList.CurrentRow.Cells["StudentID"].Value.ToString();
                    ComMedicalExpertiseID.Text = DgvList.CurrentRow.Cells["MedicalExpertiseName"].Value.ToString();
                    txtStudentCode.Text = DgvList.CurrentRow.Cells["StudentCode"].Value.ToString();
                    txtStudentName.Text = DgvList.CurrentRow.Cells["StudentName"].Value.ToString();
                    txtStudentNationalCode.Text = DgvList.CurrentRow.Cells["StudentNationalCode"].Value.ToString();
                    txtStudentMobile.Text = DgvList.CurrentRow.Cells["StudentMobile"].Value.ToString();
                    txtStudentAddress.Text = DgvList.CurrentRow.Cells["StudentAddress"].Value.ToString();

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

            txtStudentID.Text = "0";
            txtStudentCode.Text = "";
            txtStudentName.Text = "";
            txtStudentNationalCode.Text = "";
            txtStudentMobile.Text = "";
            txtStudentAddress.Text = "";
            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO Students (StudentCode,StudentName,StudentNationalCode,StudentMobile,StudentAddress,MedicalExpertiseID) VALUES (@StudentCode,@StudentName,@StudentNationalCode,@StudentMobile,@StudentAddress,@MedicalExpertiseID)", con);
                    com.Parameters.AddWithValue("@StudentCode", txtStudentCode.Text);
                    com.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                    com.Parameters.AddWithValue("@StudentNationalCode", txtStudentNationalCode.Text);
                    com.Parameters.AddWithValue("@StudentMobile", txtStudentMobile.Text);
                    com.Parameters.AddWithValue("@StudentAddress", txtStudentAddress.Text);
                    com.Parameters.AddWithValue("@MedicalExpertiseID", ComMedicalExpertiseID.SelectedValue);
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
                    com = new SqlCommand("UPDATE Students SET StudentCode=@StudentCode,StudentName=@StudentName,StudentNationalCode=@StudentNationalCode,StudentMobile=@StudentMobile,StudentAddress=@StudentAddress,MedicalExpertiseID=@MedicalExpertiseID Where StudentID=@StudentID", con);
                    com.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                    com.Parameters.AddWithValue("@StudentCode", txtStudentCode.Text);
                    com.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                    com.Parameters.AddWithValue("@StudentNationalCode", txtStudentNationalCode.Text);
                    com.Parameters.AddWithValue("@StudentMobile", txtStudentMobile.Text);
                    com.Parameters.AddWithValue("@StudentAddress", txtStudentAddress.Text);
                    com.Parameters.AddWithValue("@MedicalExpertiseID", ComMedicalExpertiseID.SelectedValue);
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
            if (txtStudentID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM Students Where StudentID=@StudentID", con);
                        com.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
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
