
namespace CMPG_223
{
    partial class Contract
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
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.Lbl_Fn = new System.Windows.Forms.Label();
            this.Lbl_LN = new System.Windows.Forms.Label();
            this.Lbl_ContNum = new System.Windows.Forms.Label();
            this.txtContNum = new System.Windows.Forms.TextBox();
            this.GrpBx_Contract = new System.Windows.Forms.GroupBox();
            this.lstbx_ViewInfo = new System.Windows.Forms.ListBox();
            this.btn_SignDate = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.rdbtn_A = new System.Windows.Forms.RadioButton();
            this.rdbtn_B = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbAparNum = new System.Windows.Forms.ComboBox();
            this.grpbx_ChooseBlock = new System.Windows.Forms.GroupBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.GrpBx_Contract.SuspendLayout();
            this.grpbx_ChooseBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(201, 42);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(153, 23);
            this.txtFname.TabIndex = 0;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(201, 98);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(153, 23);
            this.txtLname.TabIndex = 1;
            this.txtLname.TextChanged += new System.EventHandler(this.txtbx_lname_TextChanged);
            // 
            // Lbl_Fn
            // 
            this.Lbl_Fn.AutoSize = true;
            this.Lbl_Fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fn.Location = new System.Drawing.Point(33, 42);
            this.Lbl_Fn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fn.Name = "Lbl_Fn";
            this.Lbl_Fn.Size = new System.Drawing.Size(92, 20);
            this.Lbl_Fn.TabIndex = 2;
            this.Lbl_Fn.Text = "First Name";
            // 
            // Lbl_LN
            // 
            this.Lbl_LN.AutoSize = true;
            this.Lbl_LN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LN.Location = new System.Drawing.Point(33, 98);
            this.Lbl_LN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_LN.Name = "Lbl_LN";
            this.Lbl_LN.Size = new System.Drawing.Size(91, 20);
            this.Lbl_LN.TabIndex = 3;
            this.Lbl_LN.Text = "Last Name";
            // 
            // Lbl_ContNum
            // 
            this.Lbl_ContNum.AutoSize = true;
            this.Lbl_ContNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ContNum.Location = new System.Drawing.Point(33, 147);
            this.Lbl_ContNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ContNum.Name = "Lbl_ContNum";
            this.Lbl_ContNum.Size = new System.Drawing.Size(131, 20);
            this.Lbl_ContNum.TabIndex = 4;
            this.Lbl_ContNum.Text = "Contact Number";
            // 
            // txtContNum
            // 
            this.txtContNum.Location = new System.Drawing.Point(201, 147);
            this.txtContNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContNum.Name = "txtContNum";
            this.txtContNum.Size = new System.Drawing.Size(153, 23);
            this.txtContNum.TabIndex = 5;
            // 
            // GrpBx_Contract
            // 
            this.GrpBx_Contract.Controls.Add(this.lstbx_ViewInfo);
            this.GrpBx_Contract.Controls.Add(this.btn_SignDate);
            this.GrpBx_Contract.Location = new System.Drawing.Point(371, 29);
            this.GrpBx_Contract.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpBx_Contract.Name = "GrpBx_Contract";
            this.GrpBx_Contract.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpBx_Contract.Size = new System.Drawing.Size(502, 291);
            this.GrpBx_Contract.TabIndex = 6;
            this.GrpBx_Contract.TabStop = false;
            this.GrpBx_Contract.Text = "Contract";
            // 
            // lstbx_ViewInfo
            // 
            this.lstbx_ViewInfo.FormattingEnabled = true;
            this.lstbx_ViewInfo.ItemHeight = 17;
            this.lstbx_ViewInfo.Items.AddRange(new object[] {
            "Contract Details:"});
            this.lstbx_ViewInfo.Location = new System.Drawing.Point(183, 37);
            this.lstbx_ViewInfo.Name = "lstbx_ViewInfo";
            this.lstbx_ViewInfo.Size = new System.Drawing.Size(296, 208);
            this.lstbx_ViewInfo.TabIndex = 8;
            // 
            // btn_SignDate
            // 
            this.btn_SignDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignDate.Location = new System.Drawing.Point(44, 109);
            this.btn_SignDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SignDate.Name = "btn_SignDate";
            this.btn_SignDate.Size = new System.Drawing.Size(115, 69);
            this.btn_SignDate.TabIndex = 1;
            this.btn_SignDate.Text = "Signed Date";
            this.btn_SignDate.UseVisualStyleBackColor = true;
            this.btn_SignDate.Visible = false;
            this.btn_SignDate.Click += new System.EventHandler(this.btn_SignDate_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(37, 340);
            this.btnSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(92, 31);
            this.btnSign.TabIndex = 7;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Visible = false;
            this.btnSign.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbtn_A
            // 
            this.rdbtn_A.AutoSize = true;
            this.rdbtn_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_A.Location = new System.Drawing.Point(6, 32);
            this.rdbtn_A.Name = "rdbtn_A";
            this.rdbtn_A.Size = new System.Drawing.Size(76, 21);
            this.rdbtn_A.TabIndex = 9;
            this.rdbtn_A.TabStop = true;
            this.rdbtn_A.Text = "Block A";
            this.rdbtn_A.UseVisualStyleBackColor = true;
            this.rdbtn_A.CheckedChanged += new System.EventHandler(this.rdbtn_A_CheckedChanged);
            // 
            // rdbtn_B
            // 
            this.rdbtn_B.AutoSize = true;
            this.rdbtn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_B.Location = new System.Drawing.Point(88, 32);
            this.rdbtn_B.Name = "rdbtn_B";
            this.rdbtn_B.Size = new System.Drawing.Size(76, 21);
            this.rdbtn_B.TabIndex = 10;
            this.rdbtn_B.TabStop = true;
            this.rdbtn_B.Text = "Block B";
            this.rdbtn_B.UseVisualStyleBackColor = true;
            this.rdbtn_B.CheckedChanged += new System.EventHandler(this.rdbtn_B_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose apartment";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(136, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Cancel";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbAparNum
            // 
            this.cmbAparNum.FormattingEnabled = true;
            this.cmbAparNum.Location = new System.Drawing.Point(9, 89);
            this.cmbAparNum.Name = "cmbAparNum";
            this.cmbAparNum.Size = new System.Drawing.Size(121, 25);
            this.cmbAparNum.TabIndex = 15;
            this.cmbAparNum.SelectedIndexChanged += new System.EventHandler(this.cmbAparNum_SelectedIndexChanged);
            // 
            // grpbx_ChooseBlock
            // 
            this.grpbx_ChooseBlock.Controls.Add(this.rdbtn_A);
            this.grpbx_ChooseBlock.Controls.Add(this.cmbAparNum);
            this.grpbx_ChooseBlock.Controls.Add(this.rdbtn_B);
            this.grpbx_ChooseBlock.Controls.Add(this.label1);
            this.grpbx_ChooseBlock.Location = new System.Drawing.Point(37, 185);
            this.grpbx_ChooseBlock.Name = "grpbx_ChooseBlock";
            this.grpbx_ChooseBlock.Size = new System.Drawing.Size(190, 124);
            this.grpbx_ChooseBlock.TabIndex = 16;
            this.grpbx_ChooseBlock.TabStop = false;
            this.grpbx_ChooseBlock.Text = "Choose Block";
            this.grpbx_ChooseBlock.Enter += new System.EventHandler(this.grpbx_ChooseBlock_Enter);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(782, 340);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(91, 31);
            this.Btn_Close.TabIndex = 17;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPG_223.Properties.Resources.OIP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 412);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.grpbx_ChooseBlock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.GrpBx_Contract);
            this.Controls.Add(this.txtContNum);
            this.Controls.Add(this.Lbl_ContNum);
            this.Controls.Add(this.Lbl_LN);
            this.Controls.Add(this.Lbl_Fn);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Contract";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Contract_Load);
            this.GrpBx_Contract.ResumeLayout(false);
            this.grpbx_ChooseBlock.ResumeLayout(false);
            this.grpbx_ChooseBlock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label Lbl_Fn;
        private System.Windows.Forms.Label Lbl_LN;
        private System.Windows.Forms.Label Lbl_ContNum;
        private System.Windows.Forms.TextBox txtContNum;
        private System.Windows.Forms.GroupBox GrpBx_Contract;
        private System.Windows.Forms.Button btn_SignDate;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.ListBox lstbx_ViewInfo;
        private System.Windows.Forms.RadioButton rdbtn_A;
        private System.Windows.Forms.RadioButton rdbtn_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbAparNum;
        private System.Windows.Forms.GroupBox grpbx_ChooseBlock;
        private System.Windows.Forms.Button Btn_Close;
    }
}