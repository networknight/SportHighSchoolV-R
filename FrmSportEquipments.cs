using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmSportEquipments : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;
        public FrmSportEquipments()
        {
            InitializeComponent();
        }

        private void FrmSportEquipments_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT SE.SportEquipmentID AS N'شناسه',G.SportEquipmentGroup AS N'گروه ملزومات',S.SchoolName AS N'نام آموزشگاه',SE.EssentialsNeeded AS N'ملزومات مورد نیاز',SE.Available AS N'موجود',SE.UnAvailable AS N'نام موجود',SE.CountEquipment AS N'تعداد',SE.Description AS N'توضیحات' FROM SportEquipments SE INNER JOIN SportEquipmentGroups G ON SE.SportEquipmentGroupID = G.SportEquipmentGroupID INNER JOIN Schools S ON SE.SchoolID=S.SchoolID Where Convert(nvarchar(50),SE.SportEquipmentID)+' '+G.SportEquipmentGroup+' '+S.SchoolName+' '+SE.EssentialsNeeded+' '+SE.Description LIKE N'%'+@Search+'%' ORDER BY SE.SportEquipmentID DESC", con);
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
                txtSportEquipmentID.Text = DgvList.CurrentRow.Cells["SportEquipmentID"].Value.ToString();

                if (txtSportEquipmentID.Text != "0")
                {
                    //txtSportEquipmentID.Text = DgvList.CurrentRow.Cells["SportEquipmentID"].Value.ToString();
                    //ComMedicalExpertiseID.Text = DgvList.CurrentRow.Cells["MedicalExpertiseName"].Value.ToString();
                    //txtSportEquipmentCode.Text = DgvList.CurrentRow.Cells["SportEquipmentCode"].Value.ToString();
                    //txtSportEquipmentName.Text = DgvList.CurrentRow.Cells["SportEquipmentName"].Value.ToString();
                    //txtSportEquipmentNationalCode.Text = DgvList.CurrentRow.Cells["SportEquipmentNationalCode"].Value.ToString();
                    //txtSportEquipmentMobile.Text = DgvList.CurrentRow.Cells["SportEquipmentMobile"].Value.ToString();
                    //txtSportEquipmentAddress.Text = DgvList.CurrentRow.Cells["SportEquipmentAddress"].Value.ToString();

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

            //txtSportEquipmentID.Text = "0";
            //txtSportEquipmentCode.Text = "";
            //txtSportEquipmentName.Text = "";
            //txtSportEquipmentNationalCode.Text = "";
            //txtSportEquipmentMobile.Text = "";
            //txtSportEquipmentAddress.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtSportEquipmentID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    //com = new SqlCommand("INSERT INTO SportEquipments (SportEquipmentCode,SportEquipmentName,SportEquipmentNationalCode,SportEquipmentMobile,SportEquipmentAddress,MedicalExpertiseID) VALUES (@SportEquipmentCode,@SportEquipmentName,@SportEquipmentNationalCode,@SportEquipmentMobile,@SportEquipmentAddress,@MedicalExpertiseID)", con);
                    //com.Parameters.AddWithValue("@SportEquipmentCode", txtSportEquipmentCode.Text);
                    //com.Parameters.AddWithValue("@SportEquipmentName", txtSportEquipmentName.Text);
                    //com.Parameters.AddWithValue("@SportEquipmentNationalCode", txtSportEquipmentNationalCode.Text);
                    //com.Parameters.AddWithValue("@SportEquipmentMobile", txtSportEquipmentMobile.Text);
                    //com.Parameters.AddWithValue("@SportEquipmentAddress", txtSportEquipmentAddress.Text);
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
                    //com = new SqlCommand("UPDATE SportEquipments SET SportEquipmentCode=@SportEquipmentCode,SportEquipmentName=@SportEquipmentName,SportEquipmentNationalCode=@SportEquipmentNationalCode,SportEquipmentMobile=@SportEquipmentMobile,SportEquipmentAddress=@SportEquipmentAddress,MedicalExpertiseID=@MedicalExpertiseID Where SportEquipmentID=@SportEquipmentID", con);
                    //com.Parameters.AddWithValue("@SportEquipmentID", txtSportEquipmentID.Text);
                    //com.Parameters.AddWithValue("@SportEquipmentCode", txtSportEquipmentCode.Text);
                    //com.Parameters.AddWithValue("@SportEquipmentName", txtSportEquipmentName.Text);
                    //com.Parameters.AddWithValue("@SportEquipmentNationalCode", txtSportEquipmentNationalCode.Text);
                    //com.Parameters.AddWithValue("@SportEquipmentMobile", txtSportEquipmentMobile.Text);
                    //com.Parameters.AddWithValue("@SportEquipmentAddress", txtSportEquipmentAddress.Text);
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
            if (txtSportEquipmentID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM SportEquipments Where SportEquipmentID=@SportEquipmentID", con);
                        com.Parameters.AddWithValue("@SportEquipmentID", txtSportEquipmentID.Text);
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
