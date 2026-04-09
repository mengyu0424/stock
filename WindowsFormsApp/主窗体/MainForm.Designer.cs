using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp.主窗体
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.pnlTabContainer = new System.Windows.Forms.Panel();
            this.flpTabBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            this.pnlTabContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.tvMenu);
            this.pnlLeft.Controls.Add(this.lblUserInfo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(220, 600);
            this.pnlLeft.TabIndex = 0;
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HideSelection = false;
            this.tvMenu.Location = new System.Drawing.Point(0, 63);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(218, 535);
            this.tvMenu.TabIndex = 1;
            this.tvMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseClick);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserInfo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblUserInfo.Location = new System.Drawing.Point(0, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Padding = new System.Windows.Forms.Padding(8);
            this.lblUserInfo.Size = new System.Drawing.Size(218, 63);
            this.lblUserInfo.TabIndex = 0;
            this.lblUserInfo.Text = "登录用户: \r\n";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTabContainer
            // 
            this.pnlTabContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlTabContainer.Controls.Add(this.flpTabBar);
            this.pnlTabContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabContainer.Location = new System.Drawing.Point(220, 0);
            this.pnlTabContainer.Name = "pnlTabContainer";
            this.pnlTabContainer.Size = new System.Drawing.Size(780, 30);
            this.pnlTabContainer.TabIndex = 2;
            // 
            // flpTabBar
            // 
            this.flpTabBar.AutoScroll = true;
            this.flpTabBar.BackColor = System.Drawing.Color.Silver;
            this.flpTabBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTabBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTabBar.Location = new System.Drawing.Point(0, 0);
            this.flpTabBar.Name = "flpTabBar";
            this.flpTabBar.Size = new System.Drawing.Size(780, 30);
            this.flpTabBar.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(780, 570);
            this.pnlContent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTabContainer);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "系统主界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnlLeft.ResumeLayout(false);
            this.pnlTabContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Panel pnlTabContainer;
        private System.Windows.Forms.FlowLayoutPanel flpTabBar;
        private System.Windows.Forms.Panel pnlContent;
    }
}