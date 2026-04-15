namespace WindowsFormsApp.测试工具
{
    partial class MessageWin
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
            this.timeNumber = new System.Windows.Forms.TextBox();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new MyLabel();
            this.myButton2 = new MyButton();
            this.flagPanel = new MyPanel();
            this.myButton1 = new MyButton();
            this.myLabel2 = new MyLabel();
            this.myLabel1 = new MyLabel();
            this.SuspendLayout();
            // 
            // timeNumber
            // 
            this.timeNumber.Location = new System.Drawing.Point(108, 9);
            this.timeNumber.Name = "timeNumber";
            this.timeNumber.Size = new System.Drawing.Size(433, 23);
            this.timeNumber.TabIndex = 8;
            this.timeNumber.Text = "5";
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(108, 56);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(433, 23);
            this.txtSql.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "sql语句使用分号分隔；停止灰的，开始绿色，出现数据红色，报错黑色，sql语句请使用count(1)查询";
            // 
            // txtnum
            // 
            this.txtnum.AutoSize = true;
            this.txtnum.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtnum.Location = new System.Drawing.Point(45, 143);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(17, 21);
            this.txtnum.TabIndex = 10;
            this.txtnum.Text = "-";
            // 
            // myButton2
            // 
            this.myButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(466, 141);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(75, 23);
            this.myButton2.TabIndex = 7;
            this.myButton2.Text = "停止";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // flagPanel
            // 
            this.flagPanel.BackColor = System.Drawing.Color.LightGray;
            this.flagPanel.Location = new System.Drawing.Point(38, 170);
            this.flagPanel.Name = "flagPanel";
            this.flagPanel.Size = new System.Drawing.Size(503, 252);
            this.flagPanel.TabIndex = 6;
            // 
            // myButton1
            // 
            this.myButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(385, 140);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(75, 23);
            this.myButton1.TabIndex = 5;
            this.myButton1.Text = "开始";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel2.Location = new System.Drawing.Point(14, 52);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(88, 21);
            this.myLabel2.TabIndex = 3;
            this.myLabel2.Text = "SQL语句：";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(28, 9);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(74, 21);
            this.myLabel1.TabIndex = 1;
            this.myLabel1.Text = "延迟秒：";
            // 
            // MessageWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.timeNumber);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.flagPanel);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel1);
            this.Name = "MessageWin";
            this.Text = "MessageWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyLabel myLabel1;
        private MyLabel myLabel2;
        private MyButton myButton1;
        private MyPanel flagPanel;
        private MyButton myButton2;
        private System.Windows.Forms.TextBox timeNumber;
        private System.Windows.Forms.TextBox txtSql;
        private MyLabel txtnum;
        private System.Windows.Forms.Label label1;
    }
}