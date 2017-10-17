namespace Project3FamousPhilosophers
{
    partial class frmSplashPhilosopher
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
            this.picPhilosopher = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pgbPhilosopher = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPhilosopher)).BeginInit();
            this.SuspendLayout();
            // 
            // picPhilosopher
            // 
            this.picPhilosopher.Image = global::Project3FamousPhilosophers.Properties.Resources.AristotleSmaller;
            this.picPhilosopher.Location = new System.Drawing.Point(255, 89);
            this.picPhilosopher.Name = "picPhilosopher";
            this.picPhilosopher.Size = new System.Drawing.Size(372, 235);
            this.picPhilosopher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhilosopher.TabIndex = 0;
            this.picPhilosopher.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(871, 77);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Famous Philosophers Database";
            // 
            // pgbPhilosopher
            // 
            this.pgbPhilosopher.ForeColor = System.Drawing.Color.Blue;
            this.pgbPhilosopher.Location = new System.Drawing.Point(179, 346);
            this.pgbPhilosopher.Name = "pgbPhilosopher";
            this.pgbPhilosopher.Size = new System.Drawing.Size(575, 23);
            this.pgbPhilosopher.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbPhilosopher.TabIndex = 2;
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 25;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // frmSplashPhilosopher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 393);
            this.Controls.Add(this.pgbPhilosopher);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picPhilosopher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashPhilosopher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashPhilosopher";
            ((System.ComponentModel.ISupportInitialize)(this.picPhilosopher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhilosopher;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ProgressBar pgbPhilosopher;
        private System.Windows.Forms.Timer tmrSplash;
    }
}