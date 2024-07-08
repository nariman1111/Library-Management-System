using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using connect_to_server2.DataSet1TableAdapters;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace connect_to_server2
{
    public partial class Form12 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\database assignment\sql database\library mangment.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        private void DisplayData()
        {
            connect.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from RESERVE", connect);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        public Form12()
        {
            InitializeComponent();
            DisplayData();
        }

        private void loan_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (email.Text != "" && book.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO RESERVE (EMAIL, U_ID,BOOK_ID , STATUS , RESERVATION_DATE) " +
                            "VALUES(@email, @ID, @book, @stat , @reserve )", connect);
                cmd.Parameters.AddWithValue("@email", email.Text.Trim());
                cmd.Parameters.AddWithValue("@id", id.Text.Trim());
                
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                
                cmd.Parameters.AddWithValue("@book", book.Text);
                cmd.Parameters.AddWithValue("@stat", textBox1.Text);
                cmd.Parameters.AddWithValue("@reserve", sqlFormattedDate);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            DisplayData();
            connect.Close();
        }
    }
}
