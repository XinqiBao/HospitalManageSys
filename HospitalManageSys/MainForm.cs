using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace HospitalManageSys
{
    public partial class MainForm : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataAdapter ada;
        private DataSet ds;
        
        public MainForm()
        {
            InitializeComponent();

            //创建连接数据库路径
            con = new MySqlConnection(HospitalManageSys.SqlCmd.strcon);
            //con.Open();

            cmd = new MySqlCommand("", con);
            ada = new MySqlDataAdapter(cmd);
            ds = new DataSet();

            //con.Close();
        }

        #region 窗口处理
        //退出系统事件
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //工具栏打开关闭事件
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        //状态栏打开关闭事件
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        //子窗口均层叠
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        //子窗口垂直平铺
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        //子窗口水平平铺
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        //子图标均排列
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        //关闭所有子窗口
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        //权限使能，控制各模块的访问能力
        private void Capability(byte capab)
        {
            toolStripButton_Admin.Enabled        = (capab & 0x01).Equals(0x01);
            toolStripButton_Registration.Enabled = (capab & 0x02).Equals(0x02);
            toolStripButton_Clinic.Enabled       = (capab & 0x04).Equals(0x04);
            toolStripButton_DrugEx.Enabled       = (capab & 0x08).Equals(0x08);
            toolStripButton_Charge.Enabled       = (capab & 0x10).Equals(0x10);
            toolStripButton_DrugIm.Enabled       = (capab & 0x20).Equals(0x20);
        }

        //打开修改密码窗口
        private void AdminPWDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PWD form_pwd = new Form_PWD(con);
            form_pwd.ShowDialog();
        }

        //主窗口加载,用户登录刷新
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form_Login form_admin = new Form_Login(con);
            form_admin.ShowDialog();

            if (HospitalManageSys.SqlCmd.iflogin)   //登录成功
            {
                label_id.Text     = HospitalManageSys.SqlCmd.admin_id;
                label_name.Text   = HospitalManageSys.SqlCmd.admin_name;
                label_sex.Text    = HospitalManageSys.SqlCmd.admin_sex;
                label_depart.Text = HospitalManageSys.SqlCmd.admin_depart;
                label_job.Text    = HospitalManageSys.SqlCmd.admin_job;
                if (HospitalManageSys.SqlCmd.memStream != null)
                {
                    this.pictureBox1.Image = Image.FromStream(HospitalManageSys.SqlCmd.memStream);
                }

                Capability(HospitalManageSys.SqlCmd.capab);

                this.groupBox_info.Show();
                this.AdminLoginToolStripMenuItem.Enabled  = false;
                this.AdminLogoutToolStripMenuItem.Enabled = true;
                this.AdminSwitchToolStripMenuItem.Enabled = true;
                this.AdminPWDToolStripMenuItem.Enabled    = true;
                this.toolStripButton_login.Enabled        = false;
            }
            else    //登录失败
            {
                Capability(0);

                this.AdminLogoutToolStripMenuItem.Enabled = false;
                this.AdminSwitchToolStripMenuItem.Enabled = false;
                this.AdminPWDToolStripMenuItem.Enabled    = false;
            }
        }

        #region 登录相关
        //用户登录事件
        private void AdminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainForm_Load(sender, e);
        }

        //用户注销事件
        private void AdminLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllToolStripMenuItem_Click(sender, e);
            this.groupBox_info.Hide();
            HospitalManageSys.SqlCmd.iflogin = false;

            Capability(0);

            this.AdminLoginToolStripMenuItem.Enabled  = true;
            this.AdminLogoutToolStripMenuItem.Enabled = false;
            this.AdminSwitchToolStripMenuItem.Enabled = false;
            this.AdminPWDToolStripMenuItem.Enabled    = false;
            this.toolStripButton_login.Enabled = true;
        }

        //用户切换事件
        private void AdminSwitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AdminLogoutToolStripMenuItem_Click(sender, e);
            this.MainForm_Load(sender, e);
        }
        #endregion

        #region 打开模块
        //打开模块--人事管理
        private void AdminForm_Click(object sender, EventArgs e)
        {
            Form_Adminisrtator form_administrator = new Form_Adminisrtator(con, this);
            form_administrator.MdiParent = this;
            form_administrator.Show();
        }

        //打开模块--门诊挂号
        private void RegistrationForm_Click(object sender, EventArgs e)
        {
            Form_Registration form_registration = new Form_Registration(con, this);
            form_registration.MdiParent = this;
            form_registration.Show();
        }

        //打开模块--医生门诊
        private void ClinicForm_Click(object sender, EventArgs e)
        {
            
        }

        //打开模块--发药系统
        private void DrugExForm_Click(object sender, EventArgs e)
        {
            Form_DrugEx form_drugex = new Form_DrugEx(con, this);
            form_drugex.MdiParent=this;
            form_drugex.Show();
        }

        //打开模块--收费系统
        private void ChargeForm_Click(object sender, EventArgs e)
        {
            Form_Charge form_charge = new Form_Charge(con, this);
            form_charge.MdiParent = this;
            form_charge.Show();
        }

        //打开模块--药品入库
        private void DrugImForm_Click(object sender, EventArgs e)
        {
            Form_DrugIm form_drugim = new Form_DrugIm(con, this);
            form_drugim.MdiParent = this;
            form_drugim.Show();
        }
        #endregion
        
 
    
    
    }
}
