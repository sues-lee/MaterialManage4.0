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
    public partial class Form_CodeChange : Form
    {
        public Form_CodeChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入密码！", "提示");
                return;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("请再次输入密码！", "提示");
                return;
            }

            Form_Login form_login = new Form_Login();
            string str_username = form_login.UserName;
            string str_change = "update Login set Password='" + textBox2.Text.Replace("'","''") + "' where UserName='" + str_username + "'";
            if (DBHelper.ExecuteNonQuery(str_change))
            {
                MessageBox.Show("修改成功！", "提示");
            }
            else
            {
                MessageBox.Show("修改失败！", "提示");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5)
            {
                label5.Text = "密码少于五位!";
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.Text = "成功!";
                label5.ForeColor = Color.Green;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox1.Text)
            {
                label4.Text = "请再输一次密码！";
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.Text = "成功！";
                label4.ForeColor = Color.Green;
            }
        }
    }
}
