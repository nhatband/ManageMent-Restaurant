namespace QLNH.DanhMuc
{
    partial class FrmDm_Unit_Detail
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
            this.txtUnit_Id = new QLNH.CauTruc.iTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnit_Name = new QLNH.CauTruc.iTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUnit_Id
            // 
            this.txtUnit_Id.Caption = "Mã loại";
            this.txtUnit_Id.TextWidthLengh = 93;
            this.txtUnit_Id.Location = new System.Drawing.Point(9, 25);
            this.txtUnit_Id.Name = "txtUnit_Id";
            this.txtUnit_Id.Size = new System.Drawing.Size(298, 23);
            this.txtUnit_Id.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnit_Name);
            this.groupBox1.Controls.Add(this.txtUnit_Id);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtUnit_Name
            // 
            this.txtUnit_Name.Caption = "Tên loại";
            this.txtUnit_Name.TextWidthLengh = 93;
            this.txtUnit_Name.Location = new System.Drawing.Point(9, 62);
            this.txtUnit_Name.Name = "txtUnit_Name";
            this.txtUnit_Name.Size = new System.Drawing.Size(298, 23);
            this.txtUnit_Name.TabIndex = 5;
            // 
            // FrmDm_Unit_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 147);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDm_Unit_Detail";
            this.Text = "FrmDm_Unit_Detail";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CauTruc.iTextBox txtUnit_Id;
        private System.Windows.Forms.GroupBox groupBox1;
        private CauTruc.iTextBox txtUnit_Name;

    }
}