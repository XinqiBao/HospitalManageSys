namespace HospitalManageSys
{
    partial class Form_Login
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(93, 31);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 21);
            this.textBox_ID.TabIndex = 0;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(93, 85);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(46, 34);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(41, 12);
            this.label_ID.TabIndex = 2;
            this.label_ID.Text = "账号：";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Location = new System.Drawing.Point(46, 61);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(41, 12);
            this.label_pwd.TabIndex = 3;
            this.label_pwd.Text = "密码：";
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(93, 58);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.ShortcutsEnabled = false;
            this.textBox_pwd.Size = new System.Drawing.Size(100, 21);
            this.textBox_pwd.TabIndex = 1;
            this.textBox_pwd.UseSystemPasswordChar = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(93, 114);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Form_Login
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 138);
            this.ControlBox = false;
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_ID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.administrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Button button_cancel;
    }
}