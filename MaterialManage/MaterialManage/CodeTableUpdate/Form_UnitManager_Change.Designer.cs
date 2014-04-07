namespace MaterialManage.CodeTableUpdate
{
    partial class Form_UnitManager_Change
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
            this.textBox_mname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_mname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_mname
            // 
            this.textBox_mname.Location = new System.Drawing.Point(283, 71);
            this.textBox_mname.Name = "textBox_mname";
            this.textBox_mname.Size = new System.Drawing.Size(100, 21);
            this.textBox_mname.TabIndex = 34;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(99, 71);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 33;
            // 
            // label_mname
            // 
            this.label_mname.AutoSize = true;
            this.label_mname.Location = new System.Drawing.Point(224, 74);
            this.label_mname.Name = "label_mname";
            this.label_mname.Size = new System.Drawing.Size(53, 12);
            this.label_mname.TabIndex = 32;
            this.label_mname.Text = "主管姓名";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(34, 74);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(53, 12);
            this.label_name.TabIndex = 31;
            this.label_name.Text = "单位名称";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(251, 188);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 43;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(146, 188);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 42;
            this.button_change.Text = "修改";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // Form_UnitManager_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 262);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.textBox_mname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_mname);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form_UnitManager_Change";
            this.Text = "信息修改";
            this.Load += new System.EventHandler(this.Form_UnitManager_Change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_mname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_mname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_change;
    }
}