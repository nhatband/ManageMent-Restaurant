namespace QLNH.DanhMuc
{
    partial class FrmDm_Floors_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDm_Floors_Detail));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtValue_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue_Name = new System.Windows.Forms.TextBox();
            this.picFloor = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnChooseImage = new DevExpress.XtraEditors.SimpleButton();
            this.txtFileName = new QLNH.CauTruc.iTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFloor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(326, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 92);
            this.barDockControlBottom.Size = new System.Drawing.Size(326, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 60);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(326, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 60);
            // 
            // txtValue_Id
            // 
            this.txtValue_Id.Location = new System.Drawing.Point(118, 38);
            this.txtValue_Id.Name = "txtValue_Id";
            this.txtValue_Id.Size = new System.Drawing.Size(201, 20);
            this.txtValue_Id.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã tầng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên tầng";
            // 
            // txtValue_Name
            // 
            this.txtValue_Name.Location = new System.Drawing.Point(118, 64);
            this.txtValue_Name.Name = "txtValue_Name";
            this.txtValue_Name.Size = new System.Drawing.Size(201, 20);
            this.txtValue_Name.TabIndex = 7;
            // 
            // picFloor
            // 
            this.picFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFloor.EditValue = ((object)(resources.GetObject("picFloor.EditValue")));
            this.picFloor.Location = new System.Drawing.Point(2, 22);
            this.picFloor.Name = "picFloor";
            this.picFloor.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picFloor.Size = new System.Drawing.Size(559, 410);
            this.picFloor.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.picFloor);
            this.groupControl1.Location = new System.Drawing.Point(6, 112);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(563, 434);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Ảnh tầng";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(470, 83);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(99, 23);
            this.btnChooseImage.TabIndex = 10;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Caption = "Đường dẫn:";
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(21, 86);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(443, 23);
            this.txtFileName.TabIndex = 11;
            this.txtFileName.TextWidthLengh = 350;
            // 
            // FrmDm_Floors_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 553);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtValue_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValue_Id);
            this.Controls.Add(this.label1);
            this.Name = "FrmDm_Floors_Detail";
            this.Text = "FrmDm_Item_Detail";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtValue_Id, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtValue_Name, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.btnChooseImage, 0);
            this.Controls.SetChildIndex(this.txtFileName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picFloor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue_Name;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PictureEdit picFloor;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnChooseImage;
        private CauTruc.iTextBox txtFileName;
    }
}