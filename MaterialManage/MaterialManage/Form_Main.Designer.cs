namespace MaterialManage
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
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
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.材料管理ToolStripMenuItem,
            this.信息查询ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.表单整理ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(868, 25);
            this.menuStrip_Main.TabIndex = 0;
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
            this.入库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.入库ToolStripMenuItem.Text = "入库";
            this.入库ToolStripMenuItem.Click += new System.EventHandler(this.入库ToolStripMenuItem_Click);
            // 
            // 出库ToolStripMenuItem
            // 
            this.出库ToolStripMenuItem.Name = "出库ToolStripMenuItem";
            this.出库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.普通查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.普通查询ToolStripMenuItem.Text = "普通查询";
            this.普通查询ToolStripMenuItem.Click += new System.EventHandler(this.普通查询ToolStripMenuItem_Click);
            // 
            // 高级查询ToolStripMenuItem
            // 
            this.高级查询ToolStripMenuItem.Name = "高级查询ToolStripMenuItem";
            this.高级查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.系统管理ToolStripMenuItem.Click += new System.EventHandler(this.系统管理ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem1
            // 
            this.用户管理ToolStripMenuItem1.Name = "用户管理ToolStripMenuItem1";
            this.用户管理ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.用户管理ToolStripMenuItem1.Text = "密码更改";
            this.用户管理ToolStripMenuItem1.Click += new System.EventHandler(this.用户管理ToolStripMenuItem1_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.材料表整理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.材料表整理ToolStripMenuItem.Text = "材料管理";
            this.材料表整理ToolStripMenuItem.Click += new System.EventHandler(this.材料表整理ToolStripMenuItem_Click);
            // 
            // 采购人整理ToolStripMenuItem
            // 
            this.采购人整理ToolStripMenuItem.Name = "采购人整理ToolStripMenuItem";
            this.采购人整理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.采购人整理ToolStripMenuItem.Text = "采购人管理";
            this.采购人整理ToolStripMenuItem.Click += new System.EventHandler(this.采购人整理ToolStripMenuItem_Click);
            // 
            // 领料人整理ToolStripMenuItem
            // 
            this.领料人整理ToolStripMenuItem.Name = "领料人整理ToolStripMenuItem";
            this.领料人整理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.领料人整理ToolStripMenuItem.Text = "领料人管理";
            this.领料人整理ToolStripMenuItem.Click += new System.EventHandler(this.领料人整理ToolStripMenuItem_Click);
            // 
            // 单位主管整理ToolStripMenuItem
            // 
            this.单位主管整理ToolStripMenuItem.Name = "单位主管整理ToolStripMenuItem";
            this.单位主管整理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.单位主管整理ToolStripMenuItem.Text = "单位信息整理";
            this.单位主管整理ToolStripMenuItem.Click += new System.EventHandler(this.单位主管整理ToolStripMenuItem_Click);
            // 
            // 材料种类整理ToolStripMenuItem
            // 
            this.材料种类整理ToolStripMenuItem.Name = "材料种类整理ToolStripMenuItem";
            this.材料种类整理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.材料种类整理ToolStripMenuItem.Text = "材料种类管理";
            this.材料种类整理ToolStripMenuItem.Click += new System.EventHandler(this.材料种类整理ToolStripMenuItem_Click);
            // 
            // 经费分类整理ToolStripMenuItem
            // 
            this.经费分类整理ToolStripMenuItem.Name = "经费分类整理ToolStripMenuItem";
            this.经费分类整理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.计算器ToolStripMenuItem.Text = "计算器";
            this.计算器ToolStripMenuItem.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Checked = true;
            this.退出ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出程序ToolStripMenuItem});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(868, 474);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form_Main";
            this.Text = "材料管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 材料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 表单整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料表整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购人整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 领料人整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单位主管整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料种类整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 经费分类整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
    }
}

