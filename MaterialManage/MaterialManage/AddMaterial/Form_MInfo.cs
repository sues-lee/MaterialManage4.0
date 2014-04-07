using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaterialManage.AddMaterial
{
    public partial class Form_AddInfo : Form
    { 
        CDataBase db = new CDataBase();
        string Mid;                 //定义字符串保存物品编号
        string s_Name = "";         //查询名称窗口变量
        string s_Mtype = "";        //查询型号窗口变量
        //int m_count = 0;            //判断有无物品对添加按钮进行可用变换

        public Form_AddInfo()
        {
            InitializeComponent();
        } 

        private void Form_Add_Load(object sender, EventArgs e)
        {
            button_In.Enabled = false;          //初始化各控件的可用性
            comboBox_class.Enabled = false;
            numericUpDown_num.Enabled = false;
            comboBox_Bname.Enabled = false;
            dateTimePicker_date.Enabled = false;
            button_sure.Enabled = false;
            button_cancle.Enabled = false;
            button_Add.Enabled = false;


            refresh();


            string Str1 = "select distinct CName from Classify where CMark = 0";
            List<string> L2 = new List<string>();
            L2 = db.SearchL(Str1);
            comboBox_class.DataSource = L2;

            string Str2 = "select distinct BName from Buy where BMark = 0";
            List<string> L = new List<string>();
            L = db.SearchL(Str2);
            comboBox_Bname.DataSource = L;

        }

        private void refresh()
        {
            string s = "select Material.MId,Mname 名称,Mtype 型号,Mprice 单价,MUnit 单位,StCount 数量,Stid from Material,Stock where Material.MId=Stock.MId and MMark=0 and  StId in(select MAX(stid) from Stock group by mid)";
            DataSet ds = new DataSet();
            ds = db.Search(s);
            dataGridView1.DataSource = ds.Tables[0];

            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_In.Enabled = true;
            Mid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.textBox_type.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.textBox_price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.textBox_unit.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox_Mname_TextChanged(object sender, EventArgs e)
        {

            Search();

        }

        private void textBox_MType_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        //查找搜索框中的内容
        private void Search()
        {
            string s = "";
            if (textBox_Mname.Text == "")
            {
                s = "select Material.MId,Mname 名称,Mtype 型号,Mprice 单价,MUnit 单位,StCount 数量,Stid from Material,Stock where Material.MId=Stock.MId and MMark=0 and MType like'%" + textBox_MType.Text.Replace("'", "''") + "%' and  StId in(select MAX(stid) from Stock group by mid)";
           
                //s = "select * from Material where MType like'%" + textBox_MType.Text.Replace("'", "''") + "%' and MMark = 0";
            }
            else
            {
                s = "select Material.MId,Mname 名称,Mtype 型号,Mprice 单价,MUnit 单位,StCount 数量,Stid from Material,Stock where Material.MId=Stock.MId and MMark=0 and  MName like '%" + textBox_Mname.Text.Replace("'", "''") + "%' and MType like'%" + textBox_MType.Text.Replace("'", "''") + "%' and  StId in(select MAX(stid) from Stock group by mid)";
           
               // s = "select * from Material where MName like '%" + textBox_Mname.Text.Replace("'", "''") + "%' and MType like '" + textBox_MType.Text.Replace("'", "''") + "' and MMark = 0";
            }
            DataSet ds = new DataSet();
            ds = db.Search(s);
            dataGridView1.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count < 1)
            {
                button_Add.Enabled = true;
                button_In.Enabled = false;
                dataGridView1.Rows[0].Selected = false;
            }
            else
            {
                button_Add.Enabled = false;
                button_In.Enabled = false;
                dataGridView1.Rows[0].Selected = false;
            }


        }

        private void button_In_Click(object sender, EventArgs e)
        {
            setEnable(true);

        }
        /// <summary>
        /// 设置出库控件是否可用
        /// </summary>
        /// <param name="isEnable"></param>
        private void setEnable(bool isEnable)
        {
            comboBox_class.Enabled = isEnable;          
            numericUpDown_num.Enabled = isEnable;
            comboBox_Bname.Enabled = isEnable;
            dateTimePicker_date.Enabled = isEnable;
            button_sure.Enabled = isEnable;
            button_cancle.Enabled = isEnable;
        }

        private void button_sure_Click(object sender, EventArgs e)
        {
            int Count;

            if (textBox_name.Text.Length==0)
            {
                MessageBox.Show("物品名称不能为空！");
                return;
            }
            if (comboBox_class.Text.Length == 0)
            {
                MessageBox.Show("种类不能为空！");
                return;
            }
            if (comboBox_Bname.Text.Length == 0)
            {
                MessageBox.Show("采购人名称不能为空！");
                return;
            }
            string m_t = this.comboBox_class.Text.Replace("'", "''");
            string str = "select CName from Classify where CName='" + m_t + "' and CMark=0";    //当有新的类别时，插入新的类别
            string str1 = "insert into Classify (CName) values ('" + comboBox_class.Text.Replace("'", "''") + "')";
            DataSet ds_1 = new DataSet();
            ds_1 = db.Search(str);
            if (ds_1.Tables[0].Rows.Count <= 0)          //判断数据表中是否存在该物品类别 
            {
                db.Cmd(str1);
            }

            string m_b = this.comboBox_Bname.Text.Replace("'", "''");
            string str_1 = "select Bname from Buy where Bname ='" + m_b + "' and BMark = 0";          //当有新的采购员名，记录下来
            string str_2 = "insert into Buy (Bname) values ('" + comboBox_Bname.Text.Replace("'", "''") + "')";
            DataSet ds_2 = new DataSet();
            ds_2 = db.Search(str_1);
            if (ds_2.Tables[0].Rows.Count <= 0)
            {
                db.Cmd(str_2);
            }

            string strQue = "select StCount from Stock where StId = (select Max(StId) from Stock where Mid=" + Mid + " and StMark = 0)";          //通过Mid找出总数
            Count = Convert.ToInt32(db.CountM(strQue));
            Count = Count + Convert.ToInt32(numericUpDown_num.Text);         //总数加上入库数量作为新的总数

            string strAdd = "insert into Stock(Mid,CName,StNum,StCount,StDate,Bname) values('" + Mid + "','" + comboBox_class.Text.Replace("'", "''") + "','" + Convert.ToInt32(numericUpDown_num.Text) + "','" + Count + "','" + dateTimePicker_date.Text + "','" + comboBox_Bname.Text.Replace("'", "''") + "')";      //插入数据到Stock中

            bool A_cmd;
            A_cmd = db.Cmd(strAdd);
            if (A_cmd)
            {
                MessageBox.Show("添加成功！");
                refresh();
                setEnable(false);   //设置出库控件不可用
            }
        }



        private void comboBox_Bname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            s_Name = textBox_Mname.Text;
            s_Mtype = textBox_MType.Text;

            Form_AddM frm_addi = new Form_AddM(s_Name, s_Mtype);
            if (frm_addi.ShowDialog() == DialogResult.OK)
            {
                string s = "";
                if (textBox_Mname.Text == "")
                {
                    s = "select * from Material where MType like'%" + textBox_MType.Text + "%' and MMark = 0";
                }
                else
                {
                    s = "select * from Material where MName like '%" + textBox_Mname.Text + "%' and MType like '" + textBox_MType.Text + "' and MMark = 0";
                }
                DataSet ds = new DataSet();
                ds = db.Search(s);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Rows[0].Selected = false;
                return;
            }
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AddInfo_Activated(object sender, EventArgs e)
        {
            Search();
        }
    }
}
