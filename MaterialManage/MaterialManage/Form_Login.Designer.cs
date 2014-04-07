namespace MaterialManage
{
    partial class Form_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UseName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_CanCle = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(102, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(117, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码：";
            // 
            // textBox_UseName
            // 
            this.textBox_UseName.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_UseName.Location = new System.Drawing.Point(212, 108);
            this.textBox_UseName.Name = "textBox_UseName";
            this.textBox_UseName.Size = new System.Drawing.Size(128, 21);
            this.textBox_UseName.TabIndex = 8;
            this.textBox_UseName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_UseName_KeyUp);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(212, 149);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(128, 21);
            this.textBox_Password.TabIndex = 9;
            this.textBox_Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Password_KeyUp);
            // 
            // button_CanCle
            // 
            this.button_CanCle.Location = new System.Drawing.Point(258, 224);
            this.button_CanCle.Name = "button_CanCle";
            this.button_CanCle.Size = new System.Drawing.Size(64, 27);
            this.button_CanCle.TabIndex = 13;
            this.button_CanCle.Text = "取消";
            this.button_CanCle.UseVisualStyleBackColor = true;
            this.button_CanCle.Click += new System.EventHandler(this.button_CanCle_Click);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(139, 224);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(67, 27);
            this.button_Login.TabIndex = 12;
            this.button_Login.Text = "确定";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(160, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "用户登录";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_CanCle);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_UseName);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存管理系统---登录窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UseName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_CanCle;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label3;



    }
}