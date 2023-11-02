
namespace ClientTCP
{
    partial class Group
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.txtViewChat = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.lvClient = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // txtViewChat
            // 
            this.txtViewChat.Location = new System.Drawing.Point(12, 34);
            this.txtViewChat.Multiline = true;
            this.txtViewChat.Name = "txtViewChat";
            this.txtViewChat.ReadOnly = true;
            this.txtViewChat.Size = new System.Drawing.Size(464, 305);
            this.txtViewChat.TabIndex = 0;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(12, 360);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(364, 27);
            this.txtMess.TabIndex = 1;
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(382, 360);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(94, 29);
            this.butSend.TabIndex = 2;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            // 
            // lvClient
            // 
            this.lvClient.CheckBoxes = true;
            this.lvClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.lvClient.GridLines = true;
            this.lvClient.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lvClient.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvClient.Location = new System.Drawing.Point(533, 34);
            this.lvClient.Name = "lvClient";
            this.lvClient.Size = new System.Drawing.Size(329, 300);
            this.lvClient.TabIndex = 3;
            this.lvClient.UseCompatibleStateImageBehavior = false;
            this.lvClient.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 120;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 426);
            this.Controls.Add(this.lvClient);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.txtViewChat);
            this.Name = "Group";
            this.Text = "Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtViewChat;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.ListView lvClient;
        private System.Windows.Forms.ColumnHeader name;
    }
}