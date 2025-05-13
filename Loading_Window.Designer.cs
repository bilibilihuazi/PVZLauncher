namespace PVZLauncher
{
    partial class Loading_Window
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
            this.spin1 = new AntdUI.Spin();
            this.SuspendLayout();
            // 
            // spin1
            // 
            this.spin1.HandCursor = System.Windows.Forms.Cursors.Default;
            this.spin1.Location = new System.Drawing.Point(0, 0);
            this.spin1.Name = "spin1";
            this.spin1.Size = new System.Drawing.Size(400, 150);
            this.spin1.TabIndex = 0;
            this.spin1.Text = "加载中...";
            // 
            // Loading_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.spin1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loading_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading_Window";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Spin spin1;
    }
}