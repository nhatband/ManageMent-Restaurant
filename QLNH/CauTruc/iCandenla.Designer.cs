﻿namespace QLNH.CauTruc
{
    partial class iCandenla
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.TextBox = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Label.Size = new System.Drawing.Size(93, 23);
            this.Label.TabIndex = 0;
            this.Label.Text = "TextTest";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.TextBox.EditValue = null;
            this.TextBox.Location = new System.Drawing.Point(93, 0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TextBox.Properties.Mask.EditMask = "";
            this.TextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TextBox.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TextBox.Size = new System.Drawing.Size(205, 20);
            this.TextBox.TabIndex = 1;
            // 
            // iCandenla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TextBox);
            this.Name = "iCandenla";
            this.Size = new System.Drawing.Size(298, 23);
            ((System.ComponentModel.ISupportInitialize)(this.TextBox.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private DevExpress.XtraEditors.DateEdit TextBox;
    }
}