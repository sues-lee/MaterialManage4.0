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
    public partial class Form_Material : Update
    {
        public Form_Material()
        {
            InitializeComponent();
        }
        string name = null;
        private static string mname;
        private static string type;
        private static string price;
        private static string unit;
        public static string Mname
        {
            get { return mname; }
            set { mname = value; }
        }
        public static string Type
        {
            get { return type; }
            set { type = value; }
        }
        public static string Price
        {
            get { return price; }
            set { price = value; }
        }
        public static string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        string str_All = "select Mid,Mname 名称,Mtype 型号,Mprice 单价,Munit 单位 from Material where MMark=0";
        protected override string Str_All
        {
            get { return str_All; }
            set { str_All = value; }
        }

        private void Form_Material_Load(object sender, EventArgs e)
        {
            fresh(str_All);
        }

        private void Form_Material_Activated(object sender, EventArgs e)
        {
            fresh(str_All);
        }

        protected override void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str_Search = "select Mid,Mname 名称,Mtype 型号,Mprice 单价,Munit 单位 from Material where MMark=0 and Mname like '%" + toolStripTextBox1.Text.Replace("'", "''") + "%' ";
            isSearched(str_Search);
            name = toolStripTextBox1.Text;
        }
        protected override void toolStripButton_Increase_Click(object sender, EventArgs e)
        {
            Form_Material_Change Frm_change = new Form_Material_Change(false,name);
            Frm_change.ShowDialog();
        }

        protected override void toolStripButton_change_Click(object sender, EventArgs e)
        {
            Form_Material_Change Frm_change = new Form_Material_Change(true,name);
            Frm_change.ShowDialog();
        }
        protected override void toolStripButton_del_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                string str_Del = string.Format("update Material set MMark=1 where Mid='{0}'", id);
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
                mname = dataGridView.CurrentRow.Cells[1].Value.ToString();
                type = dataGridView.CurrentRow.Cells[2].Value.ToString();
                price = dataGridView.CurrentRow.Cells[3].Value.ToString();
                unit = dataGridView.CurrentRow.Cells[4].Value.ToString();
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
