namespace BookmarksStocker.Source.Views
{
    partial class FrmBookmarkList
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cntxtGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registeredBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.chkDateFiltering = new System.Windows.Forms.CheckBox();
            this.grpDateFiltering = new System.Windows.Forms.GroupBox();
            this.tblLytDateMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpTimeSelection = new System.Windows.Forms.GroupBox();
            this.rdbtnUpdatetime = new System.Windows.Forms.RadioButton();
            this.rdbtnCreationtime = new System.Windows.Forms.RadioButton();
            this.grpDateSearchType = new System.Windows.Forms.GroupBox();
            this.rdbtnEndsWith = new System.Windows.Forms.RadioButton();
            this.rdbtnBetween = new System.Windows.Forms.RadioButton();
            this.rdbtnStartsWith = new System.Windows.Forms.RadioButton();
            this.tblLytDates = new System.Windows.Forms.TableLayoutPanel();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.tblLytKeySearch = new System.Windows.Forms.TableLayoutPanel();
            this.cmbxSearchType = new BookmarksStocker.Source.UserControls.LightComboBox();
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdVwBookmarks = new BookmarksStocker.Source.UserControls.LightGridView();
            this.tblLytSearchAndops = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.tblLytRight = new System.Windows.Forms.TableLayoutPanel();
            this.mnStripMain = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalBrowserListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxtGrid.SuspendLayout();
            this.grpDateFiltering.SuspendLayout();
            this.tblLytDateMain.SuspendLayout();
            this.grpTimeSelection.SuspendLayout();
            this.grpDateSearchType.SuspendLayout();
            this.tblLytDates.SuspendLayout();
            this.tblLytKeySearch.SuspendLayout();
            this.tblLytMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwBookmarks)).BeginInit();
            this.tblLytSearchAndops.SuspendLayout();
            this.tblLytLeft.SuspendLayout();
            this.tblLytButtons.SuspendLayout();
            this.tblLytRight.SuspendLayout();
            this.mnStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUpdate.Location = new System.Drawing.Point(163, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDelete.Location = new System.Drawing.Point(83, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cntxtGrid
            // 
            this.cntxtGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.runWithToolStripMenuItem});
            this.cntxtGrid.Name = "contextMenuStrip1";
            this.cntxtGrid.Size = new System.Drawing.Size(124, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // runWithToolStripMenuItem
            // 
            this.runWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registeredBrowserToolStripMenuItem,
            this.externalBrowserToolStripMenuItem});
            this.runWithToolStripMenuItem.Name = "runWithToolStripMenuItem";
            this.runWithToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.runWithToolStripMenuItem.Text = "Run With";
            // 
            // registeredBrowserToolStripMenuItem
            // 
            this.registeredBrowserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registeredBrowserToolStripMenuItem.Name = "registeredBrowserToolStripMenuItem";
            this.registeredBrowserToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.registeredBrowserToolStripMenuItem.Text = "Registered Browser";
            this.registeredBrowserToolStripMenuItem.Click += new System.EventHandler(this.runWithToolStripMenuItem_Click);
            // 
            // externalBrowserToolStripMenuItem
            // 
            this.externalBrowserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.externalBrowserToolStripMenuItem.Name = "externalBrowserToolStripMenuItem";
            this.externalBrowserToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.externalBrowserToolStripMenuItem.Text = " External Browser";
            this.externalBrowserToolStripMenuItem.Click += new System.EventHandler(this.externalBrowserToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtSearch.Location = new System.Drawing.Point(211, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSearch.Location = new System.Drawing.Point(15, 10);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 17);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search Text :";
            // 
            // lblSearchType
            // 
            this.lblSearchType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSearchType.Location = new System.Drawing.Point(15, 47);
            this.lblSearchType.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(97, 17);
            this.lblSearchType.TabIndex = 7;
            this.lblSearchType.Text = "Search Type :";
            // 
            // chkDateFiltering
            // 
            this.chkDateFiltering.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDateFiltering.AutoSize = true;
            this.chkDateFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chkDateFiltering.Location = new System.Drawing.Point(10, 9);
            this.chkDateFiltering.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkDateFiltering.Name = "chkDateFiltering";
            this.chkDateFiltering.Size = new System.Drawing.Size(111, 21);
            this.chkDateFiltering.TabIndex = 8;
            this.chkDateFiltering.Text = "Date Filtering";
            this.chkDateFiltering.UseVisualStyleBackColor = true;
            this.chkDateFiltering.CheckedChanged += new System.EventHandler(this.IsDatefilterchecked);
            // 
            // grpDateFiltering
            // 
            this.grpDateFiltering.Controls.Add(this.tblLytDateMain);
            this.grpDateFiltering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDateFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.grpDateFiltering.Location = new System.Drawing.Point(3, 43);
            this.grpDateFiltering.Name = "grpDateFiltering";
            this.grpDateFiltering.Size = new System.Drawing.Size(402, 229);
            this.grpDateFiltering.TabIndex = 9;
            this.grpDateFiltering.TabStop = false;
            this.grpDateFiltering.Text = "Date Filtering";
            // 
            // tblLytDateMain
            // 
            this.tblLytDateMain.ColumnCount = 1;
            this.tblLytDateMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytDateMain.Controls.Add(this.grpTimeSelection, 0, 0);
            this.tblLytDateMain.Controls.Add(this.grpDateSearchType, 0, 1);
            this.tblLytDateMain.Controls.Add(this.tblLytDates, 0, 2);
            this.tblLytDateMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytDateMain.Location = new System.Drawing.Point(3, 19);
            this.tblLytDateMain.Name = "tblLytDateMain";
            this.tblLytDateMain.RowCount = 3;
            this.tblLytDateMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLytDateMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLytDateMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytDateMain.Size = new System.Drawing.Size(396, 207);
            this.tblLytDateMain.TabIndex = 2;
            // 
            // grpTimeSelection
            // 
            this.grpTimeSelection.Controls.Add(this.rdbtnUpdatetime);
            this.grpTimeSelection.Controls.Add(this.rdbtnCreationtime);
            this.grpTimeSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimeSelection.Location = new System.Drawing.Point(3, 3);
            this.grpTimeSelection.Name = "grpTimeSelection";
            this.grpTimeSelection.Size = new System.Drawing.Size(390, 44);
            this.grpTimeSelection.TabIndex = 0;
            this.grpTimeSelection.TabStop = false;
            // 
            // rdbtnUpdatetime
            // 
            this.rdbtnUpdatetime.AutoSize = true;
            this.rdbtnUpdatetime.Location = new System.Drawing.Point(276, 18);
            this.rdbtnUpdatetime.Name = "rdbtnUpdatetime";
            this.rdbtnUpdatetime.Size = new System.Drawing.Size(107, 21);
            this.rdbtnUpdatetime.TabIndex = 0;
            this.rdbtnUpdatetime.TabStop = true;
            this.rdbtnUpdatetime.Tag = "2";
            this.rdbtnUpdatetime.Text = "Update Time";
            this.rdbtnUpdatetime.UseVisualStyleBackColor = true;
            this.rdbtnUpdatetime.CheckedChanged += new System.EventHandler(this.IsCreationtimeToggleChanged);
            // 
            // rdbtnCreationtime
            // 
            this.rdbtnCreationtime.AutoSize = true;
            this.rdbtnCreationtime.Location = new System.Drawing.Point(18, 17);
            this.rdbtnCreationtime.Name = "rdbtnCreationtime";
            this.rdbtnCreationtime.Size = new System.Drawing.Size(114, 21);
            this.rdbtnCreationtime.TabIndex = 0;
            this.rdbtnCreationtime.TabStop = true;
            this.rdbtnCreationtime.Tag = "1";
            this.rdbtnCreationtime.Text = "Creation Time";
            this.rdbtnCreationtime.UseVisualStyleBackColor = true;
            this.rdbtnCreationtime.CheckedChanged += new System.EventHandler(this.IsCreationtimeToggleChanged);
            // 
            // grpDateSearchType
            // 
            this.grpDateSearchType.Controls.Add(this.rdbtnEndsWith);
            this.grpDateSearchType.Controls.Add(this.rdbtnBetween);
            this.grpDateSearchType.Controls.Add(this.rdbtnStartsWith);
            this.grpDateSearchType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDateSearchType.Location = new System.Drawing.Point(3, 53);
            this.grpDateSearchType.Name = "grpDateSearchType";
            this.grpDateSearchType.Size = new System.Drawing.Size(390, 44);
            this.grpDateSearchType.TabIndex = 1;
            this.grpDateSearchType.TabStop = false;
            // 
            // rdbtnEndsWith
            // 
            this.rdbtnEndsWith.AutoSize = true;
            this.rdbtnEndsWith.Location = new System.Drawing.Point(276, 12);
            this.rdbtnEndsWith.Name = "rdbtnEndsWith";
            this.rdbtnEndsWith.Size = new System.Drawing.Size(90, 21);
            this.rdbtnEndsWith.TabIndex = 0;
            this.rdbtnEndsWith.TabStop = true;
            this.rdbtnEndsWith.Tag = "3";
            this.rdbtnEndsWith.Text = "Ends With";
            this.rdbtnEndsWith.UseVisualStyleBackColor = true;
            this.rdbtnEndsWith.CheckedChanged += new System.EventHandler(this.IsStartToggleChanged);
            // 
            // rdbtnBetween
            // 
            this.rdbtnBetween.AutoSize = true;
            this.rdbtnBetween.Location = new System.Drawing.Point(137, 12);
            this.rdbtnBetween.Name = "rdbtnBetween";
            this.rdbtnBetween.Size = new System.Drawing.Size(80, 21);
            this.rdbtnBetween.TabIndex = 0;
            this.rdbtnBetween.TabStop = true;
            this.rdbtnBetween.Tag = "2";
            this.rdbtnBetween.Text = "Between";
            this.rdbtnBetween.UseVisualStyleBackColor = true;
            this.rdbtnBetween.CheckedChanged += new System.EventHandler(this.IsStartToggleChanged);
            // 
            // rdbtnStartsWith
            // 
            this.rdbtnStartsWith.AutoSize = true;
            this.rdbtnStartsWith.Location = new System.Drawing.Point(18, 12);
            this.rdbtnStartsWith.Name = "rdbtnStartsWith";
            this.rdbtnStartsWith.Size = new System.Drawing.Size(95, 21);
            this.rdbtnStartsWith.TabIndex = 0;
            this.rdbtnStartsWith.TabStop = true;
            this.rdbtnStartsWith.Tag = "1";
            this.rdbtnStartsWith.Text = "Starts With";
            this.rdbtnStartsWith.UseVisualStyleBackColor = true;
            this.rdbtnStartsWith.CheckedChanged += new System.EventHandler(this.IsStartToggleChanged);
            // 
            // tblLytDates
            // 
            this.tblLytDates.ColumnCount = 4;
            this.tblLytDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytDates.Controls.Add(this.lblStartTime, 0, 0);
            this.tblLytDates.Controls.Add(this.lblEndTime, 0, 1);
            this.tblLytDates.Controls.Add(this.dtpStartDate, 1, 0);
            this.tblLytDates.Controls.Add(this.dtpEndDate, 1, 1);
            this.tblLytDates.Controls.Add(this.dtpStartTime, 2, 0);
            this.tblLytDates.Controls.Add(this.dtpEndTime, 2, 1);
            this.tblLytDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytDates.Location = new System.Drawing.Point(3, 103);
            this.tblLytDates.Name = "tblLytDates";
            this.tblLytDates.RowCount = 3;
            this.tblLytDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLytDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLytDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytDates.Size = new System.Drawing.Size(390, 101);
            this.tblLytDates.TabIndex = 2;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(15, 21);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(81, 17);
            this.lblStartTime.TabIndex = 0;
            this.lblStartTime.Text = "Start Time :";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(15, 81);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(76, 17);
            this.lblEndTime.TabIndex = 0;
            this.lblEndTime.Text = "End Time :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(130, 18);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(100, 23);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(130, 78);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(100, 23);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(250, 18);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(91, 23);
            this.dtpStartTime.TabIndex = 3;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(250, 78);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(91, 23);
            this.dtpEndTime.TabIndex = 4;
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // tblLytKeySearch
            // 
            this.tblLytKeySearch.ColumnCount = 2;
            this.tblLytKeySearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytKeySearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytKeySearch.Controls.Add(this.txtSearch, 1, 0);
            this.tblLytKeySearch.Controls.Add(this.cmbxSearchType, 1, 1);
            this.tblLytKeySearch.Controls.Add(this.lblSearch, 0, 0);
            this.tblLytKeySearch.Controls.Add(this.lblSearchType, 0, 1);
            this.tblLytKeySearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytKeySearch.Location = new System.Drawing.Point(3, 3);
            this.tblLytKeySearch.Name = "tblLytKeySearch";
            this.tblLytKeySearch.RowCount = 2;
            this.tblLytKeySearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytKeySearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytKeySearch.Size = new System.Drawing.Size(402, 74);
            this.tblLytKeySearch.TabIndex = 10;
            // 
            // cmbxSearchType
            // 
            this.cmbxSearchType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbxSearchType.FormattingEnabled = true;
            this.cmbxSearchType.Location = new System.Drawing.Point(211, 42);
            this.cmbxSearchType.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.cmbxSearchType.Name = "cmbxSearchType";
            this.cmbxSearchType.Size = new System.Drawing.Size(181, 25);
            this.cmbxSearchType.TabIndex = 6;
            this.cmbxSearchType.SelectedIndexChanged += new System.EventHandler(this.cmbxSearchType_SelectedIndexChanged);
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.grdVwBookmarks, 0, 1);
            this.tblLytMain.Controls.Add(this.tblLytSearchAndops, 0, 2);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 3;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytMain.Size = new System.Drawing.Size(834, 599);
            this.tblLytMain.TabIndex = 11;
            // 
            // grdVwBookmarks
            // 
            this.grdVwBookmarks.AllowUserToAddRows = false;
            this.grdVwBookmarks.AllowUserToDeleteRows = false;
            this.grdVwBookmarks.AllowUserToOrderColumns = true;
            this.grdVwBookmarks.AllowUserToResizeColumns = false;
            this.grdVwBookmarks.AllowUserToResizeRows = false;
            this.grdVwBookmarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVwBookmarks.ColumnHeaderDeLimiter = '-';
            this.grdVwBookmarks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdVwBookmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVwBookmarks.ColumnHeaderTextList = "";
            this.grdVwBookmarks.ColumnInVisibilityString = "[i]";
            this.grdVwBookmarks.ContextMenuStrip = this.cntxtGrid;
            this.grdVwBookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVwBookmarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grdVwBookmarks.Location = new System.Drawing.Point(3, 28);
            this.grdVwBookmarks.MultiSelect = false;
            this.grdVwBookmarks.Name = "grdVwBookmarks";
            this.grdVwBookmarks.ReadOnly = true;
            this.grdVwBookmarks.RowHeadersVisible = false;
            this.grdVwBookmarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVwBookmarks.Size = new System.Drawing.Size(828, 281);
            this.grdVwBookmarks.TabIndex = 2;
            this.grdVwBookmarks.SelectionChanged += new System.EventHandler(this.grdVwBookmarks_SelectionChanged);
            // 
            // tblLytSearchAndops
            // 
            this.tblLytSearchAndops.ColumnCount = 2;
            this.tblLytSearchAndops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytSearchAndops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytSearchAndops.Controls.Add(this.tblLytLeft, 0, 0);
            this.tblLytSearchAndops.Controls.Add(this.tblLytRight, 1, 0);
            this.tblLytSearchAndops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytSearchAndops.Location = new System.Drawing.Point(3, 315);
            this.tblLytSearchAndops.Name = "tblLytSearchAndops";
            this.tblLytSearchAndops.RowCount = 1;
            this.tblLytSearchAndops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytSearchAndops.Size = new System.Drawing.Size(828, 281);
            this.tblLytSearchAndops.TabIndex = 3;
            // 
            // tblLytLeft
            // 
            this.tblLytLeft.ColumnCount = 1;
            this.tblLytLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytLeft.Controls.Add(this.tblLytKeySearch, 0, 0);
            this.tblLytLeft.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytLeft.Controls.Add(this.txtDetails, 0, 2);
            this.tblLytLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytLeft.Location = new System.Drawing.Point(3, 3);
            this.tblLytLeft.Name = "tblLytLeft";
            this.tblLytLeft.RowCount = 3;
            this.tblLytLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytLeft.Size = new System.Drawing.Size(408, 275);
            this.tblLytLeft.TabIndex = 0;
            // 
            // tblLytButtons
            // 
            this.tblLytButtons.ColumnCount = 4;
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Controls.Add(this.btnUpdate, 2, 0);
            this.tblLytButtons.Controls.Add(this.btnDelete, 1, 0);
            this.tblLytButtons.Controls.Add(this.btnAdd, 0, 0);
            this.tblLytButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytButtons.Location = new System.Drawing.Point(3, 83);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(402, 34);
            this.tblLytButtons.TabIndex = 11;
            // 
            // txtDetails
            // 
            this.txtDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDetails.Location = new System.Drawing.Point(3, 123);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(402, 149);
            this.txtDetails.TabIndex = 12;
            // 
            // tblLytRight
            // 
            this.tblLytRight.ColumnCount = 1;
            this.tblLytRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytRight.Controls.Add(this.chkDateFiltering, 0, 0);
            this.tblLytRight.Controls.Add(this.grpDateFiltering, 0, 1);
            this.tblLytRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytRight.Location = new System.Drawing.Point(417, 3);
            this.tblLytRight.Name = "tblLytRight";
            this.tblLytRight.RowCount = 2;
            this.tblLytRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytRight.Size = new System.Drawing.Size(408, 275);
            this.tblLytRight.TabIndex = 1;
            // 
            // mnStripMain
            // 
            this.mnStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem});
            this.mnStripMain.Location = new System.Drawing.Point(0, 0);
            this.mnStripMain.Name = "mnStripMain";
            this.mnStripMain.Size = new System.Drawing.Size(834, 24);
            this.mnStripMain.TabIndex = 12;
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutToolStripMenuItem,
            this.externalBrowserListToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // shortcutToolStripMenuItem
            // 
            this.shortcutToolStripMenuItem.Name = "shortcutToolStripMenuItem";
            this.shortcutToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.shortcutToolStripMenuItem.Text = "&Create Shortcut To Desktop";
            this.shortcutToolStripMenuItem.Click += new System.EventHandler(this.shortcutToolStripMenuItem_Click);
            // 
            // externalBrowserListToolStripMenuItem
            // 
            this.externalBrowserListToolStripMenuItem.Name = "externalBrowserListToolStripMenuItem";
            this.externalBrowserListToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.externalBrowserListToolStripMenuItem.Text = "&External Browser List";
            this.externalBrowserListToolStripMenuItem.Click += new System.EventHandler(this.externalBrowserListToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allBookmarksToolStripMenuItem,
            this.selectedBookmarksToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // allBookmarksToolStripMenuItem
            // 
            this.allBookmarksToolStripMenuItem.Name = "allBookmarksToolStripMenuItem";
            this.allBookmarksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allBookmarksToolStripMenuItem.Text = "All Bookmarks";
            this.allBookmarksToolStripMenuItem.Click += new System.EventHandler(this.allBookmarksToolStripMenuItem_Click);
            // 
            // selectedBookmarksToolStripMenuItem
            // 
            this.selectedBookmarksToolStripMenuItem.Name = "selectedBookmarksToolStripMenuItem";
            this.selectedBookmarksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectedBookmarksToolStripMenuItem.Text = "Selected Bookmarks";
            this.selectedBookmarksToolStripMenuItem.Click += new System.EventHandler(this.selectedBookmarksToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FrmBookmarkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 599);
            this.Controls.Add(this.mnStripMain);
            this.Controls.Add(this.tblLytMain);
            this.MainMenuStrip = this.mnStripMain;
            this.Name = "FrmBookmarkList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookmark List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBookmarkList_FormClosing);
            this.Load += new System.EventHandler(this.FormLoad);
            this.cntxtGrid.ResumeLayout(false);
            this.grpDateFiltering.ResumeLayout(false);
            this.tblLytDateMain.ResumeLayout(false);
            this.grpTimeSelection.ResumeLayout(false);
            this.grpTimeSelection.PerformLayout();
            this.grpDateSearchType.ResumeLayout(false);
            this.grpDateSearchType.PerformLayout();
            this.tblLytDates.ResumeLayout(false);
            this.tblLytDates.PerformLayout();
            this.tblLytKeySearch.ResumeLayout(false);
            this.tblLytKeySearch.PerformLayout();
            this.tblLytMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVwBookmarks)).EndInit();
            this.tblLytSearchAndops.ResumeLayout(false);
            this.tblLytLeft.ResumeLayout(false);
            this.tblLytLeft.PerformLayout();
            this.tblLytButtons.ResumeLayout(false);
            this.tblLytRight.ResumeLayout(false);
            this.tblLytRight.PerformLayout();
            this.mnStripMain.ResumeLayout(false);
            this.mnStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Source.UserControls.LightGridView grdVwBookmarks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip cntxtGrid;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runWithToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private Source.UserControls.LightComboBox cmbxSearchType;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.CheckBox chkDateFiltering;
        private System.Windows.Forms.GroupBox grpDateFiltering;
        private System.Windows.Forms.GroupBox grpTimeSelection;
        private System.Windows.Forms.RadioButton rdbtnUpdatetime;
        private System.Windows.Forms.RadioButton rdbtnCreationtime;
        private System.Windows.Forms.GroupBox grpDateSearchType;
        private System.Windows.Forms.RadioButton rdbtnEndsWith;
        private System.Windows.Forms.RadioButton rdbtnBetween;
        private System.Windows.Forms.RadioButton rdbtnStartsWith;
        private System.Windows.Forms.TableLayoutPanel tblLytDateMain;
        private System.Windows.Forms.TableLayoutPanel tblLytDates;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.TableLayoutPanel tblLytKeySearch;
        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.TableLayoutPanel tblLytSearchAndops;
        private System.Windows.Forms.TableLayoutPanel tblLytLeft;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.TableLayoutPanel tblLytRight;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ToolStripMenuItem registeredBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externalBrowserToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnStripMain;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externalBrowserListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allBookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedBookmarksToolStripMenuItem;
    }
}