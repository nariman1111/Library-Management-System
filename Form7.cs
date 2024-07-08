using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect_to_server2
{
    public partial class Form7 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\database assignment\sql database\library mangment.mdf"";Integrated Security=True;Connect Timeout=30"); 
        SqlDataAdapter adapt;
        SqlCommand cmd; 


        public Form7()
        {
            InitializeComponent();
            DisplayData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void DisplayData()
        {
            connect.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from BOOK", connect);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        private void ClearData()
        {
            email.Text = "";
            fname.Text = "";
            last.Text = "";
            password.Text = ""; textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || password.Text == "" || fname.Text == "" || last.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                cmd = new SqlCommand("update BOOK set   AUTHOR=@A,NAME = @N ,LANGUAGE=@L,PRINT_YEAR = @P, CATEGORY = @G  where BOOK_ID=@id", connect);

                //cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@id", email.Text);

                cmd.Parameters.AddWithValue("@N", fname.Text);
                cmd.Parameters.AddWithValue("@A", last.Text);
                cmd.Parameters.AddWithValue("@L", password.Text);
                cmd.Parameters.AddWithValue("@P", textBox1.Text);
                cmd.Parameters.AddWithValue("@G", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                connect.Close();
                DisplayData();
                ClearData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (email.Text != "")
            {
                cmd = new SqlCommand("delete BOOK where BOOK_ID=@id", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@id", email.Text);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO BOOK (BOOK_ID, NAME ,LANGUAGE, AUTHOR,PRINT_YEAR, CATEGORY) " +
                            "VALUES(@id, @N,@L,@A,@P,@G)", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@id", email.Text);

                cmd.Parameters.AddWithValue("@N", fname.Text);
                cmd.Parameters.AddWithValue("@A", last.Text);
                cmd.Parameters.AddWithValue("@L", password.Text);
                cmd.Parameters.AddWithValue("@P", textBox1.Text);
                cmd.Parameters.AddWithValue("@G", textBox2.Text);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sqlDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form7_Load_1(object sender, EventArgs e)
        {

        }
    }
}
