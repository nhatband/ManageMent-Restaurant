namespace QLNH.DanhMuc
{
    partial class FrmDm_Employees_Detail
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
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtMatKhau = new QLNH.CauTruc.iTextBox();
            this.txtSoCMT = new QLNH.CauTruc.iTextBox();
            this.txtSDT = new QLNH.CauTruc.iTextBox();
            this.txtMaCapBac = new QLNH.CauTruc.iComboBox();
            this.txtTenNV = new QLNH.CauTruc.iTextBox();
            this.txtMaNV = new QLNH.CauTruc.iTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtSoCMT);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtMaCapBac);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 219);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật danh mục nhân viên";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(10, 194);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Trạng thái";
            this.chkActive.Size = new System.Drawing.Size(300, 19);
            this.chkActive.TabIndex = 20;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Caption = "Mật khẩu";
            this.txtMatKhau.Location = new System.Drawing.Point(14, 165);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(298, 23);
            this.txtMatKhau.TabIndex = 19;
            this.txtMatKhau.TextWidthLengh = 200;
            // 
            // txtSoCMT
            // 
            this.txtSoCMT.Caption = "Số CMT";
            this.txtSoCMT.Location = new System.Drawing.Point(14, 136);
            this.txtSoCMT.Name = "txtSoCMT";
            this.txtSoCMT.Size = new System.Drawing.Size(298, 23);
            this.txtSoCMT.TabIndex = 18;
            this.txtSoCMT.TextWidthLengh = 200;
            // 
            // txtSDT
            // 
            this.txtSDT.Caption = "Số điện thoại";
            this.txtSDT.Location = new System.Drawing.Point(14, 107);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(298, 23);
            this.txtSDT.TabIndex = 17;
            this.txtSDT.TextWidthLengh = 200;
            // 
            // txtMaCapBac
            // 
            this.txtMaCapBac.Caption = "Mã cấp bậc";
            this.txtMaCapBac.FrmDetail = null;
            this.txtMaCapBac.LabelLengh = 97;
            this.txtMaCapBac.Location = new System.Drawing.Point(14, 78);
            this.txtMaCapBac.Name = "txtMaCapBac";
            this.txtMaCapBac.Size = new System.Drawing.Size(298, 23);
            this.txtMaCapBac.TabIndex = 16;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Caption = "Tên nhân viên";
            this.txtTenNV.Location = new System.Drawing.Point(14, 52);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(298, 23);
            this.txtTenNV.TabIndex = 15;
            this.txtTenNV.TextWidthLengh = 200;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Caption = "Mã nhân viên";
            this.txtMaNV.Location = new System.Drawing.Point(14, 23);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(298, 23);
            this.txtMaNV.TabIndex = 14;
            this.txtMaNV.TextWidthLengh = 200;
            // 
            // FrmDm_Employees_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 270);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDm_Employees_Detail";
            this.Text = "FrmDm_Employees_Detail";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CauTruc.iTextBox txtMaNV;
        private CauTruc.iTextBox txtTenNV;
        private CauTruc.iComboBox txtMaCapBac;
        private CauTruc.iTextBox txtSDT;
        private CauTruc.iTextBox txtSoCMT;
        private CauTruc.iTextBox txtMatKhau;
        private DevExpress.XtraEditors.CheckEdit chkActive;
    }
}