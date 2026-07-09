namespace WindowsFormsApp.维护功能
{
    partial class DictListSetting
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
            this.btn_Copy = new MyButton();
            this.btn_Refresh = new MyButton();
            this.btn_Save = new MyButton();
            this.btn_Edit = new MyButton();
            this.btn_Add = new MyButton();
            this.groupBox2 = new MyGroupBox();
            this.txtBz = new MyTextBox();
            this.myLabel4 = new MyLabel();
            this.cmbFlag = new MyComboBox();
            this.myLabel3 = new MyLabel();
            this.txtName = new MyTextBox();
            this.myLabel2 = new MyLabel();
            this.txtCode = new MyTextBox();
            this.myLabel1 = new MyLabel();
            this.groupBox3 = new MyGroupBox();
            this.btn_Query = new MyButton();
            this.txtQuery = new MyTextBox();
            this.myLabel5 = new MyLabel();
            this.groupBox4 = new MyGroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new MyGroupBox();
            this.dgvDictMainList = new MyDataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new MyGroupBox();
            this.dgvDictNextList = new MyDataGridView();
            this.NEXT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEXT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEXT_BZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictMainList)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictNextList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_Copy);
            this.groupBox1.Controls.Add(this.btn_Refresh);
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
            // btn_Copy
            // 
            this.btn_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copy.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Copy.ForeColor = System.Drawing.Color.White;
            this.btn_Copy.Location = new System.Drawing.Point(334, 12);
            this.btn_Copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(120, 25);
            this.btn_Copy.TabIndex = 4;
            this.btn_Copy.Text = "复制字典为新字典";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(260, 12);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(64, 25);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "刷新";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(186, 12);
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
            this.btn_Edit.Location = new System.Drawing.Point(96, 12);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(80, 25);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "修改字典";
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
            this.btn_Add.Size = new System.Drawing.Size(80, 25);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "新增字典";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.txtBz);
            this.groupBox2.Controls.Add(this.myLabel4);
            this.groupBox2.Controls.Add(this.cmbFlag);
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
            this.groupBox2.Size = new System.Drawing.Size(1144, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据操作";
            // 
            // txtBz
            // 
            this.txtBz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBz.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtBz.Location = new System.Drawing.Point(91, 73);
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(693, 22);
            this.txtBz.TabIndex = 7;
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel4.Location = new System.Drawing.Point(43, 73);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(42, 21);
            this.myLabel4.TabIndex = 6;
            this.myLabel4.Text = "备注";
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
            "停用"});
            this.cmbFlag.Location = new System.Drawing.Point(662, 25);
            this.cmbFlag.Name = "cmbFlag";
            this.cmbFlag.Size = new System.Drawing.Size(122, 34);
            this.cmbFlag.TabIndex = 5;
            this.cmbFlag.Text = "启用";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel3.Location = new System.Drawing.Point(579, 32);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(74, 21);
            this.myLabel3.TabIndex = 4;
            this.myLabel3.Text = "使用标志";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtName.Location = new System.Drawing.Point(337, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 22);
            this.txtName.TabIndex = 3;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel2.Location = new System.Drawing.Point(257, 32);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(74, 21);
            this.myLabel2.TabIndex = 2;
            this.myLabel2.Text = "字典名称";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCode.Location = new System.Drawing.Point(91, 31);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(160, 22);
            this.txtCode.TabIndex = 1;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(11, 32);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(74, 21);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "字典代码";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btn_Query);
            this.groupBox3.Controls.Add(this.txtQuery);
            this.groupBox3.Controls.Add(this.myLabel5);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 159);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1144, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询";
            // 
            // btn_Query
            // 
            this.btn_Query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Query.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Query.ForeColor = System.Drawing.Color.White;
            this.btn_Query.Location = new System.Drawing.Point(418, 20);
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
            this.txtQuery.Location = new System.Drawing.Point(91, 21);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(321, 22);
            this.txtQuery.TabIndex = 1;
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel5.Location = new System.Drawing.Point(11, 21);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(58, 21);
            this.myLabel5.TabIndex = 0;
            this.myLabel5.Text = "关键字";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.splitContainer1);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox4.Location = new System.Drawing.Point(0, 215);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1144, 384);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据展示";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Size = new System.Drawing.Size(1138, 364);
            this.splitContainer1.SplitterDistance = 630;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDictMainList);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(630, 364);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "字典分类";
            // 
            // dgvDictMainList
            // 
            this.dgvDictMainList.AllowUserToAddRows = false;
            this.dgvDictMainList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvDictMainList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDictMainList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDictMainList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDictMainList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDictMainList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDictMainList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDictMainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictMainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.NAME,
            this.FLAG,
            this.BZ});
            this.dgvDictMainList.ConvertValueData = "FLAG:1-启用*0-停用;";
            this.dgvDictMainList.ConvertValueFlag = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDictMainList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDictMainList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDictMainList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDictMainList.EnableHeadersVisualStyles = false;
            this.dgvDictMainList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvDictMainList.Location = new System.Drawing.Point(3, 19);
            this.dgvDictMainList.MultiSelect = false;
            this.dgvDictMainList.Name = "dgvDictMainList";
            this.dgvDictMainList.RowHeadersVisible = false;
            this.dgvDictMainList.RowTemplate.Height = 32;
            this.dgvDictMainList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDictMainList.Size = new System.Drawing.Size(624, 342);
            this.dgvDictMainList.TabIndex = 0;
            this.dgvDictMainList.SelectionChanged += new System.EventHandler(this.dgvDictMainList_SelectionChanged);
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "CODE";
            this.CODE.HeaderText = "字典代码";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "字典名称";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "使用标志";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            // 
            // BZ
            // 
            this.BZ.DataPropertyName = "BZ";
            this.BZ.HeaderText = "备注";
            this.BZ.Name = "BZ";
            this.BZ.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvDictNextList);
            this.groupBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(504, 364);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "字典子项";
            // 
            // dgvDictNextList
            // 
            this.dgvDictNextList.AllowUserToAddRows = true;
            this.dgvDictNextList.AllowUserToDeleteRows = true;
            this.dgvDictNextList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvDictNextList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDictNextList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDictNextList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDictNextList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDictNextList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDictNextList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDictNextList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictNextList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NEXT_CODE,
            this.NEXT_NAME,
            this.NEXT_BZ});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDictNextList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDictNextList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDictNextList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDictNextList.EnableHeadersVisualStyles = false;
            this.dgvDictNextList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvDictNextList.Location = new System.Drawing.Point(3, 19);
            this.dgvDictNextList.MultiSelect = false;
            this.dgvDictNextList.Name = "dgvDictNextList";
            this.dgvDictNextList.ReadOnly = true;
            this.dgvDictNextList.RowHeadersVisible = false;
            this.dgvDictNextList.RowTemplate.Height = 32;
            this.dgvDictNextList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDictNextList.Size = new System.Drawing.Size(498, 342);
            this.dgvDictNextList.TabIndex = 0;
            // 
            // NEXT_CODE
            // 
            this.NEXT_CODE.DataPropertyName = "CODE";
            this.NEXT_CODE.HeaderText = "值代码";
            this.NEXT_CODE.Name = "NEXT_CODE";
            // 
            // NEXT_NAME
            // 
            this.NEXT_NAME.DataPropertyName = "NAME";
            this.NEXT_NAME.HeaderText = "值名称";
            this.NEXT_NAME.Name = "NEXT_NAME";
            // 
            // NEXT_BZ
            // 
            this.NEXT_BZ.DataPropertyName = "BZ";
            this.NEXT_BZ.HeaderText = "备注";
            this.NEXT_BZ.Name = "NEXT_BZ";
            // 
            // DictListSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 599);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DictListSetting";
            this.Text = "DictListSetting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictMainList)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictNextList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGroupBox groupBox1;
        private MyButton btn_Copy;
        private MyButton btn_Refresh;
        private MyButton btn_Save;
        private MyButton btn_Edit;
        private MyButton btn_Add;
        private MyGroupBox groupBox2;
        private MyTextBox txtBz;
        private MyLabel myLabel4;
        private MyComboBox cmbFlag;
        private MyLabel myLabel3;
        private MyTextBox txtName;
        private MyLabel myLabel2;
        private MyTextBox txtCode;
        private MyLabel myLabel1;
        private MyGroupBox groupBox3;
        private MyButton btn_Query;
        private MyTextBox txtQuery;
        private MyLabel myLabel5;
        private MyGroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyGroupBox groupBox5;
        private MyDataGridView dgvDictMainList;
        private MyGroupBox groupBox6;
        private MyDataGridView dgvDictNextList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEXT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEXT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEXT_BZ;
    }
}
