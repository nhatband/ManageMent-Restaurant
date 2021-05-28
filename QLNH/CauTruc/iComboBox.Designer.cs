namespace QLNH.CauTruc
{
    partial class iComboBox
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
            this.ButtonShow = new DevExpress.XtraEditors.SimpleButton();
            this.Label = new System.Windows.Forms.Label();
            this.ComboBox = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonShow
            // 
            this.ButtonShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonShow.Location = new System.Drawing.Point(274, 0);
            this.ButtonShow.Name = "ButtonShow";
            this.ButtonShow.Size = new System.Drawing.Size(24, 23);
            this.ButtonShow.TabIndex = 2;
            this.ButtonShow.Text = "...";
            this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // Label
            // 
            this.Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Label.Size = new System.Drawing.Size(95, 23);
            this.Label.TabIndex = 0;
            this.Label.Text = "TextTest";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox
            // 
            this.ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox.Location = new System.Drawing.Point(95, 0);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBox.Properties.NullText = "";
            this.ComboBox.Properties.PopupSizeable = false;
            this.ComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ComboBox.Size = new System.Drawing.Size(179, 20);
            this.ComboBox.TabIndex = 1;
            // 
            // iComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.ButtonShow);
            this.Controls.Add(this.Label);
            this.Name = "iComboBox";
            this.Size = new System.Drawing.Size(298, 23);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ButtonShow;
        private System.Windows.Forms.Label Label;
        private DevExpress.XtraEditors.LookUpEdit ComboBox;
    }
}
