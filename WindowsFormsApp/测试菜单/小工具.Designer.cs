namespace WindowsFormsApp.测试菜单
{
    partial class 小工具
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
            this.myButton1 = new MyButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(13, 13);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(168, 35);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "数据库查询检测";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // 小工具
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myButton1);
            this.Name = "小工具";
            this.Text = "小工具";
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton myButton1;
    }
}