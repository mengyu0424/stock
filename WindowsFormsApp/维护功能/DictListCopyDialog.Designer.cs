namespace WindowsFormsApp.维护功能
{
    partial class DictListCopyDialog
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
            this.myPanel1 = new MyPanel();
            this.txtNewName = new MyTextBox();
            this.myLabel2 = new MyLabel();
            this.txtNewCode = new MyTextBox();
            this.myLabel1 = new MyLabel();
            this.myPanel2 = new MyPanel();
            this.btnCancel = new MyButton();
            this.btnConfirm = new MyButton();
            this.myPanel1.SuspendLayout();
            this.myPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPanel1
            // 
            this.myPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myPanel1.Controls.Add(this.txtNewName);
            this.myPanel1.Controls.Add(this.myLabel2);
            this.myPanel1.Controls.Add(this.txtNewCode);
            this.myPanel1.Controls.Add(this.myLabel1);
            this.myPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPanel1.Location = new System.Drawing.Point(0, 0);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(430, 114);
            this.myPanel1.TabIndex = 0;
            // 
            // txtNewName
            // 
            this.txtNewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNewName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtNewName.Location = new System.Drawing.Point(116, 68);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(278, 22);
            this.txtNewName.TabIndex = 3;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel2.Location = new System.Drawing.Point(28, 68);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(74, 21);
            this.myLabel2.TabIndex = 2;
            this.myLabel2.Text = "字典名称";
            // 
            // txtNewCode
            // 
            this.txtNewCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNewCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtNewCode.Location = new System.Drawing.Point(116, 26);
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.Size = new System.Drawing.Size(278, 22);
            this.txtNewCode.TabIndex = 1;
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.myLabel1.Location = new System.Drawing.Point(28, 26);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(74, 21);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "字典代码";
            // 
            // myPanel2
            // 
            this.myPanel2.Controls.Add(this.btnCancel);
            this.myPanel2.Controls.Add(this.btnConfirm);
            this.myPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanel2.Location = new System.Drawing.Point(0, 114);
            this.myPanel2.Name = "myPanel2";
            this.myPanel2.Size = new System.Drawing.Size(430, 46);
            this.myPanel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(305, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(210, 12);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // DictListCopyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 160);
            this.Controls.Add(this.myPanel2);
            this.Controls.Add(this.myPanel1);
            this.Name = "DictListCopyDialog";
            this.Text = "复制字典";
            this.myPanel1.ResumeLayout(false);
            this.myPanel1.PerformLayout();
            this.myPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyPanel myPanel1;
        private MyTextBox txtNewName;
        private MyLabel myLabel2;
        private MyTextBox txtNewCode;
        private MyLabel myLabel1;
        private MyPanel myPanel2;
        private MyButton btnCancel;
        private MyButton btnConfirm;
    }
}
