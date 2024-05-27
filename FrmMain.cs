using System;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmMain : Form
    {
        public static string ConnectionString = "Data Source=.;Initial Catalog=SportHighSchool;Connect Timeout=3600;Integrated Security=True;";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

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

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void BtnSchools_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSchools frm = new FrmSchools();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnClasses_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmClasses frm = new FrmClasses();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnPresences_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPresences frm = new FrmPresences();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnSafetyReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSafetyReports frm = new FrmSafetyReports();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnSportEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSportEvents frm = new FrmSportEvents();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnAssessments_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAssessments frm = new FrmAssessments();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnParentsReferences_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmParentsReferences frm = new FrmParentsReferences();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudents frm = new FrmStudents();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnWeeklyPhysicalEducationPrograms_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmWeeklyPhysicalEducationPrograms frm = new FrmWeeklyPhysicalEducationPrograms();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnSportEquipments_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSportEquipments frm = new FrmSportEquipments();
            frm.ShowDialog();
            this.Show();
        }
    }
}
