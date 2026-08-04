namespace WindowsFormsApp.库房业务
{
    partial class KcStates
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxButtons = new MyGroupBox();
            this.btnDisable = new MyButton();
            this.btnEnable = new MyButton();
            this.btnQuery = new MyButton();
            this.groupBoxFilter = new MyGroupBox();
            this.txtKeyword = new MyTextBox();
            this.myLabel3 = new MyLabel();
            this.cmbTypeFilter = new MyComboBox();
            this.myLabel2 = new MyLabel();
            this.cmbStatusFilter = new MyComboBox();
            this.myLabel1 = new MyLabel();
            this.groupBoxList = new MyGroupBox();
            this.dgvInventoryList = new MyDataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JHJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LSJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JHJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LSJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxButtons.Controls.Add(this.btnDisable);
            this.groupBoxButtons.Controls.Add(this.btnEnable);
            this.groupBoxButtons.Controls.Add(this.btnQuery);
            this.groupBoxButtons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxButtons.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBoxButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBoxButtons.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(1180, 42);
            this.groupBoxButtons.TabIndex = 0;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "操作";
            // 
            // btnDisable
            // 
            this.btnDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Location = new System.Drawing.Point(146, 12);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(64, 25);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "停用";
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(76, 12);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(64, 25);
            this.btnEnable.TabIndex = 1;
            this.btnEnable.Text = "启用";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(6, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(64, 25);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.Color.White;
            this.groupBoxFilter.Controls.Add(this.txtKeyword);
            this.groupBoxFilter.Controls.Add(this.myLabel3);
            this.groupBoxFilter.Controls.Add(this.cmbTypeFilter);
            this.groupBoxFilter.Controls.Add(this.myLabel2);
            this.groupBoxFilter.Controls.Add(this.cmbStatusFilter);
            this.groupBoxFilter.Controls.Add(this.myLabel1);
            this.groupBoxFilter.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // txtKeyword
            // 
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeyword.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.myLabel3.Text = "查询内容";
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
            this.cmbTypeFilter.IntegralHeight = false;
            this.cmbTypeFilter.ItemHeight = 28;
            this.cmbTypeFilter.Location = new System.Drawing.Point(328, 26);
            this.cmbTypeFilter.Name = "cmbTypeFilter";
            this.cmbTypeFilter.Size = new System.Drawing.Size(160, 34);
            this.cmbTypeFilter.TabIndex = 3;
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
            this.myLabel2.Text = "物品类型";
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
            this.cmbStatusFilter.IntegralHeight = false;
            this.cmbStatusFilter.ItemHeight = 28;
            this.cmbStatusFilter.Location = new System.Drawing.Point(90, 26);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(130, 34);
            this.cmbStatusFilter.TabIndex = 1;
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
            this.groupBoxList.Controls.Add(this.dgvInventoryList);
            this.groupBoxList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBoxList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBoxList.Location = new System.Drawing.Point(0, 120);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(1180, 540);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "库存查询";
            // 
            // dgvInventoryList
            // 
            this.dgvInventoryList.AllowUserToAddRows = false;
            this.dgvInventoryList.AllowUserToDeleteRows = false;
            this.dgvInventoryList.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvInventoryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInventoryList.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventoryList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInventoryList.ColumnHeadersHeight = 36;
            this.dgvInventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.NAME,
            this.FLAG,
            this.TYPE_NAME,
            this.GG,
            this.PH,
            this.PC,
            this.JHJ,
            this.LSJ,
            this.SYSL,
            this.JHJE,
            this.LSJE});
            this.dgvInventoryList.ConvertValueData = "FLAG:1-启用*0-禁用;";
            this.dgvInventoryList.ConvertValueFlag = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryList.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInventoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventoryList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventoryList.EnableHeadersVisualStyles = false;
            this.dgvInventoryList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvInventoryList.Location = new System.Drawing.Point(3, 19);
            this.dgvInventoryList.MultiSelect = false;
            this.dgvInventoryList.Name = "dgvInventoryList";
            this.dgvInventoryList.ReadOnly = true;
            this.dgvInventoryList.RowHeadersVisible = false;
            this.dgvInventoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryList.Size = new System.Drawing.Size(1174, 518);
            this.dgvInventoryList.TabIndex = 0;
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
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "显示标志";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            this.FLAG.Width = 90;
            // 
            // TYPE_NAME
            // 
            this.TYPE_NAME.DataPropertyName = "TYPE_NAME";
            this.TYPE_NAME.HeaderText = "物品类型";
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
            this.GG.Width = 130;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "0.####";
            this.JHJ.DefaultCellStyle = dataGridViewCellStyle9;
            this.JHJ.HeaderText = "进货价";
            this.JHJ.Name = "JHJ";
            this.JHJ.ReadOnly = true;
            // 
            // LSJ
            // 
            this.LSJ.DataPropertyName = "LSJ";
            this.LSJ.HeaderText = "零售价";
            this.LSJ.Name = "LSJ";
            this.LSJ.ReadOnly = true;
            // 
            // SYSL
            // 
            this.SYSL.DataPropertyName = "SYSL";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "0.####";
            this.SYSL.DefaultCellStyle = dataGridViewCellStyle10;
            this.SYSL.HeaderText = "剩余数量";
            this.SYSL.Name = "SYSL";
            this.SYSL.ReadOnly = true;
            // 
            // JHJE
            // 
            this.JHJE.DataPropertyName = "JHJE";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "0.##";
            this.JHJE.DefaultCellStyle = dataGridViewCellStyle11;
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
            // KcStates
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxButtons);
            this.Name = "KcStates";
            this.Text = "库存查询";
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGroupBox groupBoxButtons;
        private MyButton btnDisable;
        private MyButton btnEnable;
        private MyButton btnQuery;
        private MyGroupBox groupBoxFilter;
        private MyTextBox txtKeyword;
        private MyLabel myLabel3;
        private MyComboBox cmbTypeFilter;
        private MyLabel myLabel2;
        private MyComboBox cmbStatusFilter;
        private MyLabel myLabel1;
        private MyGroupBox groupBoxList;
        private MyDataGridView dgvInventoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC;
        private System.Windows.Forms.DataGridViewTextBoxColumn JHJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn LSJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn JHJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LSJE;
    }
}
