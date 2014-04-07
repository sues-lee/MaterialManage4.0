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
    public partial class Form_UserChange : Form
    {
        public Form_UserChange()
        {
            InitializeComponent();
        }
        string auth;
        private void Form_UserChange_Load(object sender, EventArgs e)
        {
            setComobox();
            showPwd();
        }
        /// <summary>
        /// 用户名绑定到combobox
        /// </summary>
        private void setComobox()
        {
            //用户名绑定到combobox
            string str_User = "Select Username from Login where Authority=0 or Authority=1";
            List<string> L_UserName = new List<string>();
            L_UserName = DBHelper.SearchL(str_User);
            if (L_UserName.Count >0)
            {
                comboBox_User.DataSource = L_UserName;
                comboBox_User.SelectedIndex = 0;
            }
            else
            {
                button_Change.Enabled = false;
                button_Del.Enabled = false;
            }
            
        }
        /// <summary>
        /// 显示密码
        /// </summary>
        private void showPwd()
        {
            string str_Pwd = "Select Password from Login where UserName='"+comboBox_User.Text.Replace("'","''")+"'";
            List<string> L_Pwd = new List<string>();
            L_Pwd = DBHelper.SearchL(str_Pwd);
            label3.Text = L_Pwd[0];
        }
        private void comboBox_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str_Auth = "Select Authority from Login where Username='"+comboBox_User.Text+"'";
            List<string> L_Auth = new List<string>();
            L_Auth = DBHelper.SearchL(str_Auth);
            auth = L_Auth[0].ToString();
            if (auth =="0")
            {
                comboBox_Authority.SelectedIndex = 0;
            }
            else if (auth == "1")
            {
                comboBox_Authority.SelectedIndex = 1;
            }
            showPwd();
            

        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            string str_Change = string.Format("update Login set Authority='{0}' where UserName='{1}'",auth,comboBox_User.Text);
            execute(str_Change);
            setComobox();
        }
        /// <summary>
        /// 提交sql修改语句
        /// </summary>
        /// <param name="str_Change"></param>
        private static void execute(string str_Change)
        {
            if (DBHelper.ExecuteNonQuery(str_Change))
            {
                MessageBox.Show("修改成功！", "提示");
            }
            else
            {
                MessageBox.Show("修改失败！", "提示");
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            string str_Del = string.Format("delete from  Login where UserName='{0}'", comboBox_User.Text);
            execute(str_Del);
            setComobox();
        }

        private void comboBox_Authority_SelectedIndexChanged(object sender, EventArgs e)
        {
            auth = comboBox_Authority.SelectedIndex.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_AddUser frmAdd = new Form_AddUser();
            frmAdd.ShowDialog();
            setComobox();
        }

        private void button_Pwd_Click(object sender, EventArgs e)
        {
            string str_Changepwd = string.Format("update Login set PassWord='111111' where UserName='{0}'", comboBox_User.Text);
            if (DBHelper.ExecuteNonQuery(str_Changepwd))
            {
                MessageBox.Show("密码已重置为111111！", "提示");
                showPwd();
            }
            else
            {
                MessageBox.Show("修改失败！", "提示");
            }
        }
    }
}
