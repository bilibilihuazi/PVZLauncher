namespace PVZLauncher
{
    partial class SelectGame_Window
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
            this.pageHeader = new AntdUI.PageHeader();
            this.button_Load = new AntdUI.Button();
            this.button_Refresh = new AntdUI.Button();
            this.ListBox = new ReaLTaiizor.Controls.MaterialListBox();
            this.button_Done = new AntdUI.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_Cancel = new AntdUI.Button();
            this.image3D_GameIcon = new AntdUI.Image3D();
            this.label_Gameinfo1 = new AntdUI.Label();
            this.pageHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.Add(this.button_Load);
            this.pageHeader.Controls.Add(this.button_Refresh);
            this.pageHeader.HandCursor = System.Windows.Forms.Cursors.Default;
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pageHeader.MaximizeBox = false;
            this.pageHeader.MinimizeBox = false;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowButton = true;
            this.pageHeader.Size = new System.Drawing.Size(611, 30);
            this.pageHeader.TabIndex = 0;
            this.pageHeader.Text = "选择版本";
            // 
            // button_Load
            // 
            this.button_Load.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Load.Icon = global::PVZLauncher.Properties.Resources.folder;
            this.button_Load.IconRatio = 0.8F;
            this.button_Load.Location = new System.Drawing.Point(381, 0);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(128, 30);
            this.button_Load.TabIndex = 6;
            this.button_Load.Text = "导入";
            this.button_Load.Type = AntdUI.TTypeMini.Warn;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Refresh.Icon = global::PVZLauncher.Properties.Resources.refresh;
            this.button_Refresh.IconRatio = 0.8F;
            this.button_Refresh.Location = new System.Drawing.Point(515, 0);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(30, 30);
            this.button_Refresh.TabIndex = 5;
            this.button_Refresh.Type = AntdUI.TTypeMini.Primary;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.White;
            this.ListBox.BorderColor = System.Drawing.Color.LightGray;
            this.ListBox.Depth = 0;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListBox.Location = new System.Drawing.Point(12, 37);
            this.ListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.ListBox.Name = "ListBox";
            this.ListBox.SelectedIndex = -1;
            this.ListBox.SelectedItem = null;
            this.ListBox.Size = new System.Drawing.Size(587, 321);
            this.ListBox.TabIndex = 1;
            this.ListBox.SelectedIndexChanged += new ReaLTaiizor.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // button_Done
            // 
            this.button_Done.Enabled = false;
            this.button_Done.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Done.Icon = global::PVZLauncher.Properties.Resources.done;
            this.button_Done.Location = new System.Drawing.Point(488, 364);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(111, 42);
            this.button_Done.TabIndex = 3;
            this.button_Done.Text = "确定";
            this.button_Done.Type = AntdUI.TTypeMini.Success;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "请选择含有可执行文件的游戏目录";
            // 
            // button_Cancel
            // 
            this.button_Cancel.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Cancel.Icon = global::PVZLauncher.Properties.Resources.cancel;
            this.button_Cancel.Location = new System.Drawing.Point(371, 364);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(111, 42);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.Type = AntdUI.TTypeMini.Error;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // image3D_GameIcon
            // 
            this.image3D_GameIcon.HandCursor = System.Windows.Forms.Cursors.Default;
            this.image3D_GameIcon.Image = global::PVZLauncher.Properties.Resources.icon;
            this.image3D_GameIcon.Location = new System.Drawing.Point(12, 364);
            this.image3D_GameIcon.Name = "image3D_GameIcon";
            this.image3D_GameIcon.Size = new System.Drawing.Size(42, 42);
            this.image3D_GameIcon.TabIndex = 2;
            // 
            // label_Gameinfo1
            // 
            this.label_Gameinfo1.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_Gameinfo1.Location = new System.Drawing.Point(60, 364);
            this.label_Gameinfo1.Name = "label_Gameinfo1";
            this.label_Gameinfo1.Size = new System.Drawing.Size(305, 23);
            this.label_Gameinfo1.TabIndex = 5;
            this.label_Gameinfo1.Text = "请选择游戏";
            // 
            // SelectGame_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(611, 414);
            this.Controls.Add(this.label_Gameinfo1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.image3D_GameIcon);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.pageHeader);
            this.EnableHitTest = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(611, 414);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(611, 414);
            this.Name = "SelectGame_Window";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectGame_Window";
            this.Load += new System.EventHandler(this.SelectGame_Window_Load);
            this.pageHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private ReaLTaiizor.Controls.MaterialListBox ListBox;
        private AntdUI.Image3D image3D_GameIcon;
        private AntdUI.Button button_Done;
        private AntdUI.Button button_Cancel;
        private AntdUI.Button button_Refresh;
        private AntdUI.Button button_Load;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private AntdUI.Label label_Gameinfo1;
    }
}