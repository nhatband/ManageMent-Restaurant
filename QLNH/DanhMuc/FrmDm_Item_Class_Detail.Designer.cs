namespace QLNH.DanhMuc
{
    partial class FrmDm_Item_Class_Detail
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
            this.txtItem_Class_Name = new System.Windows.Forms.TextBox();
            this.txtItem_Class_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtItem_Class_Name);
            this.groupBox1.Controls.Add(this.txtItem_Class_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại nguyên liệu";
            // 
            // txtItem_Class_Name
            // 
            this.txtItem_Class_Name.Location = new System.Drawing.Point(123, 51);
            this.txtItem_Class_Name.Name = "txtItem_Class_Name";
            this.txtItem_Class_Name.Size = new System.Drawing.Size(144, 21);
            this.txtItem_Class_Name.TabIndex = 1;
            // 
            // txtItem_Class_id
            // 
            this.txtItem_Class_id.Location = new System.Drawing.Point(123, 27);
            this.txtItem_Class_id.Name = "txtItem_Class_id";
            this.txtItem_Class_id.Size = new System.Drawing.Size(144, 21);
            this.txtItem_Class_id.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên loại nguyên liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã loại nguyên liệu";
            // 
            // FrmDm_Item_Class_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDm_Item_Class_Detail";
            this.Text = "FrmDm_Item_Detail";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtItem_Class_Name;
        private System.Windows.Forms.TextBox txtItem_Class_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}