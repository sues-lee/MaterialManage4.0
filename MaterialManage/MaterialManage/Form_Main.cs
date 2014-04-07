using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MaterialManage
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void 材料表整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CodeTableUpdate.Form_Material frm_Material = new CodeTableUpdate.Form_Material();
            DataUpdate.Form_Material frm_Material =new DataUpdate.Form_Material();
            frm_Material.Show();
          
        }

        private void 采购人整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CodeTableUpdate.Form_Buy frm_Buy = new CodeTableUpdate.Form_Buy();
            DataUpdate.Form_Buy frm_Buy = new DataUpdate.Form_Buy();
            frm_Buy.Show();
          
        }

        private void 领料人整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // CodeTableUpdate.Form_Operator frm_Operator = new CodeTableUpdate.Form_Operator();
            DataUpdate.Form_Operator frm_Operator = new DataUpdate.Form_Operator();
            frm_Operator.Show();
           
        }

        private void 单位主管整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CodeTableUpdate.Form_UnitManager frm_UManege = new CodeTableUpdate.Form_UnitManager();
            DataUpdate.Form_UnitManager frm_UManage = new DataUpdate.Form_UnitManager();
            frm_UManage.Show();
            
        }

        private void 材料种类整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CodeTableUpdate.Form_Classify frm_Class = new CodeTableUpdate.Form_Classify();
            DataUpdate.Form_Classify frm_Class = new DataUpdate.Form_Classify();
            frm_Class.Show();
          
        }

        private void 经费分类整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // CodeTableUpdate.Form_Funds frm_Funds = new CodeTableUpdate.Form_Funds();
            DataUpdate.Form_Funds frm_Funds = new DataUpdate.Form_Funds();
            frm_Funds.Show();
           
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddMaterial.Form_AddInfo().Show();
            //this.Visible = false;
        }

        private void 出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OutStock.Form_Out().Show();
           // this.Visible = false;
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void 普通查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoSearch.Form_Search_Simple().Show();
            //this.Visible = false;
        }

        private void 高级查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoSearch.Form_Search().Show();
            //this.Visible = false;
        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new User.Form_CodeChange().Show();
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new User.Form_UserChange().Show();
        }

        private void 系统管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (Form_Login.Authority == "0")
            {
                材料管理ToolStripMenuItem.Enabled = false;
                表单整理ToolStripMenuItem.Enabled = false;
            }
            //只有管理员可以增删用户和管理用户权限
            if (Form_Login.Authority != "2")
            {
                用户管理ToolStripMenuItem.Visible = false;
            }
            //检查单号日期
  
            string outDate = DateTime.Today.ToString("yyyyMMdd");
            //获取出库单号
            string str_OutIdPath = Application.StartupPath + "/OutId.xml";
            XmlDocument outDoc = new XmlDocument();
            outDoc.Load(str_OutIdPath);
            XmlNode xnRoot = outDoc.SelectSingleNode("Out");
            XmlNodeList oList = xnRoot.ChildNodes;
            XmlNode xnId = oList[0];
            XmlNode xnDate = oList[1];
            string outId = xnDate.InnerText;
            if (outId!=outDate)
            {
                xnDate.InnerText = outDate;
                xnId.InnerText = "100";
                outDoc.Save(str_OutIdPath);//保存
            }
            
        }



        
    }
}
