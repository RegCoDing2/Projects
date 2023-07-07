
namespace CMPG_223
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.msApartment = new System.Windows.Forms.ToolStripMenuItem();
            this.msFacilities = new System.Windows.Forms.ToolStripMenuItem();
            this.msBookFac = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainFacil = new System.Windows.Forms.ToolStripMenuItem();
            this.msReport = new System.Windows.Forms.ToolStripMenuItem();
            this.msContract = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLogout,
            this.msApartment,
            this.msFacilities,
            this.msReport,
            this.msContract});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(579, 30);
            this.MainMenuStrip.TabIndex = 9;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // msLogout
            // 
            this.msLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.msLogout.Name = "msLogout";
            this.msLogout.Size = new System.Drawing.Size(73, 26);
            this.msLogout.Text = "Logout";
            this.msLogout.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // msApartment
            // 
            this.msApartment.Name = "msApartment";
            this.msApartment.Size = new System.Drawing.Size(100, 26);
            this.msApartment.Text = "Apartments";
            this.msApartment.Click += new System.EventHandler(this.apartmentsToolStripMenuItem_Click);
            // 
            // msFacilities
            // 
            this.msFacilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msBookFac,
            this.msMainFacil});
            this.msFacilities.Name = "msFacilities";
            this.msFacilities.Size = new System.Drawing.Size(79, 26);
            this.msFacilities.Text = "Facilities";
            // 
            // msBookFac
            // 
            this.msBookFac.Name = "msBookFac";
            this.msBookFac.Size = new System.Drawing.Size(199, 26);
            this.msBookFac.Text = "Book Facility";
            this.msBookFac.Click += new System.EventHandler(this.msBookFac_Click);
            // 
            // msMainFacil
            // 
            this.msMainFacil.Name = "msMainFacil";
            this.msMainFacil.Size = new System.Drawing.Size(199, 26);
            this.msMainFacil.Text = "Maintain Facility";
            this.msMainFacil.Click += new System.EventHandler(this.msMainFacil_Click);
            // 
            // msReport
            // 
            this.msReport.Name = "msReport";
            this.msReport.Size = new System.Drawing.Size(68, 26);
            this.msReport.Text = "Report";
            this.msReport.Click += new System.EventHandler(this.msReport_Click);
            // 
            // msContract
            // 
            this.msContract.Name = "msContract";
            this.msContract.Size = new System.Drawing.Size(79, 26);
            this.msContract.Text = "Contract";
            this.msContract.Click += new System.EventHandler(this.msContract_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2100, 945);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        private System.Windows.Forms.ToolStripMenuItem msApartment;
        private System.Windows.Forms.ToolStripMenuItem msFacilities;
        private System.Windows.Forms.ToolStripMenuItem msReport;
        private System.Windows.Forms.ToolStripMenuItem msContract;
        private System.Windows.Forms.ToolStripMenuItem msBookFac;
        private System.Windows.Forms.ToolStripMenuItem msMainFacil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}