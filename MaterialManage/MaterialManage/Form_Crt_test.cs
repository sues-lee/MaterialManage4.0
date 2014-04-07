using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Xml;
namespace MaterialManage
{
    public partial class Form_Crt_test : Form
    {
        public Form_Crt_test()
        {
            InitializeComponent();
            flag = 0;

        }
        public Form_Crt_test(List<string> L_info,string str_path1)
        {
            InitializeComponent();
            this.l_info = L_info;
            str_Path = str_path1;
            flag = 1;

        }

        ReportDocument myReport = new ReportDocument();
        int flag = 0;
        string str_Path;

        public string Str_Path
        {
            get { return str_Path; }
            set { str_Path = value; }
        }
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        List<string> l_Fname = new List<string>();
        List<string> l_info = new List<string>();
        public List<string> L_Fname
        {
            get { return l_Fname; }
            set { l_Fname = value; }
        }
        private void Form_Crt_test_Load(object sender, EventArgs e)
        {
            if (flag==0)
            {
                myReport.Load(str_Path);
                string str = L_Fname[0].ToString();
                for (int i = 0; i < L_Fname.Count; i++)     //设置字段中文名
                {
                    myReport.DataDefinition.FormulaFields["F" + (i + 1).ToString()].Text = "'" + l_Fname[i] + "'";
                }
                myReport.SetDataSource(Dt);
                crystalReportViewer1.ReportSource = myReport;
                crystalReportViewer1.RefreshReport();
             
            }
            if (flag==1)//出库单报表
            {
                myReport.Load(str_Path);
                //设置公式字段，用来显示表头信息
                myReport.DataDefinition.FormulaFields["UName"].Text = "'" + l_info[0] + "'";
                myReport.DataDefinition.FormulaFields["OSDate"].Text = "'" + l_info[1] + "'";
                myReport.DataDefinition.FormulaFields["OName"].Text = "'" + l_info[2] + "'";
                myReport.DataDefinition.FormulaFields["UMName"].Text = "'" + l_info[3] + "'";
                myReport.DataDefinition.FormulaFields["OSUse"].Text = "'" + l_info[4] + "'";
                myReport.DataDefinition.FormulaFields["OutId"].Text = "'" + l_info[5] + "'";
                myReport.SetDataSource(Ds);
                crystalReportViewer1.ReportSource = myReport;
                crystalReportViewer1.RefreshReport();

            }
        
          
           
        }
        //窗体关闭时关闭水晶报表
        private void Form_Crt_test_FormClosed(object sender, FormClosedEventArgs e)
        {
            myReport.Dispose();
            
        }
    }
}
