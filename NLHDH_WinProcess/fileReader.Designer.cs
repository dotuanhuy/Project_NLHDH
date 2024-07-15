namespace NLHDH_WinProcess
{
    partial class fileReader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileReader));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPickFolder = new Guna.UI2.WinForms.Guna2Button();
            this.fileInfoMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.fileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFileInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtFileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddFile = new Guna.UI2.WinForms.Guna2Button();
            this.txtFileContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancelFile = new Guna.UI2.WinForms.Guna2Button();
            this.fileInfoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Brown;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(1242, 512);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "File Explorer";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPath
            // 
            this.txtPath.BorderRadius = 10;
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.DefaultText = "";
            this.txtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPath.ForeColor = System.Drawing.Color.DimGray;
            this.txtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Location = new System.Drawing.Point(114, 60);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PlaceholderText = "";
            this.txtPath.ReadOnly = true;
            this.txtPath.SelectedText = "";
            this.txtPath.Size = new System.Drawing.Size(432, 34);
            this.txtPath.TabIndex = 2;
            // 
            // btnPickFolder
            // 
            this.btnPickFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickFolder.BorderRadius = 12;
            this.btnPickFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPickFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPickFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPickFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPickFolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPickFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickFolder.ForeColor = System.Drawing.Color.White;
            this.btnPickFolder.Location = new System.Drawing.Point(1133, 60);
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.Size = new System.Drawing.Size(97, 34);
            this.btnPickFolder.TabIndex = 6;
            this.btnPickFolder.Text = "Chọn";
            this.btnPickFolder.Click += new System.EventHandler(this.btnPickFolder_Click);
            // 
            // fileInfoMenu
            // 
            this.fileInfoMenu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.fileInfoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.fileInfoMenu.Name = "fileInfoMenu";
            this.fileInfoMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.fileInfoMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.fileInfoMenu.RenderStyle.ColorTable = null;
            this.fileInfoMenu.RenderStyle.RoundedEdges = true;
            this.fileInfoMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.fileInfoMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fileInfoMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.fileInfoMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.fileInfoMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.fileInfoMenu.Size = new System.Drawing.Size(223, 86);
            this.fileInfoMenu.Opening += new System.ComponentModel.CancelEventHandler(this.fileInfoMenu_Opening);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.xemToolStripMenuItem.Text = "Xem";
            this.xemToolStripMenuItem.Click += new System.EventHandler(this.xemToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Animated = true;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.861538F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::NLHDH_WinProcess.Properties.Resources.addfile;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.ImageSize = new System.Drawing.Size(33, 32);
            this.btnAdd.Location = new System.Drawing.Point(1053, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 51);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BorderRadius = 20;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = global::NLHDH_WinProcess.Properties.Resources.prev;
            this.btnPrev.ImageSize = new System.Drawing.Size(44, 44);
            this.btnPrev.Location = new System.Drawing.Point(12, 60);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(39, 34);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 20;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::NLHDH_WinProcess.Properties.Resources.next;
            this.btnNext.ImageSize = new System.Drawing.Size(44, 44);
            this.btnNext.Location = new System.Drawing.Point(57, 60);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 34);
            this.btnNext.TabIndex = 4;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // fileDate
            // 
            this.fileDate.HeaderText = "Ngày tạo";
            this.fileDate.MinimumWidth = 7;
            this.fileDate.Name = "fileDate";
            this.fileDate.ReadOnly = true;
            // 
            // fileSize
            // 
            this.fileSize.HeaderText = "Size";
            this.fileSize.MinimumWidth = 7;
            this.fileSize.Name = "fileSize";
            this.fileSize.ReadOnly = true;
            // 
            // fileFormat
            // 
            this.fileFormat.HeaderText = "Định dạng";
            this.fileFormat.MinimumWidth = 7;
            this.fileFormat.Name = "fileFormat";
            this.fileFormat.ReadOnly = true;
            // 
            // fileName
            // 
            this.fileName.HeaderText = "Tên";
            this.fileName.MinimumWidth = 7;
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            // 
            // dgvFileInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFileInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFileInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFileInfo.ColumnHeadersHeight = 40;
            this.dgvFileInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFileInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.fileFormat,
            this.fileSize,
            this.fileDate});
            this.dgvFileInfo.ContextMenuStrip = this.fileInfoMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFileInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFileInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFileInfo.Location = new System.Drawing.Point(0, 130);
            this.dgvFileInfo.MultiSelect = false;
            this.dgvFileInfo.Name = "dgvFileInfo";
            this.dgvFileInfo.ReadOnly = true;
            this.dgvFileInfo.RowHeadersVisible = false;
            this.dgvFileInfo.RowHeadersWidth = 100;
            this.dgvFileInfo.RowTemplate.Height = 32;
            this.dgvFileInfo.Size = new System.Drawing.Size(1241, 408);
            this.dgvFileInfo.TabIndex = 7;
            this.dgvFileInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFileInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFileInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFileInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFileInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFileInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFileInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFileInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFileInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFileInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFileInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFileInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFileInfo.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvFileInfo.ThemeStyle.ReadOnly = true;
            this.dgvFileInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFileInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFileInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFileInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFileInfo.ThemeStyle.RowsStyle.Height = 32;
            this.dgvFileInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFileInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtFileName
            // 
            this.txtFileName.BorderRadius = 16;
            this.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileName.DefaultText = "";
            this.txtFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileName.FillColor = System.Drawing.Color.Gainsboro;
            this.txtFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFileName.Location = new System.Drawing.Point(13, 116);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtFileName.PlaceholderText = "Nhập tên file";
            this.txtFileName.SelectedText = "";
            this.txtFileName.Size = new System.Drawing.Size(320, 41);
            this.txtFileName.TabIndex = 10;
            // 
            // btnAddFile
            // 
            this.btnAddFile.BorderRadius = 16;
            this.btnAddFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.07692F, System.Drawing.FontStyle.Bold);
            this.btnAddFile.ForeColor = System.Drawing.Color.White;
            this.btnAddFile.Location = new System.Drawing.Point(375, 115);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(66, 42);
            this.btnAddFile.TabIndex = 12;
            this.btnAddFile.Text = "Tạo";
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // txtFileContent
            // 
            this.txtFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileContent.DefaultText = "";
            this.txtFileContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFileContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFileContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFileContent.Font = new System.Drawing.Font("Segoe UI", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFileContent.Location = new System.Drawing.Point(0, 165);
            this.txtFileContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.PasswordChar = '\0';
            this.txtFileContent.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtFileContent.PlaceholderText = "Nhập dữ liệu .......";
            this.txtFileContent.SelectedText = "";
            this.txtFileContent.Size = new System.Drawing.Size(1241, 347);
            this.txtFileContent.TabIndex = 11;
            // 
            // btnCancelFile
            // 
            this.btnCancelFile.BorderRadius = 16;
            this.btnCancelFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.07692F, System.Drawing.FontStyle.Bold);
            this.btnCancelFile.ForeColor = System.Drawing.Color.White;
            this.btnCancelFile.Location = new System.Drawing.Point(462, 115);
            this.btnCancelFile.Name = "btnCancelFile";
            this.btnCancelFile.Size = new System.Drawing.Size(84, 42);
            this.btnCancelFile.TabIndex = 13;
            this.btnCancelFile.Text = "Hủy";
            this.btnCancelFile.Click += new System.EventHandler(this.btnCancelFile_Click);
            // 
            // fileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 512);
            this.Controls.Add(this.btnCancelFile);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvFileInfo);
            this.Controls.Add(this.btnPickFolder);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fileReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Reader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fileReader_Load);
            this.fileInfoMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnPickFolder;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip fileInfoMenu;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFileInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtFileName;
        private Guna.UI2.WinForms.Guna2Button btnAddFile;
        private Guna.UI2.WinForms.Guna2TextBox txtFileContent;
        private Guna.UI2.WinForms.Guna2Button btnCancelFile;
    }
}