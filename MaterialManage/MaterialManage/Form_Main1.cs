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
    public partial class Form_Main1 : Form
    {
        public Form_Main1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form temp = new Form();
            //temp.TopLevel = false;
            //temp.Parent = this.panel4;
            //temp.Show();
            Form frm_Add = new AddMaterial.Form_AddInfo();
            showForm(frm_Add);
        }

        private void showForm(Form frm)
        { 
            frm.TopLevel = false;
            frm.Parent = this.groupBox1;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_Out = new OutStock.Form_Out();
            showForm(frm_Out);
        }

        private void 普通查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_SearchSimple = new InfoSearch.Form_Search_Simple();
            showForm(frm_SearchSimple);
        }

        private void 高级查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_Search = new InfoSearch.Form_Search();
            showForm(frm_Search);
        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm_CodeChange = new User.Form_CodeChange();
            showForm(frm_CodeChange);
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_UserChange = new User.Form_UserChange();
            showForm(frm_UserChange);
        }

        private void 材料表整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DataUpdate.Form_Material();
            showForm(frm);
        }

        private void 采购人整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DataUpdate.Form_Buy();
            showForm(frm);
        }

        private void 领料人整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DataUpdate.Form_Operator();
            showForm(frm);
        }

        private void 单位主管整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DataUpdate.Form_UnitManager();
            showForm(frm);
        }

        private void 材料种类整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DataUpdate.Form_Classify();
            showForm(frm);
        }

        private void 经费分类整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DataUpdate.Form_Funds();
            showForm(frm);
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Main1_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            if (Form_Login.Authority == "0")
            {
                材料管理ToolStripMenuItem.Enabled = false;
                表单整理ToolStripMenuItem.Enabled = false;
                
            }
            //只有管理员可以增删用户和管理用户权限
            if (Form_Login.Authority != "2")
            {
                用户管理ToolStripMenuItem.Visible = false;
                treeView1.Nodes[1].Checked = false;
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
            if (outId != outDate)
            {
                xnDate.InnerText = outDate;
                xnId.InnerText = "100";
                outDoc.Save(str_OutIdPath);//保存
            }
        }



        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            TreeNode tn = treeView1.GetNodeAt(new Point(e.X, e.Y));
            if (tn != null)
            {
                //此处表示点击到TreeNode节点了。
                switch (tn.Name)
                {
                    case "Out":
                        {
                            Form frm = new OutStock.Form_Out();
                            showForm(frm);
                        } break;
                    case "In":
                         Form frm_Add = new AddMaterial.Form_AddInfo();
                         showForm(frm_Add);break;
                    case"SearchSimple":
                        {Form frm = new InfoSearch.Form_Search_Simple();
                        showForm(frm);}break;
                    case "Search":
                        {
                            Form frm = new InfoSearch.Form_Search();
                            showForm(frm);
                        } break;
                    case "CodeChange":
                        {
                            Form frm = new User.Form_CodeChange();
                            showForm(frm);
                        } break;
                    case "UserChange":
                        {
                            Form frm = new User.Form_UserChange();
                            showForm(frm);
                        } break;
                    case "Material":
                        {
                            Form frm = new DataUpdate.Form_Material();
                            showForm(frm);
                        } break;
                    case "Classify":
                        {
                            Form frm = new DataUpdate.Form_Classify();
                            showForm(frm);
                        } break;
                    case "Buy":
                        {
                            Form frm = new DataUpdate.Form_Buy();
                            showForm(frm);
                        } break;
                    case "Funds":
                        {
                            Form frm = new DataUpdate.Form_Funds();
                            showForm(frm);
                        } break;
                    case "Unit":
                        {
                            Form frm = new DataUpdate.Form_UnitManager();
                            showForm(frm);
                        } break;
                    case "Operator":
                        {
                            Form frm = new DataUpdate.Form_Operator();
                            showForm(frm);
                        } break;
                    case "Calculator":
                        {
                            System.Diagnostics.Process.Start("calc.exe");
                        } break;
                    case "Exit":
                        {
                            Application.Exit();
                        } break;

                }
            }
            else
            {
                //表示此处点击在TreeView1控件的空白区域
                //可以在此处添加弹出菜单的方法
            }
        }     
    }
}
