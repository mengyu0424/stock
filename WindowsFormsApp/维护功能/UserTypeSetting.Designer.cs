namespace WindowsFormsApp.维护功能
{
    partial class UserTypeSetting
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
            this.label6 = new MyLabel();
            this.cmb_Org = new MyComboBox();
            this.myLabel1 = new MyLabel();
            this.txtCode = new MyTextBox();
            this.myLabel2 = new MyLabel();
            this.txtName = new MyTextBox();
            this.myLabel3 = new MyLabel();
            this.txtPym = new MyTextBox();
            this.myLabel4 = new MyLabel();
            this.groupBox2 = new MyGroupBox();
            this.cmbFlag = new MyComboBox();
            this.btn_Add = new MyButton();
            this.btn_Save = new MyButton();
            this.btn_Refresh = new MyButton();
            this.groupBox1 = new MyGroupBox();
            this.ORGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORGCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PYM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserTypeList = new MyDataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "机构：";
            // 
            // cmb_Org
            // 
            this.cmb_Org.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Org.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Org.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Org.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Org.DropDownHeight = 200;
            this.cmb_Org.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Org.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmb_Org.FormattingEnabled = true;
            this.cmb_Org.IntegralHeight = false;
            this.cmb_Org.ItemHeight = 24;
            this.cmb_Org.Location = new System.Drawing.Point(70, 23);
            this.cmb_Org.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Org.Name = "cmb_Org";
            this.cmb_Org.Size = new System.Drawing.Size(158, 30);
            this.cmb_Org.TabIndex = 7;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(234, 28);
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
            this.txtCode.Location = new System.Drawing.Point(313, 27);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(151, 22);
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
            this.myLabel4.Location = new System.Drawing.Point(471, 71);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(58, 21);
            this.myLabel4.TabIndex = 14;
            this.myLabel4.Text = "代码：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.cmbFlag);
            this.groupBox2.Controls.Add(this.myLabel4);
            this.groupBox2.Controls.Add(this.txtPym);
            this.groupBox2.Controls.Add(this.myLabel3);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.myLabel2);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.myLabel1);
            this.groupBox2.Controls.Add(this.cmb_Org);
            this.groupBox2.Controls.Add(this.label6);
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
            // ORGNAME
            // 
            this.ORGNAME.DataPropertyName = "ORGNAME";
            this.ORGNAME.HeaderText = "机构名称";
            this.ORGNAME.Name = "ORGNAME";
            this.ORGNAME.ReadOnly = true;
            // 
            // ORGCODE
            // 
            this.ORGCODE.DataPropertyName = "ORGCODE";
            this.ORGCODE.HeaderText = "机构代码";
            this.ORGCODE.Name = "ORGCODE";
            this.ORGCODE.ReadOnly = true;
            this.ORGCODE.Visible = false;
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "使用标志";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            // 
            // PYM
            // 
            this.PYM.DataPropertyName = "PYM";
            this.PYM.HeaderText = "拼音码";
            this.PYM.Name = "PYM";
            this.PYM.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "名称";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "CODE";
            this.CODE.HeaderText = "代码";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            // 
            // dgvUserTypeList
            // 
            this.dgvUserTypeList.AllowUserToAddRows = false;
            this.dgvUserTypeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvUserTypeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserTypeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserTypeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserTypeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.NAME,
            this.PYM,
            this.FLAG,
            this.ORGCODE,
            this.ORGNAME});
            this.dgvUserTypeList.ConvertValueData = "flag:1-启用*0-停用;";
            this.dgvUserTypeList.ConvertValueFlag = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserTypeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserTypeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUserTypeList.EnableHeadersVisualStyles = false;
            this.dgvUserTypeList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvUserTypeList.Location = new System.Drawing.Point(0, 151);
            this.dgvUserTypeList.MultiSelect = false;
            this.dgvUserTypeList.Name = "dgvUserTypeList";
            this.dgvUserTypeList.RowHeadersVisible = false;
            this.dgvUserTypeList.RowTemplate.Height = 32;
            this.dgvUserTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserTypeList.Size = new System.Drawing.Size(800, 299);
            this.dgvUserTypeList.TabIndex = 3;
            this.dgvUserTypeList.SelectionChanged += new System.EventHandler(this.dgvUserTypeList_SelectionChanged);
            // 
            // UserTypeSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUserTypeList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserTypeSetting";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyLabel label6;
        private MyComboBox cmb_Org;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ORGNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORGCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PYM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private MyDataGridView dgvUserTypeList;
        private MyComboBox cmbFlag;
    }
}