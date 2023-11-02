namespace ClientTCP
{
    partial class MainForm
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
            this.butSend = new System.Windows.Forms.Button();
            this.txtViewMess = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.GroupBox();
            this.cms_ClientToClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lv_TochosseClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.butSendChatCTC = new System.Windows.Forms.Button();
            this.txtViewChatCTC = new System.Windows.Forms.TextBox();
            this.txtSendViewChatCTC = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.butRoom = new System.Windows.Forms.Button();
            this.Server.SuspendLayout();
            this.cms_ClientToClient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(597, 334);
            this.butSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(98, 26);
            this.butSend.TabIndex = 1;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // txtViewMess
            // 
            this.txtViewMess.Location = new System.Drawing.Point(6, 26);
            this.txtViewMess.Multiline = true;
            this.txtViewMess.Name = "txtViewMess";
            this.txtViewMess.Size = new System.Drawing.Size(689, 301);
            this.txtViewMess.TabIndex = 9;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(6, 333);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(587, 27);
            this.txtMess.TabIndex = 10;
            // 
            // Server
            // 
            this.Server.Controls.Add(this.butSend);
            this.Server.Controls.Add(this.txtViewMess);
            this.Server.Controls.Add(this.txtMess);
            this.Server.Location = new System.Drawing.Point(6, 6);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(701, 380);
            this.Server.TabIndex = 11;
            this.Server.TabStop = false;
            this.Server.Text = "Server";
            // 
            // cms_ClientToClient
            // 
            this.cms_ClientToClient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_ClientToClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.clientToClientToolStripMenuItem});
            this.cms_ClientToClient.Name = "cms_ClientToClient";
            this.cms_ClientToClient.Size = new System.Drawing.Size(179, 52);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // clientToClientToolStripMenuItem
            // 
            this.clientToClientToolStripMenuItem.Name = "clientToClientToolStripMenuItem";
            this.clientToClientToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.clientToClientToolStripMenuItem.Text = "Client To Client";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 489);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.butRoom);
            this.tabPage1.Controls.Add(this.Server);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1163, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lv_TochosseClient);
            this.tabPage2.Controls.Add(this.butSendChatCTC);
            this.tabPage2.Controls.Add(this.txtViewChatCTC);
            this.tabPage2.Controls.Add(this.txtSendViewChatCTC);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1163, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client To Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lv_TochosseClient
            // 
            this.lv_TochosseClient.CheckBoxes = true;
            this.lv_TochosseClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_TochosseClient.ContextMenuStrip = this.cms_ClientToClient;
            this.lv_TochosseClient.GridLines = true;
            this.lv_TochosseClient.HideSelection = false;
            this.lv_TochosseClient.Location = new System.Drawing.Point(742, 19);
            this.lv_TochosseClient.Name = "lv_TochosseClient";
            this.lv_TochosseClient.Size = new System.Drawing.Size(406, 344);
            this.lv_TochosseClient.TabIndex = 12;
            this.lv_TochosseClient.UseCompatibleStateImageBehavior = false;
            this.lv_TochosseClient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // butSendChatCTC
            // 
            this.butSendChatCTC.Location = new System.Drawing.Point(610, 370);
            this.butSendChatCTC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butSendChatCTC.Name = "butSendChatCTC";
            this.butSendChatCTC.Size = new System.Drawing.Size(98, 26);
            this.butSendChatCTC.TabIndex = 11;
            this.butSendChatCTC.Text = "Send";
            this.butSendChatCTC.UseVisualStyleBackColor = true;
            // 
            // txtViewChatCTC
            // 
            this.txtViewChatCTC.Location = new System.Drawing.Point(17, 19);
            this.txtViewChatCTC.Multiline = true;
            this.txtViewChatCTC.Name = "txtViewChatCTC";
            this.txtViewChatCTC.Size = new System.Drawing.Size(691, 344);
            this.txtViewChatCTC.TabIndex = 12;
            // 
            // txtSendViewChatCTC
            // 
            this.txtSendViewChatCTC.Location = new System.Drawing.Point(17, 370);
            this.txtSendViewChatCTC.Name = "txtSendViewChatCTC";
            this.txtSendViewChatCTC.Size = new System.Drawing.Size(587, 27);
            this.txtSendViewChatCTC.TabIndex = 13;
            // 
            // butRoom
            // 
            this.butRoom.Location = new System.Drawing.Point(12, 392);
            this.butRoom.Name = "butRoom";
            this.butRoom.Size = new System.Drawing.Size(162, 44);
            this.butRoom.TabIndex = 12;
            this.butRoom.Text = "Create Room";
            this.butRoom.UseVisualStyleBackColor = true;
            this.butRoom.Click += new System.EventHandler(this.butRoom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 523);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Server.ResumeLayout(false);
            this.Server.PerformLayout();
            this.cms_ClientToClient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.TextBox txtViewMess;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.GroupBox Server;
        private System.Windows.Forms.ContextMenuStrip cms_ClientToClient;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToClientToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lv_TochosseClient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button butSendChatCTC;
        private System.Windows.Forms.TextBox txtViewChatCTC;
        private System.Windows.Forms.TextBox txtSendViewChatCTC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button butRoom;
    }
}