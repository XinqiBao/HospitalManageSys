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
    public partial class Form_DrugIm_2 : Form
    {
        public Form_DrugIm_2()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        MySqlDataAdapter sda;
        private void Form2_Load(object sender, EventArgs e)
        {
            mtbBirthDate.MaskInputRejected += new MaskInputRejectedEventHandler(mtbBirthDate_MaskInputRejected);
            string connectionString = "Data Source=localhost;Initial Catalog=hospitalmanagesys;User ID=root;Password=nnnbc4318";
            string query = "insert into hospitalmanagesys.drug value('115','jam','29.0','nothing','ssk','u','19');";
            ds = SelectRows(ds, connectionString, query);
            /*MySqlConnection conn = new MySqlConnection(connectionString);
            string sql = "select*from drug";
            sda = new MySqlDataAdapter(sql, conn);
            sda.Fill(ds);
            DataTable dt = new DataTable("childTable");
            DataColumn column = new DataColumn("ChildID", typeof(System.Int32));
            column.AutoIncrement = true;
            column.Caption = "ID";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);
            DataRow row;
            for (int i = 0; i <= 4; i++)
            {
                row = dt.NewRow();
                row["ChildID"] = i;
                dt.Rows.Add(row);
            }
            ds.Tables.Add(dt);
            dataGridView1.DataSource = ds.Tables[0];*/

        }
        private void mtbBirthDate_MaskInputRejected(object sender,MaskInputRejectedEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Warning;
            toolTip.ToolTipTitle = "system warning";
            toolTip.Show("please input effective number",label1,2000);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private static DataSet SelectRows(DataSet dataset, string connectionString, string queryString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = new MySqlCommand(queryString, connection);
                adapter.Fill(dataset);
                return dataset;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要将修改的数据保存到数据库吗？", "修改提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK) 
            {
                MySqlCommandBuilder sb = new MySqlCommandBuilder(sda);
                sda.Update(ds);
                MessageBox.Show("修改成功", "成功提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
