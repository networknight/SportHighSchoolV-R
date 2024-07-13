namespace SportHighSchool
{
    partial class UsageLicense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsageLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.licenseagreed = new System.Windows.Forms.CheckBox();
            this.btnaccept = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.githublink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(798, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "لاینسس و شرایط استفاده از آن";
            // 
            // licenseagreed
            // 
            this.licenseagreed.AutoSize = true;
            this.licenseagreed.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseagreed.Location = new System.Drawing.Point(659, 263);
            this.licenseagreed.Name = "licenseagreed";
            this.licenseagreed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.licenseagreed.Size = new System.Drawing.Size(203, 32);
            this.licenseagreed.TabIndex = 2;
            this.licenseagreed.Text = "شرایط ذکر شده را می پذیرم";
            this.licenseagreed.UseVisualStyleBackColor = true;
            this.licenseagreed.CheckedChanged += new System.EventHandler(this.licenseagreed_CheckedChanged);
            // 
            // btnaccept
            // 
            this.btnaccept.Location = new System.Drawing.Point(429, 264);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(213, 34);
            this.btnaccept.TabIndex = 3;
            this.btnaccept.Text = "ادامه";
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(35, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(1047, 77);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(288, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "همچنین برای مطالعه بیشتر نحوه استفاده از این برنامه می توانید صفحه گیت هاب پیوست " +
    "شده را مطالعه بفرمایید";
            // 
            // githublink
            // 
            this.githublink.AutoSize = true;
            this.githublink.Location = new System.Drawing.Point(426, 228);
            this.githublink.Name = "githublink";
            this.githublink.Size = new System.Drawing.Size(347, 17);
            this.githublink.TabIndex = 5;
            this.githublink.TabStop = true;
            this.githublink.Text = "https://github.com/networknight/SportHighSchoolV-R";
            this.githublink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githublink_LinkClicked);
            // 
            // UsageLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 402);
            this.Controls.Add(this.githublink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.licenseagreed);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.Name = "UsageLicense";
            this.RightToLeftLayout = true;
            this.Text = "UsageLicense";
            this.Load += new System.EventHandler(this.UsageLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox licenseagreed;
        private System.Windows.Forms.Button btnaccept;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel githublink;
    }
}