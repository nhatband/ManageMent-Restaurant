using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Windows.Forms;

namespace QLNH.CoSo
{
    public class XmlExecute
    {
        public DataTable DataTable;
        public DataTable DataStruct;
        public NHMain NHMain;
        public string NameTable;
        DataSet DataSet;
        public XmlExecute(NHMain nhmain, DataTable data)
        {
            DataTable = data;
            NHMain = nhmain;
            CreateXml();
            this.DataStruct = this.NHMain.GetDataByQuery("select * from sys_field where table_id = '" + data.TableName + "'", "sys_field");
            this.DataStruct.TableName = "struct_" + data.TableName.ToUpper();
        }
        public XmlExecute(NHMain nhmain, DataSet dataset,string nametable)
        {
            DataSet = dataset;
            NHMain = nhmain;
            NameTable = nametable;
            DataSet.DataSetName = nametable + "_M";
            DataSet.WriteXml(NHMain.StartUpPath + "\\XmlData\\" + nametable + "_M.xml");
            NameTable = NameTable + "_M";
        }
        public XmlExecute(NHMain nhmain, string nametable)
        {
            try
            {
                NameTable = nametable;
                NHMain = nhmain;
                this.DataTable = new DataTable(NameTable);
                this.DataStruct = new DataTable("struct_" + NameTable);
                if (File.Exists(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xsd"))
                    this.DataTable.ReadXmlSchema(NHMain.StartUpPath + "\\XmlData\\" + NameTable.ToUpper() + ".xsd");
                if (File.Exists(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xsd"))
                    this.DataStruct.ReadXmlSchema(NHMain.StartUpPath + "\\XmlData\\struct_" + NameTable.ToUpper() + ".xsd");
                if (File.Exists(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml"))
                    this.DataTable.ReadXml(NHMain.StartUpPath + "\\XmlData\\" + NameTable.ToUpper() + ".xml");
                if (File.Exists(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml"))
                    this.DataStruct.ReadXml(NHMain.StartUpPath + "\\XmlData\\struct_" + NameTable.ToUpper() + ".xml");
                this.DataTable.TableName = NameTable;
            }
            catch
            {
                MessageBox.Show("Không tồn tại đối tượng " + DataTable.TableName);
                return;
            }

        }
        public void LoadReport()
        {
            TransformOutput();
        }
        private void TransformOutput()
        {
            try
            {
                XmlReader input = XmlReader.Create(NHMain.StartUpPath + "\\XmlData\\" + NameTable + ".xml");
                XmlDocument stylesheet = new XmlDocument();
                stylesheet.Load(NHMain.StartUpPath + "\\BaoCao\\" + NameTable + ".xslt");
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(stylesheet);
                MemoryStream buffer = new MemoryStream();
                StreamWriter sw = new StreamWriter(buffer);
                transform.Transform(input, null, sw);
                byte[] chars = buffer.ToArray();
                string output = Encoding.UTF8.GetString(chars);
                WriteFile(output, NHMain.StartUpPath + "\\BaoCao\\", NameTable + ".html", true);
            }
            catch
            {
            }
        }
        public object WriteFile(string DataWrite, string Path, string File_Name, bool Overwritten)
        {
            bool TT = true;
            Overwritten = false;
            StreamWriter Rw = new StreamWriter(Path + File_Name.Replace("False", ""), Overwritten);
            try
            {
                Rw.WriteLine(DataWrite + "\r\n");
                Rw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TT = false;
            }
            return TT;
        }
        public void Save()
        {
            this.DataTable.WriteXml(NHMain.StartUpPath + "\\XmlData\\" + NameTable.ToUpper() + ".xml");
        }
        public void CreateXml()
        {
            if (!File.Exists(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xsd"))
                DataTable.WriteXmlSchema(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xsd");
            if (!File.Exists(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml"))
                DataTable.WriteXml(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml");
            //else
            //{
            //    File.Delete(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml");
            //    DataTable.WriteXml(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml");
            //}
        }
        public void Delete(string key, DataRow row)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml");
            XmlNode table = doc.DocumentElement;
            string strpath = @"./" + DataTable.TableName + "[" + key + "='" + row[key] + "']";
            XmlNode old = table.SelectSingleNode(strpath);
            if (old != null)
                doc.RemoveChild(old);
            doc.Save(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml");
        }
        public void Edit(DataRow data, double index, string pr_key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml");
            XmlNode table = doc.DocumentElement;
            string strpath = @"./" + NameTable + "[" + pr_key + "='" + data[pr_key] + "']";
            XmlNode old = table.SelectSingleNode(strpath);

            XmlElement record = doc.DocumentElement;
            XmlNode newnode = doc.CreateElement(DataTable.TableName);
            XmlNode node;
            foreach (DataRow i in DataStruct.Rows)
            {
                node = null;
                node = doc.CreateElement(i["FIELD_ID"].ToString());
                node.InnerText = data[i["FIELD_ID"].ToString()].ToString();
                newnode.AppendChild(node);
            }
            if(old != null)
            table.ReplaceChild(newnode, old);
            doc.Save(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml");
        }
        public void AddNew(DataRow datarow)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml");
                XmlElement record = doc.DocumentElement;
                XmlNode newnode = doc.CreateElement(DataTable.TableName);
                DataTable dt = NHMain.GetTables(DataTable.TableName);
                XmlNode node;
                foreach (DataRow i in dt.Rows)
                {
                    node = null;
                    node = doc.CreateElement(i["nameCL"].ToString());
                    node.InnerText = datarow[i["nameCL"].ToString()].ToString();
                    newnode.AppendChild(node);
                }
                record.AppendChild(newnode);
                doc.Save(NHMain.StartUpPath + "\\XmlData\\" + DataTable.TableName + ".xml");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
