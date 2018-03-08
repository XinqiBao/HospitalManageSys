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
    public partial class Form_Registration : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        DataSet ds;
        MySqlDataAdapter ada;

        MainForm mf;


        public Form_Registration(MySqlConnection connector, MainForm mainform)
        {
            InitializeComponent();

            mf = mainform;

            string constr = "server=localhost;database=hospitalmanagesys;uid=huangweiqiang;pwd=hwq123456;";
            //con = new MySqlConnection(constr);
            con = connector;
            con.Open();
            cmd = new MySqlCommand("select * from administrator", con);
            ada = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ada.Fill(ds);

            //textBox8.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            
            
            string strID = getID();

            textBox8.Text = strID;

            
            
            int ds_count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < ds_count; i++)
            {
                comboBox1_doctorID.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private string getID()
        {
            string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVXYZ";
            int[] iArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            char[] cArr = str.ToCharArray();
            Random rad =new Random();
            string date = DateTime.Now.ToString("yyyyMMddHHmmss");
            int str_i = rad.Next(cArr.Length);
            int i = rad.Next(iArr.Length);
            string name = date;//+ " " + cArr[str_i] + iArr[i];
            return name;

        }


        private void textBox8_Click(object sender, EventArgs e)
        {
            string strID = getID();

            textBox8.Text = strID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into registration (registration_count,patient_name,patient_sex,patient_insurance,doctor_ID,patient_address,patient_fee) value"
            + "('" + textBox8.Text + "','" + textBox_name.Text + "','" + textBox_patientsex.Text + "','" + textBox_patient_insurance.Text + "','" + comboBox1_doctorID.Text + "','" + textBox4_patientaddress.Text + "','" + textBox_patient_fee.Text + "');";
            cmd.ExecuteNonQuery();
        }

        

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string strID=getID();

            textBox8.Text = strID;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           /* string constr = "server=localhost;database=hospitalmanagesys;uid=huangweiqiang;pwd=hwq123456;";
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cm = new MySqlCommand("select admin_name,admin_ID from administrator", con);

            MySqlDataReader dr = cm.ExecuteReader();

            //绑定

            this.lbxAdministrator.DataSource = dr;        //lbxEmp为ListBox对象

            this.lbxadministrator.DataTextField = "admin_name";

            this.lbxadministrator.DataValueField = "admin_ID";

            this.lbxadministrator.DataBind();

            dr.Close();

            con.Close();*/
        }

        
        private void cBoxTables_SelectedIndexChanged(object sender, EventArgs e)          
        {              
                      
         }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Clear();
            cmd.CommandText = "select * from administrator where admin_ID='" + comboBox1_doctorID.Text + "';";
            cmd.ExecuteNonQuery();
            ada.Fill(ds);

            
            textBox9_doctorname.Text        = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            textBox5_doctordepartment.Text  = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            textBox7_doctorfee.Text         = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            textBox6_doctorcapability.Text  = ds.Tables[0].Rows[0].ItemArray[3].ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update registration set  patient_name        = '" + textBox_name.Text
                                                    + "',patient_sex        = '" + textBox_patientsex.Text
                                                    + "',patient_insurance  = '" + textBox_patient_insurance.Text
                                                    + "',doctor_ID          = '" + comboBox1_doctorID.Text
                                                    + "',patient_address    = '" + textBox4_patientaddress.Text
                                                    + "',patient_fee        = '" + textBox_patient_fee.Text
                                                    + "' where registration_count = " + textBox1.Text;

        cmd.ExecuteNonQuery();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.Clear();
            cmd.CommandText = "select * from registration where registration_count ='" + textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            ada.Fill(ds);
            
            textBox_name.Text              = ds.Tables[0].Rows[0].ItemArray[11].ToString();
            textBox_patient_insurance.Text = ds.Tables[0].Rows[0].ItemArray[12].ToString();
            textBox_patientsex.Text        = ds.Tables[0].Rows[0].ItemArray[13].ToString();
            textBox4_patientaddress.Text   = ds.Tables[0].Rows[0].ItemArray[15].ToString();
            textBox_patient_fee.Text       = ds.Tables[0].Rows[0].ItemArray[16].ToString();
            comboBox1_doctorID.Text        = ds.Tables[0].Rows[0].ItemArray[17].ToString();
        
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    
    
    }

       

    }

