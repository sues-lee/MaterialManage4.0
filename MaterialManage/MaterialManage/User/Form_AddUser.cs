using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaterialManage.User
{
    public partial class Form_AddUser : Form
    {
        public Form_AddUser()
        {
            InitializeComponent();
        }
        bool isNameRight = false;       //用户名输入是否正确

        private void button_Confirm_Click(object sender, EventArgs e)
        {

            if (!isNameRight)
            {
                MessageBox.Show("请输入正确的用户名", "提示");
                return;
            }


            string str_Add = string.Format("insert into Login(UserName,PassWord,Authority) values('{0}','{1}','{2}')", textBox_Name.Text.Replace("'", "''"), "111111", comboBox_Auth.SelectedIndex.ToString());
            if (DBHelper.ExecuteNonQuery(str_Add))
            {
                MessageBox.Show("添加成功！", "提示");
            }
            else
            {
                MessageBox.Show("添加失败！", "提示");
            }
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            string str_name = "select * from Login where UserName='"+textBox_Name.Text.Replace("'","''")+"'";
            if (DBHelper.IsExist(str_name))
            {
                label4.Text = "用户名已存在";
                label4.ForeColor = Color.Red;
                isNameRight = false;
            }
            else if(textBox_Name.TextLength==0)
            {
                label4.Text = "用户名不能为空";
                label4.ForeColor = Color.Red;
                isNameRight = false;
            }
            else
            {
                label4.Text = "用户名可用";
                label4.ForeColor = Color.Green;
                isNameRight = true;
            }
        }



        private void Form_AddUser_Load(object sender, EventArgs e)
        {
            comboBox_Auth.SelectedIndex = 0;
        }
    }
}
