using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaterialManage
{
    public partial class Form_Login : Form
    {
        CDataBase db = new CDataBase();
        static string userName;
        static string id;
        static string authority;    //权限

        public static string Authority
        {
            get { return Form_Login.authority; }
            set { Form_Login.authority = value; }
        }
        public static string Id
        {
            get { return Form_Login.id; }
            set { Form_Login.id = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string Str="select UserName,Password,Authority from Login where UserName='"+textBox_UseName.Text +"'and Password ='"+textBox_Password .Text+"'";
            if (textBox_UseName.Text == "'" || textBox_UseName.Text == "\"") 
            {
                MessageBox.Show("用户名称不能为非法字符！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_Password.Text == "'" || textBox_UseName.Text == "\"")
            {
                MessageBox.Show("密码不能为非法字符！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_UseName.Text == string.Empty)
            {
                MessageBox.Show("用户名称不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_Password.Text == string.Empty)
            {
                MessageBox.Show("密码不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet ds = new DataSet();
            ds = db.Search(Str);

            if (ds.Tables[0].Rows.Count > 0) 
            {
                Form_Main frm_main = new Form_Main();
                
                userName = textBox_UseName.Text;
                Id = ds.Tables[0].Rows[0][0].ToString();
                authority = ds.Tables[0].Rows[0][2].ToString();
                frm_main.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名称或密码不正确！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_UseName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                textBox_Password.Focus();
        }

        private void textBox_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                button_Login.Focus();
        }

        private void button_CanCle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
