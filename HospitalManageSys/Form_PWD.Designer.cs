namespace HospitalManageSys
{
    partial class Form_PWD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_prePWD = new System.Windows.Forms.TextBox();
            this.textBox_newPWD = new System.Windows.Forms.TextBox();
            this.textBox_PWDagain = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "重复新密码：";
            // 
            // textBox_prePWD
            // 
            this.textBox_prePWD.Location = new System.Drawing.Point(136, 53);
            this.textBox_prePWD.Name = "textBox_prePWD";
            this.textBox_prePWD.PasswordChar = '*';
            this.textBox_prePWD.ShortcutsEnabled = false;
            this.textBox_prePWD.Size = new System.Drawing.Size(100, 21);
            this.textBox_prePWD.TabIndex = 1;
            this.textBox_prePWD.UseSystemPasswordChar = true;
            // 
            // textBox_newPWD
            // 
            this.textBox_newPWD.Location = new System.Drawing.Point(136, 102);
            this.textBox_newPWD.Name = "textBox_newPWD";
            this.textBox_newPWD.PasswordChar = '*';
            this.textBox_newPWD.ShortcutsEnabled = false;
            this.textBox_newPWD.Size = new System.Drawing.Size(100, 21);
            this.textBox_newPWD.TabIndex = 2;
            this.textBox_newPWD.UseSystemPasswordChar = true;
            // 
            // textBox_PWDagain
            // 
            this.textBox_PWDagain.Location = new System.Drawing.Point(136, 129);
            this.textBox_PWDagain.Name = "textBox_PWDagain";
            this.textBox_PWDagain.PasswordChar = '*';
            this.textBox_PWDagain.ShortcutsEnabled = false;
            this.textBox_PWDagain.Size = new System.Drawing.Size(100, 21);
            this.textBox_PWDagain.TabIndex = 3;
            this.textBox_PWDagain.UseSystemPasswordChar = true;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(243, 163);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(243, 192);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Form_PWD
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 223);
            this.ControlBox = false;
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_PWDagain);
            this.Controls.Add(this.textBox_newPWD);
            this.Controls.Add(this.textBox_prePWD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_PWD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更换密码";
            this.Load += new System.EventHandler(this.Form_PWD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_prePWD;
        private System.Windows.Forms.TextBox textBox_newPWD;
        private System.Windows.Forms.TextBox textBox_PWDagain;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
    }
}