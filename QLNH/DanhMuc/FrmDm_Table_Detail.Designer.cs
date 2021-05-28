namespace QLNH.DanhMuc
{
    partial class FrmDm_Table_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDm_Table_Detail));
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtTotal_Chair = new System.Windows.Forms.NumericUpDown();
            this.txtTable_Name = new System.Windows.Forms.TextBox();
            this.txtTable_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtFileName = new QLNH.CauTruc.iTextBox();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.picTable = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal_Chair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(232, 81);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(77, 17);
            this.chkActive.TabIndex = 3;
            this.chkActive.Text = "Hoạt động";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtTotal_Chair
            // 
            this.txtTotal_Chair.Location = new System.Drawing.Point(103, 78);
            this.txtTotal_Chair.Name = "txtTotal_Chair";
            this.txtTotal_Chair.Size = new System.Drawing.Size(48, 20);
            this.txtTotal_Chair.TabIndex = 2;
            // 
            // txtTable_Name
            // 
            this.txtTable_Name.Location = new System.Drawing.Point(103, 52);
            this.txtTable_Name.Name = "txtTable_Name";
            this.txtTable_Name.Size = new System.Drawing.Size(206, 20);
            this.txtTable_Name.TabIndex = 1;
            // 
            // txtTable_Id
            // 
            this.txtTable_Id.Location = new System.Drawing.Point(103, 25);
            this.txtTable_Id.Name = "txtTable_Id";
            this.txtTable_Id.Size = new System.Drawing.Size(206, 20);
            this.txtTable_Id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng số ghế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bàn";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnChoose);
            this.groupControl1.Controls.Add(this.txtFileName);
            this.groupControl1.Controls.Add(this.chkActive);
            this.groupControl1.Controls.Add(this.txtTable_Id);
            this.groupControl1.Controls.Add(this.txtTotal_Chair);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtTable_Name);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Location = new System.Drawing.Point(3, 36);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(323, 135);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin bàn";
            // 
            // txtFileName
            // 
            this.txtFileName.Caption = "Chọn ảnh";
            this.txtFileName.Location = new System.Drawing.Point(12, 104);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(200, 23);
            this.txtFileName.TabIndex = 4;
            this.txtFileName.TextWidthLengh = 110;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(234, 104);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Chọn ảnh";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.picTable);
            this.groupControl2.Location = new System.Drawing.Point(3, 177);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(323, 202);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Ảnh bàn";
            // 
            // picTable
            // 
            this.picTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTable.EditValue = ((object)(resources.GetObject("picTable.EditValue")));
            this.picTable.Location = new System.Drawing.Point(2, 22);
            this.picTable.Name = "picTable";
            this.picTable.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picTable.Size = new System.Drawing.Size(319, 178);
            this.picTable.TabIndex = 9;
            // 
            // FrmDm_Table_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDm_Table_Detail";
            this.Text = "Danh mục bàn";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal_Chair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTable.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTable_Name;
        private System.Windows.Forms.TextBox txtTable_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtTotal_Chair;
        private System.Windows.Forms.CheckBox chkActive;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private CauTruc.iTextBox txtFileName;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PictureEdit picTable;
    }
}