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
    public partial class Form_Login : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;        
        MySqlDataAdapter ada;
        DataSet ds;

        public Form_Login(MySqlConnection connector)
        {
            InitializeComponent();

            con = connector;

            cmd = new MySqlCommand("", con);
            ada = new MySqlDataAdapter(cmd);
            ds = new DataSet();
        }


        private void administrator_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd.CommandText = "select * from administrator where Admin_ID='" + textBox_ID.Text + "';";
            cmd.ExecuteNonQuery();
            ada.Fill(ds);
            con.Close();

            if (ds.Tables[0].Rows.Count != 0)
            {
                if (this.textBox_pwd.Text.GetHashCode().Equals(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[9])))
                {
                    HospitalManageSys.SqlCmd.iflogin = true;
                    HospitalManageSys.SqlCmd.admin_id     = ds.Tables[0].Rows[0].ItemArray[0].ToString().PadLeft(11, '0');
                    HospitalManageSys.SqlCmd.admin_name   = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    HospitalManageSys.SqlCmd.admin_sex    = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    HospitalManageSys.SqlCmd.admin_job    = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                    HospitalManageSys.SqlCmd.capab        = (byte)Convert.ToInt16(ds.Tables[0].Rows[0].ItemArray[4]);
                    HospitalManageSys.SqlCmd.admin_depart = ds.Tables[0].Rows[0].ItemArray[5].ToString();

                    if (ds.Tables[0].Rows[0].ItemArray[8] != System.DBNull.Value)//如果有照片
                    {
                        byte[] images = (byte[])ds.Tables[0].Rows[0].ItemArray[8];
                        HospitalManageSys.SqlCmd.memStream = new MemoryStream(images);//字节流转化为内存流
                    }

                    this.Close();
                }
                else
                {
                    textBox_pwd.Clear();
                    MessageBox.Show("输入的密码错误！请重新输入！", "提示", MessageBoxButtons.OK);
                }
            }
            else
            {
                textBox_pwd.Clear();
                MessageBox.Show("账号不存在！请输入正确的账号！", "提示", MessageBoxButtons.OK);

                return;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
