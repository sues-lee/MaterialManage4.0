using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace MaterialManage.OutStock
{
    public partial class Form_Confirm : Form
    {
        public Form_Confirm()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath + "/OutList.xml";
        bool isOut = false;
        private void Form_Confirm_Load(object sender, EventArgs e)
        {
            fresh();
            if (dataGridView.DataSource!=null)
            {
                int index = 0;
                for(index = 0;index<dataGridView.Columns.Count;index++)
                {
                    string colName = dataGridView.Columns[index].HeaderText;
                    string str_cname = string.Format("select DPCName from DDT where DPName='{0}' ",colName );
                    List<string> L_cname = DBHelper.SearchL(str_cname);         //将中文字段名输入dgv
                    dataGridView.Columns[index].HeaderText = L_cname[0];
                    
                }
            }
            button_Print.Enabled = false;
            //dataGridView.Columns[3].Visible = false;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(path)==false)
            {
                MessageBox.Show("出库清单不存在");
                return;
            }
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                 xmlDoc.Load(path);
                 if (!xmlDoc.DocumentElement.HasChildNodes)
                 {
                     MessageBox.Show("无出库信息，请添加！", "提示");
                     return;
                 }
                //获取出库单号
                 string str_OutIdPath = Application.StartupPath + "/OutId.xml";
                 XmlDocument outDoc = new XmlDocument();
                 outDoc.Load(str_OutIdPath);
                 XmlNode xnRoot = outDoc.SelectSingleNode("Out");
                 XmlNodeList oList = xnRoot.ChildNodes;
                  XmlNode xnId = oList[0];
                 XmlNode xnDate = oList[1];
                 string outId = xnDate.InnerText + xnId.InnerText;
            foreach (XmlElement xeOut in xmlDoc.DocumentElement.ChildNodes)
            {
                string mname = xeOut.SelectSingleNode("MName").InnerText;
                string mid = xeOut.SelectSingleNode("MId").InnerText;
                string osnum = xeOut.SelectSingleNode("OSNum").InnerText;
                string oname = xeOut.SelectSingleNode("OName").InnerText;
                string uname = xeOut.SelectSingleNode("UName").InnerText;
                string umname = xeOut.SelectSingleNode("UMName").InnerText;
                string totalprice = xeOut.SelectSingleNode("OSTotalPrice").InnerText;
                string use = xeOut.SelectSingleNode("OSUse").InnerText;
                string date = xeOut.SelectSingleNode("OSDate").InnerText;
                string remark = xeOut.SelectSingleNode("OSRemark").InnerText;
                string fcname = xeOut.SelectSingleNode("FCName").InnerText;
            
                //查找对应物品的库存数
                string str_Num = "select StCount from Stock where StId in(select MAX(stid) from Stock group by mid) and MId='"+mid+"'";
                DataSet ds = DBHelper.Search(str_Num);
                string oldNum = ds.Tables[0].Rows[0][0].ToString();
                //修改库存数
                string newNum = (Convert.ToInt32(oldNum) - Convert.ToInt32(osnum)).ToString();
                if (Convert.ToInt32(newNum)<0)      //若数量不足，则此物品不出库
                {
                    MessageBox.Show(mname+"数量不足！", "提示");
                    continue;
                }
                //出库信息插入出库表
                string str_outstock = string.Format("insert into OutStock(MId,OSNum,OName,UName,UMName,OSTotalPrice,OSUse,OSDate,OSRemark,FCName,OSOutId) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", mid, osnum, oname, uname, umname, totalprice, use, date, remark, fcname,outId);
                DBHelper.ExecuteNonQuery(str_outstock);

                string str_stock = "update Stock set StCount='" + newNum + "'where StId in(select MAX(stid) from Stock group by mid) and MId='"+mid+"'";
                DBHelper.ExecuteNonQuery(str_stock);

               
            }
            //设置打印单号加1：
           
            int i_outId = Convert.ToInt32(oList[0].InnerText);
            i_outId++;
            oList[0].InnerText = i_outId.ToString();
            outDoc.Save(str_OutIdPath);//保存
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("出库成功！","提示");
            ////设置打印单号加1：
            //string str_OutIdPath = Application.StartupPath + "/OutId.xml";
            //XmlDocument outDoc = new XmlDocument();
            //outDoc.Load(str_OutIdPath);
            //XmlNode xnRoot = outDoc.SelectSingleNode("Out");
            //XmlNodeList oList = xnRoot.ChildNodes;
            //int outId = Convert.ToInt32(oList[0].InnerText);
            //outId++;
            //oList[0].InnerText = outId.ToString();
            //outDoc.Save(str_OutIdPath);//保存

            isOut = true;
            button_Confirm.Text = "已出库";
            button_Confirm.Enabled = false;
            button_del.Enabled = false;
            button_Print.Enabled = true;
           


        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            string str_CrtPath = Application.StartupPath + "/CReporter/CRt_Out2.rpt";
            string str_OutIdPath = Application.StartupPath + "/OutId.xml";
            Ds_Out dsOut = new Ds_Out();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode xnRoot = xmlDoc.SelectSingleNode("List");
            int i = 1;
            dsOut.Tables[0].Rows.Add();
            foreach (XmlNode xn in xnRoot.ChildNodes)
            {
                XmlNodeList oList = xn.ChildNodes;
                dsOut.Tables[0].Rows[0]["MName"+i] = oList[0].InnerText;
                dsOut.Tables[0].Rows[0]["MType" + i] = oList[1].InnerText;
                dsOut.Tables[0].Rows[0]["OSNum" + i] = oList[4].InnerText;
                dsOut.Tables[0].Rows[0]["Munit" + i] = oList[5].InnerText;
                dsOut.Tables[0].Rows[0]["MPrice" + i] = oList[2].InnerText;
                dsOut.Tables[0].Rows[0]["OSTotalPrice" + i] = oList[9].InnerText;
                dsOut.Tables[0].Rows[0]["OSRemark" + i] = oList[12].InnerText;
                dsOut.Tables[0].Rows[0]["FCName" + i] = oList[13].InnerText;
                i++;
            }
            XmlNodeList oList1 = xnRoot.ChildNodes[0].ChildNodes;
            //设置打印单号：
            XmlDocument outDoc = new XmlDocument();
            outDoc.Load(str_OutIdPath);
            XmlNode xnIdRoot = outDoc.SelectSingleNode("Out");
            XmlNodeList idList = xnIdRoot.ChildNodes;
            XmlNode xnId = idList[0];
            XmlNode xnDate = idList[1];

            List<string> L_info = new List<string>();//设置报表公式字段
            L_info.Add(oList1[6].InnerText);
            L_info.Add(oList1[11].InnerText);
            L_info.Add(oList1[6].InnerText);
            L_info.Add(oList1[8].InnerText);
            L_info.Add(oList1[10].InnerText);
            L_info.Add(xnDate.InnerText+ xnId.InnerText);


            Form_Crt_test form_out = new Form_Crt_test(L_info,str_CrtPath);
            form_out.Str_Path = str_CrtPath;
            form_out.Ds = dsOut;
            form_out.Show();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode xnOut = xmlDoc.SelectSingleNode("List");
            foreach (XmlNode xn in xnOut.ChildNodes)
            {
                foreach (XmlNode xn1 in xn)
                {
                    XmlElement xe = (XmlElement)xn1;
                    if (xe.Name=="MId"&&xe.InnerText == dataGridView.CurrentRow.Cells[3].Value.ToString())
                    {
                        xnOut.RemoveChild(xn); //删除当前行
                            
                    }
                }
                
            }
            xmlDoc.Save(path);  //保存文件
            fresh();
        }
        private void fresh()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            if (ds.Tables.Count > 0)
            {
                dataGridView.DataSource = ds.Tables[0];
                dataGridView.CurrentCell = dataGridView.Rows[0].Cells[1];//设置第一行为当前行
            }
            else
            {
                dataGridView.DataSource = null;
            }
        }

        private void Form_Confirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isOut==true)    //如果出库，则清空xml并返回yes
            {
                xmlClear();
                DialogResult = DialogResult.Yes;
            }
        }
        /// <summary>
        /// 清除出库信息
        /// </summary>
        private void xmlClear()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlElement xeDel = (XmlElement)xmlDoc.SelectSingleNode("List");
            xeDel.RemoveAll();      //清除所有子节点
            xmlDoc.Save(path);  //保存文件

        }
    }
}
