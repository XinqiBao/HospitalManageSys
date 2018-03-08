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
    public partial class Form_Adminisrtator : Form
    {
        MySqlConnection conn;
        MainForm mf;

        public Form_Adminisrtator(MySqlConnection connector, MainForm mainform)
        {
            InitializeComponent();

            conn = connector;
            mf = mainform;
        }

//        string strcon = @"Data Source=localhost;Database=hospitalmanagesys;User Id=root;
//            Password=123456;Allow User Variables=True";
        string FileNamePath = "";
        /// <summary>
        /// 员工查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("请输入员工编号！");
                return;
            }
            //MySqlConnection conn = new MySqlConnection(strcon);//新建数据库连接对象
            string StrSelcet = @"SELECT Admin_name,Admin_password,Admin_sex,Admin_job,Admin_department,Admin_fee,
Admin_photo,Admin_comment,Admin_capability FROM Administrator WHERE Admin_ID='" + tb_id.Text + "'";//sql查找语句
            MySqlCommand cmd = new MySqlCommand(StrSelcet, conn);
            try
            {
                conn.Open();//打开数据库
                MySqlDataReader sdr = cmd.ExecuteReader();
                MemoryStream memStream = null;//定义一个内存流
                if (sdr.HasRows)//如果有记录
                {
                    sdr.Read();//读取第一行记录
                    tb_name.Text = sdr["Admin_name"].ToString();//读取姓名
                    //tb_password.Text = sdr["Admin_password"].ToString();//读取密码
                    cb_sex.Text = sdr["Admin_sex"].ToString();//读取性别
                    cb_job.Text = sdr["Admin_job"].ToString();//读取职位
                    cb_department.Text = sdr["Admin_department"].ToString();//读取科室
                    tb_fee.Text = sdr["Admin_fee"].ToString();//读取挂号费
                    tb_comment.Text = sdr["Admin_comment"].ToString();//读取备注
                    if (this.pb_photo.Image != null)//原有图片销毁
                        pb_photo.Image = null;
                    if (sdr["Admin_photo"] != System.DBNull.Value)//如果有照片
                    {
                        byte[] images = (byte[])sdr["Admin_photo"];
                        memStream = new MemoryStream(images);//字节流转化为内存流
                        pb_photo.Image = Image.FromStream(memStream);//内存流转换为照片
                        memStream.Close();
                    }
                    int a = Convert.ToInt32(sdr["Admin_capability"].ToString());//读取职能转化为int类型
                    if ((a & 1) != 0)
                        check_1.Checked = true;
                    else
                        check_1.Checked = false;
                    if ((a & 2) != 0)
                        check_2.Checked = true;
                    else
                        check_2.Checked = false;
                    if ((a & 4) != 0)
                        check_3.Checked = true;
                    else
                        check_3.Checked = false;
                    if ((a & 8) != 0)
                        check_4.Checked = true;
                    else
                        check_4.Checked = false;
                    if ((a & 16) != 0)
                        check_5.Checked = true;
                    else
                        check_5.Checked = false;
                    if ((a & 32) != 0)
                        check_6.Checked = true;
                    else
                        check_6.Checked = false;
                }
                else
                    MessageBox.Show("没有此员工！"); 
                     
                if (!sdr.IsClosed)//关闭sdr
                    sdr.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)//如果数据处于连接状态，关闭连接
                    conn.Close();
            }
        }
        /// <summary>
        /// 员工添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "" || tb_name.Text == "" || cb_job.Text == "" || cb_sex.Text == "")
            {
                MessageBox.Show("请输入完整信息");
                return;
            }
            string StrInsert;
            //MySqlConnection conn = new MySqlConnection(strcon);//新建数据库连接对象
            if (FileNamePath != "")
            {
                StrInsert = @"INSERT INTO Administrator(Admin_ID,Admin_name,Admin_sex,Admin_job,Admin_department,
Admin_fee,Admin_photo,Admin_comment,Admin_capability,Admin_password) VALUES (@Admin_ID,@Admin_name,@Admin_sex,@Admin_job,@Admin_department,
@Admin_fee,@Admin_photo,@Admin_comment,@Admin_capability,@Admin_password)";
            }
            else
            {
                StrInsert = @"INSERT INTO Administrator(Admin_ID,Admin_name,Admin_sex,Admin_job,Admin_department,
Admin_fee,Admin_comment,Admin_capability,Admin_password) VALUES (@Admin_ID,@Admin_name,@Admin_sex,@Admin_job,@Admin_department,
@Admin_fee,@Admin_comment,@Admin_capability,@Admin_password)";
            }
            MySqlCommand cmd = new MySqlCommand(StrInsert, conn);
            //添加参数
            cmd.Parameters.Add("@Admin_ID", MySqlDbType.VarChar, 11).Value = tb_id.Text;
            cmd.Parameters.Add("@Admin_name", MySqlDbType.VarChar, 20).Value = tb_name.Text;
            cmd.Parameters.Add("@Admin_password", MySqlDbType.Int32,11).Value = tb_password.Text.GetHashCode();
            cmd.Parameters.Add("@Admin_sex", MySqlDbType.VarChar, 2).Value = cb_sex.Text;
            cmd.Parameters.Add("@Admin_job", MySqlDbType.VarChar, 20).Value = cb_job.Text;
            cmd.Parameters.Add("@Admin_department", MySqlDbType.VarChar, 50).Value = cb_department.Text;
            cmd.Parameters.Add("@Admin_fee", MySqlDbType.Decimal).Value = tb_fee.Text;
            cmd.Parameters.Add("@Admin_comment", MySqlDbType.VarChar, 100).Value = tb_comment.Text;
            if (FileNamePath != "")//如果照片不为空，添加照片
            {
                FileStream fs = null;//以文件流方式读取照片
                fs = new FileStream(FileNamePath, FileMode.Open, FileAccess.Read);
                byte[] imageBytes = new byte[Convert.ToInt32(fs.Length)];//定义照片长度数组
                BinaryReader br = new BinaryReader(fs);
                imageBytes = br.ReadBytes(Convert.ToInt32(fs.Length));//图片转换成二进制流
                fs.Close();
                cmd.Parameters.Add("@Admin_photo", MySqlDbType.MediumBlob);//选择MediumBlob类型
                cmd.Parameters["@Admin_photo"].Value = imageBytes;//给@Admin_photo参数赋值
            }
            int ability;//定义职能
            int a1 = check_1.Checked ? 1 : 0;
            int a2 = check_2.Checked ? 2 : 0;
            int a3 = check_3.Checked ? 4 : 0;
            int a4 = check_4.Checked ? 8 : 0;
            int a5 = check_5.Checked ? 16 : 0;
            int a6 = check_6.Checked ? 32 : 0;
            ability = a1 | a2 | a3 | a4 | a5 | a6;
            cmd.Parameters.Add("@Admin_capability", MySqlDbType.Bit, 8);
            cmd.Parameters["@Admin_capability"].Value = ability;

            try
            {
                conn.Open();//打开数据库连接
                cmd.ExecuteNonQuery();//执行sql语句
                MessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错！" + ex.Message);
            }
            finally
            {
                conn.Close();//关闭数据库连接
                FileNamePath = "";
            }
        }
        /// <summary>
        /// 员工删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("请输入员工编号");
                return;
            }
            //MySqlConnection conn = new MySqlConnection(strcon);////新建数据库连接对象
            string StrDel = "DELETE FROM Administrator WHERE Admin_ID=@Admin_ID";
            MySqlCommand cmd = new MySqlCommand(StrDel, conn);
            cmd.Parameters.Add("@Admin_ID", MySqlDbType.VarChar, 11).Value = tb_id.Text;
            try
            {
                conn.Open();//打开数据库连接
                int a = cmd.ExecuteNonQuery();//执行sql语句
                if (a == 1)//如果受影响的行数为1，则删除成功
                    MessageBox.Show("删除成功！");
                else
                    MessageBox.Show("数据库中没有此员工！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();//关闭数据库连接
            }
        }
        /// <summary>
        /// 员工修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("请输入员工编号");
                return;
            }
            //MySqlConnection conn = new MySqlConnection(strcon);
            string StrUpdate = "UPDATE Administrator SET ";
            StrUpdate += "Admin_name='" + tb_name.Text + "',";//修改姓名
            //StrUpdate += "Admin_password='" + tb_password.Text + "',";//修改密码
            StrUpdate += "Admin_sex='" + cb_sex.Text + "',";//修改性别
            StrUpdate += "Admin_job='" + cb_job.Text + "',";//修改职位
            StrUpdate += "Admin_department='" + cb_department.Text + "',";//修改科室
            StrUpdate += "Admin_fee='" + tb_fee.Text + "',";//修改挂号费
            
            if (FileNamePath != "")//如果选择了照片
            {
                FileStream fs = null;
                fs = new FileStream(FileNamePath, FileMode.Open, FileAccess.Read);
                byte[] imageBytes = new byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                imageBytes = br.ReadBytes(Convert.ToInt32(fs.Length));//图片转换成二进制流
                fs.Close();
                StrUpdate += "Admin_photo='" + imageBytes + "',";
            }
            int ability;//定义职能
            int a1 = check_1.Checked ? 1 : 0;
            int a2 = check_2.Checked ? 2 : 0;
            int a3 = check_3.Checked ? 4 : 0;
            int a4 = check_4.Checked ? 8 : 0;
            int a5 = check_5.Checked ? 16 : 0;
            int a6 = check_6.Checked ? 32 : 0;
            ability = a1 | a2 | a3 | a4 | a5 | a6;
            StrUpdate += "Admin_capability='" + ability + "',";//修改职能
            StrUpdate += "Admin_comment='" + tb_comment.Text + "'";//修改备注
            StrUpdate += "WHERE Admin_ID='" + tb_id.Text + "'";
            MySqlCommand cmd = new MySqlCommand(StrUpdate, conn);
            try
            {
                conn.Open();
                int b = cmd.ExecuteNonQuery();
                if (b == 1)
                    MessageBox.Show("修改成功！");
                else
                    MessageBox.Show("数据库中没有此员工！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错，没有完成修改！" + ex.Message);
            }
            finally
            {
                conn.Close();
                FileNamePath = "";
            }

        }
        /// <summary>
        /// 选择照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//实例化打开文件对话框
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            ofd.Filter = "jpg 图片|*.jpg|gif 图片|*.gif|所有文件(*.*)|*.*";//设置打开文件类型
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                FileNamePath = ofd.FileName;//获取文件路径
                pb_photo.Image = Image.FromFile(FileNamePath);//将照片显示在pb_photo中
            }
        }
        /// <summary>
        /// 清空操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tb_password.Text = "";
            cb_department.Text = "";
            tb_fee.Text = "";
            tb_comment.Text = "";
            cb_sex.Text = "";
            cb_job.Text = "";
            pb_photo.Image = null;
            check_1.Checked = false;
            check_2.Checked = false;
            check_3.Checked = false;
            check_4.Checked = false;
            check_5.Checked = false;
            check_6.Checked = false;
        }
        /// <summary>
        /// 显示所有员工信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            string StrSelcet = @"SELECT Admin_ID,Admin_name,Admin_sex,Admin_job,Admin_department,Admin_comment FROM Administrator";//sql查找语句
            //MySqlConnection conn = new MySqlConnection(strcon);
            try
            {
                conn.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter(StrSelcet, conn);
                DataSet dataSet = new DataSet("Syxx");
                msda.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form_Adminisrtator_Load(object sender, EventArgs e)
        {

        }
    }
}
