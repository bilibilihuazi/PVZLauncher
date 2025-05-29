namespace PvzLauncher
{
    partial class Download_Window
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
            this.label1 = new AntdUI.Label();
            this.progress1 = new AntdUI.Progress();
            this.label2 = new AntdUI.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(88, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "下载中...";
            // 
            // progress1
            // 
            this.progress1.ContainerControl = this;
            this.progress1.HandCursor = System.Windows.Forms.Cursors.Default;
            this.progress1.Location = new System.Drawing.Point(88, 58);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(486, 23);
            this.progress1.TabIndex = 2;
            this.progress1.Text = "progress1";
            // 
            // label2
            // 
            this.label2.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(214, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "下载中";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PvzLauncher.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Download_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 93);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progress1);
            this.Controls.Add(this.label1);
            this.EnableHitTest = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(586, 93);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(586, 93);
            this.Name = "Download_Window";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "下载";
            this.Load += new System.EventHandler(this.Download_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Label label1;
        private AntdUI.Progress progress1;
        private AntdUI.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}