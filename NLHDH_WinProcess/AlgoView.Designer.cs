namespace NLHDH_WinProcess
{
    partial class AlgoView
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbProcessName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbExeTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tblProcessInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.processName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luuLaiHeThong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianCho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbWaitAvg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbSystemAvg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GroupBoxLabel = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tblProcessInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(370, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(110, 22);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Process Name:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(607, 37);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(115, 22);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Execution Time:";
            // 
            // lbProcessName
            // 
            this.lbProcessName.AutoSize = false;
            this.lbProcessName.BackColor = System.Drawing.Color.Transparent;
            this.lbProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessName.Location = new System.Drawing.Point(486, 37);
            this.lbProcessName.Name = "lbProcessName";
            this.lbProcessName.Size = new System.Drawing.Size(39, 20);
            this.lbProcessName.TabIndex = 3;
            this.lbProcessName.Text = "_-_";
            // 
            // lbExeTime
            // 
            this.lbExeTime.AutoSize = false;
            this.lbExeTime.BackColor = System.Drawing.Color.Transparent;
            this.lbExeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExeTime.Location = new System.Drawing.Point(731, 38);
            this.lbExeTime.Name = "lbExeTime";
            this.lbExeTime.Size = new System.Drawing.Size(38, 20);
            this.lbExeTime.TabIndex = 4;
            this.lbExeTime.Text = "_-_";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1112, 81);
            this.tableLayoutPanel.TabIndex = 6;
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
            this.luuLaiHeThong,
            this.thoiGianCho});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblProcessInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblProcessInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblProcessInfo.Location = new System.Drawing.Point(0, 192);
            this.tblProcessInfo.Name = "tblProcessInfo";
            this.tblProcessInfo.ReadOnly = true;
            this.tblProcessInfo.RowHeadersVisible = false;
            this.tblProcessInfo.RowHeadersWidth = 80;
            this.tblProcessInfo.RowTemplate.Height = 36;
            this.tblProcessInfo.Size = new System.Drawing.Size(1112, 204);
            this.tblProcessInfo.TabIndex = 7;
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
            // luuLaiHeThong
            // 
            this.luuLaiHeThong.HeaderText = "Thời gian lưu lại hệ thống";
            this.luuLaiHeThong.MinimumWidth = 7;
            this.luuLaiHeThong.Name = "luuLaiHeThong";
            this.luuLaiHeThong.ReadOnly = true;
            // 
            // thoiGianCho
            // 
            this.thoiGianCho.HeaderText = "Thời gian chờ";
            this.thoiGianCho.MinimumWidth = 7;
            this.thoiGianCho.Name = "thoiGianCho";
            this.thoiGianCho.ReadOnly = true;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(120, 416);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(176, 22);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Thời gian chờ trung bình:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(772, 416);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(190, 22);
            this.guna2HtmlLabel5.TabIndex = 9;
            this.guna2HtmlLabel5.Text = "Thời gian lưu lại trung bình:";
            // 
            // lbWaitAvg
            // 
            this.lbWaitAvg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWaitAvg.BackColor = System.Drawing.Color.Transparent;
            this.lbWaitAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitAvg.Location = new System.Drawing.Point(301, 417);
            this.lbWaitAvg.Name = "lbWaitAvg";
            this.lbWaitAvg.Size = new System.Drawing.Size(26, 22);
            this.lbWaitAvg.TabIndex = 10;
            this.lbWaitAvg.Text = "_-_";
            // 
            // lbSystemAvg
            // 
            this.lbSystemAvg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSystemAvg.BackColor = System.Drawing.Color.Transparent;
            this.lbSystemAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSystemAvg.Location = new System.Drawing.Point(967, 417);
            this.lbSystemAvg.Name = "lbSystemAvg";
            this.lbSystemAvg.Size = new System.Drawing.Size(26, 22);
            this.lbSystemAvg.TabIndex = 11;
            this.lbSystemAvg.Text = "_-_";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.CustomBorderColor = System.Drawing.Color.Transparent;
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox.Location = new System.Drawing.Point(0, 488);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1112, 58);
            this.groupBox.TabIndex = 12;
            this.groupBox.Text = "Gantt Chart";
            // 
            // GroupBoxLabel
            // 
            this.GroupBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxLabel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GroupBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupBoxLabel.ForeColor = System.Drawing.Color.Transparent;
            this.GroupBoxLabel.Location = new System.Drawing.Point(0, 546);
            this.GroupBoxLabel.Name = "GroupBoxLabel";
            this.GroupBoxLabel.Size = new System.Drawing.Size(1115, 41);
            this.GroupBoxLabel.TabIndex = 13;
            this.GroupBoxLabel.Text = "guna2GroupBox2";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(479, 460);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(155, 22);
            this.guna2HtmlLabel3.TabIndex = 14;
            this.guna2HtmlLabel3.Text = "------ Gantt Chart ------";
            // 
            // AlgoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 583);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.GroupBoxLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lbSystemAvg);
            this.Controls.Add(this.lbWaitAvg);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.tblProcessInfo);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.lbExeTime);
            this.Controls.Add(this.lbProcessName);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "AlgoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlgoView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlgoView_FormClosed);
            this.Load += new System.EventHandler(this.AlgoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProcessInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbProcessName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbExeTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Guna.UI2.WinForms.Guna2DataGridView tblProcessInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn processName;
        private System.Windows.Forms.DataGridViewTextBoxColumn luuLaiHeThong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianCho;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbWaitAvg;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSystemAvg;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBoxLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}