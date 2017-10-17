namespace Project3FamousPhilosophers
{
    partial class frmSearch
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
            this.radName = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.radCountry = new System.Windows.Forms.RadioButton();
            this.radPhilosophy = new System.Windows.Forms.RadioButton();
            this.radWork = new System.Windows.Forms.RadioButton();
            this.radYear = new System.Windows.Forms.RadioButton();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstPhilosophers = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Checked = true;
            this.radName.Location = new System.Drawing.Point(14, 43);
            this.radName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(98, 22);
            this.radName.TabIndex = 0;
            this.radName.TabStop = true;
            this.radName.Text = "by &Name";
            this.radName.UseVisualStyleBackColor = true;
            this.radName.CheckedChanged += new System.EventHandler(this.radName_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 9);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(214, 18);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search for a philosopher:";
            // 
            // radCountry
            // 
            this.radCountry.AutoSize = true;
            this.radCountry.Location = new System.Drawing.Point(14, 73);
            this.radCountry.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radCountry.Name = "radCountry";
            this.radCountry.Size = new System.Drawing.Size(180, 22);
            this.radCountry.TabIndex = 2;
            this.radCountry.Text = "by &Country of birth";
            this.radCountry.UseVisualStyleBackColor = true;
            this.radCountry.CheckedChanged += new System.EventHandler(this.radCountry_CheckedChanged);
            // 
            // radPhilosophy
            // 
            this.radPhilosophy.AutoSize = true;
            this.radPhilosophy.Location = new System.Drawing.Point(14, 103);
            this.radPhilosophy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radPhilosophy.Name = "radPhilosophy";
            this.radPhilosophy.Size = new System.Drawing.Size(139, 22);
            this.radPhilosophy.TabIndex = 3;
            this.radPhilosophy.Text = "by &Philosophy";
            this.radPhilosophy.UseVisualStyleBackColor = true;
            this.radPhilosophy.CheckedChanged += new System.EventHandler(this.radPhilosophy_CheckedChanged);
            // 
            // radWork
            // 
            this.radWork.AutoSize = true;
            this.radWork.Location = new System.Drawing.Point(14, 133);
            this.radWork.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radWork.Name = "radWork";
            this.radWork.Size = new System.Drawing.Size(101, 22);
            this.radWork.TabIndex = 4;
            this.radWork.Text = "by &Works";
            this.radWork.UseVisualStyleBackColor = true;
            this.radWork.CheckedChanged += new System.EventHandler(this.radWork_CheckedChanged);
            // 
            // radYear
            // 
            this.radYear.AutoSize = true;
            this.radYear.Location = new System.Drawing.Point(14, 163);
            this.radYear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radYear.Name = "radYear";
            this.radYear.Size = new System.Drawing.Size(166, 22);
            this.radYear.TabIndex = 5;
            this.radYear.Text = "in range of &Years";
            this.radYear.UseVisualStyleBackColor = true;
            this.radYear.CheckedChanged += new System.EventHandler(this.radYear_CheckedChanged);
            // 
            // txtSearchString
            // 
            this.txtSearchString.Location = new System.Drawing.Point(13, 193);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(237, 27);
            this.txtSearchString.TabIndex = 6;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 229);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(55, 18);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "From:";
            this.lblFrom.Visible = false;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(192, 226);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(58, 27);
            this.txtTo.TabIndex = 9;
            this.txtTo.Visible = false;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(73, 226);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(58, 27);
            this.txtFrom.TabIndex = 8;
            this.txtFrom.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(153, 229);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 18);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To:";
            this.lblTo.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 270);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(257, 54);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(342, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(257, 54);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstPhilosophers
            // 
            this.lstPhilosophers.FormattingEnabled = true;
            this.lstPhilosophers.ItemHeight = 18;
            this.lstPhilosophers.Location = new System.Drawing.Point(274, 9);
            this.lstPhilosophers.Name = "lstPhilosophers";
            this.lstPhilosophers.Size = new System.Drawing.Size(325, 166);
            this.lstPhilosophers.TabIndex = 10;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(274, 181);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(325, 39);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "S&elect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(611, 335);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstPhilosophers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtSearchString);
            this.Controls.Add(this.radYear);
            this.Controls.Add(this.radWork);
            this.Controls.Add(this.radPhilosophy);
            this.Controls.Add(this.radCountry);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.radName);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.RadioButton radCountry;
        private System.Windows.Forms.RadioButton radPhilosophy;
        private System.Windows.Forms.RadioButton radWork;
        private System.Windows.Forms.RadioButton radYear;
        private System.Windows.Forms.TextBox txtSearchString;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstPhilosophers;
        private System.Windows.Forms.Button btnSelect;
    }
}