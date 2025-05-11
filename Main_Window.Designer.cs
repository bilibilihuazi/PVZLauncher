namespace PVZLauncher
{
    partial class Main_Window
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleCard styleCard1 = new AntdUI.Tabs.StyleCard();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.pageHeader = new AntdUI.PageHeader();
            this.tabs_Main = new AntdUI.Tabs();
            this.tabPage_Home = new AntdUI.TabPage();
            this.tabPage_Download = new AntdUI.TabPage();
            this.tabPage_Settings = new AntdUI.TabPage();
            this.tabPage_About = new AntdUI.TabPage();
            this.tabs_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageHeader
            // 
            this.pageHeader.HandCursor = System.Windows.Forms.Cursors.Default;
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.MaximizeBox = false;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowButton = true;
            this.pageHeader.ShowIcon = true;
            this.pageHeader.Size = new System.Drawing.Size(750, 30);
            this.pageHeader.TabIndex = 0;
            this.pageHeader.Text = "Main_Window";
            // 
            // tabs_Main
            // 
            this.tabs_Main.Centered = true;
            this.tabs_Main.Controls.Add(this.tabPage_Home);
            this.tabs_Main.Controls.Add(this.tabPage_Download);
            this.tabs_Main.Controls.Add(this.tabPage_Settings);
            this.tabs_Main.Controls.Add(this.tabPage_About);
            this.tabs_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs_Main.HandCursor = System.Windows.Forms.Cursors.Default;
            this.tabs_Main.Location = new System.Drawing.Point(0, 30);
            this.tabs_Main.Name = "tabs_Main";
            this.tabs_Main.Pages.Add(this.tabPage_Home);
            this.tabs_Main.Pages.Add(this.tabPage_Download);
            this.tabs_Main.Pages.Add(this.tabPage_Settings);
            this.tabs_Main.Pages.Add(this.tabPage_About);
            this.tabs_Main.Size = new System.Drawing.Size(750, 370);
            this.tabs_Main.Style = styleCard1;
            this.tabs_Main.TabIndex = 1;
            this.tabs_Main.Type = AntdUI.TabType.Card;
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Location = new System.Drawing.Point(3, 29);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Size = new System.Drawing.Size(744, 338);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "主页";
            // 
            // tabPage_Download
            // 
            this.tabPage_Download.Location = new System.Drawing.Point(0, 0);
            this.tabPage_Download.Name = "tabPage_Download";
            this.tabPage_Download.Size = new System.Drawing.Size(0, 0);
            this.tabPage_Download.TabIndex = 1;
            this.tabPage_Download.Text = "下载中心";
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Location = new System.Drawing.Point(0, 0);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(0, 0);
            this.tabPage_Settings.TabIndex = 2;
            this.tabPage_Settings.Text = "设置";
            // 
            // tabPage_About
            // 
            this.tabPage_About.Location = new System.Drawing.Point(0, 0);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Size = new System.Drawing.Size(0, 0);
            this.tabPage_About.TabIndex = 3;
            this.tabPage_About.Text = "关于";
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.tabs_Main);
            this.Controls.Add(this.pageHeader);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Window";
            this.Text = "Main_Window";
            this.tabs_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Tabs tabs_Main;
        private AntdUI.TabPage tabPage_Home;
        private AntdUI.TabPage tabPage_Download;
        private AntdUI.TabPage tabPage_Settings;
        private AntdUI.TabPage tabPage_About;
    }
}

