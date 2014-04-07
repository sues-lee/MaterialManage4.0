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
    public partial class Form_Operator : Update
    {
        public Form_Operator()
        {
            InitializeComponent();
        }
        string name = null;
        static string oname;
        public static string Oname
        {
            get { return oname; }
            set { oname = value; }
        }

        string str_All = "select Oid,Oname 姓名 from Operator where OMark=0";
        protected override string Str_All
        {
            get { return str_All; }
            set { str_All = value; }
        }
        private void Form_Operator_Load(object sender, EventArgs e)
        {
            fresh(str_All);
        }

        private void Form_Operator_Activated(object sender, EventArgs e)
        {
            fresh(str_All);
        }

        protected override void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str_Search = "select Oid,Oname 姓名 from Operator where OMark=0 and Oname like '%" + toolStripTextBox1.Text.Replace("'", "''") + "%' ";
            isSearched(str_Search);
            name = toolStripTextBox1.Text;
        }
        protected override void toolStripButton_Increase_Click(object sender, EventArgs e)
        {
            Form_Operator_Change form_change = new Form_Operator_Change(false, name);
            form_change.Show();
        }

        protected override void toolStripButton_change_Click(object sender, EventArgs e)
        {
            Form_Operator_Change form_change = new Form_Operator_Change(true, name);
            form_change.Show();
        }
        protected override void toolStripButton_del_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                string str_Del = string.Format("update Operator set OMark=1 where Oid='{0}'", id);
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
                oname = dataGridView.CurrentRow.Cells[1].Value.ToString();
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
