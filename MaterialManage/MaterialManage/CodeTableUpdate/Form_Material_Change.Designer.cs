namespace MaterialManage.CodeTableUpdate
{
    partial class Form_Material_Change
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
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.textBox_unit = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label_unit = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(290, 169);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 41;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(185, 169);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 40;
            this.button_change.Text = "修改";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // textBox_unit
            // 
            this.textBox_unit.Location = new System.Drawing.Point(265, 96);
            this.textBox_unit.Name = "textBox_unit";
            this.textBox_unit.Size = new System.Drawing.Size(100, 21);
            this.textBox_unit.TabIndex = 39;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(265, 58);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 21);
            this.textBox_price.TabIndex = 38;
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_price_KeyPress);
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(63, 96);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(100, 21);
            this.textBox_type.TabIndex = 37;
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Location = new System.Drawing.Point(218, 100);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(29, 12);
            this.label_unit.TabIndex = 36;
            this.label_unit.Text = "单位";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(218, 62);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(29, 12);
            this.label_price.TabIndex = 35;
            this.label_price.Text = "单价";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(16, 100);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(29, 12);
            this.label_type.TabIndex = 34;
            this.label_type.Text = "型号";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(16, 62);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 33;
            this.label_name.Text = "名称";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(63, 58);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 32;
            // 
            // Form_Material_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 227);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.textBox_unit);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form_Material_Change";
            this.Text = "材料修改";
            this.Load += new System.EventHandler(this.Form_Material_Change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.TextBox textBox_unit;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
    }
}