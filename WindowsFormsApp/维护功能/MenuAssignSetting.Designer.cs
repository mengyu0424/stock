namespace WindowsFormsApp.维护功能
{
    partial class MenuAssignSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new MyGroupBox();
            this.btn_Refresh = new MyButton();
            this.btn_Add = new MyButton();
            this.groupBox3 = new MyGroupBox();
            this.dgvMenuList = new MyDataGridView();
            this.dgvAssignList = new MyDataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MenuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1138, 41);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(6, 11);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(64, 25);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "刷新";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(76, 12);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(64, 25);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "保存";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMenuList);
            this.groupBox3.Controls.Add(this.dgvAssignList);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1138, 434);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // dgvMenuList
            // 
            this.dgvMenuList.AllowUserToAddRows = false;
            this.dgvMenuList.AllowUserToDeleteRows = false;
            this.dgvMenuList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvMenuList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenuList.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenuList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenuList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuCheck,
            this.MenuCode,
            this.MenuFatherName,
            this.MenuName,
            this.MenuFlag});
            this.dgvMenuList.ConvertValueData = "MenuFlag:1-启用*0-停用;";
            this.dgvMenuList.ConvertValueFlag = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenuList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenuList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMenuList.EnableHeadersVisualStyles = false;
            this.dgvMenuList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvMenuList.Location = new System.Drawing.Point(332, 5);
            this.dgvMenuList.MultiSelect = false;
            this.dgvMenuList.Name = "dgvMenuList";
            this.dgvMenuList.RowHeadersVisible = false;
            this.dgvMenuList.RowTemplate.Height = 32;
            this.dgvMenuList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuList.Size = new System.Drawing.Size(794, 417);
            this.dgvMenuList.TabIndex = 1;
            // 
            // dgvAssignList
            // 
            this.dgvAssignList.AllowUserToAddRows = false;
            this.dgvAssignList.AllowUserToDeleteRows = false;
            this.dgvAssignList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvAssignList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAssignList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAssignList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.NAME,
            this.FLAG});
            this.dgvAssignList.ConvertValueData = "flag:1-启用*0-停用;";
            this.dgvAssignList.ConvertValueFlag = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAssignList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAssignList.EnableHeadersVisualStyles = false;
            this.dgvAssignList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvAssignList.Location = new System.Drawing.Point(3, 5);
            this.dgvAssignList.MultiSelect = false;
            this.dgvAssignList.Name = "dgvAssignList";
            this.dgvAssignList.ReadOnly = true;
            this.dgvAssignList.RowHeadersVisible = false;
            this.dgvAssignList.RowTemplate.Height = 32;
            this.dgvAssignList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignList.Size = new System.Drawing.Size(312, 417);
            this.dgvAssignList.TabIndex = 0;
            this.dgvAssignList.SelectionChanged += new System.EventHandler(this.dgvMenuList_SelectionChanged);
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "CODE";
            this.CODE.HeaderText = "代码";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            this.CODE.Width = 103;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "名称";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "使用标志";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            this.FLAG.Width = 102;
            // 
            // MenuCheck
            // 
            this.MenuCheck.DataPropertyName = "MenuCheck";
            this.MenuCheck.HeaderText = "选择";
            this.MenuCheck.Name = "MenuCheck";
            this.MenuCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuCheck.Width = 50;
            // 
            // MenuCode
            // 
            this.MenuCode.DataPropertyName = "MenuCode";
            this.MenuCode.HeaderText = "代码";
            this.MenuCode.Name = "MenuCode";
            this.MenuCode.ReadOnly = true;
            this.MenuCode.Width = 103;
            // 
            // MenuFatherName
            // 
            this.MenuFatherName.DataPropertyName = "MenuFatherName";
            this.MenuFatherName.HeaderText = "上级菜单";
            this.MenuFatherName.Name = "MenuFatherName";
            this.MenuFatherName.ReadOnly = true;
            // 
            // MenuName
            // 
            this.MenuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MenuName.DataPropertyName = "MenuName";
            this.MenuName.HeaderText = "名称";
            this.MenuName.Name = "MenuName";
            this.MenuName.ReadOnly = true;
            // 
            // MenuFlag
            // 
            this.MenuFlag.DataPropertyName = "MenuFlag";
            this.MenuFlag.HeaderText = "使用标志";
            this.MenuFlag.Name = "MenuFlag";
            this.MenuFlag.ReadOnly = true;
            this.MenuFlag.Width = 102;
            // 
            // MenuAssignSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1138, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1138, 475);
            this.Name = "MenuAssignSetting";
            this.Text = "MenuAssignSetting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGroupBox groupBox1;
        private MyButton btn_Refresh;
        private MyButton btn_Add;
        private MyGroupBox groupBox3;
        private MyDataGridView dgvAssignList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private MyDataGridView dgvMenuList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MenuCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuFlag;
    }
}