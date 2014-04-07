using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaterialManage.CodeTableUpdate
{
    public partial class Form_Funds_Change : Form
    {
        bool isChange;      //若为真则为修改界面，否则为增加界面
        string name = null;

        public Form_Funds_Change(bool IsChange,string Name)
        {
            InitializeComponent();
            isChange = IsChange;
            name = Name;
        }

        private void Form_Funds_Change_Load(object sender, EventArgs e)
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
                 sql = string.Format("update FundsClass set FCname='{0}' where FCid='{1}'", textBox_name.Text.Replace("'", "''"), id);
            }
            else
            {
                string str = string.Format("select * from FundsClass where FCname='{0}' and FCMark=0", textBox_name.Text.Replace("'", "''"));
                if (DBHelper.IsExist(str))
                {
                    MessageBox.Show("信息已存在！", "提示");
                    return;
                }
                sql = string.Format("insert into FundsClass(FCname) values('{0}') ", textBox_name.Text.Replace("'", "''"));
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


        private void button_Clear_Click(object sender, EventArgs e)
        { 
            textBox_name.Clear();
        }
    }
}
