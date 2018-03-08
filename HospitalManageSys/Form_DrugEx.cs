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
    public partial class Form_DrugEx : Form
    {
        MainForm mf;
        MySqlConnection conn;

        public Form_DrugEx(MySqlConnection connector, MainForm mainform)
        {
            InitializeComponent();

            mf = mainform;
            conn = connector;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strConn = "server=localhost;uid=root;pwd=dongyz1130 ;database=hospitalmanagesys";
            //MySqlConnection conn = new MySqlConnection(strConn);
            String sqlId = "Select * from drugex where DrugEx_registration = '" + textBox1.Text + "'and Drug_state='未发' ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sqlId, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "USER");
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String strConn = "server=localhost;uid=root;pwd=dongyz1130 ;database=hospitalmanagesys";
            //MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = strConn;
            //2、准备新增sql命令
            string strcommand = "update drugex set Drug_state = '已发' where DrugEx_registration = '" + textBox1.Text + "' ";
            //3、新建命令对象，并前告诉它走那条路，做什么事情
            MySqlCommand cmd = new MySqlCommand(strcommand, conn);
            //4、打开通道
            conn.Open();
            //5、执行sql语句
            int intres = -1;
            intres = cmd.ExecuteNonQuery();
            //6、关闭连接通道
            conn.Close();
            if (intres > 0)
            {
                Console.WriteLine("修改成功");
            }
            else
            {
                Console.WriteLine("修改失败");
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            String strConn = "server=localhost;uid=root;pwd=dongyz1130 ;database=hospitalmanagesys";
            //MySqlConnection conn = new MySqlConnection(strConn);
            String sqlId = "Select * from drugex where DrugEx_date = '" + dateTimePicker1.Text + "'and Drug_state='已发' ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sqlId, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "USER");
            dataGridView2.DataSource = ds.Tables[0];

            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String strConn = "server=localhost;uid=root;pwd=dongyz1130 ;database=hospitalmanagesys";
            //MySqlConnection conn = new MySqlConnection(strConn);
            String sqlId = "Select * from drugex where DrugEx_date = '" + dateTimePicker1.Text + "'and Drug_state='未发' ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sqlId, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "USER");
            dataGridView2.DataSource = ds.Tables[0];

            conn.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            String strConn = "server=localhost;uid=root;pwd=dongyz1130 ;database=hospitalmanagesys";
            //MySqlConnection conn = new MySqlConnection(strConn);
            String sqlId = "Select * from drugex where DrugEx_registration = '" + textBox2.Text + "' ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sqlId, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "USER");
            dataGridView2.DataSource = ds.Tables[0];

        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String strConn = "server=localhost;uid=root;pwd=dongyz1130 ;database=hospitalmanagesys";
            //MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = strConn;
            //2、准备新增sql命令
            String sqlId = "Select Drugex_quantity from drugex where Drug_name = '" + textBox3.Text + "'";  
            MySqlCommand cmd = new MySqlCommand(sqlId, conn); 
            conn.Open();  
            MySqlDataReader myReader = cmd.ExecuteReader();   
            while (myReader.Read())  
           {  
                textBox4.Text  = myReader.GetValue(0).ToString();  
            }  
            myReader.Close(); 
           conn.Close();  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String strConn = "server=localhost;uid=root;pwd=dongyz1130 ;database=hospitalmanagesys";
            //MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = strConn;
            //2、准备新增sql命令
            string strcommand = "update drug set Drug_remain = Drug_remain-'" + textBox4.Text + "' where Drug_name = '" + textBox3.Text + "' ";
            //3、新建命令对象，并前告诉它走那条路，做什么事情
            MySqlCommand cmd = new MySqlCommand(strcommand, conn);
            //4、打开通道
            conn.Open();
            //5、执行sql语句
            int intres = -1;
            intres = cmd.ExecuteNonQuery();
            //6、关闭连接通道
            conn.Close();
            if (intres > 0)
            {
                Console.WriteLine("修改成功");
            }
            else
            {
                Console.WriteLine("修改失败");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_DrugEx_Load(object sender, EventArgs e)
        {

        }
        }
    }

