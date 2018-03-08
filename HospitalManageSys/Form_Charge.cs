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
    public partial class Form_Charge : Form
    {
        MySqlConnection conne;
        MainForm mf;

        public Form_Charge(MySqlConnection connector,MainForm mainform)
        {
            InitializeComponent();

            conne = connector;
            mf = mainform;
        }
        //string myconnect = "Server = localhost;Database=HospitalManageSys;User Id = barry;Password = zixue788634; ";
        //保存按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //MySqlConnection conne = new MySqlConnection(myconnect);
            MySqlCommand cmd;
            conne.Open();
            try
            {
                if(textBox1.Text.Trim().ToString().Length == 0)
                {
                    MessageBox.Show("请输入单号");
                    return;
                }else if(comboBox1.Text.Trim().ToString().Length == 0){
                    MessageBox.Show("收费人编号不能为空");
                    return;
                }
                else if (textBox3.Text.Trim().ToString().Length == 0) {
                    MessageBox.Show("请输入中药费用，如果没有请输入0.00");
                    return;
                }
                else if (textBox4.Text.Trim().ToString().Length == 0) {
                    MessageBox.Show("请输入西药费用，如果没有请输入0.00");
                    return;
                }
                else if (textBox2.Text.Trim().ToString().Length == 0) {
                    MessageBox.Show("请输入相关中药名称与数量，没有输入“无”");
                    return;
                }
                else if (textBox5.Text.Trim().ToString().Length == 0) {
                    MessageBox.Show("请输入相关中药名称与数量，没有输入“无”");
                    return;
                }

                
                decimal tex = decimal.Parse(textBox3.Text) + decimal.Parse(textBox4.Text);
                cmd = conne.CreateCommand();
                cmd.CommandText = "INSERT INTO charge(charge_count,charge_admin,charge_tcmname,charge_tcm,charge_twmname,charge_twm,charge_sum,charge_date)VALUES(@charge_count,@charge_admin,@charge_tcmname,@charge_tcm,@charge_twmname,@charge_twm,@charge_sum,@charge_date)";
                cmd.Parameters.AddWithValue("@charge_count", textBox1.Text);
                cmd.Parameters.AddWithValue("@charge_admin", int.Parse(comboBox1.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@charge_tcm", textBox3.Text);
                cmd.Parameters.AddWithValue("@charge_twm", textBox4.Text);
                cmd.Parameters.AddWithValue("@charge_sum", tex);
                cmd.Parameters.AddWithValue("@charge_date", System.DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@charge_tcmname", textBox2.Text);
                cmd.Parameters.AddWithValue("@charge_twmname", textBox5.Text);
                cmd.ExecuteNonQuery();

                conne.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                if (conne.State == ConnectionState.Open)
                {
                    conne.Close();
                    LoadData();
                }
            }
        }
        private void LoadData() {
            MySqlConnection connection = conne;
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM charge";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
            catch (Exception)
            {
                throw;  
            }
            finally {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //查询按钮
        private void button2_Click(object sender, EventArgs e)
        {
            //MySqlConnection conne = new MySqlConnection(myconnect);

            MySqlCommand cmd;
            conne.Open();
            try
            {
 
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conne.State == ConnectionState.Open)
                {
                    conne.Close();
                    ReLoadData();
                }
            }
        }
        private void ReLoadData()
        {
            MySqlConnection connection = conne;
            connection.Open();
            try
            {
                if (comboBox1.Text.Trim().ToString().Length == 0)
                {
                    MessageBox.Show("请选择要查询的收费人编号");
                    return;
                }
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = string.Format("SELECT charge_count,charge_admin,charge_tcmname,charge_tcm,charge_twmname,charge_twm,charge_sum,charge_date FROM charge where charge_admin = {0} ", comboBox1.Text); ;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd.CommandText, connection);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void Form_Charge_Load(object sender, EventArgs e)
        {

        }
    }
}
