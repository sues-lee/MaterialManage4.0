namespace MaterialManage
{
    partial class Form_Main1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("出库");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("入库");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("材料管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("普通查询");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("高级查询");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("密码更改");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("用户管理");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("系统管理", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("材料管理");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("采购人管理");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("领料人管理");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("单位信息管理");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("材料种类管理");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("经费分类管理");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("表单管理", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("计算器");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("附加应用", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("退出系统");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("退出", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.材料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表单整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材料表整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购人整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.领料人整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单位主管整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材料种类整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.经费分类整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 458);
            this.panel2.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.Color.Blue;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Out";
            treeNode1.Text = "出库";
            treeNode2.Name = "In";
            treeNode2.Text = "入库";
            treeNode3.Name = "节点0";
            treeNode3.Text = "材料管理";
            treeNode4.Name = "SearchSimple";
            treeNode4.Text = "普通查询";
            treeNode5.Name = "Search";
            treeNode5.Text = "高级查询";
            treeNode6.Name = "节点1";
            treeNode6.Text = "信息管理";
            treeNode7.Name = "CodeChange";
            treeNode7.Text = "密码更改";
            treeNode8.Name = "UserChange";
            treeNode8.Text = "用户管理";
            treeNode9.Name = "节点2";
            treeNode9.Text = "系统管理";
            treeNode10.Name = "Material";
            treeNode10.Text = "材料管理";
            treeNode11.Name = "Buy";
            treeNode11.Text = "采购人管理";
            treeNode12.Name = "Operator";
            treeNode12.Text = "领料人管理";
            treeNode13.Name = "Unit";
            treeNode13.Text = "单位信息管理";
            treeNode14.Name = "Classify";
            treeNode14.Text = "材料种类管理";
            treeNode15.Name = "Funds";
            treeNode15.Text = "经费分类管理";
            treeNode16.Name = "节点3";
            treeNode16.Text = "表单管理";
            treeNode17.Name = "Calculator";
            treeNode17.Text = "计算器";
            treeNode18.Name = "节点4";
            treeNode18.Text = "附加应用";
            treeNode19.Name = "Exit";
            treeNode19.Text = "退出系统";
            treeNode20.Name = "节点5";
            treeNode20.Text = "退出";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode16,
            treeNode18,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(147, 458);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(101, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.menuStrip_Main);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 49);
            this.panel3.TabIndex = 3;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.材料管理ToolStripMenuItem,
            this.信息查询ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.表单整理ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(850, 25);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "主窗体菜单";
            // 
            // 材料管理ToolStripMenuItem
            // 
            this.材料管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库ToolStripMenuItem,
            this.出库ToolStripMenuItem});
            this.材料管理ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.材料管理ToolStripMenuItem.Name = "材料管理ToolStripMenuItem";
            this.材料管理ToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.材料管理ToolStripMenuItem.Text = "材料管理";
            // 
            // 入库ToolStripMenuItem
            // 
            this.入库ToolStripMenuItem.Name = "入库ToolStripMenuItem";
            this.入库ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.入库ToolStripMenuItem.Text = "入库";
            this.入库ToolStripMenuItem.Click += new System.EventHandler(this.入库ToolStripMenuItem_Click);
            // 
            // 出库ToolStripMenuItem
            // 
            this.出库ToolStripMenuItem.Name = "出库ToolStripMenuItem";
            this.出库ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.出库ToolStripMenuItem.Text = "出库";
            this.出库ToolStripMenuItem.Click += new System.EventHandler(this.出库ToolStripMenuItem_Click);
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通查询ToolStripMenuItem,
            this.高级查询ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.信息查询ToolStripMenuItem.Text = "信息查询";
            // 
            // 普通查询ToolStripMenuItem
            // 
            this.普通查询ToolStripMenuItem.Name = "普通查询ToolStripMenuItem";
            this.普通查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.普通查询ToolStripMenuItem.Text = "普通查询";
            this.普通查询ToolStripMenuItem.Click += new System.EventHandler(this.普通查询ToolStripMenuItem_Click);
            // 
            // 高级查询ToolStripMenuItem
            // 
            this.高级查询ToolStripMenuItem.Name = "高级查询ToolStripMenuItem";
            this.高级查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.高级查询ToolStripMenuItem.Text = "高级查询";
            this.高级查询ToolStripMenuItem.Click += new System.EventHandler(this.高级查询ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem1,
            this.用户管理ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 用户管理ToolStripMenuItem1
            // 
            this.用户管理ToolStripMenuItem1.Name = "用户管理ToolStripMenuItem1";
            this.用户管理ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.用户管理ToolStripMenuItem1.Text = "密码更改";
            this.用户管理ToolStripMenuItem1.Click += new System.EventHandler(this.用户管理ToolStripMenuItem1_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 表单整理ToolStripMenuItem
            // 
            this.表单整理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.材料表整理ToolStripMenuItem,
            this.采购人整理ToolStripMenuItem,
            this.领料人整理ToolStripMenuItem,
            this.单位主管整理ToolStripMenuItem,
            this.材料种类整理ToolStripMenuItem,
            this.经费分类整理ToolStripMenuItem});
            this.表单整理ToolStripMenuItem.Name = "表单整理ToolStripMenuItem";
            this.表单整理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.表单整理ToolStripMenuItem.Text = "表单管理";
            // 
            // 材料表整理ToolStripMenuItem
            // 
            this.材料表整理ToolStripMenuItem.Name = "材料表整理ToolStripMenuItem";
            this.材料表整理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.材料表整理ToolStripMenuItem.Text = "材料管理";
            this.材料表整理ToolStripMenuItem.Click += new System.EventHandler(this.材料表整理ToolStripMenuItem_Click);
            // 
            // 采购人整理ToolStripMenuItem
            // 
            this.采购人整理ToolStripMenuItem.Name = "采购人整理ToolStripMenuItem";
            this.采购人整理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.采购人整理ToolStripMenuItem.Text = "采购人管理";
            this.采购人整理ToolStripMenuItem.Click += new System.EventHandler(this.采购人整理ToolStripMenuItem_Click);
            // 
            // 领料人整理ToolStripMenuItem
            // 
            this.领料人整理ToolStripMenuItem.Name = "领料人整理ToolStripMenuItem";
            this.领料人整理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.领料人整理ToolStripMenuItem.Text = "领料人管理";
            this.领料人整理ToolStripMenuItem.Click += new System.EventHandler(this.领料人整理ToolStripMenuItem_Click);
            // 
            // 单位主管整理ToolStripMenuItem
            // 
            this.单位主管整理ToolStripMenuItem.Name = "单位主管整理ToolStripMenuItem";
            this.单位主管整理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.单位主管整理ToolStripMenuItem.Text = "单位信息整理";
            this.单位主管整理ToolStripMenuItem.Click += new System.EventHandler(this.单位主管整理ToolStripMenuItem_Click);
            // 
            // 材料种类整理ToolStripMenuItem
            // 
            this.材料种类整理ToolStripMenuItem.Name = "材料种类整理ToolStripMenuItem";
            this.材料种类整理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.材料种类整理ToolStripMenuItem.Text = "材料种类管理";
            this.材料种类整理ToolStripMenuItem.Click += new System.EventHandler(this.材料种类整理ToolStripMenuItem_Click);
            // 
            // 经费分类整理ToolStripMenuItem
            // 
            this.经费分类整理ToolStripMenuItem.Name = "经费分类整理ToolStripMenuItem";
            this.经费分类整理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.经费分类整理ToolStripMenuItem.Text = "经费分类管理";
            this.经费分类整理ToolStripMenuItem.Click += new System.EventHandler(this.经费分类整理ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算器ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "附加应用";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.计算器ToolStripMenuItem.Text = "计算器";
            this.计算器ToolStripMenuItem.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出程序ToolStripMenuItem});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(147, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 458);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作区";
            // 
            // Form_Main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form_Main1";
            this.Text = "Form_Main1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 材料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表单整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料表整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购人整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 领料人整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单位主管整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料种类整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 经费分类整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}