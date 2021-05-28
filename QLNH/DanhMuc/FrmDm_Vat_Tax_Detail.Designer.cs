namespace QLNH.DanhMuc
{
    partial class FrmDm_Vat_Tax_Detail
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
            this.txtVat_Tax_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVat_Tax_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVat_Tax_Id
            // 
            this.txtVat_Tax_Id.Location = new System.Drawing.Point(118, 38);
            this.txtVat_Tax_Id.Name = "txtVat_Tax_Id";
            this.txtVat_Tax_Id.Size = new System.Drawing.Size(201, 20);
            this.txtVat_Tax_Id.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã thuế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thuế xuất";
            // 
            // txtVat_Tax_Name
            // 
            this.txtVat_Tax_Name.Location = new System.Drawing.Point(118, 64);
            this.txtVat_Tax_Name.Name = "txtVat_Tax_Name";
            this.txtVat_Tax_Name.Size = new System.Drawing.Size(201, 20);
            this.txtVat_Tax_Name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá trị";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(118, 90);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(201, 20);
            this.txtRate.TabIndex = 8;
            // 
            // FrmDm_Vat_Tax_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 116);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtVat_Tax_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVat_Tax_Id);
            this.Controls.Add(this.label1);
            this.Name = "FrmDm_Vat_Tax_Detail";
            this.Text = "FrmDm_Item_Detail";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtVat_Tax_Id, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtVat_Tax_Name, 0);
            this.Controls.SetChildIndex(this.txtRate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVat_Tax_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVat_Tax_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtRate;
    }
}