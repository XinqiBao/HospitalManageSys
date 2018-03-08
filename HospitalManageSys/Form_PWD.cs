using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalManageSys
{
    public partial class Form_PWD : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter ada;
        DataSet ds;

        public Form_PWD(MySqlConnection connector)
        {
            InitializeComponent();

            con = connector;

            cmd = new MySqlCommand("select * from administrator where Admin_ID = " + HospitalManageSys.SqlCmd.admin_id, con);
            ada = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ada.Fill(ds);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (this.textBox_prePWD.Text.Trim() == string.Empty || this.textBox_newPWD.Text.Trim() == string.Empty || this.textBox_PWDagain.Text.Trim() == string.Empty)
            {
                MessageBox.Show("密码不能为空！", "提示", MessageBoxButtons.OK);
                return;
            }

            if (!this.textBox_prePWD.Text.GetHashCode().Equals(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[9])))
            {
                textBox_prePWD.Clear();
                textBox_newPWD.Clear();
                textBox_PWDagain.Clear();
                MessageBox.Show("原密码不正确！请再次输入！", "提示", MessageBoxButtons.OK);

                return;
            }
            else
                if (!this.textBox_newPWD.Text.Equals(this.textBox_PWDagain.Text))
                {
                    textBox_newPWD.Clear();
                    textBox_PWDagain.Clear();
                    MessageBox.Show("两次输入新密码不一样！请重新输入！", "提示", MessageBoxButtons.OK);

                    return;
                }
                else
                {
                    con.Open();
                    cmd.CommandText = "update administrator set Admin_password ='" + this.textBox_newPWD.Text.GetHashCode()
                                                           + "' where Admin_ID = " + HospitalManageSys.SqlCmd.admin_id;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("密码修改成功！请不要忘记修改后的密码！");
                    
                    this.Close();
                }

        
        }

        private void Form_PWD_Load(object sender, EventArgs e)
        {

        }
    }
}
