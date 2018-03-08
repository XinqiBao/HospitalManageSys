namespace HospitalManageSys
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.AdminOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminLogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminPWDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_login = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Admin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Registration = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Clinic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_DrugEx = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Charge = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_DrugIm = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_exit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.label_job = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_sex = new System.Windows.Forms.Label();
            this.label_depart = new System.Windows.Forms.Label();
            this.label_lflogin = new System.Windows.Forms.Label();
            this.panel_WinArea = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_WinArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminOperationToolStripMenuItem,
            this.windowsMenu,
            this.viewMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(801, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // AdminOperationToolStripMenuItem
            // 
            this.AdminOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminLoginToolStripMenuItem,
            this.AdminLogoutToolStripMenuItem,
            this.AdminSwitchToolStripMenuItem,
            this.AdminPWDToolStripMenuItem,
            this.toolStripSeparator9,
            this.exitToolStripMenuItem});
            this.AdminOperationToolStripMenuItem.Name = "AdminOperationToolStripMenuItem";
            this.AdminOperationToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.AdminOperationToolStripMenuItem.Text = "用户操作(&A)";
            // 
            // AdminLoginToolStripMenuItem
            // 
            this.AdminLoginToolStripMenuItem.Name = "AdminLoginToolStripMenuItem";
            this.AdminLoginToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.AdminLoginToolStripMenuItem.Text = "用户登录";
            this.AdminLoginToolStripMenuItem.Click += new System.EventHandler(this.AdminLoginToolStripMenuItem_Click);
            // 
            // AdminLogoutToolStripMenuItem
            // 
            this.AdminLogoutToolStripMenuItem.Name = "AdminLogoutToolStripMenuItem";
            this.AdminLogoutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.AdminLogoutToolStripMenuItem.Text = "用户注销";
            this.AdminLogoutToolStripMenuItem.Click += new System.EventHandler(this.AdminLogoutToolStripMenuItem_Click);
            // 
            // AdminSwitchToolStripMenuItem
            // 
            this.AdminSwitchToolStripMenuItem.Name = "AdminSwitchToolStripMenuItem";
            this.AdminSwitchToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.AdminSwitchToolStripMenuItem.Text = "用户切换";
            this.AdminSwitchToolStripMenuItem.Click += new System.EventHandler(this.AdminSwitchToolStripMenuItem_Click);
            // 
            // AdminPWDToolStripMenuItem
            // 
            this.AdminPWDToolStripMenuItem.Name = "AdminPWDToolStripMenuItem";
            this.AdminPWDToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.AdminPWDToolStripMenuItem.Text = "更换密码";
            this.AdminPWDToolStripMenuItem.Click += new System.EventHandler(this.AdminPWDToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "退出系统(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(64, 21);
            this.windowsMenu.Text = "窗口(&W)";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cascadeToolStripMenuItem.Text = "层叠(&C)";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.tileVerticalToolStripMenuItem.Text = "垂直平铺(&V)";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.tileHorizontalToolStripMenuItem.Text = "水平平铺(&H)";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.closeAllToolStripMenuItem.Text = "全部关闭(&L)";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.arrangeIconsToolStripMenuItem.Text = "排列图标(&A)";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(60, 21);
            this.viewMenu.Text = "视图(&V)";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.toolBarToolStripMenuItem.Text = "工具栏(&T)";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.statusBarToolStripMenuItem.Text = "状态栏(&S)";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(61, 21);
            this.helpMenu.Text = "帮助(&H)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "关于(&A) ... ...";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_login,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton_Admin,
            this.toolStripButton_Registration,
            this.toolStripButton_Clinic,
            this.toolStripButton_DrugEx,
            this.toolStripButton_Charge,
            this.toolStripButton_DrugIm,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton_exit});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(801, 40);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripButton_login
            // 
            this.toolStripButton_login.Image = global::HospitalManageSys.Properties.Resources.login;
            this.toolStripButton_login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_login.Name = "toolStripButton_login";
            this.toolStripButton_login.Size = new System.Drawing.Size(36, 37);
            this.toolStripButton_login.Text = "登录";
            this.toolStripButton_login.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_login.Click += new System.EventHandler(this.AdminLoginToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButton_Admin
            // 
            this.toolStripButton_Admin.Enabled = false;
            this.toolStripButton_Admin.Image = global::HospitalManageSys.Properties.Resources.admin;
            this.toolStripButton_Admin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Admin.Name = "toolStripButton_Admin";
            this.toolStripButton_Admin.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton_Admin.Text = "人事管理";
            this.toolStripButton_Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Admin.Click += new System.EventHandler(this.AdminForm_Click);
            // 
            // toolStripButton_Registration
            // 
            this.toolStripButton_Registration.Enabled = false;
            this.toolStripButton_Registration.Image = global::HospitalManageSys.Properties.Resources.registration;
            this.toolStripButton_Registration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Registration.Name = "toolStripButton_Registration";
            this.toolStripButton_Registration.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton_Registration.Text = "门诊挂号";
            this.toolStripButton_Registration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Registration.Click += new System.EventHandler(this.RegistrationForm_Click);
            // 
            // toolStripButton_Clinic
            // 
            this.toolStripButton_Clinic.Enabled = false;
            this.toolStripButton_Clinic.Image = global::HospitalManageSys.Properties.Resources.clinic;
            this.toolStripButton_Clinic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Clinic.Name = "toolStripButton_Clinic";
            this.toolStripButton_Clinic.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton_Clinic.Text = "医生门诊";
            this.toolStripButton_Clinic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Clinic.Click += new System.EventHandler(this.ClinicForm_Click);
            // 
            // toolStripButton_DrugEx
            // 
            this.toolStripButton_DrugEx.Enabled = false;
            this.toolStripButton_DrugEx.Image = global::HospitalManageSys.Properties.Resources.drugEx;
            this.toolStripButton_DrugEx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DrugEx.Name = "toolStripButton_DrugEx";
            this.toolStripButton_DrugEx.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton_DrugEx.Text = "发药系统";
            this.toolStripButton_DrugEx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_DrugEx.Click += new System.EventHandler(this.DrugExForm_Click);
            // 
            // toolStripButton_Charge
            // 
            this.toolStripButton_Charge.Enabled = false;
            this.toolStripButton_Charge.Image = global::HospitalManageSys.Properties.Resources.charge;
            this.toolStripButton_Charge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Charge.Name = "toolStripButton_Charge";
            this.toolStripButton_Charge.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton_Charge.Text = "收费系统";
            this.toolStripButton_Charge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Charge.Click += new System.EventHandler(this.ChargeForm_Click);
            // 
            // toolStripButton_DrugIm
            // 
            this.toolStripButton_DrugIm.Enabled = false;
            this.toolStripButton_DrugIm.Image = global::HospitalManageSys.Properties.Resources.drugIm;
            this.toolStripButton_DrugIm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DrugIm.Name = "toolStripButton_DrugIm";
            this.toolStripButton_DrugIm.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton_DrugIm.Text = "药品入库";
            this.toolStripButton_DrugIm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_DrugIm.Click += new System.EventHandler(this.DrugImForm_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButton_exit
            // 
            this.toolStripButton_exit.Image = global::HospitalManageSys.Properties.Resources.exit;
            this.toolStripButton_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_exit.Name = "toolStripButton_exit";
            this.toolStripButton_exit.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton_exit.Text = "退出系统";
            this.toolStripButton_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_exit.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 547);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(801, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // groupBox_info
            // 
            this.groupBox_info.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox_info.Controls.Add(this.label_job);
            this.groupBox_info.Controls.Add(this.label5);
            this.groupBox_info.Controls.Add(this.pictureBox1);
            this.groupBox_info.Controls.Add(this.label1);
            this.groupBox_info.Controls.Add(this.label2);
            this.groupBox_info.Controls.Add(this.label3);
            this.groupBox_info.Controls.Add(this.label4);
            this.groupBox_info.Controls.Add(this.label_id);
            this.groupBox_info.Controls.Add(this.label_name);
            this.groupBox_info.Controls.Add(this.label_sex);
            this.groupBox_info.Controls.Add(this.label_depart);
            this.groupBox_info.Location = new System.Drawing.Point(8, 50);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(270, 199);
            this.groupBox_info.TabIndex = 11;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "操作用户";
            this.groupBox_info.Visible = false;
            // 
            // label_job
            // 
            this.label_job.AutoSize = true;
            this.label_job.Location = new System.Drawing.Point(53, 173);
            this.label_job.Name = "label_job";
            this.label_job.Size = new System.Drawing.Size(35, 12);
            this.label_job.TabIndex = 21;
            this.label_job.Text = "*job*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "职位：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HospitalManageSys.Properties.Resources.QQ截图20161101204141;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(149, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 165);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "部门：";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(53, 30);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(29, 12);
            this.label_id.TabIndex = 15;
            this.label_id.Text = "*ID*";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(53, 65);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 12);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "*name*";
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Location = new System.Drawing.Point(53, 104);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(35, 12);
            this.label_sex.TabIndex = 17;
            this.label_sex.Text = "*sex*";
            // 
            // label_depart
            // 
            this.label_depart.AutoSize = true;
            this.label_depart.Location = new System.Drawing.Point(53, 141);
            this.label_depart.Name = "label_depart";
            this.label_depart.Size = new System.Drawing.Size(77, 12);
            this.label_depart.TabIndex = 18;
            this.label_depart.Text = "*department*";
            // 
            // label_lflogin
            // 
            this.label_lflogin.AutoSize = true;
            this.label_lflogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_lflogin.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_lflogin.ForeColor = System.Drawing.Color.Red;
            this.label_lflogin.Location = new System.Drawing.Point(3, 50);
            this.label_lflogin.Name = "label_lflogin";
            this.label_lflogin.Size = new System.Drawing.Size(187, 29);
            this.label_lflogin.TabIndex = 4;
            this.label_lflogin.Text = "请登录账号！";
            // 
            // panel_WinArea
            // 
            this.panel_WinArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_WinArea.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel_WinArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_WinArea.Controls.Add(this.groupBox_info);
            this.panel_WinArea.Controls.Add(this.label_lflogin);
            this.panel_WinArea.Location = new System.Drawing.Point(515, 28);
            this.panel_WinArea.Name = "panel_WinArea";
            this.panel_WinArea.Size = new System.Drawing.Size(286, 541);
            this.panel_WinArea.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::HospitalManageSys.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 569);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel_WinArea);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "医院管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_WinArea.ResumeLayout(false);
            this.panel_WinArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.Label label_depart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem AdminOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminSwitchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminLogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_login;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label_lflogin;
        private System.Windows.Forms.Panel panel_WinArea;
        private System.Windows.Forms.ToolStripButton toolStripButton_Registration;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton_exit;
        private System.Windows.Forms.ToolStripButton toolStripButton_Admin;
        private System.Windows.Forms.ToolStripButton toolStripButton_Charge;
        private System.Windows.Forms.ToolStripButton toolStripButton_Clinic;
        private System.Windows.Forms.ToolStripButton toolStripButton_DrugEx;
        private System.Windows.Forms.ToolStripButton toolStripButton_DrugIm;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem AdminPWDToolStripMenuItem;
        private System.Windows.Forms.Label label_job;
        private System.Windows.Forms.Label label5;
    }
}



