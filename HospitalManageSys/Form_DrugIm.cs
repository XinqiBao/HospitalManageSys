using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HospitalManageSys
{
    public partial class Form_DrugIm : Form
    {
        MySqlConnection conn;
        MainForm mf;

        public Form_DrugIm(MySqlConnection connector, MainForm mainform)
        {
            InitializeComponent();

            conn = connector;
            mf = mainform;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 20;
            CreateHeaderandFillListView();
            
        }


        private void CreateHeaderandFillListView()
        { 
            ColumnHeader colHead = new ColumnHeader();
            colHead.Text = "Pid";
            colHead.Width = 50;
            lvitem.Columns.Add(colHead);
            ColumnHeader col2 = new ColumnHeader();
            col2.Text = "Pname";
            col2.Width = 100;
            lvitem.Columns.Add(col2);
            ColumnHeader col3 = new ColumnHeader();
            col3.Text = "Pprize";
            col3.Width = 100;
            lvitem.Columns.Add(col3);
            ColumnHeader col4 = new ColumnHeader();
            col4.Text = "Pdetile";
            col4.Width = 100;
            lvitem.Columns.Add(col4);
            ColumnHeader col5 = new ColumnHeader();
            col5.Text = "Pamount";
            col5.Width = 100;
            lvitem.Columns.Add(col5);
        }
        private static DataSet SelectRows(DataSet dataset, string connectionString, string queryString) 
        {
            using (MySqlConnection connection = new MySqlConnection (connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = new MySqlCommand(queryString,connection);
                adapter.Fill(dataset);
                return dataset;
            }
        }

        private void CreateItemView() 
        {
            string a;
            a = textBox5.Text;
            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(textBox3.Text);
            lvi.SubItems.Add(textBox4.Text);
            lvi.SubItems.Add(textBox5.Text);
            lvitem.Items.Add(lvi);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("please fill up the entering box");
            else if (textBox2.Text == "") MessageBox.Show("please fill up the entering box");
            else if (textBox3.Text == "") MessageBox.Show("please fill up the entering box");
            else if (textBox4.Text == "") MessageBox.Show("please fill up the entering box");
            else if (textBox5.Text == "") MessageBox.Show("please fill up the entering box");
            else 
            {
                CreateItemView();
                MessageBox.Show("药品编号输入有误");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clear");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            lvitem.Columns.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();
            string ConnectionString = HospitalManageSys.SqlCmd.strcon;
            //MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            string a = "select*from dru"+"g";
            string sql = string.Format(a);
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
            sda.Fill(ds);
            DataView dv = ds.Tables[0].DefaultView;
            listBox1.DataSource = ds.Tables[0];
            if (radioButton1.Checked)
                listBox1.DisplayMember = "Drug_name";
            else if (radioButton2.Checked)
                listBox1.DisplayMember = "Drug_supplier";
            else if (radioButton3.Checked)
                listBox1.DisplayMember = "Drug_id";
            conn.Close();
            ttt();
        }
        private void ttt() 
        {

            string ConnectionString = HospitalManageSys.SqlCmd.strcon;
            //MySqlConnection conn = new MySqlConnection(ConnectionString);
            try
            {
                conn.Open();
                label7.Text = "服务器名称:" + conn.DataSource + ";要使用的数据库：" + conn.Database;
                string strcmd = "select*from drug";
                MySqlCommand cmd = new MySqlCommand(strcmd, conn);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);//查询结果填充数据集
                dataGridView1.DataSource = ds.Tables[0];
                conn.Dispose();
                conn.Close();
            }
            catch (Exception)
            {
                label7.Text = "failed";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("please fill up the entering box");
            else if (textBox2.Text == "") MessageBox.Show("please fill up the entering box");
            else if (textBox3.Text == "") MessageBox.Show("please fill up the entering box");
            else if (textBox4.Text == "") MessageBox.Show("please fill up the entering box");
            else if (textBox5.Text == "") MessageBox.Show("please fill up the entering box");
            else
            {
                DataSet ds = new DataSet();
                string connectionString = HospitalManageSys.SqlCmd.strcon;//"Data Source=localhost;Initial Catalog=hospitalmanagesys;User ID=root;Password=nnnbc4318";
                string t1, t2, t3, t4, t5, t6, t7;
                t1 = textBox1.Text;
                t2 = textBox2.Text;
                t3 = textBox3.Text; t4 = textBox4.Text; t5 = textBox5.Text; t6 = textBox6.Text; t7 = textBox7.Text;
                string query = "insert into hospitalmanagesys.drug value('" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t7 + "','" + t6 + "','" + t5 + "');";
                ds = SelectRows(ds, connectionString, query);
                MessageBox.Show("添加成功");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
