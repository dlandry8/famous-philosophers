namespace Project3FamousPhilosophers
{
    partial class frmAddPhilosopher
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(509, 387);
            this.txtLink.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(426, 27);
            this.txtLink.TabIndex = 25;
            // 
            // txtPhilosophy
            // 
            this.txtPhilosophy.Location = new System.Drawing.Point(509, 268);
            this.txtPhilosophy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhilosophy.Multiline = true;
            this.txtPhilosophy.Name = "txtPhilosophy";
            this.txtPhilosophy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhilosophy.Size = new System.Drawing.Size(426, 101);
            this.txtPhilosophy.TabIndex = 24;
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(509, 224);
            this.txtWork.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(426, 27);
            this.txtWork.TabIndex = 23;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(509, 180);
            this.txtYear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(426, 27);
            this.txtYear.TabIndex = 22;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(509, 136);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(426, 27);
            this.txtCountry.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(509, 91);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(426, 27);
            this.txtName.TabIndex = 20;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(357, 390);
            this.lblLink.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(142, 18);
            this.lblLink.TabIndex = 19;
            this.lblLink.Text = "Link to internet:";
            // 
            // lblPhilosophy
            // 
            this.lblPhilosophy.AutoSize = true;
            this.lblPhilosophy.Location = new System.Drawing.Point(388, 298);
            this.lblPhilosophy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhilosophy.Name = "lblPhilosophy";
            this.lblPhilosophy.Size = new System.Drawing.Size(111, 36);
            this.lblPhilosophy.TabIndex = 18;
            this.lblPhilosophy.Text = "Summary of \r\nphilosophy:";
            this.lblPhilosophy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(378, 227);
            this.lblWork.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(121, 18);
            this.lblWork.TabIndex = 17;
            this.lblWork.Text = "Famous work:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(382, 183);
            this.lblYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(117, 18);
            this.lblYear.TabIndex = 16;
            this.lblYear.Text = "Year of birth:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(355, 139);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(144, 18);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Country of birth:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(325, 94);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 18);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Philosopher\'s name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(371, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 60);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(675, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 60);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(451, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 57);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Add a New Philosopher";
            // 
            // picBR
            // 
            this.picBR.Image = global::Project3FamousPhilosophers.Properties.Resources._800px_Bertrand_Russell_transparent_bg;
            this.picBR.Location = new System.Drawing.Point(12, 47);
            this.picBR.Name = "picBR";
            this.picBR.Size = new System.Drawing.Size(315, 427);
            this.picBR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBR.TabIndex = 29;
            this.picBR.TabStop = false;
            // 
            // frmAddPhilosopher
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(967, 524);
            this.Controls.Add(this.picBR);
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
            this.Name = "frmAddPhilosopher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Philosopher";
            ((System.ComponentModel.ISupportInitialize)(this.picBR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBR;
    }
}