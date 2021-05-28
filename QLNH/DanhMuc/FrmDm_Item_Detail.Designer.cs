namespace QLNH.DanhMuc
{
    partial class FrmDm_Item_Detail
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
            this.txtItem_Name = new System.Windows.Forms.TextBox();
            this.txtItem_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboItem_Class_Id = new QLNH.CauTruc.iComboBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.cboUnit_Id = new QLNH.CauTruc.iComboBox();
            this.cboVat_Id = new QLNH.CauTruc.iComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboUnit_Id);
            this.groupBox1.Controls.Add(this.cboVat_Id);
            this.groupBox1.Controls.Add(this.cboItem_Class_Id);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtItem_Name);
            this.groupBox1.Controls.Add(this.txtItem_Id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nguyên liệu";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(11, 156);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Hoạt động";
            this.chkActive.Size = new System.Drawing.Size(220, 19);
            this.chkActive.TabIndex = 3;
            // 
            // txtItem_Name
            // 
            this.txtItem_Name.Location = new System.Drawing.Point(102, 52);
            this.txtItem_Name.Name = "txtItem_Name";
            this.txtItem_Name.Size = new System.Drawing.Size(132, 20);
            this.txtItem_Name.TabIndex = 1;
            // 
            // txtItem_Id
            // 
            this.txtItem_Id.Location = new System.Drawing.Point(102, 26);
            this.txtItem_Id.Name = "txtItem_Id";
            this.txtItem_Id.Size = new System.Drawing.Size(132, 20);
            this.txtItem_Id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nguyên liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nguyên liệu";
            // 
            // cboItem_Class_Id
            // 
            this.cboItem_Class_Id.Caption = "Nhóm nguyên liệu";
            this.cboItem_Class_Id.FrmDetail = null;
            this.cboItem_Class_Id.LabelLengh = 95;
            this.cboItem_Class_Id.Location = new System.Drawing.Point(11, 78);
            this.cboItem_Class_Id.Name = "cboItem_Class_Id";
            this.cboItem_Class_Id.Size = new System.Drawing.Size(223, 20);
            this.cboItem_Class_Id.TabIndex = 4;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(258, 38);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(201, 178);
            this.picImage.TabIndex = 7;
            this.picImage.TabStop = false;
            // 
            // cboUnit_Id
            // 
            this.cboUnit_Id.Caption = "Đơn vị tính";
            this.cboUnit_Id.FrmDetail = null;
            this.cboUnit_Id.LabelLengh = 95;
            this.cboUnit_Id.Location = new System.Drawing.Point(11, 104);
            this.cboUnit_Id.Name = "cboUnit_Id";
            this.cboUnit_Id.Size = new System.Drawing.Size(223, 20);
            this.cboUnit_Id.TabIndex = 4;
            // 
            // cboVat_Id
            // 
            this.cboVat_Id.Caption = "Thuế VAT";
            this.cboVat_Id.FrmDetail = null;
            this.cboVat_Id.LabelLengh = 95;
            this.cboVat_Id.Location = new System.Drawing.Point(11, 130);
            this.cboVat_Id.Name = "cboVat_Id";
            this.cboVat_Id.Size = new System.Drawing.Size(223, 20);
            this.cboVat_Id.TabIndex = 4;
            // 
            // FrmDm_Item_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 222);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDm_Item_Detail";
            this.Text = "FrmDm_Item_Detail";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.picImage, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private System.Windows.Forms.TextBox txtItem_Name;
        private System.Windows.Forms.TextBox txtItem_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CauTruc.iComboBox cboItem_Class_Id;
        private CauTruc.iComboBox cboVat_Id;
        private CauTruc.iComboBox cboUnit_Id;
    }
}