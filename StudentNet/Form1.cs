using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace StudentNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //绑定数据
        SqlConnection conn;
        SqlDataAdapter sda;
        SqlCommand cmd;
        private void loadData()
        {
            sda = new SqlDataAdapter("select * from Student", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        //获取文本框输入的值
        private void bindData()
        {
            string stuno = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string gender = textBox3.Text.Trim();
            string age = textBox4.Text.Trim();
            string grade = textBox5.Text.Trim();
            string clas = textBox6.Text.Trim();
            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@StuNo", stuno);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Grade", grade);
            cmd.Parameters.AddWithValue("@Class", clas);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“reportServerDataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.reportServerDataSet.Student);
            string testDB = ConfigurationManager.ConnectionStrings["testDB"].ConnectionString;
            conn = new SqlConnection(testDB);
            loadData();
            string[] htext = { "StuNo", "Name", "Gender", "Age", "Grade", "Class" };
            for (int i = 0; i < htext.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = htext[i];
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //新增
        private void button1_Click(object sender, EventArgs e)
        {
            string stuno = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string gender = textBox3.Text.Trim();
            string age = textBox4.Text.Trim();
            string grade = textBox5.Text.Trim();
            string clas = textBox6.Text.Trim();
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Student where stuno = @StuNo";
                cmd.Parameters.AddWithValue("@StuNo", stuno);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.Parameters.AddWithValue("@Class", clas);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //判断读取到的数据库中的学号与输入的学号是否相同
                    if (reader["StuNO"].ToString() == stuno)
                    {
                        MessageBox.Show("学号已存在");
                        this.textBox1.Focus();
                        this.textBox1.SelectAll();
                    }
                    //关闭读取器
                    reader.Close();
                }
                else
                {
                    //关闭读取器
                    reader.Close();
                    cmd.CommandText = "insert into Student (StuNo,Name,Gender,Age,Grade,Class) values(@StuNo,@Name,@Gender,@Age,@Grade,@Class)";
                    //获取执行sql语句后受影响的行数
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount == 1) //Update、Insert和Delete返回1，其他返回-1
                    {
                        MessageBox.Show("学生【" + this.textBox2.Text + "】录入成功！");
                        this.textBox1.Text = "";
                        this.textBox2.Text = "";
                        this.textBox3.Text = "";
                        this.textBox4.Text = "";
                        this.textBox5.Text = "";
                        this.textBox6.Text = "";
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            loadData();
        }

        //删除
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否删除学生【" + this.textBox2.Text + "】", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    bindData();
                    cmd.CommandText = "delete from Student where StuNo=@stuno";
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount == 1)
                    {
                        MessageBox.Show("学生【" + this.textBox2.Text + "】删除成功！");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                return;
            }
            loadData();
        }

        //点击行获取数据
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells["stuno"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells["name"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells["gender"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells["age"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[index].Cells["grade"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[index].Cells["clas"].Value.ToString();
        }

        //修改
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否修改学生【" + this.textBox2.Text + "】", "修改", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    bindData();
                    cmd.CommandText = "update Student set Name=@name,Gender=@gender,Age=@age,Grade=@grade,Class=@clas where StuNo=@stuno";
                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("学生【" + this.textBox2.Text + "】修改成功！");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                return;
            }
            loadData();
        }
    }
}
