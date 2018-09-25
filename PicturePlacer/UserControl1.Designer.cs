namespace PicturePlacer
{
    partial class PicturePlacer
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PicturePlacer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Name = "PicturePlacer";
            this.Size = new System.Drawing.Size(362, 347);
            this.Load += new System.EventHandler(this.PicturePlacer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PicturePlacer_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicturePlacer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicturePlacer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicturePlacer_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
