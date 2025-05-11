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
            this.components = new System.ComponentModel.Container();
            AntdUI.Tabs.StyleCard2 styleCard21 = new AntdUI.Tabs.StyleCard2();
            AntdUI.Tabs.StyleCard styleCard1 = new AntdUI.Tabs.StyleCard();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.pageHeader = new AntdUI.PageHeader();
            this.tabs_Main = new AntdUI.Tabs();
            this.timer_Main = new System.Windows.Forms.Timer(this.components);
            this.tabPage_Home = new AntdUI.TabPage();
            this.pictureBox_Home_Title = new System.Windows.Forms.PictureBox();
            this.button_GameSettings = new AntdUI.Button();
            this.button_SelectGame = new AntdUI.Button();
            this.label_Home_Gamename = new AntdUI.Label();
            this.button_Launch = new AntdUI.Button();
            this.tabPage_Download = new AntdUI.TabPage();
            this.tabs_Download = new AntdUI.Tabs();
            this.tabPage_Game = new AntdUI.TabPage();
            this.tabPage_Cheater = new AntdUI.TabPage();
            this.tabPage_Settings = new AntdUI.TabPage();
            this.tabPage_About = new AntdUI.TabPage();
            this.tabs_Main.SuspendLayout();
            this.tabPage_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Home_Title)).BeginInit();
            this.tabPage_Download.SuspendLayout();
            this.tabs_Download.SuspendLayout();
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
            this.tabs_Main.SelectedIndexChanged += new AntdUI.IntEventHandler(this.tabs_Main_SelectedIndexChanged);
            // 
            // timer_Main
            // 
            this.timer_Main.Enabled = true;
            this.timer_Main.Interval = 1;
            this.timer_Main.Tick += new System.EventHandler(this.timer_Main_Tick);
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Controls.Add(this.pictureBox_Home_Title);
            this.tabPage_Home.Controls.Add(this.button_GameSettings);
            this.tabPage_Home.Controls.Add(this.button_SelectGame);
            this.tabPage_Home.Controls.Add(this.label_Home_Gamename);
            this.tabPage_Home.Controls.Add(this.button_Launch);
            this.tabPage_Home.Icon = global::PVZLauncher.Properties.Resources.home;
            this.tabPage_Home.Location = new System.Drawing.Point(3, 32);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Size = new System.Drawing.Size(744, 335);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "主页";
            // 
            // pictureBox_Home_Title
            // 
            this.pictureBox_Home_Title.Image = global::PVZLauncher.Properties.Resources.PvZ_Logo;
            this.pictureBox_Home_Title.Location = new System.Drawing.Point(163, 0);
            this.pictureBox_Home_Title.Name = "pictureBox_Home_Title";
            this.pictureBox_Home_Title.Size = new System.Drawing.Size(421, 75);
            this.pictureBox_Home_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Home_Title.TabIndex = 5;
            this.pictureBox_Home_Title.TabStop = false;
            // 
            // button_GameSettings
            // 
            this.button_GameSettings.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_GameSettings.Icon = global::PVZLauncher.Properties.Resources.settings_;
            this.button_GameSettings.IconRatio = 1F;
            this.button_GameSettings.Location = new System.Drawing.Point(501, 280);
            this.button_GameSettings.Name = "button_GameSettings";
            this.button_GameSettings.Size = new System.Drawing.Size(139, 46);
            this.button_GameSettings.TabIndex = 4;
            this.button_GameSettings.Text = "版本设置";
            this.button_GameSettings.Type = AntdUI.TTypeMini.Info;
            // 
            // button_SelectGame
            // 
            this.button_SelectGame.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_SelectGame.Icon = global::PVZLauncher.Properties.Resources.select;
            this.button_SelectGame.IconRatio = 1F;
            this.button_SelectGame.Location = new System.Drawing.Point(104, 280);
            this.button_SelectGame.Name = "button_SelectGame";
            this.button_SelectGame.Size = new System.Drawing.Size(139, 46);
            this.button_SelectGame.TabIndex = 3;
            this.button_SelectGame.Text = "选择版本";
            this.button_SelectGame.Type = AntdUI.TTypeMini.Info;
            this.button_SelectGame.Click += new System.EventHandler(this.button_SelectGame_Click);
            // 
            // label_Home_Gamename
            // 
            this.label_Home_Gamename.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_Home_Gamename.Location = new System.Drawing.Point(104, 228);
            this.label_Home_Gamename.Name = "label_Home_Gamename";
            this.label_Home_Gamename.Shadow = 10;
            this.label_Home_Gamename.Size = new System.Drawing.Size(536, 23);
            this.label_Home_Gamename.TabIndex = 1;
            this.label_Home_Gamename.Text = "当前版本:{GameName}";
            this.label_Home_Gamename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Launch
            // 
            this.button_Launch.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Launch.Icon = global::PVZLauncher.Properties.Resources.launch;
            this.button_Launch.IconRatio = 1F;
            this.button_Launch.Location = new System.Drawing.Point(249, 257);
            this.button_Launch.Name = "button_Launch";
            this.button_Launch.Size = new System.Drawing.Size(246, 69);
            this.button_Launch.TabIndex = 0;
            this.button_Launch.Text = "启动游戏";
            this.button_Launch.Type = AntdUI.TTypeMini.Success;
            this.button_Launch.Click += new System.EventHandler(this.button_Launch_Click);
            // 
            // tabPage_Download
            // 
            this.tabPage_Download.Controls.Add(this.tabs_Download);
            this.tabPage_Download.Icon = global::PVZLauncher.Properties.Resources.download;
            this.tabPage_Download.Location = new System.Drawing.Point(-744, -335);
            this.tabPage_Download.Name = "tabPage_Download";
            this.tabPage_Download.Size = new System.Drawing.Size(744, 335);
            this.tabPage_Download.TabIndex = 1;
            this.tabPage_Download.Text = "下载中心";
            // 
            // tabs_Download
            // 
            this.tabs_Download.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabs_Download.Controls.Add(this.tabPage_Game);
            this.tabs_Download.Controls.Add(this.tabPage_Cheater);
            this.tabs_Download.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs_Download.HandCursor = System.Windows.Forms.Cursors.Default;
            this.tabs_Download.Location = new System.Drawing.Point(0, 0);
            this.tabs_Download.Name = "tabs_Download";
            this.tabs_Download.Pages.Add(this.tabPage_Game);
            this.tabs_Download.Pages.Add(this.tabPage_Cheater);
            this.tabs_Download.Size = new System.Drawing.Size(747, 338);
            this.tabs_Download.Style = styleCard1;
            this.tabs_Download.TabIndex = 1;
            this.tabs_Download.Type = AntdUI.TabType.Card;
            // 
            // tabPage_Game
            // 
            this.tabPage_Game.Icon = global::PVZLauncher.Properties.Resources.game;
            this.tabPage_Game.Location = new System.Drawing.Point(97, 3);
            this.tabPage_Game.Name = "tabPage_Game";
            this.tabPage_Game.Size = new System.Drawing.Size(647, 332);
            this.tabPage_Game.TabIndex = 0;
            this.tabPage_Game.Text = "游戏下载";
            // 
            // tabPage_Cheater
            // 
            this.tabPage_Cheater.Icon = global::PVZLauncher.Properties.Resources.cheater;
            this.tabPage_Cheater.Location = new System.Drawing.Point(0, 0);
            this.tabPage_Cheater.Name = "tabPage_Cheater";
            this.tabPage_Cheater.Size = new System.Drawing.Size(0, 0);
            this.tabPage_Cheater.TabIndex = 1;
            this.tabPage_Cheater.Text = "修改器下载";
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
            this.EnableHitTest = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_Window";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.tabs_Main.ResumeLayout(false);
            this.tabPage_Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Home_Title)).EndInit();
            this.tabPage_Download.ResumeLayout(false);
            this.tabs_Download.ResumeLayout(false);
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
        private AntdUI.Button button_GameSettings;
        private AntdUI.Button button_SelectGame;
        private AntdUI.Tabs tabs_Download;
        private AntdUI.TabPage tabPage_Game;
        private AntdUI.TabPage tabPage_Cheater;
        private System.Windows.Forms.PictureBox pictureBox_Home_Title;
        private AntdUI.Label label_Home_Gamename;
        private System.Windows.Forms.Timer timer_Main;
    }
}

