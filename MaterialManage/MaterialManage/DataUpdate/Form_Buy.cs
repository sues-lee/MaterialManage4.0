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
    public partial class Form_Buy : Update
    {
        public Form_Buy()
        {
            InitializeComponent();
        }
        string name = null;
         private static string bname;
         public static string Bname
         {
             get { return bname; }
             set { bname = value; }
         }
         string str_All = "select Bid,Bname 名称 from Buy where BMark=0";
         protected override string Str_All
        {
            get { return str_All; }
            set { str_All = value; }
        }
  

        private void Form_Buy_Load(object sender, EventArgs e)
        {
            fresh(str_All);
        }
        protected override void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str_Search = "select Bid,Bname 名称 from Buy where BMark=0 and Bname like '%" + toolStripTextBox1.Text.Replace("'", "''") + "%' ";
            isSearched(str_Search);
            name = toolStripTextBox1.Text;
        }
        protected override void toolStripButton_Increase_Click(object sender, EventArgs e)
        {
            Form_Buy_Change form_Change = new Form_Buy_Change(false,name);
            form_Change.ShowDialog();
        }

        protected override void toolStripButton_change_Click(object sender, EventArgs e)
        {
            Form_Buy_Change form_Change = new Form_Buy_Change(true,name);
            form_Change.ShowDialog();
        }
        protected override void toolStripButton_del_Click(object sender, EventArgs e)
        {
            if (id!="")
            {
                string str_Del = string.Format("update Buy set BMark=1 where Bid='{0}'", id);
                delInfo(str_Del);
            }
            else
            {
                MessageBox.Show("请选择要删除的信息！");
            }
            
            
        }
        private void Form_Buy_Activated(object sender, EventArgs e)
        {
           fresh(str_All);
        }
        protected override void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow.Cells[0].Value != null)       //检验是否有数据
            {
                id = dataGridView.CurrentRow.Cells[0].Value.ToString(); //获取物品编号
                bname = dataGridView.CurrentRow.Cells[1].Value.ToString();
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
