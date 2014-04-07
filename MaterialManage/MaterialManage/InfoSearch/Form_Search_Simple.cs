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
    public partial class Form_Search_Simple : Form
    {
        public Form_Search_Simple()
        {
            InitializeComponent();
        }

   

        private void Form_Search_Simple_Load(object sender, EventArgs e)
        {
            string str_searchall = "select Mname 名称,Mtype 型号,CName 分类,StNum 入库数量,BName 采购人,StDate 入库日期 from Material,Stock where Material.MId=Stock.MId and StMark=0 and MMark=0";

            dgvInit(str_searchall);
            dataGridView.ReadOnly = true;
        }
        /// <summary>
        /// 初始化datagridview，载入所有数据
        /// </summary>
        private void dgvInit(string sql)
        {
            DataSet ds = DBHelper.Search(sql);
            dataGridView.DataSource = ds.Tables[0];
            ds_search = DBHelper.Search(sql);
        }
        DataSet ds_search = new DataSet();
        private void button_in_confirm_Click(object sender, EventArgs e)
        {
            string str_search = "select Mname 名称,Mtype 型号,CName 分类,StNum 入库数量,BName 采购人,StDate 入库日期 from Material,Stock where Material.MId=Stock.MId and StMark=0 and MMark=0";
            //根据输入增加sql语句的查询条件
            if (textBox_in_name.Text.Length>0)
            {
                str_search += string.Format(" and Mname like '%{0}%'", textBox_in_name.Text.Replace("'", "''"));
            }
            if (textBox_in_type.Text.Length > 0)
            {
                str_search += string.Format(" and Mtype like '%{0}%'", textBox_in_type.Text.Replace("'", "''"));
            }
            if (textBox_in_class.Text.Length > 0)
            {
                str_search += string.Format(" and Cname like '%{0}%'", textBox_in_class.Text.Replace("'", "''"));
            }
            if (textBox_in_nummin.Text.Length > 0)
            {
                str_search += string.Format(" and StNum >= '{0}'", textBox_in_nummin.Text.Replace("'", "''"));
            }
            if (textBox_in_nummax.Text.Length > 0)
            {
                str_search += string.Format(" and StNum <= '%{0}'", textBox_in_nummax.Text.Replace("'", "''"));
            }
            if (textBox_in_buy.Text.Length > 0)
            {
                str_search += string.Format(" and Bname like '%{0}%'", textBox_in_buy.Text.Replace("'", "''"));
            }
            if (dateTimePicker_in_min.Checked==true)
            {
                str_search += string.Format(" and StDate >= '{0}'", dateTimePicker_in_min.Value.ToString());
            }
            if (dateTimePicker_in_max.Checked == true)
            {
                str_search += string.Format(" and StDate <= '{0}'", dateTimePicker_in_max.Value.ToString());
            }
             ds_search = DBHelper.Search(str_search);
            dataGridView.DataSource = ds_search.Tables[0];
            
        }

        private void textBox_in_nummin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是.键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox_in_nummax_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是.键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button_out_confirm_Click(object sender, EventArgs e)
        {
            string str_search = "select Mname 名称,Mtype 型号,OSNum 出库数量,Stcount 库存数,OSTotalPrice 总价,UName 单位名称,OSUse 用途,OsDate 出库日期,OName 经办人,FCName 经费分类,OSRemark 备注,OSOutId 出库单号 from Material,OutStock,Stock where Material.MId=OutStock.MId and Material.MId=Stock.MId and StId in(select MAX(stid) from Stock group by mid) and OSMark =0 and MMark=0 and StMark=0";
            if (textBox_out_name.Text.Length > 0)
            {
                str_search += string.Format(" and Mname like '%{0}%'", textBox_out_name.Text.Replace("'", "''"));
            }
            if (textBox_out_type.Text.Length > 0)
            {
                str_search += string.Format(" and Mtype like '%{0}%'", textBox_out_type.Text.Replace("'", "''"));
            }
            if (textBox_out_nummin.Text.Length > 0)
            {
                str_search += string.Format(" and OsNum >= '{0}'", textBox_out_nummin.Text.Replace("'", "''"));
            }
            if (textBox_out_nummax.Text.Length > 0)
            {
                str_search += string.Format(" and OsNum <= '{0}'", textBox_out_nummax.Text.Replace("'", "''"));
            }
            if (textBox_out_oname.Text.Length > 0)
            {
                str_search += string.Format(" and OName like '%{0}%'", textBox_out_oname.Text.Replace("'", "''"));
            }
            if (textBox_out_uname.Text.Length > 0)
            {
                str_search += string.Format(" and UName like '%{0}%'", textBox_out_uname.Text.Replace("'", "''"));
            }
            if (textBox_out_use.Text.Length > 0)
            {
                str_search += string.Format(" and OSUse like '%{0}%'", textBox_out_use.Text.Replace("'", "''"));
            }
            if (dateTimePicker_out_min.Checked == true)
            {
                str_search += string.Format(" and OsDate >= '{0}'", dateTimePicker_out_min.Value.ToString());
            }
            if (dateTimePicker_out_max.Checked == true)
            {
                str_search += string.Format(" and OsDate <= '{0}'", dateTimePicker_out_max.Value.ToString());
            }
            if (textBox_out_outId.Text.Length > 0)
            {
                str_search += string.Format(" and OSOutId like '%{0}%'", textBox_out_outId.Text.Replace("'", "''"));
            }
            ds_search = DBHelper.Search(str_search);
            dataGridView.DataSource = ds_search.Tables[0];
        }

        private void button_m_confirm_Click(object sender, EventArgs e)
        {
            string str_search = "select Mname 名称,Mtype 型号,MPrice 单价,MUnit 单位,StCount 库存数 from Material,Stock where Material.MId=Stock.MId and StId in(select MAX(stid) from Stock group by mid) and MMark =0 and StMark=0";
            if (textBox_m_name.Text.Length > 0)
            {
                str_search += string.Format(" and Mname like '%{0}%'", textBox_m_name.Text.Replace("'", "''"));
            }
            if (textBox_m_type.Text.Length > 0)
            {
                str_search += string.Format(" and Mtype like '%{0}%'", textBox_m_type.Text.Replace("'", "''"));
            }
            if (textBox_m_unit.Text.Length > 0)
            {
                str_search += string.Format(" and MUnit like '%{0}%'", textBox_m_unit.Text.Replace("'", "''"));
            }
            if (textBox_m_nummin.Text.Length > 0)
            {
                str_search += string.Format(" and StCount >= '{0}'", textBox_m_nummin.Text.Replace("'", "''"));
            }
            if (textBox_m_nummax.Text.Length > 0)
            {
                str_search += string.Format(" and StCount <= '{0}'", textBox_m_pricemax.Text.Replace("'", "''"));
            }
            if (textBox_m_pricemin.Text.Length > 0)
            {
                str_search += string.Format(" and MPrice >= '{0}'", textBox_m_pricemin.Text.Replace("'", "''"));
            }
            if (textBox_m_pricemax.Text.Length > 0)
            {
                str_search += string.Format(" and MPrice <= '{0}'", textBox_m_pricemax.Text.Replace("'", "''"));
            }
            ds_search = DBHelper.Search(str_search);
            dataGridView.DataSource = ds_search.Tables[0];
        }
       //-------------------------------------------------------------------------------------

        private void button_in_print_Click(object sender, EventArgs e)
        {
            //string str_Path = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + "\\CReporter" + "\\CRt_Test.rpt";
            string str_Path = Application.StartupPath + "/CReporter/CRt_Test.rpt";

            Print(ds_search.Tables[0], str_Path);

        }
        /// <summary>
        /// 将对应数据表中的数据在报表中显示
        /// </summary>
        /// <param name="dt_print"></param>
        private void Print( DataTable dt_print,string str_Path)
        {
            DataTable dt = new DataTable();
            //处理ds1
            dt = this.dtx(dt_print);
           //ReportDocument myReport = new ReportDocument();
            List<string> L_Fname = new List<string>();         //输入中文字段名
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                string str_dpName = dataGridView.Columns[i].Name;

                L_Fname.Add(str_dpName);
            }

            Form_Crt_test form_test = new Form_Crt_test();
            form_test.Str_Path = str_Path;
            form_test.L_Fname = L_Fname;
            form_test.Dt = dt;
            form_test.Show();
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

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            string str_searchall = "";
           if ( tabControl1.SelectedIndex==0)
	            {
                     str_searchall = "select Mname 名称,Mtype 型号,CName 分类,StNum 入库数量,BName 采购人,StDate 入库日期 from Material,Stock where Material.MId=Stock.MId and MMark=0 and StMark=0";
                    
	            }
           if (tabControl1.SelectedIndex==1)
           {
               str_searchall = "select Mname 名称,Mtype 型号,OSNum 出库数量,Stcount 库存数,OSTotalPrice 总价,UName 单位名称,OSUse 用途,OsDate 出库日期,OName 经办人,FCName 经费分类,OSRemark 备注,OSOutId 出库单号 from Material,OutStock,Stock where Material.MId=OutStock.MId and Material.MId=Stock.MId and StId in(select MAX(stid) from Stock group by mid) and OSMark =0 and MMark=0 and StMark=0";
            
           }
           if (tabControl1.SelectedIndex==2)
           {
                str_searchall = "select Mname 名称,Mtype 型号,MPrice 单价,MUnit 单位,StCount 库存数 from Material,Stock where Material.MId=Stock.MId and StId in(select MAX(stid) from Stock group by mid) and MMark =0 and StMark=0";
           
           }
           dgvInit(str_searchall);

        }

        private void button_in_all_Click(object sender, EventArgs e)
        {
           string str_searchall = "select Mname 名称,Mtype 型号,CName 分类,StNum 入库数量,BName 采购人,StDate 入库日期 from Material,Stock where Material.MId=Stock.MId and MMark=0 and StMark=0";
            dgvInit(str_searchall);
            ds_search = DBHelper.Search(str_searchall);
        }

        private void button_out_all_Click(object sender, EventArgs e)
        {
            string str_searchall = "select Mname 名称,Mtype 型号,OSNum 出库数量,Stcount 库存数,OSTotalPrice 总价,UName 单位名称,OSUse 用途,OsDate 出库日期,OName 经办人,FCName 经费分类,OSRemark 备注,OSOutId 出库单号 from Material,OutStock,Stock where Material.MId=OutStock.MId and Material.MId=Stock.MId and StId in(select MAX(stid) from Stock group by mid) and OSMark =0 and MMark=0 and StMark=0";
            dgvInit(str_searchall);
            ds_search = DBHelper.Search(str_searchall);
        }

        private void button_m_all_Click(object sender, EventArgs e)
        {
            
           string str_searchall = "select Mname 名称,Mtype 型号,MPrice 单价,MUnit 单位,StCount 库存数 from Material,Stock where Material.MId=Stock.MId and StId in(select MAX(stid) from Stock group by mid) and MMark =0 and StMark=0";
           dgvInit(str_searchall);
           ds_search = DBHelper.Search(str_searchall);
        }

        private void button_out_print_Click(object sender, EventArgs e)
        {
           // string str_Path = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + "\\CReporter" + "\\CRt_PrintLong.rpt";
            string str_Path = AppDomain.CurrentDomain.BaseDirectory + "CReporter" + "\\CRt_PrintLong.rpt";

            Print(ds_search.Tables[0], str_Path);
        }

        private void button_m_print_Click(object sender, EventArgs e)
        {
            //string str_Path = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + "\\CReporter" + "\\CRt_Test.rpt";
            string str_Path = AppDomain.CurrentDomain.BaseDirectory + "CReporter" + "\\CRt_Test.rpt";

            Print(ds_search.Tables[0], str_Path);
        }
        
    }
}
