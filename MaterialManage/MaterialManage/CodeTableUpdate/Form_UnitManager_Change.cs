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
    public partial class Form_UnitManager_Change : Form
    {
        bool isChange;
        string name = null;
        public Form_UnitManager_Change(bool IsChange,string Name)
        {
            InitializeComponent();
            isChange = IsChange;
            name = Name;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Replace("'", "''").Length == 0)
            {
                MessageBox.Show("请输入单位名称！", "提示");
                return;
            }
            if (textBox_name.Text.Replace("'", "''").Length == 0)
            {
                MessageBox.Show("请输入主管姓名！", "提示");
                return;
            }
            string sql;
            if (isChange)
            {
                string id = DataUpdate.Form_UnitManager.Id;
                sql = string.Format("update UnitManager set Uname='{0}',UMname='{1}' where UMId='{2}'", textBox_name.Text.Replace("'", "''"), textBox_mname.Text.Replace("'", "''"), id);
           
            }
            else
            {
                string str = string.Format("select * from UnitManager where Uname='{0}' and UMMark=0", textBox_name.Text.Replace("'", "''"));
                if (DBHelper.IsExist(str))
                {
                    MessageBox.Show("信息已存在！", "提示");
                    return;
                }
                sql = string.Format("insert into UnitManager(Uname,UMname) values('{0}','{1}') ", textBox_name.Text.Replace("'", "''"), textBox_mname.Text);
           
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

        private void Form_UnitManager_Change_Load(object sender, EventArgs e)
        {
            if (isChange)
            {
                textBox_mname.Text = DataUpdate.Form_UnitManager.Mname;
                textBox_name.Text = DataUpdate.Form_UnitManager.Uname;
            }
            else
            {
                button_change.Text = "增加";
                textBox_name.Text = name;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_mname.Clear();
            textBox_name.Clear();
        }
    }
}
