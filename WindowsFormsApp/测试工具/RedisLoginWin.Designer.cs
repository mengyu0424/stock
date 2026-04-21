namespace WindowsFormsApp.测试工具
{
    partial class RedisLoginWin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myButton1 = new MyButton();
            this.myLabel1 = new MyLabel();
            this.myLabel2 = new MyLabel();
            this.txtCode = new MyTextBox();
            this.txtIP = new MyTextBox();
            this.btn_query = new MyButton();
            this.dgvList = new MyDataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myLabel3 = new MyLabel();
            this.txt_time = new MyTextBox();
            this.M = new MyLabel();
            this.myButton2 = new MyButton();
            this.myLabel4 = new MyLabel();
            this.txt_url = new MyTextBox();
            this.myButton3 = new MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton1.Enabled = false;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(404, 67);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(131, 23);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "登录测试";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(104, 69);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(58, 21);
            this.myLabel1.TabIndex = 1;
            this.myLabel1.Text = "账号：";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel2.Location = new System.Drawing.Point(121, 103);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(41, 21);
            this.myLabel2.TabIndex = 2;
            this.myLabel2.Text = "IP：";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCode.Location = new System.Drawing.Point(168, 69);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(186, 22);
            this.txtCode.TabIndex = 3;
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtIP.Location = new System.Drawing.Point(168, 103);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(186, 22);
            this.txtIP.TabIndex = 4;
            // 
            // btn_query
            // 
            this.btn_query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_query.Enabled = false;
            this.btn_query.FlatAppearance.BorderSize = 0;
            this.btn_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_query.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_query.ForeColor = System.Drawing.Color.White;
            this.btn_query.Location = new System.Drawing.Point(404, 135);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(131, 23);
            this.btn_query.TabIndex = 6;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.IP});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvList.Location = new System.Drawing.Point(41, 185);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 32;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(648, 214);
            this.dgvList.TabIndex = 7;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "CODE";
            this.CODE.FillWeight = 50.76142F;
            this.CODE.HeaderText = "账号";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.FillWeight = 149.2386F;
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel3.Location = new System.Drawing.Point(104, 137);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(58, 21);
            this.myLabel3.TabIndex = 9;
            this.myLabel3.Text = "时间：";
            // 
            // txt_time
            // 
            this.txt_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_time.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_time.Location = new System.Drawing.Point(168, 137);
            this.txt_time.Name = "txt_time";
            this.txt_time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_time.Size = new System.Drawing.Size(138, 22);
            this.txt_time.TabIndex = 10;
            this.txt_time.Text = "1";
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.M.Location = new System.Drawing.Point(312, 137);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(42, 21);
            this.M.TabIndex = 11;
            this.M.Text = "分钟";
            // 
            // myButton2
            // 
            this.myButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton2.Enabled = false;
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(404, 101);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(131, 23);
            this.myButton2.TabIndex = 12;
            this.myButton2.Text = "登录维持测试";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel4.Location = new System.Drawing.Point(32, 12);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(130, 21);
            this.myLabel4.TabIndex = 13;
            this.myLabel4.Text = "配置Redis地址：";
            // 
            // txt_url
            // 
            this.txt_url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_url.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_url.Location = new System.Drawing.Point(168, 12);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(424, 22);
            this.txt_url.TabIndex = 14;
            this.txt_url.Text = "192.168.56.101;6379;Root1234";
            // 
            // myButton3
            // 
            this.myButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton3.FlatAppearance.BorderSize = 0;
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myButton3.ForeColor = System.Drawing.Color.White;
            this.myButton3.Location = new System.Drawing.Point(598, 10);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(75, 23);
            this.myButton3.TabIndex = 15;
            this.myButton3.Text = "连接";
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // RedisLoginWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.M);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.myButton1);
            this.Name = "RedisLoginWin";
            this.Text = "RedisLoginWin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton myButton1;
        private MyLabel myLabel1;
        private MyLabel myLabel2;
        private MyTextBox txtCode;
        private MyTextBox txtIP;
        private MyButton btn_query;
        private MyDataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private MyLabel myLabel3;
        private MyTextBox txt_time;
        private MyLabel M;
        private MyButton myButton2;
        private MyLabel myLabel4;
        private MyTextBox txt_url;
        private MyButton myButton3;
    }
}