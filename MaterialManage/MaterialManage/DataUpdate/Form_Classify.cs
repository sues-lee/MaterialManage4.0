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
    public partial class Form_Classify : Update
    {
        public Form_Classify()
        {
            InitializeComponent();
        }
        string name = null;
        private static string cname;
        public static string Cname
        {
            get { return cname; }
            set { cname = value; }
        }

        string str_All = "select Cid,Cname 名称 from Classify where CMark=0";
        protected override string Str_All
        {
            get { return str_All; }
            set { str_All = value; }
        }

        private void Form_Classify_Load(object sender, EventArgs e)
        {
           fresh(str_All);
        }

        private void Form_Classify_Activated(object sender, EventArgs e)
        {
            fresh(str_All);
        }

        protected override void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str_Search = "select Cid,Cname 名称 from Classify where CMark=0 and Cname like '%" + toolStripTextBox1.Text.Replace("'", "''") + "%' ";
            isSearched(str_Search);
            name = toolStripTextBox1.Text;
        }
        protected override void toolStripButton_Increase_Click(object sender, EventArgs e)
        {
            Form_Classify_Change form_change = new Form_Classify_Change(false,name);
            form_change.ShowDialog();
        }

        protected override void toolStripButton_change_Click(object sender, EventArgs e)
        {
            Form_Classify_Change form_change = new Form_Classify_Change(true,name);
            form_change.ShowDialog(); ;
        }
        protected override void toolStripButton_del_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                string str_Del = string.Format("update Classify set CMark=1 where Cid='{0}'", id);
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
                cname = dataGridView.CurrentRow.Cells[1].Value.ToString();
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
