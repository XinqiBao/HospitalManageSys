namespace HospitalManageSys
{
    partial class Form_Adminisrtator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.cb_job = new System.Windows.Forms.ComboBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.tb_fee = new System.Windows.Forms.TextBox();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.所有员工信息 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check_4 = new System.Windows.Forms.CheckBox();
            this.check_5 = new System.Windows.Forms.CheckBox();
            this.check_1 = new System.Windows.Forms.CheckBox();
            this.check_6 = new System.Windows.Forms.CheckBox();
            this.check_2 = new System.Windows.Forms.CheckBox();
            this.check_3 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.所有员工信息.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pb_photo);
            this.groupBox1.Controls.Add(this.cb_department);
            this.groupBox1.Controls.Add(this.cb_job);
            this.groupBox1.Controls.Add(this.cb_sex);
            this.groupBox1.Controls.Add(this.tb_fee);
            this.groupBox1.Controls.Add(this.tb_comment);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工详细信息";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(380, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "清空(&C)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(380, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "修改(&M)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "删除(&D)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "添加(&A)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pb_photo
            // 
            this.pb_photo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pb_photo.BackgroundImage = global::HospitalManageSys.Properties.Resources.QQ截图20161101204141;
            this.pb_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_photo.ErrorImage = null;
            this.pb_photo.Location = new System.Drawing.Point(243, 30);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(119, 153);
            this.pb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_photo.TabIndex = 3;
            this.pb_photo.TabStop = false;
            this.pb_photo.Click += new System.EventHandler(this.pb_photo_Click);
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "办公室",
            "财务科",
            "护理科",
            "后勤部",
            "内科",
            "外科",
            "妇科",
            "男科",
            "儿科",
            "五官科",
            "肿瘤科",
            "皮肤科",
            "放射科",
            "中医科"});
            this.cb_department.Location = new System.Drawing.Point(82, 136);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(135, 20);
            this.cb_department.TabIndex = 2;
            // 
            // cb_job
            // 
            this.cb_job.FormattingEnabled = true;
            this.cb_job.Items.AddRange(new object[] {
            "院长",
            "副院长",
            "科室主任",
            "护士长",
            "财务主任",
            "门诊医生",
            "护士",
            "药房会计",
            "药房库管",
            "挂号/收银员"});
            this.cb_job.Location = new System.Drawing.Point(82, 110);
            this.cb_job.Name = "cb_job";
            this.cb_job.Size = new System.Drawing.Size(135, 20);
            this.cb_job.TabIndex = 2;
            // 
            // cb_sex
            // 
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cb_sex.Location = new System.Drawing.Point(82, 84);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(135, 20);
            this.cb_sex.TabIndex = 2;
            // 
            // tb_fee
            // 
            this.tb_fee.Location = new System.Drawing.Point(82, 162);
            this.tb_fee.Name = "tb_fee";
            this.tb_fee.Size = new System.Drawing.Size(137, 21);
            this.tb_fee.TabIndex = 1;
            // 
            // tb_comment
            // 
            this.tb_comment.Location = new System.Drawing.Point(80, 189);
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(375, 21);
            this.tb_comment.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(82, 57);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(135, 21);
            this.tb_password.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(82, 30);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(135, 21);
            this.tb_name.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "备    注:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "挂 号 费:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "科    室:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "职    位:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "密    码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "性    别:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓    名:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询(&F)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(82, 43);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(135, 21);
            this.tb_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编    号:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.tb_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(8, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 82);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "员工查询";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(364, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "所有员工(&S)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // 所有员工信息
            // 
            this.所有员工信息.Controls.Add(this.dataGridView1);
            this.所有员工信息.Location = new System.Drawing.Point(485, 13);
            this.所有员工信息.Name = "所有员工信息";
            this.所有员工信息.Size = new System.Drawing.Size(456, 407);
            this.所有员工信息.TabIndex = 7;
            this.所有员工信息.TabStop = false;
            this.所有员工信息.Text = "所有员工信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(-2, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(449, 381);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_4);
            this.groupBox3.Controls.Add(this.check_5);
            this.groupBox3.Controls.Add(this.check_1);
            this.groupBox3.Controls.Add(this.check_6);
            this.groupBox3.Controls.Add(this.check_2);
            this.groupBox3.Controls.Add(this.check_3);
            this.groupBox3.Location = new System.Drawing.Point(8, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 96);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "权限设置";
            // 
            // check_4
            // 
            this.check_4.AutoSize = true;
            this.check_4.Location = new System.Drawing.Point(32, 59);
            this.check_4.Name = "check_4";
            this.check_4.Size = new System.Drawing.Size(72, 16);
            this.check_4.TabIndex = 0;
            this.check_4.Text = "发药系统";
            this.check_4.UseVisualStyleBackColor = true;
            // 
            // check_5
            // 
            this.check_5.AutoSize = true;
            this.check_5.Location = new System.Drawing.Point(176, 59);
            this.check_5.Name = "check_5";
            this.check_5.Size = new System.Drawing.Size(72, 16);
            this.check_5.TabIndex = 0;
            this.check_5.Text = "收费系统";
            this.check_5.UseVisualStyleBackColor = true;
            // 
            // check_1
            // 
            this.check_1.AutoSize = true;
            this.check_1.Location = new System.Drawing.Point(32, 28);
            this.check_1.Name = "check_1";
            this.check_1.Size = new System.Drawing.Size(72, 16);
            this.check_1.TabIndex = 0;
            this.check_1.Text = "人事管理";
            this.check_1.UseVisualStyleBackColor = true;
            // 
            // check_6
            // 
            this.check_6.AutoSize = true;
            this.check_6.Location = new System.Drawing.Point(310, 59);
            this.check_6.Name = "check_6";
            this.check_6.Size = new System.Drawing.Size(72, 16);
            this.check_6.TabIndex = 0;
            this.check_6.Text = "药品入库";
            this.check_6.UseVisualStyleBackColor = true;
            // 
            // check_2
            // 
            this.check_2.AutoSize = true;
            this.check_2.Location = new System.Drawing.Point(176, 28);
            this.check_2.Name = "check_2";
            this.check_2.Size = new System.Drawing.Size(72, 16);
            this.check_2.TabIndex = 0;
            this.check_2.Text = "门诊挂号";
            this.check_2.UseVisualStyleBackColor = true;
            // 
            // check_3
            // 
            this.check_3.AutoSize = true;
            this.check_3.Location = new System.Drawing.Point(310, 28);
            this.check_3.Name = "check_3";
            this.check_3.Size = new System.Drawing.Size(72, 16);
            this.check_3.TabIndex = 0;
            this.check_3.Text = "医生门诊";
            this.check_3.UseVisualStyleBackColor = true;
            // 
            // Form_Adminisrtator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 421);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.所有员工信息);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Adminisrtator";
            this.Text = "人事信息";
            this.Load += new System.EventHandler(this.Form_Adminisrtator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.所有员工信息.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.TextBox tb_fee;
        private System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox 所有员工信息;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_job;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox check_4;
        private System.Windows.Forms.CheckBox check_5;
        private System.Windows.Forms.CheckBox check_1;
        private System.Windows.Forms.CheckBox check_6;
        private System.Windows.Forms.CheckBox check_2;
        private System.Windows.Forms.CheckBox check_3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label8;
    }
}

