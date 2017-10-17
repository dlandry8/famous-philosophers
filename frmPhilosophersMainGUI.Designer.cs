namespace Project3FamousPhilosophers
{
    partial class frmPhilosophersMainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhilosophersMainGUI));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstPhilosophers = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblPhilosophy = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.txtPhilosophy = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mnuPhilosophers = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListClearFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClearFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfoPrintFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormPrintFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNameSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCountrySort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdPhilosophers = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picSocrates = new System.Windows.Forms.PictureBox();
            this.picPlato = new System.Windows.Forms.PictureBox();
            this.ppdPhilosopher = new System.Windows.Forms.PrintPreviewDialog();
            this.pdPhilosopher = new System.Drawing.Printing.PrintDocument();
            this.pdScreen = new System.Drawing.Printing.PrintDocument();
            this.mnuPhilosophers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSocrates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(286, 64);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(466, 57);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Famous Philosophers";
            // 
            // lstPhilosophers
            // 
            this.lstPhilosophers.FormattingEnabled = true;
            this.lstPhilosophers.ItemHeight = 18;
            this.lstPhilosophers.Location = new System.Drawing.Point(50, 210);
            this.lstPhilosophers.Name = "lstPhilosophers";
            this.lstPhilosophers.Size = new System.Drawing.Size(363, 310);
            this.lstPhilosophers.TabIndex = 1;
            this.lstPhilosophers.SelectedIndexChanged += new System.EventHandler(this.lstPhilosophers_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(459, 208);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Philosopher\'s name:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(489, 255);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(144, 18);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country of birth:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(516, 300);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(117, 18);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year of birth:";
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(512, 348);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(121, 18);
            this.lblWork.TabIndex = 5;
            this.lblWork.Text = "Famous work:";
            // 
            // lblPhilosophy
            // 
            this.lblPhilosophy.AutoSize = true;
            this.lblPhilosophy.Location = new System.Drawing.Point(522, 408);
            this.lblPhilosophy.Name = "lblPhilosophy";
            this.lblPhilosophy.Size = new System.Drawing.Size(111, 36);
            this.lblPhilosophy.TabIndex = 6;
            this.lblPhilosophy.Text = "Summary of \r\nphilosophy:";
            this.lblPhilosophy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(491, 489);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(142, 18);
            this.lblLink.TabIndex = 7;
            this.lblLink.Text = "Link to internet:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(672, 208);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(311, 27);
            this.txtName.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(672, 252);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(311, 27);
            this.txtCountry.TabIndex = 9;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(672, 297);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(311, 27);
            this.txtYear.TabIndex = 10;
            // 
            // txtWork
            // 
            this.txtWork.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWork.Location = new System.Drawing.Point(672, 345);
            this.txtWork.Name = "txtWork";
            this.txtWork.ReadOnly = true;
            this.txtWork.Size = new System.Drawing.Size(311, 27);
            this.txtWork.TabIndex = 11;
            // 
            // txtPhilosophy
            // 
            this.txtPhilosophy.Location = new System.Drawing.Point(672, 393);
            this.txtPhilosophy.Multiline = true;
            this.txtPhilosophy.Name = "txtPhilosophy";
            this.txtPhilosophy.ReadOnly = true;
            this.txtPhilosophy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhilosophy.Size = new System.Drawing.Size(311, 74);
            this.txtPhilosophy.TabIndex = 12;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(672, 486);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(311, 27);
            this.txtLink.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 543);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 50);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(239, 543);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 50);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(428, 543);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 50);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(813, 543);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 50);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mnuPhilosophers
            // 
            this.mnuPhilosophers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuSort,
            this.mnuAction,
            this.mnuHelp});
            this.mnuPhilosophers.Location = new System.Drawing.Point(0, 0);
            this.mnuPhilosophers.Name = "mnuPhilosophers";
            this.mnuPhilosophers.Size = new System.Drawing.Size(1057, 24);
            this.mnuPhilosophers.TabIndex = 19;
            this.mnuPhilosophers.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenFile,
            this.mnuClearFile,
            this.mnuPrintFile,
            this.mnuExitFile});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuOpenFile
            // 
            this.mnuOpenFile.Name = "mnuOpenFile";
            this.mnuOpenFile.Size = new System.Drawing.Size(214, 22);
            this.mnuOpenFile.Text = "&Open philosopher list (.txt)";
            this.mnuOpenFile.Click += new System.EventHandler(this.mnuOpenFile_Click);
            // 
            // mnuClearFile
            // 
            this.mnuClearFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListClearFile,
            this.mnuFileClearFile});
            this.mnuClearFile.Name = "mnuClearFile";
            this.mnuClearFile.Size = new System.Drawing.Size(214, 22);
            this.mnuClearFile.Text = "&Clear";
            // 
            // mnuListClearFile
            // 
            this.mnuListClearFile.Name = "mnuListClearFile";
            this.mnuListClearFile.Size = new System.Drawing.Size(169, 22);
            this.mnuListClearFile.Text = "&List and form";
            this.mnuListClearFile.Click += new System.EventHandler(this.mnuListClearFile_Click);
            // 
            // mnuFileClearFile
            // 
            this.mnuFileClearFile.Name = "mnuFileClearFile";
            this.mnuFileClearFile.Size = new System.Drawing.Size(169, 22);
            this.mnuFileClearFile.Text = "List, &file, and form";
            this.mnuFileClearFile.Click += new System.EventHandler(this.mnuFileClearFile_Click);
            // 
            // mnuPrintFile
            // 
            this.mnuPrintFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInfoPrintFile,
            this.mnuFormPrintFile});
            this.mnuPrintFile.Name = "mnuPrintFile";
            this.mnuPrintFile.Size = new System.Drawing.Size(214, 22);
            this.mnuPrintFile.Text = "&Print";
            // 
            // mnuInfoPrintFile
            // 
            this.mnuInfoPrintFile.Name = "mnuInfoPrintFile";
            this.mnuInfoPrintFile.Size = new System.Drawing.Size(211, 22);
            this.mnuInfoPrintFile.Text = "Philosopher\'s &Information";
            this.mnuInfoPrintFile.Click += new System.EventHandler(this.mnuInfoPrintFile_Click);
            // 
            // mnuFormPrintFile
            // 
            this.mnuFormPrintFile.Name = "mnuFormPrintFile";
            this.mnuFormPrintFile.Size = new System.Drawing.Size(211, 22);
            this.mnuFormPrintFile.Text = "&Form";
            this.mnuFormPrintFile.Click += new System.EventHandler(this.mnuFormPrintFile_Click);
            // 
            // mnuExitFile
            // 
            this.mnuExitFile.Name = "mnuExitFile";
            this.mnuExitFile.Size = new System.Drawing.Size(214, 22);
            this.mnuExitFile.Text = "E&xit";
            this.mnuExitFile.Click += new System.EventHandler(this.mnuExitFile_Click);
            // 
            // mnuSort
            // 
            this.mnuSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNameSort,
            this.mnuYearSort,
            this.mnuCountrySort});
            this.mnuSort.Name = "mnuSort";
            this.mnuSort.Size = new System.Drawing.Size(40, 20);
            this.mnuSort.Text = "S&ort";
            // 
            // mnuNameSort
            // 
            this.mnuNameSort.CheckOnClick = true;
            this.mnuNameSort.Name = "mnuNameSort";
            this.mnuNameSort.Size = new System.Drawing.Size(173, 22);
            this.mnuNameSort.Text = "By &name";
            this.mnuNameSort.Click += new System.EventHandler(this.mnuNameSort_Click);
            // 
            // mnuYearSort
            // 
            this.mnuYearSort.CheckOnClick = true;
            this.mnuYearSort.Name = "mnuYearSort";
            this.mnuYearSort.Size = new System.Drawing.Size(173, 22);
            this.mnuYearSort.Text = "By &year of birth";
            this.mnuYearSort.Click += new System.EventHandler(this.mnuYearSort_Click);
            // 
            // mnuCountrySort
            // 
            this.mnuCountrySort.CheckOnClick = true;
            this.mnuCountrySort.Name = "mnuCountrySort";
            this.mnuCountrySort.Size = new System.Drawing.Size(173, 22);
            this.mnuCountrySort.Text = "By &country of birth";
            this.mnuCountrySort.Click += new System.EventHandler(this.mnuCountrySort_Click);
            // 
            // mnuAction
            // 
            this.mnuAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddAction,
            this.mnuEditAction,
            this.mnuDeleteAction,
            this.mnuSearchAction});
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.Size = new System.Drawing.Size(54, 20);
            this.mnuAction.Text = "A&ction";
            // 
            // mnuAddAction
            // 
            this.mnuAddAction.Name = "mnuAddAction";
            this.mnuAddAction.Size = new System.Drawing.Size(219, 22);
            this.mnuAddAction.Text = "&Add new philosopher";
            this.mnuAddAction.Click += new System.EventHandler(this.mnuAddAction_Click);
            // 
            // mnuEditAction
            // 
            this.mnuEditAction.Name = "mnuEditAction";
            this.mnuEditAction.Size = new System.Drawing.Size(219, 22);
            this.mnuEditAction.Text = "&Edit existing philosopher";
            this.mnuEditAction.Click += new System.EventHandler(this.mnuEditAction_Click);
            // 
            // mnuDeleteAction
            // 
            this.mnuDeleteAction.Name = "mnuDeleteAction";
            this.mnuDeleteAction.Size = new System.Drawing.Size(219, 22);
            this.mnuDeleteAction.Text = "&Delete selected philosopher";
            this.mnuDeleteAction.Click += new System.EventHandler(this.mnuDeleteAction_Click);
            // 
            // mnuSearchAction
            // 
            this.mnuSearchAction.Name = "mnuSearchAction";
            this.mnuSearchAction.Size = new System.Drawing.Size(219, 22);
            this.mnuSearchAction.Text = "&Search";
            this.mnuSearchAction.Click += new System.EventHandler(this.mnuSearchAction_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutHelp});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAboutHelp
            // 
            this.mnuAboutHelp.Name = "mnuAboutHelp";
            this.mnuAboutHelp.Size = new System.Drawing.Size(152, 22);
            this.mnuAboutHelp.Text = "&About";
            this.mnuAboutHelp.Click += new System.EventHandler(this.mnuAboutHelp_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(620, 543);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 50);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picSocrates
            // 
            this.picSocrates.Image = global::Project3FamousPhilosophers.Properties.Resources.soc;
            this.picSocrates.Location = new System.Drawing.Point(747, 27);
            this.picSocrates.Name = "picSocrates";
            this.picSocrates.Size = new System.Drawing.Size(236, 164);
            this.picSocrates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSocrates.TabIndex = 21;
            this.picSocrates.TabStop = false;
            // 
            // picPlato
            // 
            this.picPlato.Image = global::Project3FamousPhilosophers.Properties.Resources.plato_1_320x320;
            this.picPlato.Location = new System.Drawing.Point(62, 27);
            this.picPlato.Name = "picPlato";
            this.picPlato.Size = new System.Drawing.Size(236, 164);
            this.picPlato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlato.TabIndex = 20;
            this.picPlato.TabStop = false;
            // 
            // ppdPhilosopher
            // 
            this.ppdPhilosopher.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdPhilosopher.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdPhilosopher.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdPhilosopher.Document = this.pdPhilosopher;
            this.ppdPhilosopher.Enabled = true;
            this.ppdPhilosopher.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdPhilosopher.Icon")));
            this.ppdPhilosopher.Name = "ppdPhilosopher";
            this.ppdPhilosopher.ShowIcon = false;
            this.ppdPhilosopher.Visible = false;
            // 
            // pdPhilosopher
            // 
            this.pdPhilosopher.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPhilosopher_PrintPage);
            // 
            // pdScreen
            // 
            this.pdScreen.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdScreen_PrintPage);
            // 
            // frmPhilosophersMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 618);
            this.Controls.Add(this.picSocrates);
            this.Controls.Add(this.picPlato);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
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
            this.Controls.Add(this.lstPhilosophers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuPhilosophers);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPhilosophers;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmPhilosophersMainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Famous Philosophers";
            this.Load += new System.EventHandler(this.frmPhilosophersMainGUI_Load);
            this.mnuPhilosophers.ResumeLayout(false);
            this.mnuPhilosophers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSocrates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstPhilosophers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblPhilosophy;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.TextBox txtPhilosophy;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip mnuPhilosophers;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuClearFile;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintFile;
        private System.Windows.Forms.ToolStripMenuItem mnuInfoPrintFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFormPrintFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSort;
        private System.Windows.Forms.ToolStripMenuItem mnuAction;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuExitFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNameSort;
        private System.Windows.Forms.ToolStripMenuItem mnuYearSort;
        private System.Windows.Forms.ToolStripMenuItem mnuCountrySort;
        private System.Windows.Forms.ToolStripMenuItem mnuAddAction;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAction;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteAction;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutHelp;
        private System.Windows.Forms.OpenFileDialog ofdPhilosophers;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchAction;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnuListClearFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClearFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picPlato;
        private System.Windows.Forms.PictureBox picSocrates;
        private System.Windows.Forms.PrintPreviewDialog ppdPhilosopher;
        private System.Drawing.Printing.PrintDocument pdPhilosopher;
        private System.Drawing.Printing.PrintDocument pdScreen;
    }
}

