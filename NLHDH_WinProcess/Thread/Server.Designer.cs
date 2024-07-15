﻿namespace NLHDH_WinProcess.Thread
{
    partial class Server
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
            this.txbMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txbMessage
            // 
            this.txbMessage.BorderRadius = 10;
            this.txbMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMessage.DefaultText = "";
            this.txbMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMessage.Location = new System.Drawing.Point(7, 430);
            this.txbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.PasswordChar = '\0';
            this.txbMessage.PlaceholderText = "Enter a message ...";
            this.txbMessage.SelectedText = "";
            this.txbMessage.Size = new System.Drawing.Size(729, 68);
            this.txbMessage.TabIndex = 4;
            // 
            // lsvMessage
            // 
            this.lsvMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(0, -1);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(825, 425);
            this.lsvMessage.TabIndex = 3;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 8;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.Transparent;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = global::NLHDH_WinProcess.Properties.Resources.send;
            this.btnSend.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSend.Location = new System.Drawing.Point(743, 430);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(77, 68);
            this.btnSend.TabIndex = 5;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 504);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.lsvMessage);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txbMessage;
        private System.Windows.Forms.ListView lsvMessage;
    }
}