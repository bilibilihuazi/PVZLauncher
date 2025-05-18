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
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            AntdUI.Tabs.StyleCard styleCard1 = new AntdUI.Tabs.StyleCard();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.pageHeader = new AntdUI.PageHeader();
            this.tabs_Main = new AntdUI.Tabs();
            this.timer_Main = new System.Windows.Forms.Timer(this.components);
            this.timer_PlayTime = new System.Windows.Forms.Timer(this.components);
            this.tabPage_Home = new AntdUI.TabPage();
            this.button_LaunchTrainer = new AntdUI.Button();
            this.pictureBox_Home_Title = new System.Windows.Forms.PictureBox();
            this.button_GameSettings = new AntdUI.Button();
            this.button_SelectGame = new AntdUI.Button();
            this.label_Home_Gamename = new AntdUI.Label();
            this.button_Launch = new AntdUI.Button();
            this.tabPage_Settings = new AntdUI.TabPage();
            this.tabPage_About = new AntdUI.TabPage();
            this.button_About_Bilibili = new AntdUI.Button();
            this.button_About_Github = new AntdUI.Button();
            this.label_About_info4 = new AntdUI.Label();
            this.pictureBox_About_Egg = new System.Windows.Forms.PictureBox();
            this.label_About_info3 = new AntdUI.Label();
            this.label_About_info2 = new AntdUI.Label();
            this.label_About_info1 = new AntdUI.Label();
            this.pictureBox_About_Icon = new System.Windows.Forms.PictureBox();
            this.pictureBox_About_Background = new System.Windows.Forms.PictureBox();
            this.tabs1 = new AntdUI.Tabs();
            this.button_Settings_RemoveSave = new AntdUI.Button();
            this.label_Settings_Saves = new AntdUI.Label();
            this.button_Settings_TotalSave = new AntdUI.Button();
            this.panel_Settings_Saves = new AntdUI.Panel();
            this.label_Settings_Trainer = new AntdUI.Label();
            this.switch_Settings_TrainerWithGame = new AntdUI.Switch();
            this.label_Settings_TrainerWithGame = new AntdUI.Label();
            this.panel_Settings_Trainer = new AntdUI.Panel();
            this.label_Launcher = new AntdUI.Label();
            this.label_Launcher_Ld = new AntdUI.Label();
            this.panel_Launcher = new AntdUI.Panel();
            this.tabs_Settings = new AntdUI.Tabs();
            this.tabPage_Save = new AntdUI.TabPage();
            this.tabPage_Trainer = new AntdUI.TabPage();
            this.tabPage_Launcher = new AntdUI.TabPage();
            this.select_Launcher_Ld = new AntdUI.Select();
            this.tabs_Main.SuspendLayout();
            this.tabPage_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Home_Title)).BeginInit();
            this.tabPage_Settings.SuspendLayout();
            this.tabPage_About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About_Egg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About_Background)).BeginInit();
            this.panel_Settings_Saves.SuspendLayout();
            this.panel_Settings_Trainer.SuspendLayout();
            this.panel_Launcher.SuspendLayout();
            this.tabs_Settings.SuspendLayout();
            this.tabPage_Save.SuspendLayout();
            this.tabPage_Trainer.SuspendLayout();
            this.tabPage_Launcher.SuspendLayout();
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
            this.tabs_Main.Controls.Add(this.tabPage_Settings);
            this.tabs_Main.Controls.Add(this.tabPage_About);
            this.tabs_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs_Main.HandCursor = System.Windows.Forms.Cursors.Default;
            this.tabs_Main.Location = new System.Drawing.Point(0, 30);
            this.tabs_Main.Name = "tabs_Main";
            this.tabs_Main.Pages.Add(this.tabPage_Home);
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
            // timer_PlayTime
            // 
            this.timer_PlayTime.Interval = 1000;
            this.timer_PlayTime.Tick += new System.EventHandler(this.timer_PlayTime_Tick);
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Controls.Add(this.button_LaunchTrainer);
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
            // button_LaunchTrainer
            // 
            this.button_LaunchTrainer.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_LaunchTrainer.Icon = global::PVZLauncher.Properties.Resources.PvzToolkit;
            this.button_LaunchTrainer.IconRatio = 1F;
            this.button_LaunchTrainer.Location = new System.Drawing.Point(249, 286);
            this.button_LaunchTrainer.Name = "button_LaunchTrainer";
            this.button_LaunchTrainer.Size = new System.Drawing.Size(246, 46);
            this.button_LaunchTrainer.TabIndex = 6;
            this.button_LaunchTrainer.Text = "启动修改器";
            this.button_LaunchTrainer.Type = AntdUI.TTypeMini.Success;
            this.button_LaunchTrainer.Click += new System.EventHandler(this.button_LaunchTrainer_Click);
            // 
            // pictureBox_Home_Title
            // 
            this.pictureBox_Home_Title.BackColor = System.Drawing.Color.Transparent;
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
            this.button_GameSettings.Location = new System.Drawing.Point(501, 286);
            this.button_GameSettings.Name = "button_GameSettings";
            this.button_GameSettings.Size = new System.Drawing.Size(139, 46);
            this.button_GameSettings.TabIndex = 4;
            this.button_GameSettings.Text = "版本设置";
            this.button_GameSettings.Type = AntdUI.TTypeMini.Info;
            this.button_GameSettings.Click += new System.EventHandler(this.button_GameSettings_Click);
            // 
            // button_SelectGame
            // 
            this.button_SelectGame.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_SelectGame.Icon = global::PVZLauncher.Properties.Resources.select;
            this.button_SelectGame.IconRatio = 1F;
            this.button_SelectGame.Location = new System.Drawing.Point(104, 286);
            this.button_SelectGame.Name = "button_SelectGame";
            this.button_SelectGame.Size = new System.Drawing.Size(139, 46);
            this.button_SelectGame.TabIndex = 3;
            this.button_SelectGame.Text = "选择版本";
            this.button_SelectGame.Type = AntdUI.TTypeMini.Info;
            this.button_SelectGame.Click += new System.EventHandler(this.button_SelectGame_Click);
            // 
            // label_Home_Gamename
            // 
            this.label_Home_Gamename.BackColor = System.Drawing.Color.Transparent;
            this.label_Home_Gamename.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_Home_Gamename.Location = new System.Drawing.Point(104, 184);
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
            this.button_Launch.Location = new System.Drawing.Point(249, 213);
            this.button_Launch.Name = "button_Launch";
            this.button_Launch.Size = new System.Drawing.Size(246, 69);
            this.button_Launch.TabIndex = 0;
            this.button_Launch.Text = "启动游戏";
            this.button_Launch.Type = AntdUI.TTypeMini.Success;
            this.button_Launch.Click += new System.EventHandler(this.button_Launch_Click);
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Controls.Add(this.tabs1);
            this.tabPage_Settings.Controls.Add(this.tabs_Settings);
            this.tabPage_Settings.Icon = global::PVZLauncher.Properties.Resources.settings;
            this.tabPage_Settings.Location = new System.Drawing.Point(-744, -335);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(744, 335);
            this.tabPage_Settings.TabIndex = 2;
            this.tabPage_Settings.Text = "设置";
            // 
            // tabPage_About
            // 
            this.tabPage_About.Controls.Add(this.button_About_Bilibili);
            this.tabPage_About.Controls.Add(this.button_About_Github);
            this.tabPage_About.Controls.Add(this.label_About_info4);
            this.tabPage_About.Controls.Add(this.pictureBox_About_Egg);
            this.tabPage_About.Controls.Add(this.label_About_info3);
            this.tabPage_About.Controls.Add(this.label_About_info2);
            this.tabPage_About.Controls.Add(this.label_About_info1);
            this.tabPage_About.Controls.Add(this.pictureBox_About_Icon);
            this.tabPage_About.Controls.Add(this.pictureBox_About_Background);
            this.tabPage_About.Icon = global::PVZLauncher.Properties.Resources.about;
            this.tabPage_About.Location = new System.Drawing.Point(-744, -335);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Size = new System.Drawing.Size(744, 335);
            this.tabPage_About.TabIndex = 3;
            this.tabPage_About.Text = "关于";
            // 
            // button_About_Bilibili
            // 
            this.button_About_Bilibili.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(166)))), ((int)(((byte)(216)))));
            this.button_About_Bilibili.ForeColor = System.Drawing.Color.White;
            this.button_About_Bilibili.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_About_Bilibili.Icon = global::PVZLauncher.Properties.Resources.bilibili;
            this.button_About_Bilibili.IconRatio = 1F;
            this.button_About_Bilibili.Location = new System.Drawing.Point(269, 68);
            this.button_About_Bilibili.Name = "button_About_Bilibili";
            this.button_About_Bilibili.Size = new System.Drawing.Size(120, 35);
            this.button_About_Bilibili.TabIndex = 7;
            this.button_About_Bilibili.Text = "Bilibili";
            this.button_About_Bilibili.Click += new System.EventHandler(this.button_About_Bilibili_Click);
            // 
            // button_About_Github
            // 
            this.button_About_Github.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_About_Github.ForeColor = System.Drawing.Color.White;
            this.button_About_Github.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_About_Github.Icon = global::PVZLauncher.Properties.Resources.github;
            this.button_About_Github.IconRatio = 1F;
            this.button_About_Github.Location = new System.Drawing.Point(143, 68);
            this.button_About_Github.Name = "button_About_Github";
            this.button_About_Github.Size = new System.Drawing.Size(120, 35);
            this.button_About_Github.TabIndex = 6;
            this.button_About_Github.Text = "Github";
            this.button_About_Github.Click += new System.EventHandler(this.button_About_Github_Click);
            // 
            // label_About_info4
            // 
            this.label_About_info4.Location = new System.Drawing.Point(9, 309);
            this.label_About_info4.Name = "label_About_info4";
            this.label_About_info4.Size = new System.Drawing.Size(301, 23);
            this.label_About_info4.TabIndex = 5;
            this.label_About_info4.Text = "华某人 版权所有 ©2024~2025 盗版必究";
            // 
            // pictureBox_About_Egg
            // 
            this.pictureBox_About_Egg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_About_Egg.Image = global::PVZLauncher.Properties.Resources.PvZ_Logo;
            this.pictureBox_About_Egg.Location = new System.Drawing.Point(9, 254);
            this.pictureBox_About_Egg.Name = "pictureBox_About_Egg";
            this.pictureBox_About_Egg.Size = new System.Drawing.Size(100, 20);
            this.pictureBox_About_Egg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_About_Egg.TabIndex = 4;
            this.pictureBox_About_Egg.TabStop = false;
            this.pictureBox_About_Egg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_About_info3
            // 
            this.label_About_info3.Location = new System.Drawing.Point(9, 280);
            this.label_About_info3.Name = "label_About_info3";
            this.label_About_info3.Size = new System.Drawing.Size(393, 23);
            this.label_About_info3.TabIndex = 3;
            this.label_About_info3.Text = "UNKNOWN";
            // 
            // label_About_info2
            // 
            this.label_About_info2.Location = new System.Drawing.Point(143, 39);
            this.label_About_info2.Name = "label_About_info2";
            this.label_About_info2.Size = new System.Drawing.Size(289, 23);
            this.label_About_info2.TabIndex = 2;
            this.label_About_info2.Text = "一款可以下载、管理、启动植物大战僵尸的启动器";
            // 
            // label_About_info1
            // 
            this.label_About_info1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_About_info1.Location = new System.Drawing.Point(143, 3);
            this.label_About_info1.Name = "label_About_info1";
            this.label_About_info1.Size = new System.Drawing.Size(304, 30);
            this.label_About_info1.TabIndex = 1;
            this.label_About_info1.Text = "Plants Vs. Zombies Launcher";
            // 
            // pictureBox_About_Icon
            // 
            this.pictureBox_About_Icon.Image = global::PVZLauncher.Properties.Resources.icon;
            this.pictureBox_About_Icon.Location = new System.Drawing.Point(9, 3);
            this.pictureBox_About_Icon.Name = "pictureBox_About_Icon";
            this.pictureBox_About_Icon.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_About_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_About_Icon.TabIndex = 0;
            this.pictureBox_About_Icon.TabStop = false;
            // 
            // pictureBox_About_Background
            // 
            this.pictureBox_About_Background.Image = global::PVZLauncher.Properties.Resources.titlescreen;
            this.pictureBox_About_Background.Location = new System.Drawing.Point(453, 3);
            this.pictureBox_About_Background.Name = "pictureBox_About_Background";
            this.pictureBox_About_Background.Size = new System.Drawing.Size(294, 335);
            this.pictureBox_About_Background.TabIndex = 8;
            this.pictureBox_About_Background.TabStop = false;
            // 
            // tabs1
            // 
            this.tabs1.Location = new System.Drawing.Point(9, 256);
            this.tabs1.Name = "tabs1";
            this.tabs1.Size = new System.Drawing.Size(329, 48);
            this.tabs1.Style = styleLine1;
            this.tabs1.TabIndex = 4;
            this.tabs1.Text = "tabs1";
            // 
            // button_Settings_RemoveSave
            // 
            this.button_Settings_RemoveSave.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Settings_RemoveSave.Icon = global::PVZLauncher.Properties.Resources.delete;
            this.button_Settings_RemoveSave.IconRatio = 1F;
            this.button_Settings_RemoveSave.Location = new System.Drawing.Point(5, 29);
            this.button_Settings_RemoveSave.Name = "button_Settings_RemoveSave";
            this.button_Settings_RemoveSave.Size = new System.Drawing.Size(154, 45);
            this.button_Settings_RemoveSave.TabIndex = 0;
            this.button_Settings_RemoveSave.Text = "删除存档";
            this.button_Settings_RemoveSave.Type = AntdUI.TTypeMini.Error;
            this.button_Settings_RemoveSave.Click += new System.EventHandler(this.button_Settings_RemoveSave_Click);
            // 
            // label_Settings_Saves
            // 
            this.label_Settings_Saves.BackColor = System.Drawing.Color.Transparent;
            this.label_Settings_Saves.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Settings_Saves.Location = new System.Drawing.Point(5, 0);
            this.label_Settings_Saves.Name = "label_Settings_Saves";
            this.label_Settings_Saves.Size = new System.Drawing.Size(75, 23);
            this.label_Settings_Saves.TabIndex = 1;
            this.label_Settings_Saves.Text = "存档管理";
            // 
            // button_Settings_TotalSave
            // 
            this.button_Settings_TotalSave.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Settings_TotalSave.Icon = global::PVZLauncher.Properties.Resources.victroy;
            this.button_Settings_TotalSave.IconRatio = 1F;
            this.button_Settings_TotalSave.Location = new System.Drawing.Point(165, 29);
            this.button_Settings_TotalSave.Name = "button_Settings_TotalSave";
            this.button_Settings_TotalSave.Size = new System.Drawing.Size(154, 45);
            this.button_Settings_TotalSave.TabIndex = 2;
            this.button_Settings_TotalSave.Text = "一键通关";
            this.button_Settings_TotalSave.Type = AntdUI.TTypeMini.Success;
            this.button_Settings_TotalSave.Click += new System.EventHandler(this.button_Settings_TotalSave_Click);
            // 
            // panel_Settings_Saves
            // 
            this.panel_Settings_Saves.Controls.Add(this.button_Settings_TotalSave);
            this.panel_Settings_Saves.Controls.Add(this.label_Settings_Saves);
            this.panel_Settings_Saves.Controls.Add(this.button_Settings_RemoveSave);
            this.panel_Settings_Saves.Location = new System.Drawing.Point(3, 3);
            this.panel_Settings_Saves.Name = "panel_Settings_Saves";
            this.panel_Settings_Saves.Size = new System.Drawing.Size(641, 82);
            this.panel_Settings_Saves.TabIndex = 1;
            this.panel_Settings_Saves.Text = "panel1";
            // 
            // label_Settings_Trainer
            // 
            this.label_Settings_Trainer.BackColor = System.Drawing.Color.Transparent;
            this.label_Settings_Trainer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Settings_Trainer.Location = new System.Drawing.Point(5, 0);
            this.label_Settings_Trainer.Name = "label_Settings_Trainer";
            this.label_Settings_Trainer.Size = new System.Drawing.Size(75, 23);
            this.label_Settings_Trainer.TabIndex = 1;
            this.label_Settings_Trainer.Text = "修改器";
            // 
            // switch_Settings_TrainerWithGame
            // 
            this.switch_Settings_TrainerWithGame.BackColor = System.Drawing.Color.Transparent;
            this.switch_Settings_TrainerWithGame.HandCursor = System.Windows.Forms.Cursors.Default;
            this.switch_Settings_TrainerWithGame.Location = new System.Drawing.Point(5, 29);
            this.switch_Settings_TrainerWithGame.Name = "switch_Settings_TrainerWithGame";
            this.switch_Settings_TrainerWithGame.Size = new System.Drawing.Size(40, 23);
            this.switch_Settings_TrainerWithGame.TabIndex = 2;
            this.switch_Settings_TrainerWithGame.CheckedChanged += new AntdUI.BoolEventHandler(this.switch_Settings_TrainerWithGame_CheckedChanged);
            // 
            // label_Settings_TrainerWithGame
            // 
            this.label_Settings_TrainerWithGame.BackColor = System.Drawing.Color.Transparent;
            this.label_Settings_TrainerWithGame.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_Settings_TrainerWithGame.Location = new System.Drawing.Point(51, 29);
            this.label_Settings_TrainerWithGame.Name = "label_Settings_TrainerWithGame";
            this.label_Settings_TrainerWithGame.Size = new System.Drawing.Size(113, 23);
            this.label_Settings_TrainerWithGame.TabIndex = 3;
            this.label_Settings_TrainerWithGame.Text = "修改器随游戏启动";
            // 
            // panel_Settings_Trainer
            // 
            this.panel_Settings_Trainer.Controls.Add(this.label_Settings_TrainerWithGame);
            this.panel_Settings_Trainer.Controls.Add(this.switch_Settings_TrainerWithGame);
            this.panel_Settings_Trainer.Controls.Add(this.label_Settings_Trainer);
            this.panel_Settings_Trainer.Location = new System.Drawing.Point(3, 3);
            this.panel_Settings_Trainer.Name = "panel_Settings_Trainer";
            this.panel_Settings_Trainer.Size = new System.Drawing.Size(641, 70);
            this.panel_Settings_Trainer.TabIndex = 2;
            // 
            // label_Launcher
            // 
            this.label_Launcher.BackColor = System.Drawing.Color.Transparent;
            this.label_Launcher.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Launcher.Location = new System.Drawing.Point(5, 0);
            this.label_Launcher.Name = "label_Launcher";
            this.label_Launcher.Size = new System.Drawing.Size(75, 23);
            this.label_Launcher.TabIndex = 1;
            this.label_Launcher.Text = "启动器";
            // 
            // label_Launcher_Ld
            // 
            this.label_Launcher_Ld.BackColor = System.Drawing.Color.Transparent;
            this.label_Launcher_Ld.Location = new System.Drawing.Point(5, 29);
            this.label_Launcher_Ld.Name = "label_Launcher_Ld";
            this.label_Launcher_Ld.Size = new System.Drawing.Size(124, 27);
            this.label_Launcher_Ld.TabIndex = 2;
            this.label_Launcher_Ld.Text = "游戏启动后，启动器:";
            // 
            // panel_Launcher
            // 
            this.panel_Launcher.Controls.Add(this.select_Launcher_Ld);
            this.panel_Launcher.Controls.Add(this.label_Launcher_Ld);
            this.panel_Launcher.Controls.Add(this.label_Launcher);
            this.panel_Launcher.Location = new System.Drawing.Point(3, 3);
            this.panel_Launcher.Name = "panel_Launcher";
            this.panel_Launcher.Size = new System.Drawing.Size(641, 70);
            this.panel_Launcher.TabIndex = 3;
            // 
            // tabs_Settings
            // 
            this.tabs_Settings.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabs_Settings.Controls.Add(this.tabPage_Save);
            this.tabs_Settings.Controls.Add(this.tabPage_Trainer);
            this.tabs_Settings.Controls.Add(this.tabPage_Launcher);
            this.tabs_Settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs_Settings.HandCursor = System.Windows.Forms.Cursors.Default;
            this.tabs_Settings.IconRatio = 1F;
            this.tabs_Settings.Location = new System.Drawing.Point(0, 0);
            this.tabs_Settings.Name = "tabs_Settings";
            this.tabs_Settings.Pages.Add(this.tabPage_Save);
            this.tabs_Settings.Pages.Add(this.tabPage_Trainer);
            this.tabs_Settings.Pages.Add(this.tabPage_Launcher);
            this.tabs_Settings.Size = new System.Drawing.Size(745, 335);
            this.tabs_Settings.Style = styleCard1;
            this.tabs_Settings.TabIndex = 5;
            this.tabs_Settings.Type = AntdUI.TabType.Card;
            // 
            // tabPage_Save
            // 
            this.tabPage_Save.Controls.Add(this.panel_Settings_Saves);
            this.tabPage_Save.Icon = global::PVZLauncher.Properties.Resources.save;
            this.tabPage_Save.Location = new System.Drawing.Point(91, 3);
            this.tabPage_Save.Name = "tabPage_Save";
            this.tabPage_Save.Size = new System.Drawing.Size(651, 329);
            this.tabPage_Save.TabIndex = 0;
            this.tabPage_Save.Text = "存档管理";
            // 
            // tabPage_Trainer
            // 
            this.tabPage_Trainer.Controls.Add(this.panel_Settings_Trainer);
            this.tabPage_Trainer.Icon = global::PVZLauncher.Properties.Resources.PvzToolkit_;
            this.tabPage_Trainer.Location = new System.Drawing.Point(0, 0);
            this.tabPage_Trainer.Name = "tabPage_Trainer";
            this.tabPage_Trainer.Size = new System.Drawing.Size(0, 0);
            this.tabPage_Trainer.TabIndex = 1;
            this.tabPage_Trainer.Text = "修改器";
            // 
            // tabPage_Launcher
            // 
            this.tabPage_Launcher.Controls.Add(this.panel_Launcher);
            this.tabPage_Launcher.Icon = global::PVZLauncher.Properties.Resources.icon;
            this.tabPage_Launcher.Location = new System.Drawing.Point(0, 0);
            this.tabPage_Launcher.Name = "tabPage_Launcher";
            this.tabPage_Launcher.Size = new System.Drawing.Size(0, 0);
            this.tabPage_Launcher.TabIndex = 2;
            this.tabPage_Launcher.Text = "启动器";
            // 
            // select_Launcher_Ld
            // 
            this.select_Launcher_Ld.HandCursor = System.Windows.Forms.Cursors.Default;
            this.select_Launcher_Ld.Items.AddRange(new object[] {
            "不执行任何操作",
            "退出",
            "隐藏，等待游戏结束，结束后启动器显示"});
            this.select_Launcher_Ld.List = true;
            this.select_Launcher_Ld.ListAutoWidth = true;
            this.select_Launcher_Ld.Location = new System.Drawing.Point(122, 26);
            this.select_Launcher_Ld.Name = "select_Launcher_Ld";
            this.select_Launcher_Ld.SelectedIndex = 0;
            this.select_Launcher_Ld.SelectedValue = "不执行任何操作";
            this.select_Launcher_Ld.Size = new System.Drawing.Size(251, 30);
            this.select_Launcher_Ld.TabIndex = 3;
            this.select_Launcher_Ld.Text = "不执行任何操作";
            this.select_Launcher_Ld.SelectedIndexChanged += new AntdUI.IntEventHandler(this.select_Launcher_Ld_SelectedIndexChanged);
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
            this.tabPage_Settings.ResumeLayout(false);
            this.tabPage_About.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About_Egg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About_Background)).EndInit();
            this.panel_Settings_Saves.ResumeLayout(false);
            this.panel_Settings_Trainer.ResumeLayout(false);
            this.panel_Launcher.ResumeLayout(false);
            this.tabs_Settings.ResumeLayout(false);
            this.tabPage_Save.ResumeLayout(false);
            this.tabPage_Trainer.ResumeLayout(false);
            this.tabPage_Launcher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Tabs tabs_Main;
        private AntdUI.TabPage tabPage_Home;
        private AntdUI.TabPage tabPage_Settings;
        private AntdUI.TabPage tabPage_About;
        private AntdUI.Button button_Launch;
        private AntdUI.Button button_GameSettings;
        private AntdUI.Button button_SelectGame;
        private System.Windows.Forms.PictureBox pictureBox_Home_Title;
        private AntdUI.Label label_Home_Gamename;
        private System.Windows.Forms.Timer timer_Main;
        private AntdUI.Label label_About_info3;
        private AntdUI.Label label_About_info2;
        private AntdUI.Label label_About_info1;
        private System.Windows.Forms.PictureBox pictureBox_About_Icon;
        private System.Windows.Forms.PictureBox pictureBox_About_Egg;
        private AntdUI.Label label_About_info4;
        private AntdUI.Button button_LaunchTrainer;
        private AntdUI.Button button_About_Github;
        private AntdUI.Button button_About_Bilibili;
        private System.Windows.Forms.PictureBox pictureBox_About_Background;
        private System.Windows.Forms.Timer timer_PlayTime;
        private AntdUI.Tabs tabs1;
        private AntdUI.Tabs tabs_Settings;
        private AntdUI.TabPage tabPage_Save;
        private AntdUI.Panel panel_Settings_Saves;
        private AntdUI.Button button_Settings_TotalSave;
        private AntdUI.Label label_Settings_Saves;
        private AntdUI.Button button_Settings_RemoveSave;
        private AntdUI.TabPage tabPage_Trainer;
        private AntdUI.Panel panel_Settings_Trainer;
        private AntdUI.Label label_Settings_TrainerWithGame;
        private AntdUI.Switch switch_Settings_TrainerWithGame;
        private AntdUI.Label label_Settings_Trainer;
        private AntdUI.TabPage tabPage_Launcher;
        private AntdUI.Panel panel_Launcher;
        private AntdUI.Label label_Launcher_Ld;
        private AntdUI.Label label_Launcher;
        private AntdUI.Select select_Launcher_Ld;
    }
}

