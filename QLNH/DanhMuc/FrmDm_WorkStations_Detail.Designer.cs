namespace QLNH.DanhMuc
{
    partial class FrmDm_WorkStations_Detail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaChiNhanh = new QLNH.CauTruc.iTextBox();
            this.txtTenChiNhanh = new QLNH.CauTruc.iTextBox();
            this.txtDiaChi = new QLNH.CauTruc.iTextBox();
            this.txtSDTChiNhanh = new QLNH.CauTruc.iTextBox();
            this.txtEmail = new QLNH.CauTruc.iTextBox();
            this.cboManagerMen = new QLNH.CauTruc.iComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboManagerMen);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDTChiNhanh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenChiNhanh);
            this.groupBox1.Controls.Add(this.txtMaChiNhanh);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi nhánh";
            // 
            // txtMaChiNhanh
            // 
            this.txtMaChiNhanh.Caption = "Mã chi nhánh";
            this.txtMaChiNhanh.Location = new System.Drawing.Point(7, 20);
            this.txtMaChiNhanh.Name = "txtMaChiNhanh";
            this.txtMaChiNhanh.Size = new System.Drawing.Size(285, 23);
            this.txtMaChiNhanh.TabIndex = 0;
            // 
            // txtTenChiNhanh
            // 
            this.txtTenChiNhanh.Caption = "Tên chi nhánh";
            this.txtTenChiNhanh.Location = new System.Drawing.Point(7, 49);
            this.txtTenChiNhanh.Name = "txtTenChiNhanh";
            this.txtTenChiNhanh.Size = new System.Drawing.Size(285, 23);
            this.txtTenChiNhanh.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Caption = "Địa chỉ";
            this.txtDiaChi.TextWidthLengh = 81;
            this.txtDiaChi.Location = new System.Drawing.Point(6, 78);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(286, 23);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtSDTChiNhanh
            // 
            this.txtSDTChiNhanh.Caption = "Số ĐT";
            this.txtSDTChiNhanh.Location = new System.Drawing.Point(7, 107);
            this.txtSDTChiNhanh.Name = "txtSDTChiNhanh";
            this.txtSDTChiNhanh.Size = new System.Drawing.Size(285, 23);
            this.txtSDTChiNhanh.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Caption = "Email";
            this.txtEmail.Location = new System.Drawing.Point(7, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // cboManagerMen
            // 
            this.cboManagerMen.Caption = "Nhân viên quản lý";
            this.cboManagerMen.FrmDetail = null;
            this.cboManagerMen.LabelLengh = 95;
            this.cboManagerMen.Location = new System.Drawing.Point(7, 165);
            this.cboManagerMen.Name = "cboManagerMen";
            this.cboManagerMen.Size = new System.Drawing.Size(285, 23);
            this.cboManagerMen.TabIndex = 5;
            // 
            // FrmDm_WorkStations_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 255);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDm_WorkStations_Detail";
            this.Text = "FrmDm_WorkStations_Detail";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CauTruc.iTextBox txtMaChiNhanh;
        private CauTruc.iTextBox txtDiaChi;
        private CauTruc.iTextBox txtTenChiNhanh;
        private CauTruc.iTextBox txtSDTChiNhanh;
        private CauTruc.iTextBox txtEmail;
        private CauTruc.iComboBox cboManagerMen;
    }
}