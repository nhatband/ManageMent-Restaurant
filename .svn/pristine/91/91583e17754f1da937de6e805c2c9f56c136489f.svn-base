using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using QLNH.CoSo;

namespace QLNH.CauTruc
{

    public partial class iComboBox : UserControl
    {
        public event EventHandler ComboChange;
        public event EventHandler ComboLeave;
        public FrmDataList FrmDetail
        {
            get;
            set;
        }
        public NHMain NHMain;
        public iComboBox()
        {
            InitializeComponent();
        }
        [DefaultValue(80)]
        public int LabelLengh
        {
            get { return this.Label.Width; }
            set { this.Label.Width = value; }
        }
        public string Caption
        {
            get { return this.Label.Text; }
            set { this.Label.Text = value; }
        }
        public LookUpEdit ComboBoxEdit
        {
            get { return this.ComboBox; }
            set { this.ComboBox = value; }
        }
        private void ButtonShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (FrmDetail == null)
                { MessageBox.Show("DATA_NOT_INVALID!"); }
                else
                {
                    FrmDetail.isSelect = true;

                    FrmDetail.ShowDialog();

                    this.ComboBox.Text = FrmDetail.GetDataRow()[this.ComboBox.Properties.DisplayMember].ToString();

                }
            }
            catch
            {

            }
        }
        private void lookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (ComboChange != null)
            {
                ComboChange(this.ComboBox, new EventArgs());
            }
        }

        private void lookUp_Leave(object sender, EventArgs e)
        {
            if (ComboLeave != null)
            {
                ComboLeave(this.ComboBox, new EventArgs());
            }
        }
        public void SetData(NHMain nhmain, string condition, DataTable DataTable, string idField,
                        string nameField, ComboBoxTypeView type)
        {
            NHMain = nhmain;
            DataView view = new DataView(DataTable);
            view.RowFilter = condition;
            switch (type)
            {
                case ComboBoxTypeView.NameID:
                    this.ComboBox.Properties.DataSource = view;
                    this.ComboBox.Properties.ValueMember = idField;
                    this.ComboBox.Properties.DisplayMember = nameField;
                    this.ComboBox.Properties.ShowHeader = false;
                    this.ComboBox.Properties.Columns.Clear();
                    this.ComboBox.Properties.Columns.Add(new LookUpColumnInfo(nameField, string.Empty, this.ComboBox.Width));
                    this.ComboBox.Properties.Columns.Add(new LookUpColumnInfo(idField, string.Empty, 80));
                    this.ComboBox.Properties.PopupWidth = this.ComboBox.Width + 80;
                    this.ComboBox.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
                    this.ComboBox.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = HorzAlignment.Near;
                    break;
                case ComboBoxTypeView.IDOnly:
                    this.ComboBox.Properties.DataSource = view;
                    this.ComboBox.Properties.ValueMember = idField;
                    this.ComboBox.Properties.DisplayMember = idField;
                    this.ComboBox.Properties.ShowHeader = false;
                    this.ComboBox.Properties.Columns.Clear();
                    this.ComboBox.Properties.Columns.Add(new LookUpColumnInfo(idField, string.Empty, this.ComboBox.Width));
                    this.ComboBox.Properties.PopupWidth = this.ComboBox.Width;
                    this.ComboBox.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
                    this.ComboBox.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = HorzAlignment.Near;
                    break;
                case ComboBoxTypeView.NameOnly:
                    this.ComboBox.Properties.DataSource = view;
                    this.ComboBox.Properties.ValueMember = idField;
                    this.ComboBox.Properties.DisplayMember = nameField;
                    this.ComboBox.Properties.ShowHeader = false;
                    this.ComboBox.Properties.Columns.Clear();
                    this.ComboBox.Properties.Columns.Add(new LookUpColumnInfo(nameField, string.Empty, this.ComboBox.Width));
                    this.ComboBox.Properties.PopupWidth = this.ComboBox.Width;
                    this.ComboBox.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
                    this.ComboBox.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = HorzAlignment.Near;
                    break;
                case ComboBoxTypeView.IDName:
                    this.ComboBox.Properties.DataSource = view;
                    this.ComboBox.Properties.ValueMember = idField;
                    this.ComboBox.Properties.DisplayMember = idField;
                    this.ComboBox.Properties.ShowHeader = false;
                    this.ComboBox.Properties.Columns.Clear();
                    this.ComboBox.Properties.Columns.Add(new LookUpColumnInfo(idField, string.Empty, 120));
                    this.ComboBox.Properties.Columns.Add(new LookUpColumnInfo(nameField, string.Empty, 220));
                    this.ComboBox.Properties.PopupWidth = 120 + 220;
                    this.ComboBox.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
                    this.ComboBox.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = HorzAlignment.Near;
                    break;
                default:
                    break;
            }
        }
        public void SetData(List<ItemCombobox> list)
        {
            this.ButtonShow.Visible = false;
            this.ComboBox.Properties.DataSource = list;
            this.ComboBox.Properties.ValueMember = "Id";
            this.ComboBox.Properties.DisplayMember = "Name";
            this.ComboBox.Properties.ShowHeader = false;
            this.ComboBox.Properties.Columns.Clear();
            this.ComboBox.Properties.Columns.Add(new LookUpColumnInfo("Name", string.Empty, this.ComboBox.Width));
            this.ComboBox.Properties.PopupWidth = this.ComboBox.Width;
            this.ComboBox.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.ComboBox.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = HorzAlignment.Near;
            this.ComboBox.Properties.ShowFooter = false;
        }
        public void EndEdit()
        {
            if (this.ComboBox.DataBindings.Count > 0)
            {
                this.Label.Select();
                this.ComboBox.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }
    }
}
