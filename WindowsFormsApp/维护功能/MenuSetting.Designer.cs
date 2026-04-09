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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_fatherMenu = new System.Windows.Forms.ComboBox();
            this.menuFlag = new System.Windows.Forms.ComboBox();
            this.menuSxh = new System.Windows.Forms.TextBox();
            this.menuPath = new System.Windows.Forms.TextBox();
            this.menuName = new System.Windows.Forms.TextBox();
            this.menuCode = new System.Windows.Forms.TextBox();
            this.cmb_Org = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.dgv_fatherMenu = new System.Windows.Forms.DataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PYM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatherMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1239, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "刷新";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "停用";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_fatherMenu);
            this.groupBox2.Controls.Add(this.menuFlag);
            this.groupBox2.Controls.Add(this.menuSxh);
            this.groupBox2.Controls.Add(this.menuPath);
            this.groupBox2.Controls.Add(this.menuName);
            this.groupBox2.Controls.Add(this.menuCode);
            this.groupBox2.Controls.Add(this.cmb_Org);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1239, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑区";
            // 
            // cmb_fatherMenu
            // 
            this.cmb_fatherMenu.FormattingEnabled = true;
            this.cmb_fatherMenu.Location = new System.Drawing.Point(280, 16);
            this.cmb_fatherMenu.Name = "cmb_fatherMenu";
            this.cmb_fatherMenu.Size = new System.Drawing.Size(120, 25);
            this.cmb_fatherMenu.TabIndex = 14;
            // 
            // menuFlag
            // 
            this.menuFlag.FormattingEnabled = true;
            this.menuFlag.Items.AddRange(new object[] {
            "禁用",
            "启用"});
            this.menuFlag.Location = new System.Drawing.Point(1045, 46);
            this.menuFlag.Name = "menuFlag";
            this.menuFlag.Size = new System.Drawing.Size(120, 25);
            this.menuFlag.TabIndex = 13;
            // 
            // menuSxh
            // 
            this.menuSxh.Location = new System.Drawing.Point(845, 48);
            this.menuSxh.Name = "menuSxh";
            this.menuSxh.Size = new System.Drawing.Size(120, 23);
            this.menuSxh.TabIndex = 12;
            // 
            // menuPath
            // 
            this.menuPath.Location = new System.Drawing.Point(481, 48);
            this.menuPath.Name = "menuPath";
            this.menuPath.Size = new System.Drawing.Size(296, 23);
            this.menuPath.TabIndex = 11;
            // 
            // menuName
            // 
            this.menuName.Location = new System.Drawing.Point(281, 48);
            this.menuName.Name = "menuName";
            this.menuName.Size = new System.Drawing.Size(120, 23);
            this.menuName.TabIndex = 9;
            // 
            // menuCode
            // 
            this.menuCode.Enabled = false;
            this.menuCode.Location = new System.Drawing.Point(80, 48);
            this.menuCode.Name = "menuCode";
            this.menuCode.Size = new System.Drawing.Size(120, 23);
            this.menuCode.TabIndex = 8;
            // 
            // cmb_Org
            // 
            this.cmb_Org.FormattingEnabled = true;
            this.cmb_Org.Location = new System.Drawing.Point(80, 16);
            this.cmb_Org.Name = "cmb_Org";
            this.cmb_Org.Size = new System.Drawing.Size(120, 25);
            this.cmb_Org.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(783, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "顺序号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "所属机构：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "菜单地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(971, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "启用标志：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "上级菜单：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "菜单名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜单代码：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_menu);
            this.groupBox3.Controls.Add(this.dgv_fatherMenu);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1239, 566);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dgv_menu
            // 
            this.dgv_menu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_menu.Location = new System.Drawing.Point(546, 19);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.RowTemplate.Height = 23;
            this.dgv_menu.Size = new System.Drawing.Size(690, 544);
            this.dgv_menu.TabIndex = 1;
            // 
            // dgv_fatherMenu
            // 
            this.dgv_fatherMenu.AllowUserToAddRows = false;
            this.dgv_fatherMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fatherMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fatherMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.NAME,
            this.PYM,
            this.SXH,
            this.FLAG});
            this.dgv_fatherMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_fatherMenu.Location = new System.Drawing.Point(3, 19);
            this.dgv_fatherMenu.Name = "dgv_fatherMenu";
            this.dgv_fatherMenu.RowTemplate.Height = 23;
            this.dgv_fatherMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fatherMenu.Size = new System.Drawing.Size(543, 544);
            this.dgv_fatherMenu.TabIndex = 0;
            this.dgv_fatherMenu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fatherMenu_RowEnter);
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "CODE";
            this.CODE.HeaderText = "菜单代码";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "菜单名称";
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
            // SXH
            // 
            this.SXH.DataPropertyName = "SXH";
            this.SXH.HeaderText = "顺序号";
            this.SXH.Name = "SXH";
            this.SXH.ReadOnly = true;
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "使用标志";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            // 
            // MenuSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1239, 693);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuSetting";
            this.Text = "菜单维护";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatherMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox menuFlag;
        private System.Windows.Forms.TextBox menuSxh;
        private System.Windows.Forms.TextBox menuPath;
        private System.Windows.Forms.TextBox menuName;
        private System.Windows.Forms.TextBox menuCode;
        private System.Windows.Forms.ComboBox cmb_Org;
        private System.Windows.Forms.DataGridView dgv_fatherMenu;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PYM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private System.Windows.Forms.ComboBox cmb_fatherMenu;
    }
}