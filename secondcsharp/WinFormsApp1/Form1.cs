using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP - Q6AJD9G\\SQLEXPRESS; Initial Catalog = testone; Integrated Security = True");
        public object sqlda { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into student values('prabalsir','thali','984781293','bba')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Update student set name='swornimthapa',address='mulpani' where id='5'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query ="delete from student where id=10  ";//to delete the data starting from p
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          dataGridView1.Rows.Add(textBox2.Text,textBox3.Text, textBox4.Text, textBox5.Text);
            con.Open();
            string query = "insert into student" + "(name,address,contact,sdetail)" + 
            " values('" + textBox2.Text + "','" +  textBox3.Text+ "','" + textBox4.Text +
            "','" + textBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }
    }
}
