using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialManage.CodeTableUpdate;
namespace MaterialManage.DataUpdate
{
    public partial class Form_Funds : Update
    {
        public Form_Funds()
        {
            InitializeComponent();
        }
        string name = null;
        private static string fcname;
        public static string FCname
        {
            get { return fcname; }
            set { fcname = value; }
        }
        string str_All = "select FCid,FCname 名称 from FundsClass where FCMark=0";
        protected override string Str_All
        {
            get { return str_All; }
            set { str_All = value; }
        }


        private void Form_Funds_Load(object sender, EventArgs e)
        {
            fresh(str_All);
        }

        private void Form_Funds_Activated(object sender, EventArgs e)
        {
            fresh(str_All);
        }

        protected override void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str_Search = "select FCid,FCname 名称 from FundsClass where FCMark=0 and FCname like '%" + toolStripTextBox1.Text.Replace("'", "''") + "%' ";
            isSearched(str_Search);
            name = toolStripTextBox1.Text;
        }
        protected override void toolStripButton_Increase_Click(object sender, EventArgs e)
        {
            Form_Funds_Change form_Change = new Form_Funds_Change(false,name);
            form_Change.ShowDialog();
        }

        protected override void toolStripButton_change_Click(object sender, EventArgs e)
        {
            Form_Funds_Change form_Change = new Form_Funds_Change(true,name);
            form_Change.ShowDialog();
        }
        protected override void toolStripButton_del_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                string str_Del = string.Format("update FundsClass set FCMark=1 where FCid='{0}'", id);
                delInfo(str_Del);
            }
            else
            {
                MessageBox.Show("请选择要删除的信息！");
            }
        }
        protected override void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow.Cells[0].Value != null)       //检验是否有数据
            {
                id = dataGridView.CurrentRow.Cells[0].Value.ToString(); //获取物品编号
                fcname = dataGridView.CurrentRow.Cells[1].Value.ToString();
                toolStripButton_change.Enabled = true;
            }
            else
            {
                toolStripButton_del.Enabled = false;
                toolStripButton_change.Enabled = false;
            }
        }
    }
}
