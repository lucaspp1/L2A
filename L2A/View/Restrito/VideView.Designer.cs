namespace L2A.View.Restrito
{
    partial class VideView
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
            this.wbVideo = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbVideo
            // 
            this.wbVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbVideo.Location = new System.Drawing.Point(20, 60);
            this.wbVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbVideo.Name = "wbVideo";
            this.wbVideo.Size = new System.Drawing.Size(909, 519);
            this.wbVideo.TabIndex = 0;
            // 
            // VideView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 599);
            this.Controls.Add(this.wbVideo);
            this.Name = "VideView";
            this.Text = "VideView";
            this.Load += new System.EventHandler(this.VideView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbVideo;
    }
}