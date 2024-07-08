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
    public partial class Form8 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\database assignment\sql database\library mangment.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;


        public Form8()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            connect.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from PUBLISH", connect);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        private void ClearData()
        {
            email.Text = "";
            fname.Text = "";


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
            if (email.Text == "" || fname.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                cmd = new SqlCommand("update PUBLISH set EMAIL_A=@n where BOOK_ID=@id", connect);

                //cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@id", fname.Text);

                cmd.Parameters.AddWithValue("@n", email.Text);

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
                cmd = new SqlCommand("delete PUBLISH where BOOK_ID=@id", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@id", fname.Text);
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
            connect.Open();
            
            cmd = new SqlCommand("INSERT INTO PUBLISH (EMAIL_A, BOOK_ID) " +
                            "VALUES(@email, @FIRST)", connect);
            if (email.Text != "" && fname.Text != "")
            {
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@FIRST", fname.Text);
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
            email.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            fname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
