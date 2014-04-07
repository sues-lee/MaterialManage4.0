namespace MaterialManage.AddMaterial
{
    partial class Form_AddM
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
            this.button_C = new System.Windows.Forms.Button();
            this.button_S = new System.Windows.Forms.Button();
            this.textBox_U = new System.Windows.Forms.TextBox();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_MT = new System.Windows.Forms.TextBox();
            this.textBox_MN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_C);
            this.groupBox1.Controls.Add(this.button_S);
            this.groupBox1.Controls.Add(this.textBox_U);
            this.groupBox1.Controls.Add(this.textBox_P);
            this.groupBox1.Controls.Add(this.textBox_MT);
            this.groupBox1.Controls.Add(this.textBox_MN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(296, 253);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(75, 23);
            this.button_C.TabIndex = 5;
            this.button_C.Text = "取消";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_S
            // 
            this.button_S.Location = new System.Drawing.Point(119, 253);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(75, 23);
            this.button_S.TabIndex = 4;
            this.button_S.Text = "确定";
            this.button_S.UseVisualStyleBackColor = true;
            this.button_S.Click += new System.EventHandler(this.button_S_Click);
            // 
            // textBox_U
            // 
            this.textBox_U.Location = new System.Drawing.Point(365, 152);
            this.textBox_U.Name = "textBox_U";
            this.textBox_U.Size = new System.Drawing.Size(100, 21);
            this.textBox_U.TabIndex = 3;
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(119, 155);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 21);
            this.textBox_P.TabIndex = 2;
            this.textBox_P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_P_KeyPress);
            // 
            // textBox_MT
            // 
            this.textBox_MT.Location = new System.Drawing.Point(365, 44);
            this.textBox_MT.Name = "textBox_MT";
            this.textBox_MT.Size = new System.Drawing.Size(100, 21);
            this.textBox_MT.TabIndex = 1;
            // 
            // textBox_MN
            // 
            this.textBox_MN.Location = new System.Drawing.Point(119, 45);
            this.textBox_MN.Name = "textBox_MN";
            this.textBox_MN.Size = new System.Drawing.Size(100, 21);
            this.textBox_MN.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "物品单位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "物品型号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "物品单价：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "物品名称：";
            // 
            // Form_AddM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 339);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_AddM";
            this.Text = "添加新物品";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AddM_FormClosed);
            this.Load += new System.EventHandler(this.Form_AddM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_U;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_MT;
        private System.Windows.Forms.TextBox textBox_MN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_S;
    }
}