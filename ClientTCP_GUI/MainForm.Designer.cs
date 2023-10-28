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
            this.txtMess = new System.Windows.Forms.TextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(472, 12);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(316, 191);
            this.txtMess.TabIndex = 0;
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(713, 209);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 1;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.txtMess);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button butSend;
    }
}