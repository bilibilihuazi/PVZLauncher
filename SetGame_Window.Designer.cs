namespace PVZLauncher
{
    partial class SetGame_Window
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
            this.components = new System.ComponentModel.Container();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.label_GameName = new AntdUI.Label();
            this.label_GamePath = new AntdUI.Label();
            this.label_ExecuteName = new AntdUI.Label();
            this.input_ExecuteName = new AntdUI.Input();
            this.button_ExecuteName_Browser = new AntdUI.Button();
            this.button_OpenGameFoler = new AntdUI.Button();
            this.button_DeleteGame = new AntdUI.Button();
            this.button_SetName = new AntdUI.Button();
            this.image3D_GameIcon = new AntdUI.Image3D();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pageHeader1
            // 
            this.pageHeader1.HandCursor = System.Windows.Forms.Cursors.Default;
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.MaximizeBox = false;
            this.pageHeader1.MinimizeBox = false;
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.Size = new System.Drawing.Size(753, 30);
            this.pageHeader1.TabIndex = 0;
            this.pageHeader1.Text = "版本设置";
            // 
            // label_GameName
            // 
            this.label_GameName.Location = new System.Drawing.Point(113, 36);
            this.label_GameName.Name = "label_GameName";
            this.label_GameName.Size = new System.Drawing.Size(628, 23);
            this.label_GameName.TabIndex = 2;
            this.label_GameName.Text = "游戏名称:";
            // 
            // label_GamePath
            // 
            this.label_GamePath.Location = new System.Drawing.Point(113, 65);
            this.label_GamePath.Name = "label_GamePath";
            this.label_GamePath.Size = new System.Drawing.Size(628, 23);
            this.label_GamePath.TabIndex = 3;
            this.label_GamePath.Text = "游戏路径:";
            // 
            // label_ExecuteName
            // 
            this.label_ExecuteName.Location = new System.Drawing.Point(12, 137);
            this.label_ExecuteName.Name = "label_ExecuteName";
            this.label_ExecuteName.Size = new System.Drawing.Size(121, 30);
            this.label_ExecuteName.TabIndex = 6;
            this.label_ExecuteName.Text = "游戏可执行文件名称:";
            // 
            // input_ExecuteName
            // 
            this.input_ExecuteName.HandCursor = System.Windows.Forms.Cursors.Default;
            this.input_ExecuteName.Location = new System.Drawing.Point(139, 137);
            this.input_ExecuteName.Name = "input_ExecuteName";
            this.input_ExecuteName.Size = new System.Drawing.Size(497, 30);
            this.input_ExecuteName.TabIndex = 7;
            this.input_ExecuteName.Text = "Unknown";
            // 
            // button_ExecuteName_Browser
            // 
            this.button_ExecuteName_Browser.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_ExecuteName_Browser.Location = new System.Drawing.Point(642, 137);
            this.button_ExecuteName_Browser.Name = "button_ExecuteName_Browser";
            this.button_ExecuteName_Browser.Size = new System.Drawing.Size(99, 30);
            this.button_ExecuteName_Browser.TabIndex = 8;
            this.button_ExecuteName_Browser.Text = "浏览...";
            this.button_ExecuteName_Browser.Click += new System.EventHandler(this.button_ExecuteName_Browser_Click);
            // 
            // button_OpenGameFoler
            // 
            this.button_OpenGameFoler.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_OpenGameFoler.Icon = global::PVZLauncher.Properties.Resources.folder;
            this.button_OpenGameFoler.IconRatio = 0.8F;
            this.button_OpenGameFoler.Location = new System.Drawing.Point(271, 94);
            this.button_OpenGameFoler.Name = "button_OpenGameFoler";
            this.button_OpenGameFoler.Size = new System.Drawing.Size(185, 37);
            this.button_OpenGameFoler.TabIndex = 9;
            this.button_OpenGameFoler.Text = "打开游戏文件夹";
            this.button_OpenGameFoler.Type = AntdUI.TTypeMini.Primary;
            this.button_OpenGameFoler.Click += new System.EventHandler(this.button_OpenGameFoler_Click);
            // 
            // button_DeleteGame
            // 
            this.button_DeleteGame.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_DeleteGame.Icon = global::PVZLauncher.Properties.Resources.delete;
            this.button_DeleteGame.IconRatio = 0.8F;
            this.button_DeleteGame.Location = new System.Drawing.Point(462, 94);
            this.button_DeleteGame.Name = "button_DeleteGame";
            this.button_DeleteGame.Size = new System.Drawing.Size(152, 37);
            this.button_DeleteGame.TabIndex = 5;
            this.button_DeleteGame.Text = "删除游戏";
            this.button_DeleteGame.Type = AntdUI.TTypeMini.Error;
            this.button_DeleteGame.Click += new System.EventHandler(this.button_DeleteGame_Click);
            // 
            // button_SetName
            // 
            this.button_SetName.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_SetName.Icon = global::PVZLauncher.Properties.Resources.edit;
            this.button_SetName.IconRatio = 0.8F;
            this.button_SetName.Location = new System.Drawing.Point(113, 94);
            this.button_SetName.Name = "button_SetName";
            this.button_SetName.Size = new System.Drawing.Size(152, 37);
            this.button_SetName.TabIndex = 4;
            this.button_SetName.Text = "更改游戏名称";
            this.button_SetName.Type = AntdUI.TTypeMini.Primary;
            this.button_SetName.Click += new System.EventHandler(this.button_SetName_Click);
            // 
            // image3D_GameIcon
            // 
            this.image3D_GameIcon.HandCursor = System.Windows.Forms.Cursors.Default;
            this.image3D_GameIcon.Image = global::PVZLauncher.Properties.Resources.icon;
            this.image3D_GameIcon.Location = new System.Drawing.Point(12, 36);
            this.image3D_GameIcon.Name = "image3D_GameIcon";
            this.image3D_GameIcon.Size = new System.Drawing.Size(95, 95);
            this.image3D_GameIcon.TabIndex = 1;
            this.image3D_GameIcon.Text = "image3D1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "可执行文件|*.exe";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SetGame_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 381);
            this.Controls.Add(this.button_OpenGameFoler);
            this.Controls.Add(this.button_ExecuteName_Browser);
            this.Controls.Add(this.input_ExecuteName);
            this.Controls.Add(this.label_ExecuteName);
            this.Controls.Add(this.button_DeleteGame);
            this.Controls.Add(this.button_SetName);
            this.Controls.Add(this.label_GamePath);
            this.Controls.Add(this.label_GameName);
            this.Controls.Add(this.image3D_GameIcon);
            this.Controls.Add(this.pageHeader1);
            this.EnableHitTest = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(753, 381);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(753, 381);
            this.Name = "SetGame_Window";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetGame_Window";
            this.Load += new System.EventHandler(this.SetGame_Window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Image3D image3D_GameIcon;
        private AntdUI.Label label_GameName;
        private AntdUI.Label label_GamePath;
        private AntdUI.Button button_SetName;
        private AntdUI.Button button_DeleteGame;
        private AntdUI.Label label_ExecuteName;
        private AntdUI.Input input_ExecuteName;
        private AntdUI.Button button_ExecuteName_Browser;
        private AntdUI.Button button_OpenGameFoler;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
    }
}