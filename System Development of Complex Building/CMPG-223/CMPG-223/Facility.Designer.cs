
namespace CMPG_223
{
    partial class frmFacility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacility));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddFacility = new System.Windows.Forms.Button();
            this.btnChangeFacility = new System.Windows.Forms.Button();
            this.btnDeleteFacility = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblFacilityHeading = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnAddConfirm = new System.Windows.Forms.Button();
            this.btnConfirmChange = new System.Windows.Forms.Button();
            this.btnConfirmRemoval = new System.Windows.Forms.Button();
            this.cbChange = new System.Windows.Forms.ComboBox();
            this.cbDelete = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddFacility
            // 
            this.btnAddFacility.Location = new System.Drawing.Point(71, 89);
            this.btnAddFacility.Name = "btnAddFacility";
            this.btnAddFacility.Size = new System.Drawing.Size(165, 43);
            this.btnAddFacility.TabIndex = 1;
            this.btnAddFacility.Text = "Add Facility";
            this.btnAddFacility.UseVisualStyleBackColor = true;
            this.btnAddFacility.Click += new System.EventHandler(this.btnAddFacility_Click);
            // 
            // btnChangeFacility
            // 
            this.btnChangeFacility.Location = new System.Drawing.Point(68, 238);
            this.btnChangeFacility.Name = "btnChangeFacility";
            this.btnChangeFacility.Size = new System.Drawing.Size(165, 43);
            this.btnChangeFacility.TabIndex = 2;
            this.btnChangeFacility.Text = "Change Facility";
            this.btnChangeFacility.UseVisualStyleBackColor = true;
            this.btnChangeFacility.Click += new System.EventHandler(this.btnChangeFacility_Click);
            // 
            // btnDeleteFacility
            // 
            this.btnDeleteFacility.Location = new System.Drawing.Point(68, 475);
            this.btnDeleteFacility.Name = "btnDeleteFacility";
            this.btnDeleteFacility.Size = new System.Drawing.Size(165, 43);
            this.btnDeleteFacility.TabIndex = 3;
            this.btnDeleteFacility.Text = "Delete Facility";
            this.btnDeleteFacility.UseVisualStyleBackColor = true;
            this.btnDeleteFacility.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(297, 124);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(192, 24);
            this.txtAdd.TabIndex = 4;
            this.txtAdd.Visible = false;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(294, 89);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(288, 18);
            this.lblAdd.TabIndex = 5;
            this.lblAdd.Text = "Please provide a name for the new Facility:";
            this.lblAdd.Visible = false;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(294, 228);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(194, 18);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "Select facility to be changed:";
            this.lblChange.Visible = false;
            // 
            // lblFacilityHeading
            // 
            this.lblFacilityHeading.AutoSize = true;
            this.lblFacilityHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacilityHeading.Location = new System.Drawing.Point(53, 23);
            this.lblFacilityHeading.Name = "lblFacilityHeading";
            this.lblFacilityHeading.Size = new System.Drawing.Size(221, 22);
            this.lblFacilityHeading.TabIndex = 8;
            this.lblFacilityHeading.Text = "Choose Action to be taken";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(294, 475);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(194, 18);
            this.lblDelete.TabIndex = 10;
            this.lblDelete.Text = "Select facility to be changed:";
            this.lblDelete.Visible = false;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(305, 311);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(319, 18);
            this.lblNewName.TabIndex = 12;
            this.lblNewName.Text = "Please provide a new name for the new Facility:";
            this.lblNewName.Visible = false;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(308, 348);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(192, 24);
            this.txtNewName.TabIndex = 11;
            this.txtNewName.Visible = false;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.Location = new System.Drawing.Point(297, 155);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(164, 36);
            this.btnAddConfirm.TabIndex = 13;
            this.btnAddConfirm.Text = "Confirm Addition";
            this.btnAddConfirm.UseVisualStyleBackColor = true;
            this.btnAddConfirm.Visible = false;
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // btnConfirmChange
            // 
            this.btnConfirmChange.Location = new System.Drawing.Point(308, 394);
            this.btnConfirmChange.Name = "btnConfirmChange";
            this.btnConfirmChange.Size = new System.Drawing.Size(164, 36);
            this.btnConfirmChange.TabIndex = 14;
            this.btnConfirmChange.Text = "Confirm Change";
            this.btnConfirmChange.UseVisualStyleBackColor = true;
            this.btnConfirmChange.Visible = false;
            this.btnConfirmChange.Click += new System.EventHandler(this.btnConfirmChange_Click);
            // 
            // btnConfirmRemoval
            // 
            this.btnConfirmRemoval.Location = new System.Drawing.Point(297, 549);
            this.btnConfirmRemoval.Name = "btnConfirmRemoval";
            this.btnConfirmRemoval.Size = new System.Drawing.Size(163, 36);
            this.btnConfirmRemoval.TabIndex = 15;
            this.btnConfirmRemoval.Text = "Confirm Removal";
            this.btnConfirmRemoval.UseVisualStyleBackColor = true;
            this.btnConfirmRemoval.Visible = false;
            this.btnConfirmRemoval.Click += new System.EventHandler(this.btnConfirmRemoval_Click);
            // 
            // cbChange
            // 
            this.cbChange.FormattingEnabled = true;
            this.cbChange.Location = new System.Drawing.Point(297, 255);
            this.cbChange.Name = "cbChange";
            this.cbChange.Size = new System.Drawing.Size(121, 26);
            this.cbChange.TabIndex = 16;
            this.cbChange.Visible = false;
            this.cbChange.SelectedIndexChanged += new System.EventHandler(this.cbChange_SelectedIndexChanged);
            // 
            // cbDelete
            // 
            this.cbDelete.FormattingEnabled = true;
            this.cbDelete.Location = new System.Drawing.Point(297, 505);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(121, 26);
            this.cbDelete.TabIndex = 17;
            this.cbDelete.Visible = false;
            this.cbDelete.SelectedIndexChanged += new System.EventHandler(this.cbDelete_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(914, 561);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 620);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbChange);
            this.Controls.Add(this.btnConfirmRemoval);
            this.Controls.Add(this.btnConfirmChange);
            this.Controls.Add(this.btnAddConfirm);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblFacilityHeading);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnDeleteFacility);
            this.Controls.Add(this.btnChangeFacility);
            this.Controls.Add(this.btnAddFacility);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmFacility";
            this.Text = "Facility";
            this.Load += new System.EventHandler(this.frmFacility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddFacility;
        private System.Windows.Forms.Button btnChangeFacility;
        private System.Windows.Forms.Button btnDeleteFacility;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblFacilityHeading;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnAddConfirm;
        private System.Windows.Forms.Button btnConfirmChange;
        private System.Windows.Forms.Button btnConfirmRemoval;
        private System.Windows.Forms.ComboBox cbChange;
        private System.Windows.Forms.ComboBox cbDelete;
        private System.Windows.Forms.Button btnClose;
    }
}