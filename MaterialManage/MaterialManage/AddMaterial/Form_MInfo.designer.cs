namespace MaterialManage.AddMaterial
{
    partial class Form_AddInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_In = new System.Windows.Forms.Button();
            this.textBox_MType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Mname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Bname = new System.Windows.Forms.ComboBox();
            this.numericUpDown_num = new System.Windows.Forms.NumericUpDown();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_unit = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_cancle = new System.Windows.Forms.Button();
            this.button_sure = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_num)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "材料代码表";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(643, 19);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(76, 23);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "添加新材料";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 226);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_In
            // 
            this.button_In.Location = new System.Drawing.Point(535, 19);
            this.button_In.Name = "button_In";
            this.button_In.Size = new System.Drawing.Size(75, 23);
            this.button_In.TabIndex = 2;
            this.button_In.Text = "入库";
            this.button_In.UseVisualStyleBackColor = true;
            this.button_In.Click += new System.EventHandler(this.button_In_Click);
            // 
            // textBox_MType
            // 
            this.textBox_MType.Location = new System.Drawing.Point(297, 20);
            this.textBox_MType.Name = "textBox_MType";
            this.textBox_MType.Size = new System.Drawing.Size(100, 21);
            this.textBox_MType.TabIndex = 1;
            this.textBox_MType.TextChanged += new System.EventHandler(this.textBox_MType_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "物品型号：";
            // 
            // textBox_Mname
            // 
            this.textBox_Mname.Location = new System.Drawing.Point(99, 20);
            this.textBox_Mname.Name = "textBox_Mname";
            this.textBox_Mname.Size = new System.Drawing.Size(100, 21);
            this.textBox_Mname.TabIndex = 0;
            this.textBox_Mname.TextChanged += new System.EventHandler(this.textBox_Mname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "物品名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker_date);
            this.groupBox2.Controls.Add(this.comboBox_Bname);
            this.groupBox2.Controls.Add(this.numericUpDown_num);
            this.groupBox2.Controls.Add(this.comboBox_class);
            this.groupBox2.Controls.Add(this.textBox_price);
            this.groupBox2.Controls.Add(this.textBox_unit);
            this.groupBox2.Controls.Add(this.textBox_type);
            this.groupBox2.Controls.Add(this.textBox_name);
            this.groupBox2.Controls.Add(this.button_cancle);
            this.groupBox2.Controls.Add(this.button_sure);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1008, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "入库信息表";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker_date.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(741, 89);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(114, 21);
            this.dateTimePicker_date.TabIndex = 7;
            // 
            // comboBox_Bname
            // 
            this.comboBox_Bname.AllowDrop = true;
            this.comboBox_Bname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Bname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Bname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Bname.FormattingEnabled = true;
            this.comboBox_Bname.Location = new System.Drawing.Point(552, 91);
            this.comboBox_Bname.Name = "comboBox_Bname";
            this.comboBox_Bname.Size = new System.Drawing.Size(107, 20);
            this.comboBox_Bname.TabIndex = 6;
            this.comboBox_Bname.TextChanged += new System.EventHandler(this.comboBox_Bname_TextChanged);
            // 
            // numericUpDown_num
            // 
            this.numericUpDown_num.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_num.Location = new System.Drawing.Point(375, 91);
            this.numericUpDown_num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_num.Name = "numericUpDown_num";
            this.numericUpDown_num.Size = new System.Drawing.Size(97, 21);
            this.numericUpDown_num.TabIndex = 5;
            this.numericUpDown_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_class
            // 
            this.comboBox_class.AllowDrop = true;
            this.comboBox_class.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_class.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_class.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(177, 92);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(121, 20);
            this.comboBox_class.TabIndex = 4;
            // 
            // textBox_price
            // 
            this.textBox_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_price.Location = new System.Drawing.Point(552, 44);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(107, 21);
            this.textBox_price.TabIndex = 2;
            // 
            // textBox_unit
            // 
            this.textBox_unit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_unit.Location = new System.Drawing.Point(741, 41);
            this.textBox_unit.Name = "textBox_unit";
            this.textBox_unit.ReadOnly = true;
            this.textBox_unit.Size = new System.Drawing.Size(114, 21);
            this.textBox_unit.TabIndex = 3;
            // 
            // textBox_type
            // 
            this.textBox_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_type.Location = new System.Drawing.Point(375, 41);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.ReadOnly = true;
            this.textBox_type.Size = new System.Drawing.Size(97, 21);
            this.textBox_type.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_name.Location = new System.Drawing.Point(174, 41);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(121, 21);
            this.textBox_name.TabIndex = 0;
            // 
            // button_cancle
            // 
            this.button_cancle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_cancle.Location = new System.Drawing.Point(503, 143);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(60, 23);
            this.button_cancle.TabIndex = 9;
            this.button_cancle.Text = "取消";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // button_sure
            // 
            this.button_sure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_sure.Location = new System.Drawing.Point(368, 143);
            this.button_sure.Name = "button_sure";
            this.button_sure.Size = new System.Drawing.Size(60, 23);
            this.button_sure.TabIndex = 8;
            this.button_sure.Text = "确定";
            this.button_sure.UseVisualStyleBackColor = true;
            this.button_sure.Click += new System.EventHandler(this.button_sure_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(490, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "采购人：";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(674, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "入库时间：";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "物品单价：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "入库数量：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "物品型号：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "物品分类：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "物品名称：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "物品单位：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_MType);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_In);
            this.panel1.Controls.Add(this.textBox_Mname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 63);
            this.panel1.TabIndex = 7;
            // 
            // Form_AddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_AddInfo";
            this.Text = "入库表";
            this.Activated += new System.EventHandler(this.Form_AddInfo_Activated);
            this.Load += new System.EventHandler(this.Form_Add_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_num)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_In;
        private System.Windows.Forms.TextBox textBox_MType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Mname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.ComboBox comboBox_Bname;
        private System.Windows.Forms.NumericUpDown numericUpDown_num;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_unit;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Button button_sure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Panel panel1;
    }
}

