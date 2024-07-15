namespace NLHDH_WinProcess
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.taskLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.taskDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.processDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.endtaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.taskSearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loadingBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.updateTaskBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.taskDgv)).BeginInit();
            this.taskMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.taskLabel.Location = new System.Drawing.Point(34, 12);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(201, 35);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Task Manager";
            // 
            // taskDgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.taskDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.taskDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDgv.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.taskDgv.ColumnHeadersHeight = 40;
            this.taskDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.taskDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processDgv,
            this.pid,
            this.status,
            this.memory});
            this.taskDgv.ContextMenuStrip = this.taskMenuStrip;
            this.taskDgv.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.taskDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.taskDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.taskDgv.Location = new System.Drawing.Point(1, 64);
            this.taskDgv.MultiSelect = false;
            this.taskDgv.Name = "taskDgv";
            this.taskDgv.ReadOnly = true;
            this.taskDgv.RowHeadersVisible = false;
            this.taskDgv.RowHeadersWidth = 56;
            this.taskDgv.RowTemplate.Height = 32;
            this.taskDgv.Size = new System.Drawing.Size(1174, 447);
            this.taskDgv.TabIndex = 1;
            this.taskDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.taskDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.taskDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.taskDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.taskDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.taskDgv.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.taskDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.taskDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.taskDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.taskDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.taskDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.taskDgv.ThemeStyle.HeaderStyle.Height = 40;
            this.taskDgv.ThemeStyle.ReadOnly = true;
            this.taskDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.taskDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.taskDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.taskDgv.ThemeStyle.RowsStyle.Height = 32;
            this.taskDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.taskDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // processDgv
            // 
            this.processDgv.HeaderText = "Processes";
            this.processDgv.MinimumWidth = 7;
            this.processDgv.Name = "processDgv";
            this.processDgv.ReadOnly = true;
            // 
            // pid
            // 
            this.pid.HeaderText = "PID";
            this.pid.MinimumWidth = 7;
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 7;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // memory
            // 
            this.memory.HeaderText = "Memory";
            this.memory.MinimumWidth = 7;
            this.memory.Name = "memory";
            this.memory.ReadOnly = true;
            // 
            // taskMenuStrip
            // 
            this.taskMenuStrip.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.taskMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endtaskToolStripMenuItem});
            this.taskMenuStrip.Name = "taskMenuStrip";
            this.taskMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.taskMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.taskMenuStrip.RenderStyle.ColorTable = null;
            this.taskMenuStrip.RenderStyle.RoundedEdges = true;
            this.taskMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.taskMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.taskMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.taskMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.taskMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.taskMenuStrip.Size = new System.Drawing.Size(139, 30);
            // 
            // endtaskToolStripMenuItem
            // 
            this.endtaskToolStripMenuItem.Name = "endtaskToolStripMenuItem";
            this.endtaskToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.endtaskToolStripMenuItem.Text = "End task";
            this.endtaskToolStripMenuItem.Click += new System.EventHandler(this.endtaskToolStripMenuItem_Click);
            // 
            // taskSearch
            // 
            this.taskSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taskSearch.BorderRadius = 4;
            this.taskSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taskSearch.DefaultText = "";
            this.taskSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.taskSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.taskSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.taskSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.taskSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.taskSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.taskSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.taskSearch.Location = new System.Drawing.Point(795, 13);
            this.taskSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskSearch.Name = "taskSearch";
            this.taskSearch.PasswordChar = '\0';
            this.taskSearch.PlaceholderText = "Nhập tên tiến trình...";
            this.taskSearch.SelectedText = "";
            this.taskSearch.Size = new System.Drawing.Size(257, 34);
            this.taskSearch.TabIndex = 3;
            this.taskSearch.TextChanged += new System.EventHandler(this.taskSearch_TextChanged);
            this.taskSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskSearch_KeyDown);
            // 
            // taskSearchBtn
            // 
            this.taskSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taskSearchBtn.BorderRadius = 4;
            this.taskSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskSearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.taskSearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.taskSearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.taskSearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.taskSearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.taskSearchBtn.ForeColor = System.Drawing.Color.White;
            this.taskSearchBtn.Location = new System.Drawing.Point(1059, 13);
            this.taskSearchBtn.Name = "taskSearchBtn";
            this.taskSearchBtn.Size = new System.Drawing.Size(81, 34);
            this.taskSearchBtn.TabIndex = 4;
            this.taskSearchBtn.Text = "Search";
            this.taskSearchBtn.Click += new System.EventHandler(this.taskSearchBtn_Click);
            // 
            // loadingBtn
            // 
            this.loadingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingBtn.BackColor = System.Drawing.Color.Transparent;
            this.loadingBtn.FillColor = System.Drawing.Color.Transparent;
            this.loadingBtn.Image = global::NLHDH_WinProcess.Properties.Resources.loading;
            this.loadingBtn.ImageRotate = 0F;
            this.loadingBtn.InitialImage = null;
            this.loadingBtn.Location = new System.Drawing.Point(490, 170);
            this.loadingBtn.Name = "loadingBtn";
            this.loadingBtn.Size = new System.Drawing.Size(194, 191);
            this.loadingBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingBtn.TabIndex = 7;
            this.loadingBtn.TabStop = false;
            this.loadingBtn.UseWaitCursor = true;
            // 
            // updateTaskBtn
            // 
            this.updateTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateTaskBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateTaskBtn.BorderRadius = 10;
            this.updateTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateTaskBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateTaskBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateTaskBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateTaskBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateTaskBtn.FillColor = System.Drawing.Color.Transparent;
            this.updateTaskBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateTaskBtn.ForeColor = System.Drawing.Color.White;
            this.updateTaskBtn.Image = global::NLHDH_WinProcess.Properties.Resources.icons8_update_48;
            this.updateTaskBtn.Location = new System.Drawing.Point(733, 13);
            this.updateTaskBtn.Name = "updateTaskBtn";
            this.updateTaskBtn.Size = new System.Drawing.Size(55, 34);
            this.updateTaskBtn.TabIndex = 5;
            this.updateTaskBtn.Click += new System.EventHandler(this.updateTaskBtn_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 510);
            this.Controls.Add(this.loadingBtn);
            this.Controls.Add(this.updateTaskBtn);
            this.Controls.Add(this.taskSearchBtn);
            this.Controls.Add(this.taskSearch);
            this.Controls.Add(this.taskDgv);
            this.Controls.Add(this.taskLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskDgv)).EndInit();
            this.taskMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel taskLabel;
        private Guna.UI2.WinForms.Guna2DataGridView taskDgv;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip taskMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem endtaskToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TextBox taskSearch;
        private Guna.UI2.WinForms.Guna2Button taskSearchBtn;
        private Guna.UI2.WinForms.Guna2Button updateTaskBtn;
        private Guna.UI2.WinForms.Guna2PictureBox loadingBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn memory;
    }
}