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
            this.ListBox = new ReaLTaiizor.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // pageHeader
            // 
            this.pageHeader.HandCursor = System.Windows.Forms.Cursors.Default;
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pageHeader.MaximizeBox = false;
            this.pageHeader.MinimizeBox = false;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowButton = true;
            this.pageHeader.Size = new System.Drawing.Size(773, 30);
            this.pageHeader.TabIndex = 0;
            this.pageHeader.Text = "选择版本";
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.White;
            this.ListBox.BorderColor = System.Drawing.Color.LightGray;
            this.ListBox.Depth = 0;
            this.ListBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListBox.Location = new System.Drawing.Point(12, 37);
            this.ListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.ListBox.Name = "ListBox";
            this.ListBox.SelectedIndex = -1;
            this.ListBox.SelectedItem = null;
            this.ListBox.Size = new System.Drawing.Size(749, 343);
            this.ListBox.TabIndex = 1;
            this.ListBox.SelectedIndexChanged += new ReaLTaiizor.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // SelectGame_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 418);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.pageHeader);
            this.EnableHitTest = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SelectGame_Window";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectGame_Window";
            this.Load += new System.EventHandler(this.SelectGame_Window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private ReaLTaiizor.Controls.MaterialListBox ListBox;
    }
}