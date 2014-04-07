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
    public partial class Form_Material_Change : Form
    {
        bool isChange;      //若为真则为修改界面，否则为增加界面
        string name = null;
        public Form_Material_Change(bool IsChange,string Name)
        {
            InitializeComponent();
            isChange = IsChange;
            name = Name;

        }

        private void Form_Material_Change_Load(object sender, EventArgs e)
        {
            if (isChange)
            {
                textBox_name.Text = DataUpdate.Form_Material.Mname;
                textBox_type.Text = DataUpdate.Form_Material.Type;
                textBox_price.Text = DataUpdate.Form_Material.Price;
                textBox_unit.Text = DataUpdate.Form_Material.Unit;
            }
            else
            {
                button_change.Text = "增加";
                textBox_name.Text = name;
            }
          
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

        private void button_change_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Replace("'", "''").Length == 0)
            {
                MessageBox.Show("请输入名称！", "提示");
                return;
            }
            if (textBox_type.Text.Length == 0)
            {
                MessageBox.Show("请输入型号！", "提示");
                return;
            }
            if (textBox_price.Text.Length == 0)
            {
                MessageBox.Show("请输入单价！", "提示");
                return;
            }
            if (textBox_unit.Text.Length == 0)
            {
                MessageBox.Show("请输入单位！", "提示");
                return;
            }
            string sql;
            if (isChange)
            {
                string id = DataUpdate.Form_Material.Id;
                sql = string.Format("update Material set Mname='{0}',Mtype='{1}',Mprice='{2}',Munit='{3}' where Mid='{4}'", textBox_name.Text.Replace("'", "''"), textBox_type.Text.Replace("'", "''"), textBox_price.Text.Replace("'", "''"), textBox_unit.Text.Replace("'", "''"), id);
            }
            else
            {
                string str = string.Format("select * from Material where Mname='{0}' and MMark=0", textBox_name.Text.Replace("'", "''"));
                if (DBHelper.IsExist(str))
                {
                    MessageBox.Show("信息已存在！", "提示");
                    return;
                }
                sql = string.Format("insert into Material(Mname,Mtype,Mprice,Munit) values('{0}','{1}','{2}','{3}') ", textBox_name.Text.Replace("'", "''"), textBox_type.Text.Replace("'", "''"), textBox_price.Text.Replace("'", "''"), textBox_unit.Text.Replace("'", "''"));
            
            } 
            Modify(sql);
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是.键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_type.Clear();
            textBox_unit.Clear();
        }
    }
}
