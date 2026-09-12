namespace WindowsFormsApp.库房业务
{
    partial class InStorage
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxButtons = new MyGroupBox();
            this.btnSave = new MyButton();
            this.btnClear = new MyButton();
            this.btnDeleteItem = new MyButton();
            this.btnAddItem = new MyButton();
            this.btnNewBill = new MyButton();
            this.groupBoxEdit = new MyGroupBox();
            this.txtSl = new MyTextBox();
            this.myLabel8 = new MyLabel();
            this.txtLsj = new MyTextBox();
            this.myLabel7 = new MyLabel();
            this.txtJhj = new MyTextBox();
            this.myLabel6 = new MyLabel();
            this.txtPc = new MyTextBox();
            this.myLabel5 = new MyLabel();
            this.txtPh = new MyTextBox();
            this.myLabel4 = new MyLabel();
            this.txtGg = new MyTextBox();
            this.myLabel3 = new MyLabel();
            this.cmbWpdmCode = new MyComboList();
            this.myLabel1 = new MyLabel();
            this.groupBoxList = new MyGroupBox();
            this.dgvInStorageList = new MyDataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JHJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LSJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JHJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LSJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInStorageList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxButtons.Controls.Add(this.btnSave);
            this.groupBoxButtons.Controls.Add(this.btnClear);
            this.groupBoxButtons.Controls.Add(this.btnDeleteItem);
            this.groupBoxButtons.Controls.Add(this.btnAddItem);
            this.groupBoxButtons.Controls.Add(this.btnNewBill);
            this.groupBoxButtons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxButtons.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBoxButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBoxButtons.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(1180, 54);
            this.groupBoxButtons.TabIndex = 0;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "操作";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(356, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(286, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Location = new System.Drawing.Point(188, 20);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(92, 25);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "删除物品";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(90, 20);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(92, 25);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "新增物品";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnNewBill
            // 
            this.btnNewBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBill.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnNewBill.ForeColor = System.Drawing.Color.White;
            this.btnNewBill.Location = new System.Drawing.Point(6, 20);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(78, 25);
            this.btnNewBill.TabIndex = 0;
            this.btnNewBill.Text = "新增单据";
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.BackColor = System.Drawing.Color.White;
            this.groupBoxEdit.Controls.Add(this.txtSl);
            this.groupBoxEdit.Controls.Add(this.myLabel8);
            this.groupBoxEdit.Controls.Add(this.txtLsj);
            this.groupBoxEdit.Controls.Add(this.myLabel7);
            this.groupBoxEdit.Controls.Add(this.txtJhj);
            this.groupBoxEdit.Controls.Add(this.myLabel6);
            this.groupBoxEdit.Controls.Add(this.txtPc);
            this.groupBoxEdit.Controls.Add(this.myLabel5);
            this.groupBoxEdit.Controls.Add(this.txtPh);
            this.groupBoxEdit.Controls.Add(this.myLabel4);
            this.groupBoxEdit.Controls.Add(this.txtGg);
            this.groupBoxEdit.Controls.Add(this.myLabel3);
            this.groupBoxEdit.Controls.Add(this.cmbWpdmCode);
            this.groupBoxEdit.Controls.Add(this.myLabel1);
            this.groupBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEdit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBoxEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBoxEdit.Location = new System.Drawing.Point(0, 54);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(1180, 146);
            this.groupBoxEdit.TabIndex = 1;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "入库信息";
            // 
            // txtSl
            // 
            this.txtSl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSl.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSl.Location = new System.Drawing.Point(596, 97);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(150, 22);
            this.txtSl.TabIndex = 15;
            this.txtSl.TextChanged += new System.EventHandler(this.txtDetail_TextChanged);
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = true;
            this.myLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel8.Location = new System.Drawing.Point(548, 98);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(42, 21);
            this.myLabel8.TabIndex = 14;
            this.myLabel8.Text = "数量";
            // 
            // txtLsj
            // 
            this.txtLsj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLsj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLsj.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLsj.Location = new System.Drawing.Point(328, 97);
            this.txtLsj.Name = "txtLsj";
            this.txtLsj.Size = new System.Drawing.Size(150, 22);
            this.txtLsj.TabIndex = 13;
            this.txtLsj.TextChanged += new System.EventHandler(this.txtDetail_TextChanged);
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel7.Location = new System.Drawing.Point(264, 98);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(58, 21);
            this.myLabel7.TabIndex = 12;
            this.myLabel7.Text = "零售价";
            // 
            // txtJhj
            // 
            this.txtJhj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJhj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtJhj.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtJhj.Location = new System.Drawing.Point(88, 97);
            this.txtJhj.Name = "txtJhj";
            this.txtJhj.Size = new System.Drawing.Size(150, 22);
            this.txtJhj.TabIndex = 11;
            this.txtJhj.TextChanged += new System.EventHandler(this.txtDetail_TextChanged);
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel6.Location = new System.Drawing.Point(24, 98);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(58, 21);
            this.myLabel6.TabIndex = 10;
            this.myLabel6.Text = "进货价";
            // 
            // txtPc
            // 
            this.txtPc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPc.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPc.Location = new System.Drawing.Point(880, 41);
            this.txtPc.Name = "txtPc";
            this.txtPc.Size = new System.Drawing.Size(150, 22);
            this.txtPc.TabIndex = 9;
            this.txtPc.TextChanged += new System.EventHandler(this.txtDetail_TextChanged);
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel5.Location = new System.Drawing.Point(832, 42);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(42, 21);
            this.myLabel5.TabIndex = 8;
            this.myLabel5.Text = "批次";
            // 
            // txtPh
            // 
            this.txtPh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPh.Location = new System.Drawing.Point(596, 41);
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(150, 22);
            this.txtPh.TabIndex = 7;
            this.txtPh.TextChanged += new System.EventHandler(this.txtDetail_TextChanged);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel4.Location = new System.Drawing.Point(548, 42);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(42, 21);
            this.myLabel4.TabIndex = 6;
            this.myLabel4.Text = "批号";
            // 
            // txtGg
            // 
            this.txtGg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtGg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGg.Enabled = false;
            this.txtGg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtGg.Location = new System.Drawing.Point(328, 41);
            this.txtGg.Name = "txtGg";
            this.txtGg.ReadOnly = true;
            this.txtGg.Size = new System.Drawing.Size(150, 22);
            this.txtGg.TabIndex = 5;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel3.Location = new System.Drawing.Point(280, 42);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(42, 21);
            this.myLabel3.TabIndex = 4;
            this.myLabel3.Text = "规格";
            // 
            // cmbWpdmCode
            // 
            this.cmbWpdmCode.BackColor = System.Drawing.Color.White;
            this.cmbWpdmCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbWpdmCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbWpdmCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbWpdmCode.Location = new System.Drawing.Point(90, 35);
            this.cmbWpdmCode.Name = "cmbWpdmCode";
            this.cmbWpdmCode.Size = new System.Drawing.Size(150, 34);
            this.cmbWpdmCode.TabIndex = 1;
            this.cmbWpdmCode.TabStop = false;
            this.cmbWpdmCode.SelectedValueChanged += new System.EventHandler(this.cmbWpdmCode_SelectedValueChanged);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(10, 42);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(74, 21);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "物品代码";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.dgvInStorageList);
            this.groupBoxList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBoxList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBoxList.Location = new System.Drawing.Point(0, 200);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(1180, 460);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "单据物品";
            // 
            // dgvInStorageList
            // 
            this.dgvInStorageList.AllowUserToAddRows = false;
            this.dgvInStorageList.AllowUserToDeleteRows = false;
            this.dgvInStorageList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvInStorageList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInStorageList.BackgroundColor = System.Drawing.Color.White;
            this.dgvInStorageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInStorageList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInStorageList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInStorageList.ColumnHeadersHeight = 36;
            this.dgvInStorageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInStorageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.NAME,
            this.GG,
            this.PH,
            this.PC,
            this.JHJ,
            this.LSJ,
            this.SL,
            this.JHJE,
            this.LSJE});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInStorageList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInStorageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInStorageList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInStorageList.EnableHeadersVisualStyles = false;
            this.dgvInStorageList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvInStorageList.Location = new System.Drawing.Point(3, 19);
            this.dgvInStorageList.MultiSelect = false;
            this.dgvInStorageList.Name = "dgvInStorageList";
            this.dgvInStorageList.ReadOnly = true;
            this.dgvInStorageList.RowHeadersVisible = false;
            this.dgvInStorageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInStorageList.Size = new System.Drawing.Size(1174, 438);
            this.dgvInStorageList.TabIndex = 0;
            this.dgvInStorageList.SelectionChanged += new System.EventHandler(this.dgvInStorageList_SelectionChanged);
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "CODE";
            this.CODE.HeaderText = "物品代码";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            this.CODE.Width = 130;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "物品名称";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 150;
            // 
            // GG
            // 
            this.GG.DataPropertyName = "GG";
            this.GG.HeaderText = "规格";
            this.GG.Name = "GG";
            this.GG.ReadOnly = true;
            this.GG.Width = 120;
            // 
            // PH
            // 
            this.PH.DataPropertyName = "PH";
            this.PH.HeaderText = "批号";
            this.PH.Name = "PH";
            this.PH.ReadOnly = true;
            this.PH.Width = 120;
            // 
            // PC
            // 
            this.PC.DataPropertyName = "PC";
            this.PC.HeaderText = "批次";
            this.PC.Name = "PC";
            this.PC.ReadOnly = true;
            this.PC.Width = 120;
            // 
            // JHJ
            // 
            this.JHJ.DataPropertyName = "JHJ";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "0.####";
            this.JHJ.DefaultCellStyle = dataGridViewCellStyle3;
            this.JHJ.HeaderText = "进货价";
            this.JHJ.Name = "JHJ";
            this.JHJ.ReadOnly = true;
            // 
            // LSJ
            // 
            this.LSJ.DataPropertyName = "LSJ";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.####";
            this.LSJ.DefaultCellStyle = dataGridViewCellStyle4;
            this.LSJ.HeaderText = "零售价";
            this.LSJ.Name = "LSJ";
            this.LSJ.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "0.####";
            this.SL.DefaultCellStyle = dataGridViewCellStyle5;
            this.SL.HeaderText = "数量";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // JHJE
            // 
            this.JHJE.DataPropertyName = "JHJE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "0.##";
            this.JHJE.DefaultCellStyle = dataGridViewCellStyle6;
            this.JHJE.HeaderText = "进货金额";
            this.JHJE.Name = "JHJE";
            this.JHJE.ReadOnly = true;
            this.JHJE.Width = 110;
            // 
            // LSJE
            // 
            this.LSJE.DataPropertyName = "LSJE";
            this.LSJE.HeaderText = "零售金额";
            this.LSJE.Name = "LSJE";
            this.LSJE.ReadOnly = true;
            this.LSJE.Width = 110;
            // 
            // InStorage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxButtons);
            this.Name = "InStorage";
            this.Text = "入库操作";
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInStorageList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGroupBox groupBoxButtons;
        private MyButton btnSave;
        private MyButton btnClear;
        private MyButton btnDeleteItem;
        private MyButton btnAddItem;
        private MyButton btnNewBill;
        private MyGroupBox groupBoxEdit;
        private MyTextBox txtSl;
        private MyLabel myLabel8;
        private MyTextBox txtLsj;
        private MyLabel myLabel7;
        private MyTextBox txtJhj;
        private MyLabel myLabel6;
        private MyTextBox txtPc;
        private MyLabel myLabel5;
        private MyTextBox txtPh;
        private MyLabel myLabel4;
        private MyTextBox txtGg;
        private MyLabel myLabel3;
        private MyComboList cmbWpdmCode;
        private MyLabel myLabel1;
        private MyGroupBox groupBoxList;
        private MyDataGridView dgvInStorageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC;
        private System.Windows.Forms.DataGridViewTextBoxColumn JHJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn LSJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn JHJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LSJE;
    }
}
