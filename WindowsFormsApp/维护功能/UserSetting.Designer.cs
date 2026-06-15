namespace WindowsFormsApp.维护功能
{
    partial class UserSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myLabel1 = new MyLabel();
            this.txtCode = new MyTextBox();
            this.myLabel2 = new MyLabel();
            this.txtName = new MyTextBox();
            this.myLabel3 = new MyLabel();
            this.txtPym = new MyTextBox();
            this.myLabel4 = new MyLabel();
            this.groupBox2 = new MyGroupBox();
            this.txtPassword = new MyTextBox();
            this.myLabel5 = new MyLabel();
            this.cmbFlag = new MyComboBox();
            this.btn_Add = new MyButton();
            this.btn_Save = new MyButton();
            this.btn_Refresh = new MyButton();
            this.groupBox1 = new MyGroupBox();
            this.dgvOperatorList = new MyDataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PYM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperatorList)).BeginInit();
            this.SuspendLayout();
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(-9, 32);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(73, 21);
            this.myLabel1.TabIndex = 8;
            this.myLabel1.Text = "   代码：";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCode.Location = new System.Drawing.Point(70, 31);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(158, 22);
            this.txtCode.TabIndex = 9;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel2.Location = new System.Drawing.Point(6, 71);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(58, 21);
            this.myLabel2.TabIndex = 10;
            this.myLabel2.Text = "名称：";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtName.Location = new System.Drawing.Point(70, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 22);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel3.Location = new System.Drawing.Point(234, 71);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(74, 21);
            this.myLabel3.TabIndex = 12;
            this.myLabel3.Text = "拼音码：";
            // 
            // txtPym
            // 
            this.txtPym.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPym.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPym.Location = new System.Drawing.Point(314, 70);
            this.txtPym.Name = "txtPym";
            this.txtPym.Size = new System.Drawing.Size(151, 22);
            this.txtPym.TabIndex = 13;
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel4.Location = new System.Drawing.Point(250, 31);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(58, 21);
            this.myLabel4.TabIndex = 14;
            this.myLabel4.Text = "密码：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.myLabel5);
            this.groupBox2.Controls.Add(this.cmbFlag);
            this.groupBox2.Controls.Add(this.myLabel4);
            this.groupBox2.Controls.Add(this.txtPym);
            this.groupBox2.Controls.Add(this.myLabel3);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.myLabel2);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.myLabel1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(800, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑区";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPassword.Location = new System.Drawing.Point(314, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(151, 22);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel5.Location = new System.Drawing.Point(471, 71);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(58, 21);
            this.myLabel5.TabIndex = 16;
            this.myLabel5.Text = "状态：";
            // 
            // cmbFlag
            // 
            this.cmbFlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFlag.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFlag.DropDownHeight = 200;
            this.cmbFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFlag.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbFlag.FormattingEnabled = true;
            this.cmbFlag.IntegralHeight = false;
            this.cmbFlag.ItemHeight = 28;
            this.cmbFlag.Items.AddRange(new object[] {
            "启用",
            "禁用"});
            this.cmbFlag.Location = new System.Drawing.Point(535, 64);
            this.cmbFlag.Name = "cmbFlag";
            this.cmbFlag.Size = new System.Drawing.Size(165, 34);
            this.cmbFlag.TabIndex = 15;
            this.cmbFlag.Text = "启用";
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(6, 12);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(64, 25);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "新增";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(76, 12);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(64, 25);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(146, 12);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(64, 25);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "刷新";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(800, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvOperatorList
            // 
            this.dgvOperatorList.AllowUserToAddRows = false;
            this.dgvOperatorList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvOperatorList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperatorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperatorList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperatorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOperatorList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperatorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperatorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperatorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.NAME,
            this.PYM,
            this.FLAG});
            this.dgvOperatorList.ConvertValueData = "flag:1-启用*0-停用;";
            this.dgvOperatorList.ConvertValueFlag = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperatorList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOperatorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOperatorList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOperatorList.EnableHeadersVisualStyles = false;
            this.dgvOperatorList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvOperatorList.Location = new System.Drawing.Point(0, 151);
            this.dgvOperatorList.MultiSelect = false;
            this.dgvOperatorList.Name = "dgvOperatorList";
            this.dgvOperatorList.RowHeadersVisible = false;
            this.dgvOperatorList.RowTemplate.Height = 32;
            this.dgvOperatorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperatorList.Size = new System.Drawing.Size(800, 299);
            this.dgvOperatorList.TabIndex = 3;
            this.dgvOperatorList.SelectionChanged += new System.EventHandler(this.dgvOperatorList_SelectionChanged);
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "CODE";
            this.CODE.HeaderText = "代码";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "名称";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // PYM
            // 
            this.PYM.DataPropertyName = "PYM";
            this.PYM.HeaderText = "拼音码";
            this.PYM.Name = "PYM";
            this.PYM.ReadOnly = true;
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "使用标志";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOperatorList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserSetting";
            this.Text = "操作员维护";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperatorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MyLabel myLabel1;
        private MyTextBox txtCode;
        private MyLabel myLabel2;
        private MyTextBox txtName;
        private MyLabel myLabel3;
        private MyTextBox txtPym;
        private MyLabel myLabel4;
        private MyGroupBox groupBox2;
        private MyButton btn_Add;
        private MyButton btn_Save;
        private MyButton btn_Refresh;
        private MyGroupBox groupBox1;
        private MyDataGridView dgvOperatorList;
        private MyComboBox cmbFlag;
        private MyLabel myLabel5;
        private MyTextBox txtPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PYM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
    }
}
