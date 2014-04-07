namespace MaterialManage.OutStock
{
    partial class Form_Out
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_search2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Out = new System.Windows.Forms.Button();
            this.comboBox_umname = new System.Windows.Forms.ComboBox();
            this.comboBox_oname = new System.Windows.Forms.ComboBox();
            this.textBox_use = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_funds = new System.Windows.Forms.ComboBox();
            this.comboBox_uname = new System.Windows.Forms.ComboBox();
            this.textBox_remark = new System.Windows.Forms.TextBox();
            this.textBox_totalprice = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.textBox_mname = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_search2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_search1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库存查询";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_search2
            // 
            this.textBox_search2.Location = new System.Drawing.Point(344, 20);
            this.textBox_search2.Name = "textBox_search2";
            this.textBox_search2.Size = new System.Drawing.Size(100, 21);
            this.textBox_search2.TabIndex = 10;
            this.textBox_search2.TextChanged += new System.EventHandler(this.textBox_search2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "物品型号:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_search1
            // 
            this.textBox_search1.Location = new System.Drawing.Point(132, 20);
            this.textBox_search1.Name = "textBox_search1";
            this.textBox_search1.Size = new System.Drawing.Size(100, 21);
            this.textBox_search1.TabIndex = 8;
            this.textBox_search1.TextChanged += new System.EventHandler(this.textBox_search1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "物品名称：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_clear);
            this.groupBox2.Controls.Add(this.button_Out);
            this.groupBox2.Controls.Add(this.comboBox_umname);
            this.groupBox2.Controls.Add(this.comboBox_oname);
            this.groupBox2.Controls.Add(this.textBox_use);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.comboBox_funds);
            this.groupBox2.Controls.Add(this.comboBox_uname);
            this.groupBox2.Controls.Add(this.textBox_remark);
            this.groupBox2.Controls.Add(this.textBox_totalprice);
            this.groupBox2.Controls.Add(this.textBox_price);
            this.groupBox2.Controls.Add(this.textBox_type);
            this.groupBox2.Controls.Add(this.textBox_mname);
            this.groupBox2.Controls.Add(this.button_confirm);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 294);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出库信息";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(775, 235);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(90, 23);
            this.button_clear.TabIndex = 22;
            this.button_clear.Text = "清空出库队列";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Out
            // 
            this.button_Out.Location = new System.Drawing.Point(888, 235);
            this.button_Out.Name = "button_Out";
            this.button_Out.Size = new System.Drawing.Size(91, 23);
            this.button_Out.TabIndex = 11;
            this.button_Out.Text = "出库队列";
            this.button_Out.UseVisualStyleBackColor = true;
            this.button_Out.Click += new System.EventHandler(this.button_print_Click);
            // 
            // comboBox_umname
            // 
            this.comboBox_umname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_umname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_umname.FormattingEnabled = true;
            this.comboBox_umname.Location = new System.Drawing.Point(824, 100);
            this.comboBox_umname.Name = "comboBox_umname";
            this.comboBox_umname.Size = new System.Drawing.Size(155, 20);
            this.comboBox_umname.TabIndex = 4;
            this.comboBox_umname.SelectedIndexChanged += new System.EventHandler(this.comboBox_umname_SelectedIndexChanged);
            // 
            // comboBox_oname
            // 
            this.comboBox_oname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_oname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_oname.FormattingEnabled = true;
            this.comboBox_oname.Location = new System.Drawing.Point(472, 138);
            this.comboBox_oname.Name = "comboBox_oname";
            this.comboBox_oname.Size = new System.Drawing.Size(171, 20);
            this.comboBox_oname.TabIndex = 5;
            this.comboBox_oname.SelectedIndexChanged += new System.EventHandler(this.comboBox_oname_SelectedIndexChanged);
            // 
            // textBox_use
            // 
            this.textBox_use.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_use.Location = new System.Drawing.Point(152, 185);
            this.textBox_use.Name = "textBox_use";
            this.textBox_use.Size = new System.Drawing.Size(137, 21);
            this.textBox_use.TabIndex = 7;
            this.textBox_use.TextChanged += new System.EventHandler(this.textBox_use_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(472, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 21);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(472, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(170, 21);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox_funds
            // 
            this.comboBox_funds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_funds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_funds.FormattingEnabled = true;
            this.comboBox_funds.Location = new System.Drawing.Point(472, 185);
            this.comboBox_funds.Name = "comboBox_funds";
            this.comboBox_funds.Size = new System.Drawing.Size(170, 20);
            this.comboBox_funds.TabIndex = 8;
            this.comboBox_funds.SelectedIndexChanged += new System.EventHandler(this.comboBox_funds_SelectedIndexChanged);
            // 
            // comboBox_uname
            // 
            this.comboBox_uname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_uname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_uname.FormattingEnabled = true;
            this.comboBox_uname.Location = new System.Drawing.Point(824, 52);
            this.comboBox_uname.Name = "comboBox_uname";
            this.comboBox_uname.Size = new System.Drawing.Size(156, 20);
            this.comboBox_uname.TabIndex = 2;
            this.comboBox_uname.SelectedIndexChanged += new System.EventHandler(this.comboBox_uname_SelectedIndexChanged);
            this.comboBox_uname.TextChanged += new System.EventHandler(this.comboBox_uname_TextChanged);
            // 
            // textBox_remark
            // 
            this.textBox_remark.Location = new System.Drawing.Point(824, 185);
            this.textBox_remark.Name = "textBox_remark";
            this.textBox_remark.Size = new System.Drawing.Size(157, 21);
            this.textBox_remark.TabIndex = 9;
            this.textBox_remark.TextChanged += new System.EventHandler(this.textBox_remark_TextChanged);
            // 
            // textBox_totalprice
            // 
            this.textBox_totalprice.Enabled = false;
            this.textBox_totalprice.Location = new System.Drawing.Point(824, 138);
            this.textBox_totalprice.Name = "textBox_totalprice";
            this.textBox_totalprice.Size = new System.Drawing.Size(157, 21);
            this.textBox_totalprice.TabIndex = 6;
            this.textBox_totalprice.TextChanged += new System.EventHandler(this.textBox_totalprice_TextChanged);
            // 
            // textBox_price
            // 
            this.textBox_price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_price.Enabled = false;
            this.textBox_price.Location = new System.Drawing.Point(152, 138);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(137, 21);
            this.textBox_price.TabIndex = 21;
            this.textBox_price.TextChanged += new System.EventHandler(this.textBox_price_TextChanged);
            // 
            // textBox_type
            // 
            this.textBox_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_type.Enabled = false;
            this.textBox_type.Location = new System.Drawing.Point(152, 96);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(137, 21);
            this.textBox_type.TabIndex = 14;
            this.textBox_type.TextChanged += new System.EventHandler(this.textBox_type_TextChanged);
            // 
            // textBox_mname
            // 
            this.textBox_mname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_mname.CausesValidation = false;
            this.textBox_mname.Enabled = false;
            this.textBox_mname.Location = new System.Drawing.Point(152, 52);
            this.textBox_mname.Name = "textBox_mname";
            this.textBox_mname.Size = new System.Drawing.Size(137, 21);
            this.textBox_mname.TabIndex = 12;
            this.textBox_mname.TextChanged += new System.EventHandler(this.textBox_mname_TextChanged);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(652, 235);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(101, 23);
            this.button_confirm.TabIndex = 10;
            this.button_confirm.Text = "加入出库队列";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(751, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "备注：";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(373, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "经费分类：";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "用途（项目）：";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(751, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "总价：";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(730, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "单位主管：";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(731, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "单位名称：";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "领料人：";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "出库数量：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "出库日期：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "物品单价：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "物品型号：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "物品名称：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1, 60);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1013, 380);
            this.dataGridView.TabIndex = 30;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Form_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 740);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Out";
            this.Text = "出库";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Out_FormClosed);
            this.Load += new System.EventHandler(this.Form_Out_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_search1;
        private System.Windows.Forms.TextBox textBox_search2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox_funds;
        private System.Windows.Forms.ComboBox comboBox_uname;
        private System.Windows.Forms.TextBox textBox_remark;
        private System.Windows.Forms.TextBox textBox_totalprice;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.TextBox textBox_mname;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox textBox_use;
        private System.Windows.Forms.ComboBox comboBox_oname;
        private System.Windows.Forms.ComboBox comboBox_umname;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Out;
    }
}