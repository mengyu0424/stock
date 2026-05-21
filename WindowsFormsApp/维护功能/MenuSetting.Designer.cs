namespace WindowsFormsApp.维护功能
{
    partial class MenuSetting
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
            this.groupBox1 = new MyGroupBox();
            this.btnEdit = new MyButton();
            this.btn_Refresh = new MyButton();
            this.btn_Add = new MyButton();
            this.groupBox3 = new MyGroupBox();
            this.dgvMenuList = new MyDataGridView();
            this.FATHERCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FATHERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PYM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MENULEVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORGCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FATHERSXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new MyLabel();
            this.cmb_Org = new MyComboBox();
            this.groupBox2 = new MyGroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
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
            this.groupBox1.Size = new System.Drawing.Size(1144, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(76, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 25);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(146, 11);
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
            this.btn_Add.Location = new System.Drawing.Point(6, 12);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(64, 25);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "新增";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMenuList);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(139)))), ((int)(((byte)(243)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 104);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1144, 495);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dgvMenuList
            // 
            this.dgvMenuList.AllowUserToAddRows = false;
            this.dgvMenuList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvMenuList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.FATHERCODE,
            this.FATHERNAME,
            this.CODE,
            this.NAME,
            this.PYM,
            this.MENULEVEL,
            this.FLAG,
            this.PATH,
            this.ORGCODE,
            this.ORGNAME,
            this.SXH,
            this.FATHERSXH});
            this.dgvMenuList.ConvertValueData = "flag:1-启用*0-停用;";
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
            this.dgvMenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMenuList.EnableHeadersVisualStyles = false;
            this.dgvMenuList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvMenuList.Location = new System.Drawing.Point(3, 18);
            this.dgvMenuList.MultiSelect = false;
            this.dgvMenuList.Name = "dgvMenuList";
            this.dgvMenuList.RowHeadersVisible = false;
            this.dgvMenuList.RowTemplate.Height = 32;
            this.dgvMenuList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuList.Size = new System.Drawing.Size(1138, 475);
            this.dgvMenuList.TabIndex = 0;
            // 
            // FATHERCODE
            // 
            this.FATHERCODE.DataPropertyName = "FATHERCODE";
            this.FATHERCODE.HeaderText = "上级菜单代码";
            this.FATHERCODE.Name = "FATHERCODE";
            this.FATHERCODE.ReadOnly = true;
            this.FATHERCODE.Visible = false;
            // 
            // FATHERNAME
            // 
            this.FATHERNAME.DataPropertyName = "FATHERNAME";
            this.FATHERNAME.HeaderText = "上级菜单";
            this.FATHERNAME.Name = "FATHERNAME";
            this.FATHERNAME.ReadOnly = true;
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
            // MENULEVEL
            // 
            this.MENULEVEL.DataPropertyName = "MENULEVEL";
            this.MENULEVEL.HeaderText = "菜单级别";
            this.MENULEVEL.Name = "MENULEVEL";
            this.MENULEVEL.ReadOnly = true;
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "使用标志";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            // 
            // PATH
            // 
            this.PATH.DataPropertyName = "PATH";
            this.PATH.FillWeight = 300F;
            this.PATH.HeaderText = "菜单地址";
            this.PATH.Name = "PATH";
            this.PATH.ReadOnly = true;
            // 
            // ORGCODE
            // 
            this.ORGCODE.DataPropertyName = "ORGCODE";
            this.ORGCODE.HeaderText = "机构代码";
            this.ORGCODE.Name = "ORGCODE";
            this.ORGCODE.ReadOnly = true;
            this.ORGCODE.Visible = false;
            // 
            // ORGNAME
            // 
            this.ORGNAME.DataPropertyName = "ORGNAME";
            this.ORGNAME.HeaderText = "机构名称";
            this.ORGNAME.Name = "ORGNAME";
            this.ORGNAME.ReadOnly = true;
            // 
            // SXH
            // 
            this.SXH.DataPropertyName = "SXH";
            this.SXH.HeaderText = "顺序号";
            this.SXH.Name = "SXH";
            this.SXH.ReadOnly = true;
            // 
            // FATHERSXH
            // 
            this.FATHERSXH.DataPropertyName = "FATHERSXH";
            this.FATHERSXH.HeaderText = "上级菜单顺序号";
            this.FATHERSXH.Name = "FATHERSXH";
            this.FATHERSXH.ReadOnly = true;
            this.FATHERSXH.Visible = false;
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
            this.cmb_Org.Location = new System.Drawing.Point(70, 19);
            this.cmb_Org.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Org.Name = "cmb_Org";
            this.cmb_Org.Size = new System.Drawing.Size(158, 30);
            this.cmb_Org.TabIndex = 7;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Size = new System.Drawing.Size(1144, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑区";
            // 
            // MenuSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 599);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuSetting";
            this.Text = "菜单维护";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGroupBox groupBox1;
        private MyGroupBox groupBox3;
        private MyButton btn_Add;
        private MyButton btn_Refresh;
        private MyDataGridView dgvMenuList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FATHERCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FATHERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PYM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENULEVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORGCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORGNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn FATHERSXH;
        private MyLabel label6;
        private MyComboBox cmb_Org;
        private MyGroupBox groupBox2;
        private MyButton btnEdit;
    }
}