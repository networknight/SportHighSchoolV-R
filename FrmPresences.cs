using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmPresences : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmPresences()
        {
            InitializeComponent();
        }

        private void FrmPresences_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT P.PresenceID AS N'شناسه',S.FirstName+' '+S.LastName AS N'نام و نام خانوادگی',P.GroupName AS N'گروه',P.PhysicalCondition AS N'وضعیت جسمانی',P.InterestOrSportsField AS N'علاقه یا رشته ورزشی',P.InputEvaluation AS N'ارزشیابی ورودی',P.Feedback AS N'بازخورد' FROM Presences P INNER JOIN Students S ON P.StudentID=S.StudentID Where Convert(nvarchar(50),P.PresenceID)+' '+S.FirstName+' '+S.LastName+' '+P.GroupName+' '+P.PhysicalCondition+' '+P.InterestOrSportsField+' '+P.InputEvaluation+' '+P.Feedback LIKE N'%'+@Search+'%' ORDER BY P.PresenceID DESC", con);
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
                txtPresenceID.Text = DgvList.CurrentRow.Cells["PresenceID"].Value.ToString();

                if (txtPresenceID.Text != "0")
                {
                    //txtPresenceID.Text = DgvList.CurrentRow.Cells["PresenceID"].Value.ToString();
                    //ComMedicalExpertiseID.Text = DgvList.CurrentRow.Cells["MedicalExpertiseName"].Value.ToString();
                    //txtPresenceCode.Text = DgvList.CurrentRow.Cells["PresenceCode"].Value.ToString();
                    //txtPresenceName.Text = DgvList.CurrentRow.Cells["PresenceName"].Value.ToString();
                    //txtPresenceNationalCode.Text = DgvList.CurrentRow.Cells["PresenceNationalCode"].Value.ToString();
                    //txtPresenceMobile.Text = DgvList.CurrentRow.Cells["PresenceMobile"].Value.ToString();
                    //txtPresenceAddress.Text = DgvList.CurrentRow.Cells["PresenceAddress"].Value.ToString();

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

            //txtPresenceID.Text = "0";
            //txtPresenceCode.Text = "";
            //txtPresenceName.Text = "";
            //txtPresenceNationalCode.Text = "";
            //txtPresenceMobile.Text = "";
            //txtPresenceAddress.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtPresenceID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    //com = new SqlCommand("INSERT INTO Presences (PresenceCode,PresenceName,PresenceNationalCode,PresenceMobile,PresenceAddress,MedicalExpertiseID) VALUES (@PresenceCode,@PresenceName,@PresenceNationalCode,@PresenceMobile,@PresenceAddress,@MedicalExpertiseID)", con);
                    //com.Parameters.AddWithValue("@PresenceCode", txtPresenceCode.Text);
                    //com.Parameters.AddWithValue("@PresenceName", txtPresenceName.Text);
                    //com.Parameters.AddWithValue("@PresenceNationalCode", txtPresenceNationalCode.Text);
                    //com.Parameters.AddWithValue("@PresenceMobile", txtPresenceMobile.Text);
                    //com.Parameters.AddWithValue("@PresenceAddress", txtPresenceAddress.Text);
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
                    //com = new SqlCommand("UPDATE Presences SET PresenceCode=@PresenceCode,PresenceName=@PresenceName,PresenceNationalCode=@PresenceNationalCode,PresenceMobile=@PresenceMobile,PresenceAddress=@PresenceAddress,MedicalExpertiseID=@MedicalExpertiseID Where PresenceID=@PresenceID", con);
                    //com.Parameters.AddWithValue("@PresenceID", txtPresenceID.Text);
                    //com.Parameters.AddWithValue("@PresenceCode", txtPresenceCode.Text);
                    //com.Parameters.AddWithValue("@PresenceName", txtPresenceName.Text);
                    //com.Parameters.AddWithValue("@PresenceNationalCode", txtPresenceNationalCode.Text);
                    //com.Parameters.AddWithValue("@PresenceMobile", txtPresenceMobile.Text);
                    //com.Parameters.AddWithValue("@PresenceAddress", txtPresenceAddress.Text);
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
            if (txtPresenceID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM Presences Where PresenceID=@PresenceID", con);
                        com.Parameters.AddWithValue("@PresenceID", txtPresenceID.Text);
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
