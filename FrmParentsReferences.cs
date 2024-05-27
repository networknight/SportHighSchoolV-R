using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmParentsReferences : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmParentsReferences()
        {
            InitializeComponent();
        }

        private void FrmParentsReferences_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT ParentsReferenceID AS N'شناسه',Name AS N'نام و نام خانوادگی',Class AS N'کلاس',Reason AS N'علت مراجعه',ReferenceDate AS N'تاریخ',Consideration AS N'ملاحظات' FROM     ParentsReferences Where Convert(nvarchar(50),ParentsReferenceID)+' '+Name+' '+Class+' '+Reason+' '+ReferenceDate+' '+Consideration LIKE N'%'+@Search+'%' ORDER BY ParentsReferenceID DESC", con);
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
                txtParentsReferenceID.Text = DgvList.CurrentRow.Cells["ParentsReferenceID"].Value.ToString();

                if (txtParentsReferenceID.Text != "0")
                {
                    //txtParentsReferenceID.Text = DgvList.CurrentRow.Cells["ParentsReferenceID"].Value.ToString();
                    //ComMedicalExpertiseID.Text = DgvList.CurrentRow.Cells["MedicalExpertiseName"].Value.ToString();
                    //txtParentsReferenceCode.Text = DgvList.CurrentRow.Cells["ParentsReferenceCode"].Value.ToString();
                    //txtParentsReferenceName.Text = DgvList.CurrentRow.Cells["ParentsReferenceName"].Value.ToString();
                    //txtParentsReferenceNationalCode.Text = DgvList.CurrentRow.Cells["ParentsReferenceNationalCode"].Value.ToString();
                    //txtParentsReferenceMobile.Text = DgvList.CurrentRow.Cells["ParentsReferenceMobile"].Value.ToString();
                    //txtParentsReferenceAddress.Text = DgvList.CurrentRow.Cells["ParentsReferenceAddress"].Value.ToString();

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

            //txtParentsReferenceID.Text = "0";
            //txtParentsReferenceCode.Text = "";
            //txtParentsReferenceName.Text = "";
            //txtParentsReferenceNationalCode.Text = "";
            //txtParentsReferenceMobile.Text = "";
            //txtParentsReferenceAddress.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtParentsReferenceID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    //com = new SqlCommand("INSERT INTO ParentsReferences (ParentsReferenceCode,ParentsReferenceName,ParentsReferenceNationalCode,ParentsReferenceMobile,ParentsReferenceAddress,MedicalExpertiseID) VALUES (@ParentsReferenceCode,@ParentsReferenceName,@ParentsReferenceNationalCode,@ParentsReferenceMobile,@ParentsReferenceAddress,@MedicalExpertiseID)", con);
                    //com.Parameters.AddWithValue("@ParentsReferenceCode", txtParentsReferenceCode.Text);
                    //com.Parameters.AddWithValue("@ParentsReferenceName", txtParentsReferenceName.Text);
                    //com.Parameters.AddWithValue("@ParentsReferenceNationalCode", txtParentsReferenceNationalCode.Text);
                    //com.Parameters.AddWithValue("@ParentsReferenceMobile", txtParentsReferenceMobile.Text);
                    //com.Parameters.AddWithValue("@ParentsReferenceAddress", txtParentsReferenceAddress.Text);
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
                    //com = new SqlCommand("UPDATE ParentsReferences SET ParentsReferenceCode=@ParentsReferenceCode,ParentsReferenceName=@ParentsReferenceName,ParentsReferenceNationalCode=@ParentsReferenceNationalCode,ParentsReferenceMobile=@ParentsReferenceMobile,ParentsReferenceAddress=@ParentsReferenceAddress,MedicalExpertiseID=@MedicalExpertiseID Where ParentsReferenceID=@ParentsReferenceID", con);
                    //com.Parameters.AddWithValue("@ParentsReferenceID", txtParentsReferenceID.Text);
                    //com.Parameters.AddWithValue("@ParentsReferenceCode", txtParentsReferenceCode.Text);
                    //com.Parameters.AddWithValue("@ParentsReferenceName", txtParentsReferenceName.Text);
                    //com.Parameters.AddWithValue("@ParentsReferenceNationalCode", txtParentsReferenceNationalCode.Text);
                    //com.Parameters.AddWithValue("@ParentsReferenceMobile", txtParentsReferenceMobile.Text);
                    //com.Parameters.AddWithValue("@ParentsReferenceAddress", txtParentsReferenceAddress.Text);
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
            if (txtParentsReferenceID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM ParentsReferences Where ParentsReferenceID=@ParentsReferenceID", con);
                        com.Parameters.AddWithValue("@ParentsReferenceID", txtParentsReferenceID.Text);
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
