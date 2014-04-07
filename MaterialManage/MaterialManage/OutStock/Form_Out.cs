using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MaterialManage.OutStock
{
    public partial class Form_Out : Form
    {
        public Form_Out()
        {
            InitializeComponent();
        }
        string str_stid;            //保存stid属性
        string str_num;             //保存物品数量
        string str_mid;             //保存物品编号
        string munit;
        int i_index;           //保存选中的信息的index值

        private void Form_Out_Load(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = true;
            button_Out.Enabled = false;
            //刷新
            refresh();
            //将单位名称输入下拉表
            string Str1 = "select UName from UnitManager where UMMark=0";
            List<string> L_uname = new List<string>();
            L_uname = DBHelper.SearchL(Str1);
            comboBox_uname.DataSource = L_uname;
            //将主管名称输入下拉表
            string Str2 = "select UMName from UnitManager where UMMark=0 and UName='"+comboBox_uname.Text.Replace("'", "''")+"'";
            List<string> L_umname = new List<string>();
            L_umname = DBHelper.SearchL(Str2);
           comboBox_umname.DataSource = L_umname;
            //将经费分类输入下拉表
            string Str3 = "select FCName from FundsClass where FCMark=0 ";
            List<string> L_funds = new List<string>();
            L_funds = DBHelper.SearchL(Str3);
            comboBox_funds.DataSource = L_funds;
            //将经办人姓名输入下拉列表
            string Str4 = "select OName from Operator where OMark=0 ";
            List<string> L_oname = new List<string>();
            L_oname = DBHelper.SearchL(Str4);
            comboBox_oname.DataSource = L_oname;

        }

        private void textBox_search1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select Material.MId,Mname 名称,Mtype 型号,Mprice 单价,MUnit 单位,StCount 数量,Stid from Material,Stock where Material.MId=Stock.MId and MMark=0 and  StId in(select MAX(stid) from Stock group by mid) and Mname like '" + textBox_search1.Text.Replace("'", "''") + "%' and Mtype like '" + textBox_search2.Text.Replace("'", "''") + "%' ";
            DataSet ds = DBHelper.Search(sql);
            dataGridView.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 查找物品型号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_search2_TextChanged(object sender, EventArgs e)
        {
            string sql = "select Material.MId,Mname 名称,Mtype 型号,Mprice 单价,MUnit 单位,StCount 数量,Stid from Material,Stock where Material.MId=Stock.MId and MMark=0 and  StId in(select MAX(stid) from Stock group by mid) and Mname like '" + textBox_search1.Text.Replace("'", "''") + "%'and Mtype like '" + textBox_search2.Text.Replace("'", "''") + "%' ";
            DataSet ds = DBHelper.Search(sql);
            dataGridView.DataSource = ds.Tables[0];
        }
 
        /// <summary>
        /// 单位名称改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_uname_TextChanged(object sender, EventArgs e)
        {
            string Str2 = "select distinct UMName from UnitManager where UMMark=0 and UName='" + comboBox_uname.Text.Replace("'", "''") + "'";
            List<string> L_umname = new List<string>();
            L_umname = DBHelper.SearchL(Str2);
            //显示对应单位的主管名称
            comboBox_umname.DataSource = null;
            comboBox_umname.DataSource = L_umname;
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (textBox_mname.TextLength!=0)    
            {
                //出库数量改变时总价也改变
            textBox_totalprice.Text = (Convert.ToInt32(dataGridView.CurrentRow.Cells[3].Value) * Convert.ToInt32(numericUpDown1.Value)).ToString();
            }
        }

        /// <summary>
        /// dgv单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //将当前选中的物品信息保存
            str_stid = dataGridView.CurrentRow.Cells[6].Value.ToString();
            str_num = dataGridView.CurrentRow.Cells[5].Value.ToString();
            i_index = dataGridView.CurrentRow.Index;
            str_mid = dataGridView.CurrentRow.Cells[0].Value.ToString();
            munit = dataGridView.CurrentRow.Cells[4].Value.ToString().Replace("'", "''");
            //在dgv被点击时将信息输入到下方相应的位置
            textBox_mname.Text = dataGridView.CurrentRow.Cells[1].Value.ToString().Replace("'","''");
            textBox_type.Text = dataGridView.CurrentRow.Cells[2].Value.ToString().Replace("'","''");
            textBox_price.Text = dataGridView.CurrentRow.Cells[3].Value.ToString().Replace("'","''");

            if (dataGridView.CurrentRow.Cells[5].Value.ToString().Replace("'","''")!="")
            {
                numericUpDown1.Maximum = Convert.ToDecimal(dataGridView.CurrentRow.Cells[5].Value);
            }
           
        }

        /// <summary>
        /// 确定按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (textBox_mname.Text.Length == 0)
            {
                MessageBox.Show("请选择要出库的物品！", "提示");
                return;
            }
            if (textBox_use.Text.Length == 0)
            {
                MessageBox.Show("请输入用途！", "提示");
                return;
            }
            if (textBox_use.Text.Length == 0)
            {
                MessageBox.Show("请输入用途！", "提示");
                return;
            }
            if (comboBox_oname.Text.Replace("'", "''").Length == 0)
            {
                MessageBox.Show("请输入经办人！", "提示");
                return;
            }
            if (comboBox_uname.Text.Replace("'", "''").Length == 0)
            {
                MessageBox.Show("请输入单位名称！", "提示");
                return;
            }
            if (comboBox_umname.Text.Replace("'", "''").Length == 0)
            {
                MessageBox.Show("请输入单位主管名称！", "提示");
                return;
            }
            if (Convert.ToInt32(numericUpDown1.Value)==0)
            {
                MessageBox.Show("出库数量不能为0！", "提示");
                return; 
            }
            if (Convert.ToInt32(numericUpDown1.Value)>Convert.ToInt32(str_num))
            {
                MessageBox.Show("库存不足！", "提示");
                return;
            }
            string str_funds = "select * from  FundsClass where FCMark=0 and FCname='" + comboBox_funds.Text.Replace("'", "''").Trim() + "'";
            string str_funds_input = "insert into FundsClass(FCName) values ('"+comboBox_funds.Text.Replace("'", "''").Trim()+"') ";
            DataSet ds1 = new DataSet();
            ds1 = DBHelper.Search(str_funds);
            if (ds1.Tables[0].Rows.Count <= 0)   //如果经费分类不存在，则新增一条
            {
                DBHelper.ExecuteNonQuery(str_funds_input);
            }
            string str_oname = "select * from  Operator where OMark=0 and Oname='" + comboBox_oname.Text.Replace("'", "''").Trim() + "'";
            string str_oname_input = "insert into Operator(OName) values ('" + comboBox_oname.Text.Replace("'", "''").Trim() + "') ";
            DataSet ds2 = new DataSet();
            ds2 = DBHelper.Search(str_oname);
            if (ds2.Tables[0].Rows.Count <= 0)   //如果经费经办人不存在，则新增一条
            {
                DBHelper.ExecuteNonQuery(str_oname_input);
            }
            string str_umname = "select * from  UnitManager where UMMark=0 and Umname='" + comboBox_umname.Text.Replace("'", "''").Trim() + "'";
            string str_uname = "select * from  UnitManager where UMMark=0 and Uname='" + comboBox_uname.Text.Replace("'", "''").Trim() + "'";
            string str_uname_input = "insert into UnitManager(UName,UMname) values ('" + comboBox_uname.Text.Replace("'", "''").Trim() + "','" + comboBox_umname.Text.Replace("'", "''") + "') ";
            DataSet ds3 = new DataSet();
            DataSet ds4 = new DataSet();
            ds3 = DBHelper.Search(str_uname);
            ds4 = DBHelper.Search(str_umname);
            if (ds3.Tables[0].Rows.Count <= 0 || ds3.Tables[0].Rows.Count <= 0)   //如果单位名称或主管名称不存在，则新增一条
            {
                DBHelper.ExecuteNonQuery(str_uname_input);
             
            }

            string mname = textBox_mname.Text.Replace("'", "''");
            string type = textBox_type.Text.Replace("'", "''");
            string price = textBox_price.Text.Replace("'", "''");
           
            string osnum=numericUpDown1.Value.ToString().Replace("'","''");
            string oname = comboBox_oname.Text.Replace("'", "''");
            string uname=comboBox_uname.Text.Replace("'", "''");
            string umname=comboBox_uname.Text.Replace("'", "''");
            string totalprice=textBox_totalprice.Text;
            string use = textBox_use.Text.Replace("'", "''");
            string date=dateTimePicker1.Text;
            string remark = textBox_remark.Text.Replace("'", "''");
            string fcname=comboBox_funds.Text.Replace("'", "''");

            string path = Application.StartupPath + "/OutList.xml";//存储出库队列的xml文件的路径
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                XmlNode root = xmlDoc.SelectSingleNode("List");  //获取根节点
                int i = 0;
                foreach (XmlNode xn in root.ChildNodes) //检查出库队列中的条数
                {
                    i++;
                }
                if (i >= 5)
                {
                    MessageBox.Show("出库条数不能多于5条！", "提示");
                    return;
                }

                XmlElement xeOut = xmlDoc.CreateElement("Out"); //创建出库信息条目节点
                XmlElement xeMName = xmlDoc.CreateElement("MName");//创建mname节点
                xeMName.InnerText = mname;
                xeOut.AppendChild(xeMName);
                root.AppendChild(xeOut);
                XmlElement xeType = xmlDoc.CreateElement("MType");//创建type节点
                xeType.InnerText = type;
                xeOut.AppendChild(xeType);
                root.AppendChild(xeOut);
                XmlElement xePrice = xmlDoc.CreateElement("MPrice");//创建price节点
                xePrice.InnerText = price;
                xeOut.AppendChild(xePrice);
                XmlElement xeMId = xmlDoc.CreateElement("MId");//创建MId节点
                xeMId.InnerText = str_mid;
                xeOut.AppendChild(xeMId);                       //添加到出库条目中
                XmlElement xeOSNum = xmlDoc.CreateElement("OSNum");//创建OSNum节点
                xeOSNum.InnerText = osnum;
                xeOut.AppendChild(xeOSNum);
                XmlElement xeMunit = xmlDoc.CreateElement("Munit");//创建Munit节点
                xeMunit.InnerText = munit;
                xeOut.AppendChild(xeMunit);
                XmlElement xeOName = xmlDoc.CreateElement("OName");//创建OName节点
                xeOName.InnerText = oname;
                xeOut.AppendChild(xeOName);
                XmlElement xeUName = xmlDoc.CreateElement("UName");//创建UName节点
                xeUName.InnerText = uname;
                xeOut.AppendChild(xeUName);
                XmlElement xeUMName = xmlDoc.CreateElement("UMName");//创建UMName节点
                xeUMName.InnerText = umname;
                xeOut.AppendChild(xeUMName);
                XmlElement xeOST = xmlDoc.CreateElement("OSTotalPrice");//创建OSTotalPrice节点
                xeOST.InnerText = totalprice;
                xeOut.AppendChild(xeOST);
                XmlElement xeOSUse = xmlDoc.CreateElement("OSUse");//创建OSUse节点
                xeOSUse.InnerText = use;
                xeOut.AppendChild(xeOSUse);
                XmlElement xeOSDate = xmlDoc.CreateElement("OSDate");//创建OSDate节点
                xeOSDate.InnerText = date;
                xeOut.AppendChild(xeOSDate);
                XmlElement xeOSRemark = xmlDoc.CreateElement("OSRemark");//创建OSRemark节点
                xeOSRemark.InnerText = remark;
                xeOut.AppendChild(xeOSRemark);
                XmlElement xeFCName = xmlDoc.CreateElement("FCName");//创建FCName节点
                xeFCName.InnerText = fcname;
                xeOut.AppendChild(xeFCName);
                
                root.AppendChild(xeOut);//保存一条出库信息
                xmlDoc.Save(path);  //保存文件
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

             MessageBox.Show("加入出库队列成功！", "提示");

            SetOutEnable(true);
                
        }
        /// <summary>
        /// 设置能否查看出库队列
        /// </summary>
        /// <param name="b"></param>
        public  void SetOutEnable(bool b)
        {
            if (b)
            {
                button_Out.Enabled = true;
                comboBox_oname.Enabled = false;
                dateTimePicker1.Enabled = false;
                comboBox_umname.Enabled = false;
                comboBox_funds.Enabled = false;
                comboBox_uname.Enabled = false;
                textBox_use.Enabled = false;
            }
            else
            {
                button_Out.Enabled = false;
                comboBox_oname.Enabled = true;
                dateTimePicker1.Enabled = true;
                comboBox_umname.Enabled = true;
                comboBox_funds.Enabled = true;
                comboBox_uname.Enabled = true;
                textBox_use.Enabled = true;
            }
           
        }


        /// <summary>
        /// 刷新dgv
        /// </summary>
        private void refresh()
        {
            //刷新
            DataSet ds = DBHelper.Search("select Material.MId,Mname 名称,Mtype 型号,Mprice 单价,MUnit 单位,StCount 数量,Stid from Material,Stock where Material.MId=Stock.MId and MMark=0 and  StId in(select MAX(stid) from Stock group by mid)");
            if (ds.Tables[0].Rows.Count>0)
            {
                dataGridView.DataSource = ds.Tables[0];
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[6].Visible = false;
                str_num = dataGridView.Rows[i_index].Cells[5].Value.ToString();
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
           Form_Confirm frm_Confirm = new Form_Confirm();
           if ( frm_Confirm.ShowDialog()==DialogResult.Yes)//根据队列是否被清空做出处理
           {
               SetOutEnable(false);
           }
            
            refresh();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            xmlClear();
            SetOutEnable(false);

        }
        /// <summary>
        /// 清除出库信息
        /// </summary>
        private static void xmlClear()
        {
            string path = Application.StartupPath + "/OutList.xml";//存储出库队列的xml文件的路径
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlElement xeDel = (XmlElement)xmlDoc.SelectSingleNode("List");
            xeDel.RemoveAll();      //清除所有子节点
            xmlDoc.Save(path);  //保存文件
            
        }

        private void Form_Out_FormClosed(object sender, FormClosedEventArgs e)
        {
            xmlClear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_umname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_use_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_funds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_uname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_remark_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_totalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_mname_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_oname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
