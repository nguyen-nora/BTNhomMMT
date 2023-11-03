
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
            this.txtViewChat = new System.Windows.Forms.TextBox();
            this.lvClient = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // txtViewChat
            // 
            this.txtViewChat.Location = new System.Drawing.Point(10, 26);
            this.txtViewChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtViewChat.Multiline = true;
            this.txtViewChat.Name = "txtViewChat";
            this.txtViewChat.ReadOnly = true;
            this.txtViewChat.Size = new System.Drawing.Size(186, 264);
            this.txtViewChat.TabIndex = 0;
            // 
            // lvClient
            // 
            this.lvClient.CheckBoxes = true;
            this.lvClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.lvClient.GridLines = true;
            this.lvClient.HideSelection = false;
            this.lvClient.Location = new System.Drawing.Point(234, 26);
            this.lvClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvClient.Name = "lvClient";
            this.lvClient.Size = new System.Drawing.Size(175, 264);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.lvClient);
            this.Controls.Add(this.txtViewChat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Group";
            this.Text = "Group";
            this.Load += new System.EventHandler(this.Group_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtViewChat;
        private System.Windows.Forms.ListView lvClient;
        private System.Windows.Forms.ColumnHeader name;
    }
}