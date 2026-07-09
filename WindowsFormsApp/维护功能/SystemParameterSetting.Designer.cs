namespace WindowsFormsApp.维护功能
{
    partial class SystemParameterSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new MyGroupBox();
            this.btn_Save = new MyButton();
            this.btn_Edit = new MyButton();
            this.btn_Add = new MyButton();
            this.groupBox2 = new MyGroupBox();
            this.txtBz = new MyTextBox();
            this.myLabel5 = new MyLabel();
            this.cmbFlag = new MyComboBox();
            this.myLabel4 = new MyLabel();
            this.txtCsz = new MyTextBox();
            this.myLabel3 = new MyLabel();
            this.txtCsmc = new MyTextBox();
            this.myLabel2 = new MyLabel();
            this.txtXtmk = new MyTextBox();
            this.myLabel1 = new MyLabel();
            this.groupBox3 = new MyGroupBox();
            this.btn_Query = new MyButton();
            this.txtQuery = new MyTextBox();
            this.myLabel6 = new MyLabel();
            this.groupBox4 = new MyGroupBox();
            this.dgvSystemParameterList = new MyDataGridView();
            this.XTMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemParameterList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_Edit);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1144, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(146, 12);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(64, 25);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(76, 12);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(64, 25);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "修改";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.txtBz);
            this.groupBox2.Controls.Add(this.myLabel5);
            this.groupBox2.Controls.Add(this.cmbFlag);
            this.groupBox2.Controls.Add(this.myLabel4);
            this.groupBox2.Controls.Add(this.txtCsz);
            this.groupBox2.Controls.Add(this.myLabel3);
            this.groupBox2.Controls.Add(this.txtCsmc);
            this.groupBox2.Controls.Add(this.myLabel2);
            this.groupBox2.Controls.Add(this.txtXtmk);
            this.groupBox2.Controls.Add(this.myLabel1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1144, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑区";
            // 
            // txtBz
            // 
            this.txtBz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBz.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtBz.Location = new System.Drawing.Point(92, 111);
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(692, 22);
            this.txtBz.TabIndex = 9;
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel5.Location = new System.Drawing.Point(44, 111);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(58, 21);
            this.myLabel5.TabIndex = 8;
            this.myLabel5.Text = "备注：";
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
            this.cmbFlag.Location = new System.Drawing.Point(662, 29);
            this.cmbFlag.Name = "cmbFlag";
            this.cmbFlag.Size = new System.Drawing.Size(122, 34);
            this.cmbFlag.TabIndex = 5;
            this.cmbFlag.Text = "启用";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel4.Location = new System.Drawing.Point(579, 36);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(90, 21);
            this.myLabel4.TabIndex = 4;
            this.myLabel4.Text = "使用标志：";
            // 
            // txtCsz
            // 
            this.txtCsz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCsz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCsz.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCsz.Location = new System.Drawing.Point(92, 72);
            this.txtCsz.Name = "txtCsz";
            this.txtCsz.Size = new System.Drawing.Size(692, 22);
            this.txtCsz.TabIndex = 7;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel3.Location = new System.Drawing.Point(28, 72);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(74, 21);
            this.myLabel3.TabIndex = 6;
            this.myLabel3.Text = "参数值：";
            // 
            // txtCsmc
            // 
            this.txtCsmc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCsmc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCsmc.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCsmc.Location = new System.Drawing.Point(281, 35);
            this.txtCsmc.Name = "txtCsmc";
            this.txtCsmc.Size = new System.Drawing.Size(292, 22);
            this.txtCsmc.TabIndex = 3;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel2.Location = new System.Drawing.Point(199, 36);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(90, 21);
            this.myLabel2.TabIndex = 2;
            this.myLabel2.Text = "参数名称：";
            // 
            // txtXtmk
            // 
            this.txtXtmk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXtmk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtXtmk.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtXtmk.Location = new System.Drawing.Point(92, 35);
            this.txtXtmk.Name = "txtXtmk";
            this.txtXtmk.Size = new System.Drawing.Size(101, 22);
            this.txtXtmk.TabIndex = 1;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(12, 36);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(90, 21);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "系统模块：";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btn_Query);
            this.groupBox3.Controls.Add(this.txtQuery);
            this.groupBox3.Controls.Add(this.myLabel6);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 197);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1144, 58);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询区";
            // 
            // btn_Query
            // 
            this.btn_Query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Query.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Query.ForeColor = System.Drawing.Color.White;
            this.btn_Query.Location = new System.Drawing.Point(433, 22);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(64, 25);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtQuery.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtQuery.Location = new System.Drawing.Point(104, 23);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(307, 22);
            this.txtQuery.TabIndex = 1;
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel6.Location = new System.Drawing.Point(20, 23);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(90, 21);
            this.myLabel6.TabIndex = 0;
            this.myLabel6.Text = "查询条件：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSystemParameterList);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox4.Location = new System.Drawing.Point(0, 255);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1144, 344);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据展示区";
            // 
            // dgvSystemParameterList
            // 
            this.dgvSystemParameterList.AllowUserToAddRows = false;
            this.dgvSystemParameterList.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvSystemParameterList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSystemParameterList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSystemParameterList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSystemParameterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSystemParameterList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSystemParameterList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSystemParameterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemParameterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XTMK,
            this.CSMC,
            this.CSZ,
            this.FLAG,
            this.BZ});
            this.dgvSystemParameterList.ConvertValueData = "FLAG:1-启用*0-停用;";
            this.dgvSystemParameterList.ConvertValueFlag = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSystemParameterList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSystemParameterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSystemParameterList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSystemParameterList.EnableHeadersVisualStyles = false;
            this.dgvSystemParameterList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvSystemParameterList.Location = new System.Drawing.Point(3, 18);
            this.dgvSystemParameterList.MultiSelect = false;
            this.dgvSystemParameterList.Name = "dgvSystemParameterList";
            this.dgvSystemParameterList.RowHeadersVisible = false;
            this.dgvSystemParameterList.RowTemplate.Height = 32;
            this.dgvSystemParameterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystemParameterList.Size = new System.Drawing.Size(1138, 324);
            this.dgvSystemParameterList.TabIndex = 0;
            this.dgvSystemParameterList.SelectionChanged += new System.EventHandler(this.dgvSystemParameterList_SelectionChanged);
            // 
            // XTMK
            // 
            this.XTMK.DataPropertyName = "XTMK";
            this.XTMK.FillWeight = 110F;
            this.XTMK.HeaderText = "系统模块";
            this.XTMK.Name = "XTMK";
            this.XTMK.ReadOnly = true;
            // 
            // CSMC
            // 
            this.CSMC.DataPropertyName = "CSMC";
            this.CSMC.FillWeight = 130F;
            this.CSMC.HeaderText = "参数名称";
            this.CSMC.Name = "CSMC";
            this.CSMC.ReadOnly = true;
            // 
            // CSZ
            // 
            this.CSZ.DataPropertyName = "CSZ";
            this.CSZ.FillWeight = 140F;
            this.CSZ.HeaderText = "参数值";
            this.CSZ.Name = "CSZ";
            this.CSZ.ReadOnly = true;
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.FillWeight = 90F;
            this.FLAG.HeaderText = "使用标志";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            // 
            // BZ
            // 
            this.BZ.DataPropertyName = "BZ";
            this.BZ.FillWeight = 180F;
            this.BZ.HeaderText = "备注";
            this.BZ.Name = "BZ";
            this.BZ.ReadOnly = true;
            // 
            // SystemParameterSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 599);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1000, 560);
            this.Name = "SystemParameterSetting";
            this.Text = "系统参数设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemParameterList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGroupBox groupBox1;
        private MyButton btn_Save;
        private MyButton btn_Edit;
        private MyButton btn_Add;
        private MyGroupBox groupBox2;
        private MyTextBox txtBz;
        private MyLabel myLabel5;
        private MyComboBox cmbFlag;
        private MyLabel myLabel4;
        private MyTextBox txtCsz;
        private MyLabel myLabel3;
        private MyTextBox txtCsmc;
        private MyLabel myLabel2;
        private MyTextBox txtXtmk;
        private MyLabel myLabel1;
        private MyGroupBox groupBox3;
        private MyButton btn_Query;
        private MyTextBox txtQuery;
        private MyLabel myLabel6;
        private MyGroupBox groupBox4;
        private MyDataGridView dgvSystemParameterList;
        private System.Windows.Forms.DataGridViewTextBoxColumn XTMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BZ;
    }
}
