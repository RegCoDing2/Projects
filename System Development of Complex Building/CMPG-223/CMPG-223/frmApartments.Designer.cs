
namespace CMPG_223
{
    partial class frmApartments
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
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.btnAddApart = new System.Windows.Forms.Button();
            this.btnDelApart = new System.Windows.Forms.Button();
            this.cmbApartNum = new System.Windows.Forms.ComboBox();
            this.cmbApartNumDel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBlock = new System.Windows.Forms.GroupBox();
            this.rbBlockB = new System.Windows.Forms.RadioButton();
            this.rbBlockA = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.gbBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = global::CMPG_223.Properties.Resources._360_F_251891708_kgsSyD0QgyUOqqi0HaKJOMMJeApY8FIi;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(855, 533);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            this.pbBackground.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // btnAddApart
            // 
            this.btnAddApart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApart.Location = new System.Drawing.Point(58, 224);
            this.btnAddApart.Name = "btnAddApart";
            this.btnAddApart.Size = new System.Drawing.Size(180, 60);
            this.btnAddApart.TabIndex = 1;
            this.btnAddApart.Text = "Add Apartment";
            this.btnAddApart.UseVisualStyleBackColor = true;
            this.btnAddApart.Click += new System.EventHandler(this.btnAddApart_Click);
            // 
            // btnDelApart
            // 
            this.btnDelApart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelApart.Location = new System.Drawing.Point(58, 342);
            this.btnDelApart.Name = "btnDelApart";
            this.btnDelApart.Size = new System.Drawing.Size(180, 60);
            this.btnDelApart.TabIndex = 3;
            this.btnDelApart.Text = "Delete Apartment";
            this.btnDelApart.UseVisualStyleBackColor = true;
            this.btnDelApart.Click += new System.EventHandler(this.btnDelApart_Click);
            // 
            // cmbApartNum
            // 
            this.cmbApartNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApartNum.FormattingEnabled = true;
            this.cmbApartNum.Location = new System.Drawing.Point(298, 239);
            this.cmbApartNum.Name = "cmbApartNum";
            this.cmbApartNum.Size = new System.Drawing.Size(180, 33);
            this.cmbApartNum.TabIndex = 4;
            this.cmbApartNum.Visible = false;
            // 
            // cmbApartNumDel
            // 
            this.cmbApartNumDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApartNumDel.FormattingEnabled = true;
            this.cmbApartNumDel.Location = new System.Drawing.Point(298, 357);
            this.cmbApartNumDel.Name = "cmbApartNumDel";
            this.cmbApartNumDel.Size = new System.Drawing.Size(180, 33);
            this.cmbApartNumDel.TabIndex = 5;
            this.cmbApartNumDel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maintain Aparment";
            // 
            // gbBlock
            // 
            this.gbBlock.Controls.Add(this.rbBlockB);
            this.gbBlock.Controls.Add(this.rbBlockA);
            this.gbBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBlock.Location = new System.Drawing.Point(58, 95);
            this.gbBlock.Name = "gbBlock";
            this.gbBlock.Size = new System.Drawing.Size(269, 100);
            this.gbBlock.TabIndex = 7;
            this.gbBlock.TabStop = false;
            this.gbBlock.Text = "Choose Block";
            // 
            // rbBlockB
            // 
            this.rbBlockB.AutoSize = true;
            this.rbBlockB.Location = new System.Drawing.Point(18, 64);
            this.rbBlockB.Name = "rbBlockB";
            this.rbBlockB.Size = new System.Drawing.Size(89, 24);
            this.rbBlockB.TabIndex = 1;
            this.rbBlockB.Text = "Block B";
            this.rbBlockB.UseVisualStyleBackColor = true;
            this.rbBlockB.CheckedChanged += new System.EventHandler(this.rbBlockB_CheckedChanged);
            // 
            // rbBlockA
            // 
            this.rbBlockA.AutoSize = true;
            this.rbBlockA.Location = new System.Drawing.Point(18, 29);
            this.rbBlockA.Name = "rbBlockA";
            this.rbBlockA.Size = new System.Drawing.Size(88, 24);
            this.rbBlockA.TabIndex = 0;
            this.rbBlockA.Text = "Block A";
            this.rbBlockA.UseVisualStyleBackColor = true;
            this.rbBlockA.CheckedChanged += new System.EventHandler(this.rbBlockA_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(509, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 60);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(509, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 60);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(707, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 533);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbBlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbApartNumDel);
            this.Controls.Add(this.cmbApartNum);
            this.Controls.Add(this.btnDelApart);
            this.Controls.Add(this.btnAddApart);
            this.Controls.Add(this.pbBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmApartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApartments";
            this.Load += new System.EventHandler(this.frmApartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.gbBlock.ResumeLayout(false);
            this.gbBlock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Button btnAddApart;
        private System.Windows.Forms.Button btnDelApart;
        private System.Windows.Forms.ComboBox cmbApartNum;
        private System.Windows.Forms.ComboBox cmbApartNumDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBlock;
        private System.Windows.Forms.RadioButton rbBlockB;
        private System.Windows.Forms.RadioButton rbBlockA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}