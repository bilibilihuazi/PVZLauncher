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
            AntdUI.Tabs.StyleCard2 styleCard21 = new AntdUI.Tabs.StyleCard2();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.pageHeader = new AntdUI.PageHeader();
            this.tabs_Main = new AntdUI.Tabs();
            this.tabPage_Home = new AntdUI.TabPage();
            this.button3 = new AntdUI.Button();
            this.button_SelectGame = new AntdUI.Button();
            this.image3D_Home_Background = new AntdUI.Image3D();
            this.label_Home_Gamename = new AntdUI.Label();
            this.button_Launch = new AntdUI.Button();
            this.tabPage_Download = new AntdUI.TabPage();
            this.tabPage_Settings = new AntdUI.TabPage();
            this.tabPage_About = new AntdUI.TabPage();
            this.tabs_Main.SuspendLayout();
            this.tabPage_Home.SuspendLayout();
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
            styleCard21.Closable = AntdUI.Tabs.StyleCard2.CloseType.none;
            this.tabs_Main.Style = styleCard21;
            this.tabs_Main.TabIndex = 1;
            this.tabs_Main.Type = AntdUI.TabType.Card2;
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Controls.Add(this.button3);
            this.tabPage_Home.Controls.Add(this.button_SelectGame);
            this.tabPage_Home.Controls.Add(this.image3D_Home_Background);
            this.tabPage_Home.Controls.Add(this.label_Home_Gamename);
            this.tabPage_Home.Controls.Add(this.button_Launch);
            this.tabPage_Home.Icon = global::PVZLauncher.Properties.Resources.home;
            this.tabPage_Home.Location = new System.Drawing.Point(3, 32);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Size = new System.Drawing.Size(744, 335);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "主页";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "版本设置";
            this.button3.Type = AntdUI.TTypeMini.Info;
            // 
            // button_SelectGame
            // 
            this.button_SelectGame.Location = new System.Drawing.Point(344, 244);
            this.button_SelectGame.Name = "button_SelectGame";
            this.button_SelectGame.Size = new System.Drawing.Size(139, 46);
            this.button_SelectGame.TabIndex = 3;
            this.button_SelectGame.Text = "选择版本";
            this.button_SelectGame.Type = AntdUI.TTypeMini.Info;
            // 
            // image3D_Home_Background
            // 
            this.image3D_Home_Background.HandCursor = System.Windows.Forms.Cursors.Default;
            this.image3D_Home_Background.Image = global::PVZLauncher.Properties.Resources.bg1;
            this.image3D_Home_Background.Location = new System.Drawing.Point(0, 0);
            this.image3D_Home_Background.Name = "image3D_Home_Background";
            this.image3D_Home_Background.Radius = 10;
            this.image3D_Home_Background.Size = new System.Drawing.Size(746, 238);
            this.image3D_Home_Background.TabIndex = 2;
            // 
            // label_Home_Gamename
            // 
            this.label_Home_Gamename.Location = new System.Drawing.Point(489, 312);
            this.label_Home_Gamename.Name = "label_Home_Gamename";
            this.label_Home_Gamename.Shadow = 10;
            this.label_Home_Gamename.Size = new System.Drawing.Size(246, 23);
            this.label_Home_Gamename.TabIndex = 1;
            this.label_Home_Gamename.Text = "当前版本:{GameName}";
            // 
            // button_Launch
            // 
            this.button_Launch.Icon = global::PVZLauncher.Properties.Resources.launch;
            this.button_Launch.IconRatio = 1F;
            this.button_Launch.Location = new System.Drawing.Point(489, 244);
            this.button_Launch.Name = "button_Launch";
            this.button_Launch.Size = new System.Drawing.Size(246, 69);
            this.button_Launch.TabIndex = 0;
            this.button_Launch.Text = "启动游戏";
            this.button_Launch.Type = AntdUI.TTypeMini.Success;
            // 
            // tabPage_Download
            // 
            this.tabPage_Download.Icon = global::PVZLauncher.Properties.Resources.download;
            this.tabPage_Download.Location = new System.Drawing.Point(0, 0);
            this.tabPage_Download.Name = "tabPage_Download";
            this.tabPage_Download.Size = new System.Drawing.Size(0, 0);
            this.tabPage_Download.TabIndex = 1;
            this.tabPage_Download.Text = "下载中心";
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Icon = global::PVZLauncher.Properties.Resources.settings;
            this.tabPage_Settings.Location = new System.Drawing.Point(0, 0);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(0, 0);
            this.tabPage_Settings.TabIndex = 2;
            this.tabPage_Settings.Text = "设置";
            // 
            // tabPage_About
            // 
            this.tabPage_About.Icon = global::PVZLauncher.Properties.Resources.about;
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
            this.tabPage_Home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Tabs tabs_Main;
        private AntdUI.TabPage tabPage_Home;
        private AntdUI.TabPage tabPage_Download;
        private AntdUI.TabPage tabPage_Settings;
        private AntdUI.TabPage tabPage_About;
        private AntdUI.Button button_Launch;
        private AntdUI.Label label_Home_Gamename;
        private AntdUI.Image3D image3D_Home_Background;
        private AntdUI.Button button3;
        private AntdUI.Button button_SelectGame;
    }
}

