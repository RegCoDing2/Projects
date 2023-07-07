
namespace CMPG_223
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.gbReportTypes = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbContractDetails = new System.Windows.Forms.RadioButton();
            this.rbFacilityInApartment = new System.Windows.Forms.RadioButton();
            this.rbFacilityDeatils = new System.Windows.Forms.RadioButton();
            this.rbApartmentDetails = new System.Windows.Forms.RadioButton();
            this.rbSpecial = new System.Windows.Forms.RadioButton();
            this.rbClassic = new System.Windows.Forms.RadioButton();
            this.rbTenantPerApartment = new System.Windows.Forms.RadioButton();
            this.rbDESC = new System.Windows.Forms.RadioButton();
            this.rbASC = new System.Windows.Forms.RadioButton();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.lblTypeReport = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbReportTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReportTypes
            // 
            this.gbReportTypes.Controls.Add(this.pictureBox1);
            this.gbReportTypes.Controls.Add(this.rbContractDetails);
            this.gbReportTypes.Controls.Add(this.rbFacilityInApartment);
            this.gbReportTypes.Controls.Add(this.rbFacilityDeatils);
            this.gbReportTypes.Controls.Add(this.rbApartmentDetails);
            this.gbReportTypes.Location = new System.Drawing.Point(41, 99);
            this.gbReportTypes.Name = "gbReportTypes";
            this.gbReportTypes.Size = new System.Drawing.Size(218, 134);
            this.gbReportTypes.TabIndex = 1;
            this.gbReportTypes.TabStop = false;
            this.gbReportTypes.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(172, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 417);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // rbContractDetails
            // 
            this.rbContractDetails.AutoSize = true;
            this.rbContractDetails.Location = new System.Drawing.Point(8, 79);
            this.rbContractDetails.Name = "rbContractDetails";
            this.rbContractDetails.Size = new System.Drawing.Size(135, 22);
            this.rbContractDetails.TabIndex = 8;
            this.rbContractDetails.TabStop = true;
            this.rbContractDetails.Text = "Contract Details";
            this.rbContractDetails.UseVisualStyleBackColor = true;
            this.rbContractDetails.CheckedChanged += new System.EventHandler(this.rbApartmentDetails_CheckedChanged);
            // 
            // rbFacilityInApartment
            // 
            this.rbFacilityInApartment.AutoSize = true;
            this.rbFacilityInApartment.Location = new System.Drawing.Point(8, 107);
            this.rbFacilityInApartment.Name = "rbFacilityInApartment";
            this.rbFacilityInApartment.Size = new System.Drawing.Size(209, 22);
            this.rbFacilityInApartment.TabIndex = 7;
            this.rbFacilityInApartment.TabStop = true;
            this.rbFacilityInApartment.Text = "Facility in Apartment Details";
            this.rbFacilityInApartment.UseVisualStyleBackColor = true;
            this.rbFacilityInApartment.CheckedChanged += new System.EventHandler(this.rbApartmentDetails_CheckedChanged);
            // 
            // rbFacilityDeatils
            // 
            this.rbFacilityDeatils.AutoSize = true;
            this.rbFacilityDeatils.Location = new System.Drawing.Point(8, 51);
            this.rbFacilityDeatils.Name = "rbFacilityDeatils";
            this.rbFacilityDeatils.Size = new System.Drawing.Size(123, 22);
            this.rbFacilityDeatils.TabIndex = 6;
            this.rbFacilityDeatils.TabStop = true;
            this.rbFacilityDeatils.Text = "Facility Details";
            this.rbFacilityDeatils.UseVisualStyleBackColor = true;
            this.rbFacilityDeatils.CheckedChanged += new System.EventHandler(this.rbApartmentDetails_CheckedChanged);
            // 
            // rbApartmentDetails
            // 
            this.rbApartmentDetails.AutoSize = true;
            this.rbApartmentDetails.Location = new System.Drawing.Point(8, 23);
            this.rbApartmentDetails.Name = "rbApartmentDetails";
            this.rbApartmentDetails.Size = new System.Drawing.Size(145, 22);
            this.rbApartmentDetails.TabIndex = 4;
            this.rbApartmentDetails.TabStop = true;
            this.rbApartmentDetails.Text = "Apartment Details";
            this.rbApartmentDetails.UseVisualStyleBackColor = true;
            this.rbApartmentDetails.CheckedChanged += new System.EventHandler(this.rbApartmentDetails_CheckedChanged);
            // 
            // rbSpecial
            // 
            this.rbSpecial.AutoSize = true;
            this.rbSpecial.Location = new System.Drawing.Point(41, 43);
            this.rbSpecial.Name = "rbSpecial";
            this.rbSpecial.Size = new System.Drawing.Size(126, 22);
            this.rbSpecial.TabIndex = 3;
            this.rbSpecial.TabStop = true;
            this.rbSpecial.Text = "Special Report";
            this.rbSpecial.UseVisualStyleBackColor = true;
            this.rbSpecial.CheckedChanged += new System.EventHandler(this.rbSpecial_CheckedChanged_1);
            // 
            // rbClassic
            // 
            this.rbClassic.AutoSize = true;
            this.rbClassic.Location = new System.Drawing.Point(187, 43);
            this.rbClassic.Name = "rbClassic";
            this.rbClassic.Size = new System.Drawing.Size(127, 22);
            this.rbClassic.TabIndex = 2;
            this.rbClassic.Text = "Classic Report";
            this.rbClassic.UseVisualStyleBackColor = true;
            this.rbClassic.CheckedChanged += new System.EventHandler(this.rbSpecial_CheckedChanged_1);
            // 
            // rbTenantPerApartment
            // 
            this.rbTenantPerApartment.AutoSize = true;
            this.rbTenantPerApartment.Location = new System.Drawing.Point(49, 71);
            this.rbTenantPerApartment.Name = "rbTenantPerApartment";
            this.rbTenantPerApartment.Size = new System.Drawing.Size(170, 22);
            this.rbTenantPerApartment.TabIndex = 0;
            this.rbTenantPerApartment.TabStop = true;
            this.rbTenantPerApartment.Text = "Tenant per Apartment";
            this.rbTenantPerApartment.UseVisualStyleBackColor = true;
            this.rbTenantPerApartment.Visible = false;
            this.rbTenantPerApartment.CheckedChanged += new System.EventHandler(this.rbTenantPerApartment_CheckedChanged_1);
            // 
            // rbDESC
            // 
            this.rbDESC.AutoSize = true;
            this.rbDESC.Location = new System.Drawing.Point(41, 384);
            this.rbDESC.Name = "rbDESC";
            this.rbDESC.Size = new System.Drawing.Size(107, 22);
            this.rbDESC.TabIndex = 3;
            this.rbDESC.TabStop = true;
            this.rbDESC.Text = "Descending";
            this.rbDESC.UseVisualStyleBackColor = true;
            this.rbDESC.Visible = false;
            this.rbDESC.CheckedChanged += new System.EventHandler(this.rbASC_CheckedChanged_1);
            // 
            // rbASC
            // 
            this.rbASC.AutoSize = true;
            this.rbASC.Location = new System.Drawing.Point(41, 356);
            this.rbASC.Name = "rbASC";
            this.rbASC.Size = new System.Drawing.Size(97, 22);
            this.rbASC.TabIndex = 1;
            this.rbASC.TabStop = true;
            this.rbASC.Text = "Ascending";
            this.rbASC.UseVisualStyleBackColor = true;
            this.rbASC.Visible = false;
            this.rbASC.CheckedChanged += new System.EventHandler(this.rbASC_CheckedChanged_1);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 18;
            this.lbOutput.Location = new System.Drawing.Point(373, 31);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(802, 544);
            this.lbOutput.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(41, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Location = new System.Drawing.Point(38, 282);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(69, 18);
            this.lblOrderBy.TabIndex = 6;
            this.lblOrderBy.Text = "Order by:";
            this.lblOrderBy.Visible = false;
            // 
            // lblTypeReport
            // 
            this.lblTypeReport.AutoSize = true;
            this.lblTypeReport.Location = new System.Drawing.Point(38, 22);
            this.lblTypeReport.Name = "lblTypeReport";
            this.lblTypeReport.Size = new System.Drawing.Size(156, 18);
            this.lblTypeReport.TabIndex = 7;
            this.lblTypeReport.Text = "Select a type of report:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(41, 445);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(166, 47);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Location = new System.Drawing.Point(41, 307);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(121, 26);
            this.cbOrderBy.TabIndex = 9;
            this.cbOrderBy.Visible = false;
            this.cbOrderBy.SelectedIndexChanged += new System.EventHandler(this.cbOrderBy_SelectedIndexChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(888, 43);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(276, 164);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 636);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.cbOrderBy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblTypeReport);
            this.Controls.Add(this.lblOrderBy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rbDESC);
            this.Controls.Add(this.rbTenantPerApartment);
            this.Controls.Add(this.rbClassic);
            this.Controls.Add(this.rbSpecial);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.rbASC);
            this.Controls.Add(this.gbReportTypes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmReports";
            this.Text = "Reports";
            this.gbReportTypes.ResumeLayout(false);
            this.gbReportTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReportTypes;
        private System.Windows.Forms.RadioButton rbSpecial;
        private System.Windows.Forms.RadioButton rbClassic;
        private System.Windows.Forms.RadioButton rbTenantPerApartment;
        private System.Windows.Forms.RadioButton rbFacilityInApartment;
        private System.Windows.Forms.RadioButton rbFacilityDeatils;
        private System.Windows.Forms.RadioButton rbApartmentDetails;
        private System.Windows.Forms.RadioButton rbContractDetails;
        private System.Windows.Forms.RadioButton rbDESC;
        private System.Windows.Forms.RadioButton rbASC;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.Label lblTypeReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbOrderBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}