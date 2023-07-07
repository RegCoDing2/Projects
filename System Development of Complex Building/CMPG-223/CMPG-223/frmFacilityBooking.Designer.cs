
namespace CMPG_223
{
    partial class frmFacilityBooking
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
            this.gbBookFacility = new System.Windows.Forms.GroupBox();
            this.lblChooseFacility = new System.Windows.Forms.Label();
            this.cbFacilities = new System.Windows.Forms.ComboBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBlokB = new System.Windows.Forms.RadioButton();
            this.rbBlokA = new System.Windows.Forms.RadioButton();
            this.cmbApartNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbBookFacility.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBookFacility
            // 
            this.gbBookFacility.Controls.Add(this.lblChooseFacility);
            this.gbBookFacility.Controls.Add(this.cbFacilities);
            this.gbBookFacility.Location = new System.Drawing.Point(21, 214);
            this.gbBookFacility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBookFacility.Name = "gbBookFacility";
            this.gbBookFacility.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBookFacility.Size = new System.Drawing.Size(381, 97);
            this.gbBookFacility.TabIndex = 0;
            this.gbBookFacility.TabStop = false;
            this.gbBookFacility.Text = "Book Facility";
            // 
            // lblChooseFacility
            // 
            this.lblChooseFacility.AutoSize = true;
            this.lblChooseFacility.Location = new System.Drawing.Point(9, 57);
            this.lblChooseFacility.Name = "lblChooseFacility";
            this.lblChooseFacility.Size = new System.Drawing.Size(107, 17);
            this.lblChooseFacility.TabIndex = 9;
            this.lblChooseFacility.Text = "Choose Facility:";
            // 
            // cbFacilities
            // 
            this.cbFacilities.FormattingEnabled = true;
            this.cbFacilities.Location = new System.Drawing.Point(207, 50);
            this.cbFacilities.Name = "cbFacilities";
            this.cbFacilities.Size = new System.Drawing.Size(157, 24);
            this.cbFacilities.TabIndex = 0;
            this.cbFacilities.SelectedIndexChanged += new System.EventHandler(this.cbFacilities_SelectedIndexChanged);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(20, 337);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(117, 29);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Facility";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBlokB);
            this.groupBox1.Controls.Add(this.rbBlokA);
            this.groupBox1.Controls.Add(this.cmbApartNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(381, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apartment";
            // 
            // rbBlokB
            // 
            this.rbBlokB.AutoSize = true;
            this.rbBlokB.Location = new System.Drawing.Point(12, 72);
            this.rbBlokB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBlokB.Name = "rbBlokB";
            this.rbBlokB.Size = new System.Drawing.Size(69, 21);
            this.rbBlokB.TabIndex = 11;
            this.rbBlokB.TabStop = true;
            this.rbBlokB.Text = "Blok B";
            this.rbBlokB.UseVisualStyleBackColor = true;
            this.rbBlokB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbBlokA
            // 
            this.rbBlokA.AutoSize = true;
            this.rbBlokA.Location = new System.Drawing.Point(12, 34);
            this.rbBlokA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBlokA.Name = "rbBlokA";
            this.rbBlokA.Size = new System.Drawing.Size(69, 21);
            this.rbBlokA.TabIndex = 10;
            this.rbBlokA.TabStop = true;
            this.rbBlokA.Text = "Blok A";
            this.rbBlokA.UseVisualStyleBackColor = true;
            this.rbBlokA.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cmbApartNum
            // 
            this.cmbApartNum.FormattingEnabled = true;
            this.cmbApartNum.Location = new System.Drawing.Point(207, 112);
            this.cmbApartNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbApartNum.Name = "cmbApartNum";
            this.cmbApartNum.Size = new System.Drawing.Size(157, 24);
            this.cmbApartNum.TabIndex = 9;
            this.cmbApartNum.SelectedIndexChanged += new System.EventHandler(this.cmbApartNum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Apartment Number:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(327, 342);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmFacilityBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 385);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.gbBookFacility);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFacilityBooking";
            this.Text = "frmFacilityBooking";
            this.Load += new System.EventHandler(this.frmFacilityBooking_Load);
            this.gbBookFacility.ResumeLayout(false);
            this.gbBookFacility.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBookFacility;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBlokB;
        private System.Windows.Forms.RadioButton rbBlokA;
        private System.Windows.Forms.ComboBox cmbApartNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChooseFacility;
        private System.Windows.Forms.ComboBox cbFacilities;
        private System.Windows.Forms.Button btnClose;
    }
}