using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class UsageLicense : Form
    {
        public UsageLicense()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void githublink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            githublink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/networknight/SportHighSchoolV-R");
        }

        private void licenseagreed_CheckedChanged(object sender, EventArgs e)
        {
            if(licenseagreed.Checked == true)
            {
                btnaccept.Enabled = true;
            }
        }

        private void UsageLicense_Load(object sender, EventArgs e)
        {
            btnaccept.Enabled = false;
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Visible = false;
        }
    }
}
