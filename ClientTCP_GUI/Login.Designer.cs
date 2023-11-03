namespace ClientTCP
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.usrLbl = new System.Windows.Forms.Label();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.usrTBox = new System.Windows.Forms.TextBox();
            this.pwdTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(65, 75);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Location = new System.Drawing.Point(12, 16);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(60, 15);
            this.usrLbl.TabIndex = 1;
            this.usrLbl.Text = "Username";
            // 
            // pwdLbl
            // 
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.Location = new System.Drawing.Point(12, 48);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(57, 15);
            this.pwdLbl.TabIndex = 2;
            this.pwdLbl.Text = "Password";
            // 
            // usrTBox
            // 
            this.usrTBox.Location = new System.Drawing.Point(75, 12);
            this.usrTBox.Name = "usrTBox";
            this.usrTBox.Size = new System.Drawing.Size(100, 23);
            this.usrTBox.TabIndex = 3;
            // 
            // pwdTBox
            // 
            this.pwdTBox.Location = new System.Drawing.Point(75, 45);
            this.pwdTBox.Name = "pwdTBox";
            this.pwdTBox.PasswordChar = '*';
            this.pwdTBox.Size = new System.Drawing.Size(100, 23);
            this.pwdTBox.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 110);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.usrTBox);
            this.Controls.Add(this.pwdTBox);
            this.Controls.Add(this.pwdLbl);
            this.Controls.Add(this.usrLbl);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.TextBox usrTBox;
        private System.Windows.Forms.TextBox pwdTBox;
    }
}

