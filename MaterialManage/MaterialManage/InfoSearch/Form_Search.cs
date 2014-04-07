using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace MaterialManage.InfoSearch
{
    public partial class Form_Search : Form
    {
        public Form_Search()
        {
            InitializeComponent();
        }
        string dname = null;          //表名
        string dpname = null;       //字段名
        DataTable dt = new DataTable();  //查找条件
        string datatype;                                    // 数据类型
        private void Form_Search_Load(object sender, EventArgs e)
        {
            //初始化datatable;
            dt.Columns.Add("filename");
            dt.Columns.Add("fieldname");
            dt.Columns.Add("condition");
            dt.Columns.Add("content");
            dt.Columns.Add("cfilename");
            dt.Columns.Add("cfieldname");
            dt.Columns.Add("type");
            dataGridView1.DataSource = dt;
            //初始化dgv
            this.dataGridView1.Columns[0].HeaderText = "表名";
            this.dataGridView1.Columns[1].HeaderText = "字段名";
            this.dataGridView1.Columns[2].HeaderText = "查询条件";
            this.dataGridView1.Columns[3].HeaderText = "查询内容";
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            //将中文表名输入到下拉表

            comboBox_file.Items.Add("入库表");
            comboBox_file.Items.Add("出库表");
            comboBox_file.Items.Add("材料代码表");
            comboBox_file.SelectedIndex = 0;
            //根据中文表名搜索出对应的英文表名
            string str_dname = "select distinct DName from DDT where DCName='" + comboBox_file.Text + "'";
            List<string> L_dname = DBHelper.SearchL(str_dname);
            dname = L_dname[0].ToString();              //初始化表名
            fieldinit(dname);
            //根据中文字段名搜索出对应的英文字段名
            getdpname();
        }
        /// <summary>
        /// 根据中文字段名搜索出对应的英文字段名
        /// </summary>
        private void getdpname()
        {
            //根据中文字段名搜索出对应的英文字段名
            string str_dpname = "select distinct DPName from DDT where DPCName='" + comboBox_field.Text + "' and DName='" + dname + "'";
            List<string> L_dpname = DBHelper.SearchL(str_dpname);
            dpname = L_dpname[0].ToString();              //初始化字段名
        }

        /// <summary>
        /// 根据表名初始化字段名
        /// </summary>
        /// <param name="name"></param>
        private void fieldinit(string name)
        {

            //将字段名输入到下拉表

            string str_dpcname = "select distinct DPCName from DDT where DName='" + name + "'";
            List<string> L_dpcname = new List<string>();
            L_dpcname = DBHelper.SearchL(str_dpcname);
            if (L_dpcname.Contains("编号"))
            {
                L_dpcname.Remove("编号");
            }
            if (dname == "Material")      //增加材料的库存数
            {
                L_dpcname.Add("库存数");
            }
            comboBox_field.DataSource = L_dpcname;
        }
        /// <summary>
        /// 表名改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_file_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据中文表名搜索出对应的英文表名
            string str_dname = "select distinct DName from DDT where DCName='" + comboBox_file.Text + "'";
            List<string> L_dname = DBHelper.SearchL(str_dname);
            dname = L_dname[0].ToString();              //初始化表名
            fieldinit(dname);
        }
        /// <summary>
        /// 字段名改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_field_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox_condition.Items.Clear();                   //清空
            string str_datatype = string.Format("select DType from DDT where DName='{0}' and DPCName='{1}'", dname, comboBox_field.Text);  //获取字段类型，根据类型选择不同的条件
            List<string> L_datatype = DBHelper.SearchL(str_datatype);
            datatype = L_datatype[0].ToString();              //初始化数据类型
            getdpname();                                        //获取字段英文名
            if (datatype == "I" || datatype == "D" || datatype == "M")
            {
                comboBox_condition.Items.Add(">");
                comboBox_condition.Items.Add("<");
                comboBox_condition.Items.Add(">=");
                comboBox_condition.Items.Add("<=");
                comboBox_condition.Items.Add("=");
            }
            else if (datatype == "C")
            {
                comboBox_condition.Items.Add("like");
                comboBox_condition.Items.Add("=");
            }
            if (datatype == "D")
            {
                dateTimePicker1.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = false;
            }
            comboBox_condition.SelectedIndex = 0;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_content.Text.Length == 0 && dateTimePicker1.Visible == false)
            {
                MessageBox.Show("请输入查询内容！", "提示");
                return;
            }
            DataRow dr = dt.NewRow();
            //将信息输入datatable
            dr["filename"] = comboBox_file.Text;
            dr["fieldname"] = comboBox_field.Text;
            dr["condition"] = comboBox_condition.Text;
            if (dateTimePicker1.Visible == true)      //  如果需datetimepicker可见的话则输入其日期
            {
                dr["content"] = dateTimePicker1.Text;
            }
            else
            {
                dr["content"] = textBox_content.Text;
            }
            dr["cfilename"] = dname;
            dr["cfieldname"] = dpname;
            dr["type"] = datatype;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            if (comboBox_file.Text == "入库表")
            {
                comboBox_file.Items.Clear();
                comboBox_file.Items.Add("入库表");
                comboBox_file.Items.Add("材料代码表");
                comboBox_file.SelectedIndex = 0;
            }
            if (comboBox_file.Text == "出库表")
            {
                comboBox_file.Items.Clear();
                comboBox_file.Items.Add("出库表");
                comboBox_file.Items.Add("材料代码表");
                comboBox_file.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// 搜索按钮响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_search_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("请添加查询内容！", "提示");
                return;
            }
            string filename = dname;        //查询表名
            string condition = null;        //查询条件
            string and = " and ";
            if (dataGridView1.Rows.Count > 1)     //确定表名
            {

                List<string> L_filename = new List<string>();
                L_filename.Add(dname);
                foreach (DataRow item in dt.Rows)
                {
                    if (!L_filename.Contains(item["cfilename"].ToString()))//如果条件中不存在此表，则添加
                    {
                        filename += "," + item["cfilename"].ToString();
                        L_filename.Add(item["cfilename"].ToString());
                    }
                }
                if (L_filename.Count > 1)   //根据条件中的表名添加搜索条件
                {
                    if (L_filename.Contains("Stock")) condition += "Stock.MId=Material.MId and ";
                    if (L_filename.Contains("OutStock")) condition += "OutStock.MId=Material.MId and ";
                }
            }

            string str_countsearch = null;  //搜索库存数的条件
            for (int i = 0; i < dt.Rows.Count; i++)     //动态生成sql语句
            {
                if (dt.Rows[i][5].ToString() == "Count")    //如果查找库存数
                {
                    condition += "Material.MId>0";
                    str_countsearch = "库存数" + dt.Rows[i][2].ToString() + dt.Rows[i][3].ToString();
                }
                else
                {
                    condition += dt.Rows[i][4].ToString() + "." + dt.Rows[i][5].ToString() + " " + dt.Rows[i][2].ToString();
                    if (dt.Rows[i][6].ToString() == "C" || dt.Rows[i][6].ToString() == "D")
                    {
                        condition += "'" + dt.Rows[i][3].ToString().Replace("'", "''");
                        if (dt.Rows[i][2].ToString() == "like")
                        {
                            condition += "%'";
                        }
                        else
                        {
                            condition += "'";
                        }
                    }
                    else
                    {
                        condition += dt.Rows[i][3].ToString().Replace("'", "''");
                    }
                }
                condition += and;
            }
            condition = condition.Substring(0, condition.Length - 4);   // 去掉最后的and

            string str_search = string.Format("select distinct * from {0} where {1} ", filename, condition);
            DataSet ds_result = new DataSet();
            ds_result = DBHelper.Search(str_search);
            if (ds_result.Tables[0].Columns.Contains("MId1"))//删除物品编号列
            {
                ds_result.Tables[0].Columns.Remove("MId1");
            }
            if (ds_result.Tables[0].Columns.Contains("OSId"))//删除出库编号列
            {
                ds_result.Tables[0].Columns.Remove("OSId");
            }
            if (ds_result.Tables[0].Columns.Contains("StId"))//删除入库编号列
            {
                ds_result.Tables[0].Columns.Remove("StId");
            }
            if (ds_result.Tables[0].Columns.Contains("StCount"))//删除材料数量列,添加库存数字段
            {
                ds_result.Tables[0].Columns.Remove("StCount");
            }
            List<string> L_cname = new List<string>();
            for (int i = 0; i < ds_result.Tables[0].Columns.Count; i++)
            {
                string str_cname = string.Format("select DPCName from DDT where DPName='{0}' ", ds_result.Tables[0].Columns[i].ToString());
                List<string> L_cname_1 = DBHelper.SearchL(str_cname);         //将中文字段名输入dgv2
                L_cname.Add(L_cname_1[0].ToString());
            }
            if (ds_result.Tables[0].Columns.Contains("MMark"))              //在材料表结果中添加库存数
            {
                ds_result.Tables[0].Columns.Add("库存数", typeof(int));
                for (int i = 0; i < ds_result.Tables[0].Rows.Count; i++)
                {
                    string str_count = string.Format("select Stcount 数量 from Stock where MId='{0}' and StId in(select MAX(stid) from Stock group by mid)", ds_result.Tables[0].Rows[i]["MId"].ToString());
                    List<string> L_count = new List<string>();
                    L_count = DBHelper.SearchL(str_count);
                    if (L_count.Count!=0)
                    {
                        ds_result.Tables[0].Rows[i]["库存数"] = L_count[0];  
                    }
                    
                }
            }
            if (str_countsearch != null)                                    //如果查找库存数
            {
                DataTable dt1 = new DataTable();
                dt1 = ds_result.Tables[0].Copy();
                dt1.Rows.Clear();                               //清空数据，只保留结构
                DataRow[] dr = ds_result.Tables[0].Select(str_countsearch);
                for (int i = 0; i < dr.Length; i++)  //将数据转入dt1
                {
                    dt1.Rows.Add(dr[i].ItemArray);
                }
                dataGridView2.DataSource = dt1;
            }
            else
            {
                dataGridView2.DataSource = ds_result.Tables[0];
            }


            int index = 0;
            foreach (string item in L_cname)
            {
                dataGridView2.Columns[index].HeaderText = item;
                index++;
            }

        }
        /// <summary>
        /// 清空按钮响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.DataSource = dt;
            //将中文表名输入到下拉表
            comboBox_file.Items.Clear();
            comboBox_file.Items.Add("入库表");
            comboBox_file.Items.Add("出库表");
            comboBox_file.Items.Add("材料代码表");
            comboBox_file.SelectedIndex = 0;
        }

        private void textBox_content_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (datatype != "C")
            {
                //如果输入的不是数字键，也不是.键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// 将dataset格式化
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private DataTable dtx(DataTable dt)
        {

            DataSet_Test.DataTable1DataTable dtx1 = new DataSet_Test.DataTable1DataTable();
            object[] obj = new object[dt.Columns.Count];
            //特别注意：所选择的表的列的数目需<=Bigtable的字段数目
            //请自行填写保护代码
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtx1.Rows.Add(dtx1.NewRow());

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dtx1.Rows[i][j] = dt.Rows[i][j].ToString();
                }
            }
            return dtx1;
        }
        /// <summary>
        /// 打印报表预览
        /// </summary>
        /// <param name="dt_print"></param>
        /// <param name="str_Path"></param>
        private void Print(DataTable dt_print, string str_Path)
        {
            DataTable dt = new DataTable();
            //处理ds1
            dt = this.dtx(dt_print);
            ReportDocument myReport = new ReportDocument();
            List<string> L_Fname = new List<string>();         //输入中文字段名
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                string str_dpName = dataGridView2.Columns[i].HeaderText;

                L_Fname.Add(str_dpName);
            }

            Form_Crt_test form_test = new Form_Crt_test();
            form_test.Str_Path = str_Path;
            form_test.L_Fname = L_Fname;
            form_test.Dt = dt;
            form_test.Show();
        }
        /// <summary>
        /// 打印按钮响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_print_Click(object sender, EventArgs e)
        {
            DataTable dt_info = (DataTable)dataGridView2.DataSource; //获取报表数据源
            if (dt_info == null)
            {
                MessageBox.Show("请先搜索信息", "提示");
                return;
            }
            DataTable dt_print = dtx(dt_info);    //初始化
            string str_Path = "";
            if (dt_info.Columns.Count <= 6)
            {

                str_Path = Application.StartupPath + "/CReporter/CRt_Test.rpt";
               
            }
            if (dt_info.Columns.Count > 6 && dt_info.Columns.Count <= 12)
            {
                str_Path = Application.StartupPath + "/CReporter/CRt_PrintLong.rpt";
                
            }
            if (dt_info.Columns.Count > 12 )
            {
                str_Path = Application.StartupPath + "/CReporter/CRt_PrintLongLong.rpt";
               // str_Path = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + "\\CReporter" + "\\CRt_PrintLongLong.rpt";
            }
            Print(dt_print, str_Path);
        }

    }
}
