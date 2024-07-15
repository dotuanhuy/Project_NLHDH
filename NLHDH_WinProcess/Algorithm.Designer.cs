namespace NLHDH_WinProcess
{
    partial class Algorithm
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
            this.groupDetail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddProcess = new Guna.UI2.WinForms.Guna2Button();
            this.txtArrivalTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtExeTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProcessName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tblProcessInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.processName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRun = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbTypeAlgo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtQuantum = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbQuantum = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProcessInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDetail
            // 
            this.groupDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDetail.Controls.Add(this.btnAddProcess);
            this.groupDetail.Controls.Add(this.txtArrivalTime);
            this.groupDetail.Controls.Add(this.txtExeTime);
            this.groupDetail.Controls.Add(this.txtProcessName);
            this.groupDetail.Controls.Add(this.guna2HtmlLabel4);
            this.groupDetail.Controls.Add(this.guna2HtmlLabel3);
            this.groupDetail.Controls.Add(this.guna2HtmlLabel2);
            this.groupDetail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.groupDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupDetail.Location = new System.Drawing.Point(1, 59);
            this.groupDetail.Name = "groupDetail";
            this.groupDetail.Size = new System.Drawing.Size(379, 332);
            this.groupDetail.TabIndex = 1;
            this.groupDetail.Text = "Process Detail";
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.BorderRadius = 12;
            this.btnAddProcess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProcess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProcess.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProcess.ForeColor = System.Drawing.Color.White;
            this.btnAddProcess.Location = new System.Drawing.Point(122, 269);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(110, 49);
            this.btnAddProcess.TabIndex = 8;
            this.btnAddProcess.Text = "Add";
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.BorderRadius = 10;
            this.txtArrivalTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArrivalTime.DefaultText = "";
            this.txtArrivalTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtArrivalTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtArrivalTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArrivalTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArrivalTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArrivalTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtArrivalTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArrivalTime.Location = new System.Drawing.Point(190, 137);
            this.txtArrivalTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.PasswordChar = '\0';
            this.txtArrivalTime.PlaceholderText = "";
            this.txtArrivalTime.SelectedText = "";
            this.txtArrivalTime.Size = new System.Drawing.Size(172, 32);
            this.txtArrivalTime.TabIndex = 6;
            // 
            // txtExeTime
            // 
            this.txtExeTime.BorderRadius = 10;
            this.txtExeTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExeTime.DefaultText = "";
            this.txtExeTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExeTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExeTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExeTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExeTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExeTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExeTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExeTime.Location = new System.Drawing.Point(190, 209);
            this.txtExeTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExeTime.Name = "txtExeTime";
            this.txtExeTime.PasswordChar = '\0';
            this.txtExeTime.PlaceholderText = "";
            this.txtExeTime.SelectedText = "";
            this.txtExeTime.Size = new System.Drawing.Size(172, 32);
            this.txtExeTime.TabIndex = 7;
            this.txtExeTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExeTime_KeyDown);
            // 
            // txtProcessName
            // 
            this.txtProcessName.BorderRadius = 10;
            this.txtProcessName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcessName.DefaultText = "";
            this.txtProcessName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProcessName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProcessName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcessName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcessName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcessName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProcessName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcessName.Location = new System.Drawing.Point(190, 53);
            this.txtProcessName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.PasswordChar = '\0';
            this.txtProcessName.PlaceholderText = "";
            this.txtProcessName.SelectedText = "";
            this.txtProcessName.Size = new System.Drawing.Size(172, 32);
            this.txtProcessName.TabIndex = 5;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(11, 137);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(69, 18);
            this.guna2HtmlLabel4.TabIndex = 4;
            this.guna2HtmlLabel4.Text = "Arrival time";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(11, 211);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(89, 18);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Execution time";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(11, 57);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(93, 18);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Process Name";
            // 
            // tblProcessInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tblProcessInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblProcessInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblProcessInfo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblProcessInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblProcessInfo.ColumnHeadersHeight = 32;
            this.tblProcessInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblProcessInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processName,
            this.arrivalTime,
            this.executime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblProcessInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblProcessInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblProcessInfo.Location = new System.Drawing.Point(394, 59);
            this.tblProcessInfo.Name = "tblProcessInfo";
            this.tblProcessInfo.ReadOnly = true;
            this.tblProcessInfo.RowHeadersVisible = false;
            this.tblProcessInfo.RowHeadersWidth = 80;
            this.tblProcessInfo.RowTemplate.Height = 36;
            this.tblProcessInfo.Size = new System.Drawing.Size(601, 332);
            this.tblProcessInfo.TabIndex = 2;
            this.tblProcessInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tblProcessInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblProcessInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblProcessInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblProcessInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblProcessInfo.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblProcessInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblProcessInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tblProcessInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblProcessInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblProcessInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblProcessInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblProcessInfo.ThemeStyle.HeaderStyle.Height = 32;
            this.tblProcessInfo.ThemeStyle.ReadOnly = true;
            this.tblProcessInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tblProcessInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblProcessInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblProcessInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblProcessInfo.ThemeStyle.RowsStyle.Height = 36;
            this.tblProcessInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblProcessInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // processName
            // 
            this.processName.HeaderText = "Process Name";
            this.processName.MinimumWidth = 7;
            this.processName.Name = "processName";
            this.processName.ReadOnly = true;
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Arrival Time";
            this.arrivalTime.MinimumWidth = 7;
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.ReadOnly = true;
            // 
            // executime
            // 
            this.executime.HeaderText = "Execution Time";
            this.executime.MinimumWidth = 7;
            this.executime.Name = "executime";
            this.executime.ReadOnly = true;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.BorderRadius = 12;
            this.btnRun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(874, 407);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(110, 49);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 12;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(874, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 49);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbTypeAlgo
            // 
            this.cbTypeAlgo.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeAlgo.BorderRadius = 8;
            this.cbTypeAlgo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeAlgo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbTypeAlgo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeAlgo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeAlgo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeAlgo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeAlgo.ItemHeight = 30;
            this.cbTypeAlgo.Items.AddRange(new object[] {
            "SJF",
            "FCFS",
            "RR",
            "SRTN"});
            this.cbTypeAlgo.Location = new System.Drawing.Point(12, 13);
            this.cbTypeAlgo.Name = "cbTypeAlgo";
            this.cbTypeAlgo.Size = new System.Drawing.Size(241, 36);
            this.cbTypeAlgo.StartIndex = 0;
            this.cbTypeAlgo.TabIndex = 11;
            this.cbTypeAlgo.SelectedIndexChanged += new System.EventHandler(this.cbTypeAlgo_SelectedIndexChanged);
            // 
            // txtQuantum
            // 
            this.txtQuantum.BorderRadius = 4;
            this.txtQuantum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantum.DefaultText = "";
            this.txtQuantum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantum.Location = new System.Drawing.Point(394, 15);
            this.txtQuantum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.PasswordChar = '\0';
            this.txtQuantum.PlaceholderText = "Enter Quantum ....";
            this.txtQuantum.SelectedText = "";
            this.txtQuantum.Size = new System.Drawing.Size(172, 32);
            this.txtQuantum.TabIndex = 9;
            // 
            // lbQuantum
            // 
            this.lbQuantum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantum.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbQuantum.Location = new System.Drawing.Point(318, 20);
            this.lbQuantum.Name = "lbQuantum";
            this.lbQuantum.Size = new System.Drawing.Size(69, 22);
            this.lbQuantum.TabIndex = 9;
            this.lbQuantum.Text = "Quantum";
            // 
            // Algorithm
            // 
            this.AcceptButton = this.btnAddProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 528);
            this.Controls.Add(this.lbQuantum);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.cbTypeAlgo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tblProcessInfo);
            this.Controls.Add(this.groupDetail);
            this.Name = "Algorithm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorithm";
            this.Load += new System.EventHandler(this.Algorithm_Load);
            this.groupDetail.ResumeLayout(false);
            this.groupDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProcessInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox groupDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtProcessName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtArrivalTime;
        private Guna.UI2.WinForms.Guna2TextBox txtExeTime;
        private Guna.UI2.WinForms.Guna2Button btnAddProcess;
        private Guna.UI2.WinForms.Guna2DataGridView tblProcessInfo;
        private Guna.UI2.WinForms.Guna2Button btnRun;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeAlgo;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantum;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbQuantum;
        private System.Windows.Forms.DataGridViewTextBoxColumn processName;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn executime;
    }
}