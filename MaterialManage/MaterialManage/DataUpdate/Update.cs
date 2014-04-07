using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaterialManage.DataUpdate
{
    public abstract partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        protected static string id;//要更改的id
        public static string Id
        {
            get { return id; }
            set { id = value; }
        }
        private  string str_All;

        protected virtual string Str_All
        {
            get { return str_All; }
            set { str_All = value; }
        }
        
   
        /// <summary>
        /// 刷新dgv
        /// </summary>
        protected void fresh(string str_All)
        {
            DataSet ds = DBHelper.Search(str_All);
            if (ds.Tables[0].Rows.Count > 0)       //检验是否查询有数据
            {

                dataGridView.DataSource = ds.Tables[0];
                dataGridView.CurrentCell = dataGridView.Rows[0].Cells[1];//设置第一行为当前行
                dataGridView.Columns[0].Visible = false;            // 隐藏Id列
                toolStripButton_Increase.Enabled = true;
                id = dataGridView.CurrentRow.Cells[0].Value.ToString(); //获取物品编号
            }
            else
            {
                toolStripButton_del.Enabled = false;    //如无数据 则删除按钮无法使用
            }

            dataGridView.ReadOnly = true;
            toolStripButton_change.Enabled = false;
            toolStripButton_Increase.Enabled = false;
        }

        /// <summary>
        /// 是否搜索到相应的信息
        /// </summary>
        /// <param name="sql"></param>
        protected void isSearched(string sql)
        {
            DataSet ds = DBHelper.Search(sql);
            if (ds.Tables[0].Rows.Count <= 0)
            {
                //如果搜索不到结果则增加键可用
                toolStripButton_Increase.Enabled = true;
            }
            else
            {
                toolStripButton_Increase.Enabled = false;
            }
            dataGridView.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 删除信息
        /// </summary>
        /// <param name="str_Del"></param>
        protected void delInfo(string str_Del)
        {
            DialogResult RSS = MessageBox.Show(this, "确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (RSS)
            {
                case DialogResult.Yes:
                    Modify(str_Del);
                    fresh(Str_All);
                    break;
                case DialogResult.No:
                   
                    break;
            }
        }
        /// <summary>
        /// 用来修改信息
        /// </summary>
        /// <param name="sql"></param>
        protected void Modify(string sql)
        {
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("操作成功！", "提示");

            }
            else
            {
                MessageBox.Show("操作失败！", "提示");
            }
        }

        protected abstract void toolStripButton_del_Click(object sender, EventArgs e);
        protected abstract void toolStripTextBox1_TextChanged(object sender, EventArgs e);

        protected void Update_Load(object sender, EventArgs e)
        {

        }

        protected abstract void toolStripButton_Increase_Click(object sender, EventArgs e);

        protected abstract void toolStripButton_change_Click(object sender, EventArgs e);

        protected abstract void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e);
       

    }
}
