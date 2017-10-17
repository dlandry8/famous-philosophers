namespace Project3FamousPhilosophers
{
    partial class frmEditPhilosopher
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtPhilosophy = new System.Windows.Forms.TextBox();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblPhilosophy = new System.Windows.Forms.Label();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picConfucious = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picConfucious)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(677, 441);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 60);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(371, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 60);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "&Save Changes";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(511, 388);
            this.txtLink.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(426, 27);
            this.txtLink.TabIndex = 39;
            // 
            // txtPhilosophy
            // 
            this.txtPhilosophy.Location = new System.Drawing.Point(511, 269);
            this.txtPhilosophy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhilosophy.Multiline = true;
            this.txtPhilosophy.Name = "txtPhilosophy";
            this.txtPhilosophy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhilosophy.Size = new System.Drawing.Size(426, 101);
            this.txtPhilosophy.TabIndex = 38;
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(511, 224);
            this.txtWork.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(426, 27);
            this.txtWork.TabIndex = 37;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(511, 184);
            this.txtYear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(426, 27);
            this.txtYear.TabIndex = 36;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(511, 144);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(426, 27);
            this.txtCountry.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(511, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(426, 27);
            this.txtName.TabIndex = 34;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(359, 391);
            this.lblLink.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(142, 18);
            this.lblLink.TabIndex = 33;
            this.lblLink.Text = "Link to internet:";
            // 
            // lblPhilosophy
            // 
            this.lblPhilosophy.AutoSize = true;
            this.lblPhilosophy.Location = new System.Drawing.Point(390, 301);
            this.lblPhilosophy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhilosophy.Name = "lblPhilosophy";
            this.lblPhilosophy.Size = new System.Drawing.Size(111, 36);
            this.lblPhilosophy.TabIndex = 32;
            this.lblPhilosophy.Text = "Summary of \r\nphilosophy:";
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(380, 227);
            this.lblWork.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(121, 18);
            this.lblWork.TabIndex = 31;
            this.lblWork.Text = "Famous work:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(384, 187);
            this.lblYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(117, 18);
            this.lblYear.TabIndex = 30;
            this.lblYear.Text = "Year of birth:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(357, 147);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(144, 18);
            this.lblCountry.TabIndex = 29;
            this.lblCountry.Text = "Country of birth:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(327, 106);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 18);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Philosopher\'s name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(471, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(395, 57);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Edit a Philosopher";
            // 
            // picConfucious
            // 
            this.picConfucious.Image = global::Project3FamousPhilosophers.Properties.Resources.Confucius03;
            this.picConfucious.Location = new System.Drawing.Point(12, 30);
            this.picConfucious.Name = "picConfucious";
            this.picConfucious.Size = new System.Drawing.Size(295, 458);
            this.picConfucious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfucious.TabIndex = 43;
            this.picConfucious.TabStop = false;
            // 
            // frmEditPhilosopher
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(967, 524);
            this.Controls.Add(this.picConfucious);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtPhilosophy);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblPhilosophy);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmEditPhilosopher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Philosopher";
            ((System.ComponentModel.ISupportInitialize)(this.picConfucious)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtPhilosophy;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblPhilosophy;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picConfucious;
    }
}