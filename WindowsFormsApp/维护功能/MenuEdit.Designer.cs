namespace WindowsFormsApp.维护功能
{
    partial class MenuEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEdit));
            this.myPanel1 = new MyPanel();
            this.txtPym = new MyTextBox();
            this.txtSxh = new MyTextBox();
            this.txt_url = new MyTextBox();
            this.cmbFlag = new MyComboBox();
            this.txtMenuName = new MyTextBox();
            this.txtMenuCode = new MyTextBox();
            this.cmbFatherMenu = new MyComboBox();
            this.myLabel8 = new MyLabel();
            this.myLabel6 = new MyLabel();
            this.myLabel5 = new MyLabel();
            this.myLabel4 = new MyLabel();
            this.myLabel3 = new MyLabel();
            this.myLabel2 = new MyLabel();
            this.myLabel1 = new MyLabel();
            this.btn_save = new MyButton();
            this.myPanel2 = new MyPanel();
            this.btn_close = new MyButton();
            this.myPanel1.SuspendLayout();
            this.myPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPanel1
            // 
            this.myPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myPanel1.Controls.Add(this.txtPym);
            this.myPanel1.Controls.Add(this.txtSxh);
            this.myPanel1.Controls.Add(this.txt_url);
            this.myPanel1.Controls.Add(this.cmbFlag);
            this.myPanel1.Controls.Add(this.txtMenuName);
            this.myPanel1.Controls.Add(this.txtMenuCode);
            this.myPanel1.Controls.Add(this.cmbFatherMenu);
            this.myPanel1.Controls.Add(this.myLabel8);
            this.myPanel1.Controls.Add(this.myLabel6);
            this.myPanel1.Controls.Add(this.myLabel5);
            this.myPanel1.Controls.Add(this.myLabel4);
            this.myPanel1.Controls.Add(this.myLabel3);
            this.myPanel1.Controls.Add(this.myLabel2);
            this.myPanel1.Controls.Add(this.myLabel1);
            this.myPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPanel1.Location = new System.Drawing.Point(0, 0);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(480, 233);
            this.myPanel1.TabIndex = 1;
            // 
            // txtPym
            // 
            this.txtPym.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPym.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txtPym.Location = new System.Drawing.Point(367, 101);
            this.txtPym.Name = "txtPym";
            this.txtPym.Size = new System.Drawing.Size(100, 27);
            this.txtPym.TabIndex = 15;
            // 
            // txtSxh
            // 
            this.txtSxh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSxh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSxh.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txtSxh.Location = new System.Drawing.Point(367, 141);
            this.txtSxh.Name = "txtSxh";
            this.txtSxh.Size = new System.Drawing.Size(100, 27);
            this.txtSxh.TabIndex = 14;
            this.txtSxh.Text = "1";
            // 
            // txt_url
            // 
            this.txt_url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_url.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_url.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txt_url.Location = new System.Drawing.Point(105, 181);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(344, 27);
            this.txt_url.TabIndex = 13;
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
            this.cmbFlag.Location = new System.Drawing.Point(107, 137);
            this.cmbFlag.Name = "cmbFlag";
            this.cmbFlag.Size = new System.Drawing.Size(165, 34);
            this.cmbFlag.TabIndex = 12;
            this.cmbFlag.Text = "启用";
            // 
            // txtMenuName
            // 
            this.txtMenuName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenuName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMenuName.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txtMenuName.Location = new System.Drawing.Point(107, 101);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(165, 27);
            this.txtMenuName.TabIndex = 11;
            this.txtMenuName.TextChanged += new System.EventHandler(this.txtMenuName_TextChanged);
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenuCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMenuCode.Enabled = false;
            this.txtMenuCode.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txtMenuCode.Location = new System.Drawing.Point(107, 61);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.Size = new System.Drawing.Size(165, 27);
            this.txtMenuCode.TabIndex = 10;
            // 
            // cmbFatherMenu
            // 
            this.cmbFatherMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFatherMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFatherMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFatherMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFatherMenu.DropDownHeight = 200;
            this.cmbFatherMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFatherMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbFatherMenu.FormattingEnabled = true;
            this.cmbFatherMenu.IntegralHeight = false;
            this.cmbFatherMenu.ItemHeight = 28;
            this.cmbFatherMenu.Location = new System.Drawing.Point(107, 12);
            this.cmbFatherMenu.Name = "cmbFatherMenu";
            this.cmbFatherMenu.Size = new System.Drawing.Size(165, 34);
            this.cmbFatherMenu.TabIndex = 9;
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = true;
            this.myLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel8.Location = new System.Drawing.Point(287, 145);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(74, 21);
            this.myLabel8.TabIndex = 7;
            this.myLabel8.Text = "顺序号：";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel6.Location = new System.Drawing.Point(11, 185);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(90, 21);
            this.myLabel6.TabIndex = 5;
            this.myLabel6.Text = "菜单地址：";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel5.Location = new System.Drawing.Point(11, 145);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(90, 21);
            this.myLabel5.TabIndex = 4;
            this.myLabel5.Text = "启用标志：";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel4.Location = new System.Drawing.Point(287, 105);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(74, 21);
            this.myLabel4.TabIndex = 3;
            this.myLabel4.Text = "拼音码：";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel3.Location = new System.Drawing.Point(11, 105);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(90, 21);
            this.myLabel3.TabIndex = 2;
            this.myLabel3.Text = "菜单名称：";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel2.Location = new System.Drawing.Point(11, 65);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(90, 21);
            this.myLabel2.TabIndex = 1;
            this.myLabel2.Text = "菜单代码：";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(11, 25);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(90, 21);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "上级目录：";
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(301, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // myPanel2
            // 
            this.myPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.myPanel2.Controls.Add(this.btn_save);
            this.myPanel2.Controls.Add(this.btn_close);
            this.myPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanel2.Location = new System.Drawing.Point(0, 233);
            this.myPanel2.Name = "myPanel2";
            this.myPanel2.Size = new System.Drawing.Size(480, 50);
            this.myPanel2.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(393, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "取消";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // MenuEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 283);
            this.Controls.Add(this.myPanel2);
            this.Controls.Add(this.myPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuEdit";
            this.Text = "MenuEdit";
            this.myPanel1.ResumeLayout(false);
            this.myPanel1.PerformLayout();
            this.myPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyPanel myPanel1;
        private MyPanel myPanel2;
        private MyButton btn_save;
        private MyButton btn_close;
        private MyLabel myLabel1;
        private MyLabel myLabel8;
        private MyLabel myLabel6;
        private MyLabel myLabel5;
        private MyLabel myLabel4;
        private MyLabel myLabel3;
        private MyLabel myLabel2;
        private MyComboBox cmbFatherMenu;
        private MyTextBox txtMenuCode;
        private MyComboBox cmbFlag;
        private MyTextBox txtMenuName;
        private MyTextBox txt_url;
        private MyTextBox txtPym;
        private MyTextBox txtSxh;
    }
}