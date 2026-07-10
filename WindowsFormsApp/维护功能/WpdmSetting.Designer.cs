namespace WindowsFormsApp.维护功能
{
    partial class WpdmSetting
    {
        private System.ComponentModel.IContainer components = null;

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
            this.groupBoxButtons = new MyGroupBox();
            this.btnDisable = new MyButton();
            this.btnEnable = new MyButton();
            this.btnCopyAdd = new MyButton();
            this.btnEdit = new MyButton();
            this.btnAdd = new MyButton();
            this.btnRefresh = new MyButton();
            this.groupBoxFilter = new MyGroupBox();
            this.btnQuery = new MyButton();
            this.txtKeyword = new MyTextBox();
            this.myLabel3 = new MyLabel();
            this.cmbTypeFilter = new MyComboBox();
            this.myLabel2 = new MyLabel();
            this.cmbStatusFilter = new MyComboBox();
            this.myLabel1 = new MyLabel();
            this.groupBoxList = new MyGroupBox();
            this.dgvWpdmList = new MyDataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PYM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JHJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LSJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWpdmList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxButtons.Controls.Add(this.btnDisable);
            this.groupBoxButtons.Controls.Add(this.btnEnable);
            this.groupBoxButtons.Controls.Add(this.btnCopyAdd);
            this.groupBoxButtons.Controls.Add(this.btnEdit);
            this.groupBoxButtons.Controls.Add(this.btnAdd);
            this.groupBoxButtons.Controls.Add(this.btnRefresh);
            this.groupBoxButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxButtons.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBoxButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBoxButtons.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(1180, 42);
            this.groupBoxButtons.TabIndex = 0;
            this.groupBoxButtons.TabStop = false;
            // 
            // btnDisable
            // 
            this.btnDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Location = new System.Drawing.Point(410, 12);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(64, 25);
            this.btnDisable.TabIndex = 5;
            this.btnDisable.Text = "禁用";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(340, 12);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(64, 25);
            this.btnEnable.TabIndex = 4;
            this.btnEnable.Text = "启用";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnCopyAdd
            // 
            this.btnCopyAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyAdd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCopyAdd.ForeColor = System.Drawing.Color.White;
            this.btnCopyAdd.Location = new System.Drawing.Point(250, 12);
            this.btnCopyAdd.Name = "btnCopyAdd";
            this.btnCopyAdd.Size = new System.Drawing.Size(84, 25);
            this.btnCopyAdd.TabIndex = 3;
            this.btnCopyAdd.Text = "复制新增";
            this.btnCopyAdd.UseVisualStyleBackColor = true;
            this.btnCopyAdd.Click += new System.EventHandler(this.btnCopyAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(160, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 25);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(70, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(6, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 25);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.Color.White;
            this.groupBoxFilter.Controls.Add(this.btnQuery);
            this.groupBoxFilter.Controls.Add(this.txtKeyword);
            this.groupBoxFilter.Controls.Add(this.myLabel3);
            this.groupBoxFilter.Controls.Add(this.cmbTypeFilter);
            this.groupBoxFilter.Controls.Add(this.myLabel2);
            this.groupBoxFilter.Controls.Add(this.cmbStatusFilter);
            this.groupBoxFilter.Controls.Add(this.myLabel1);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFilter.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBoxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBoxFilter.Location = new System.Drawing.Point(0, 42);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(1180, 78);
            this.groupBoxFilter.TabIndex = 1;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "筛选条件";
            // 
            // btnQuery
            // 
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.btnQuery.Location = new System.Drawing.Point(904, 29);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(72, 29);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeyword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtKeyword.Location = new System.Drawing.Point(596, 32);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(280, 22);
            this.txtKeyword.TabIndex = 5;
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel3.Location = new System.Drawing.Point(520, 32);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(74, 21);
            this.myLabel3.TabIndex = 4;
            this.myLabel3.Text = "搜索词：";
            // 
            // cmbTypeFilter
            // 
            this.cmbTypeFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTypeFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTypeFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTypeFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTypeFilter.DropDownHeight = 200;
            this.cmbTypeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTypeFilter.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbTypeFilter.FormattingEnabled = true;
            this.cmbTypeFilter.IntegralHeight = false;
            this.cmbTypeFilter.ItemHeight = 28;
            this.cmbTypeFilter.Location = new System.Drawing.Point(328, 26);
            this.cmbTypeFilter.Name = "cmbTypeFilter";
            this.cmbTypeFilter.Size = new System.Drawing.Size(160, 34);
            this.cmbTypeFilter.TabIndex = 3;
            this.cmbTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cmbTypeFilter_SelectedIndexChanged);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel2.Location = new System.Drawing.Point(248, 32);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(74, 21);
            this.myLabel2.TabIndex = 2;
            this.myLabel2.Text = "商品类别";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatusFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatusFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatusFilter.DropDownHeight = 200;
            this.cmbStatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusFilter.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.IntegralHeight = false;
            this.cmbStatusFilter.ItemHeight = 28;
            this.cmbStatusFilter.Location = new System.Drawing.Point(90, 26);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(130, 34);
            this.cmbStatusFilter.TabIndex = 1;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(12, 32);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(74, 21);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "状态筛选";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.dgvWpdmList);
            this.groupBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBoxList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBoxList.Location = new System.Drawing.Point(0, 120);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(1180, 540);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "物品代码列表";
            // 
            // dgvWpdmList
            // 
            this.dgvWpdmList.AllowUserToAddRows = false;
            this.dgvWpdmList.AllowUserToDeleteRows = false;
            this.dgvWpdmList.AutoSelectFirstRow = false;
            this.dgvWpdmList.ColumnHeadersHeight = 36;
            this.dgvWpdmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWpdmList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.NAME,
            this.PYM,
            this.FLAG,
            this.TYPE_NAME,
            this.GG,
            this.JHJ,
            this.LSJ,
            this.SXH,
            this.BZ,
            this.TYPE});
            this.dgvWpdmList.ConvertValueData = "FLAG:1-启用*0-禁用;";
            this.dgvWpdmList.ConvertValueFlag = true;
            this.dgvWpdmList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWpdmList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvWpdmList.Location = new System.Drawing.Point(3, 19);
            this.dgvWpdmList.MultiSelect = false;
            this.dgvWpdmList.Name = "dgvWpdmList";
            this.dgvWpdmList.ReadOnly = true;
            this.dgvWpdmList.RowHeadersVisible = false;
            this.dgvWpdmList.RowTemplate.Height = 32;
            this.dgvWpdmList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWpdmList.Size = new System.Drawing.Size(1174, 518);
            this.dgvWpdmList.TabIndex = 0;
            this.dgvWpdmList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWpdmList_CellDoubleClick);
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
            // PYM
            // 
            this.PYM.DataPropertyName = "PYM";
            this.PYM.HeaderText = "拼音码";
            this.PYM.Name = "PYM";
            this.PYM.ReadOnly = true;
            this.PYM.Width = 90;
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "使用标志";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            this.FLAG.Width = 90;
            // 
            // TYPE_NAME
            // 
            this.TYPE_NAME.DataPropertyName = "TYPE_NAME";
            this.TYPE_NAME.HeaderText = "类型";
            this.TYPE_NAME.Name = "TYPE_NAME";
            this.TYPE_NAME.ReadOnly = true;
            this.TYPE_NAME.Width = 120;
            // 
            // GG
            // 
            this.GG.DataPropertyName = "GG";
            this.GG.HeaderText = "规格";
            this.GG.Name = "GG";
            this.GG.ReadOnly = true;
            this.GG.Width = 110;
            // 
            // JHJ
            // 
            this.JHJ.DataPropertyName = "JHJ";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "0.####";
            this.JHJ.DefaultCellStyle = dataGridViewCellStyle1;
            this.JHJ.HeaderText = "默认进货价";
            this.JHJ.Name = "JHJ";
            this.JHJ.ReadOnly = true;
            this.JHJ.Width = 110;
            // 
            // LSJ
            // 
            this.LSJ.DataPropertyName = "LSJ";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "0.####";
            this.LSJ.DefaultCellStyle = dataGridViewCellStyle2;
            this.LSJ.HeaderText = "默认零售价";
            this.LSJ.Name = "LSJ";
            this.LSJ.ReadOnly = true;
            this.LSJ.Width = 110;
            // 
            // SXH
            // 
            this.SXH.DataPropertyName = "SXH";
            this.SXH.HeaderText = "顺序号";
            this.SXH.Name = "SXH";
            this.SXH.ReadOnly = true;
            this.SXH.Width = 80;
            // 
            // BZ
            // 
            this.BZ.DataPropertyName = "BZ";
            this.BZ.HeaderText = "备注";
            this.BZ.Name = "BZ";
            this.BZ.ReadOnly = true;
            this.BZ.Width = 180;
            // 
            // TYPE
            // 
            this.TYPE.DataPropertyName = "TYPE";
            this.TYPE.HeaderText = "TYPE";
            this.TYPE.Name = "TYPE";
            this.TYPE.ReadOnly = true;
            this.TYPE.Visible = false;
            // 
            // WpdmSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxButtons);
            this.Name = "WpdmSetting";
            this.Text = "物品代码维护";
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWpdmList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGroupBox groupBoxButtons;
        private MyButton btnDisable;
        private MyButton btnEnable;
        private MyButton btnCopyAdd;
        private MyButton btnEdit;
        private MyButton btnAdd;
        private MyButton btnRefresh;
        private MyGroupBox groupBoxFilter;
        private MyButton btnQuery;
        private MyTextBox txtKeyword;
        private MyLabel myLabel3;
        private MyComboBox cmbTypeFilter;
        private MyLabel myLabel2;
        private MyComboBox cmbStatusFilter;
        private MyLabel myLabel1;
        private MyGroupBox groupBoxList;
        private MyDataGridView dgvWpdmList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PYM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GG;
        private System.Windows.Forms.DataGridViewTextBoxColumn JHJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn LSJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
    }
}
