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
    public partial class Form_UnitManager : Update
    {
        public Form_UnitManager()
        {
            InitializeComponent();
        }
        string name = null;
        private static string mname;
        private static string uname;
        public static string Mname
        {
            get { return mname; }
            set { mname = value; }
        }
        public static string Uname
        {
            get { return uname; }
            set { uname = value; }
        }
        string str_All = "select UMid,Uname 单位名称,UMname 主管姓名 from UnitManager where UMMark=0";
        protected override string Str_All
        {
            get { return str_All; }
            set { str_All = value; }
        }
        private void Form_UnitManager_Load(object sender, EventArgs e)
        {
            fresh(str_All);
        }

        private void Form_UnitManager_Activated(object sender, EventArgs e)
        {
            fresh(str_All);
        }

        protected override void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str_Search = "select UMid,Uname 单位名称,UMname 主管姓名 from UnitManager where UMMark=0 and Uname like '%" + toolStripTextBox1.Text.Replace("'", "''") + "%' ";
            isSearched(str_Search);
            name = toolStripTextBox1.Text;
        }
        protected override void toolStripButton_Increase_Click(object sender, EventArgs e)
        {
            Form_UnitManager_Change form_change = new Form_UnitManager_Change(false,name);
            form_change.ShowDialog();
        }

        protected override void toolStripButton_change_Click(object sender, EventArgs e)
        {
            Form_UnitManager_Change form_change = new Form_UnitManager_Change(true, name);
            form_change.ShowDialog();
        }
        protected override void toolStripButton_del_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                string str_Del = string.Format("update UnitManager set UMMark=1 where UMid='{0}'", id);
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
                uname = dataGridView.CurrentRow.Cells[1].Value.ToString();
                mname = dataGridView.CurrentRow.Cells[2].Value.ToString();
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
