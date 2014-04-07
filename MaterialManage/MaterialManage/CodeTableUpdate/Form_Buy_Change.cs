using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialManage.DataUpdate;

namespace MaterialManage.CodeTableUpdate
{
    public partial class Form_Buy_Change : Form
    {

        bool isChange;
        private string name=null;
        public Form_Buy_Change(bool IsChange,string Name)
        {
            InitializeComponent();
            this.isChange = IsChange;
            this.name = Name;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Replace("'", "''").Length == 0)
            {
                MessageBox.Show("请输入姓名！", "提示");
                return;
            }
            string sql;
            if (isChange)
            {
                string id = DataUpdate.Form_Buy.Id; //获取物品编号
                 sql = string.Format("update Buy set Bname='{0}' where Bid='{1}'", textBox_name.Text.Replace("'", "''"), id);
            }
            else 
            {
                string str = string.Format("select * from Buy where Bname='{0}' and BMark=0", textBox_name.Text.Replace("'", "''"));
                if (DBHelper.IsExist(str))
                {
                    MessageBox.Show("信息已存在！", "提示");
                    return;
                }
                sql = string.Format("insert into Buy(Bname) values('{0}') ", textBox_name.Text.Replace("'", "''")); 
            }
            
            Modify(sql);
        }
        /// <summary>
        /// 用来修改信息
        /// </summary>
        /// <param name="sql"></param>
        private void Modify(string sql)
        {
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("操作成功！", "提示");
                this.Close();
            }
            else
            {
                MessageBox.Show("操作失败！", "提示");
            }
        }

        private void Form_Buy_Change_Load(object sender, EventArgs e)
        { 
            if (isChange)
            {
                textBox_name.Text = DataUpdate.Form_Buy.Bname;
            }
            else
            {
                button_change.Text = "增加";
                textBox_name.Text = name;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
        }
    }
}
