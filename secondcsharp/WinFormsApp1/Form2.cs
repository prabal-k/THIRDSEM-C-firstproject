using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;initial catalog=testone;user id=sa;password=kist@123;");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from student";
            SqlCommand sqlcommand= new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = dataGridView1.CurrentRow;
            string id = data.Cells["id"].Value.ToString();
            string name = data.Cells["name"].Value.ToString();
            string add = data.Cells["address"].Value.ToString();
            string con = data.Cells["contact"].Value.ToString();
            string detail = data.Cells["sdetail"].Value.ToString();

            textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = add;
            textBox5.Text = con.ToString();
            textBox6.Text = detail;



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
