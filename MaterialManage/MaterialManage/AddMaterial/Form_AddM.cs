using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaterialManage.AddMaterial
{
    public partial class Form_AddM : Form
    { 
        CDataBase db = new CDataBase();
        string s_name = "";
        string s_type = "";

        public Form_AddM()
        {
            InitializeComponent();
        }

        public Form_AddM(string a,string b)
        {
            InitializeComponent();
            s_name = a;
            s_type = b;
        }

        
       
        private void button_S_Click(object sender, EventArgs e)
        {
            bool a;

            if (textBox_MN.Text == "") 
            {
                MessageBox.Show("物品名称不能为空！");
                return;
            };

            if (textBox_MT.Text == "")
            {
                MessageBox.Show("物品型号不能为空！");
                return;
            };

            if (textBox_P.Text == "")
            {
                MessageBox.Show("物品单价不能为空！");
            };

            if (textBox_U.Text == "")
            {
                MessageBox.Show("物品的单位不能为空！");
            };

            string str = "insert into Material (Mname,MType,MPrice,MUnit) values ('" + textBox_MN.Text.Replace("'", "''") + "','" + textBox_MT.Text.Replace("'", "''") + "'," + textBox_P.Text.Replace("'", "''") + ",'" + textBox_U.Text.Replace("'", "''") + "' )";
            a = db.Cmd(str);
            if (a)
                MessageBox.Show("添加成功！");
            this.DialogResult = DialogResult.OK;
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AddM_Load(object sender, EventArgs e)
        {
            textBox_MN.Text = s_name;
            textBox_MT.Text = s_type;
        }

        private void Form_AddM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox_P_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是.键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
