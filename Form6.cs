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
    public partial class Form6 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\database assignment\sql database\library mangment.mdf"";Integrated Security=True;Connect Timeout=30"); 
        SqlCommand cmd; 
        SqlDataAdapter adapt;
        public Form6()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            connect.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from AUTHOR", connect);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        private void ClearData()
        {
            email.Text = "";
            fname.Text = "";
            last.Text = "";
            password.Text = "";

        }


        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form6 = new Form5();
            form6.Show();
            this.Hide();
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
                cmd = new SqlCommand("update AUTHOR set FIRST_NAME=@n,LAST_NAME = @l ,NATIONALITY=@state where EMAIL_A=@id", connect);

                //cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@id", email.Text);

                cmd.Parameters.AddWithValue("@n", fname.Text);
                cmd.Parameters.AddWithValue("@l", last.Text);
                cmd.Parameters.AddWithValue("@state", password.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                connect.Close();
                DisplayData();
                ClearData();
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (email.Text != "")
            {
                cmd = new SqlCommand("delete AUTHOR where EMAIL_A=@id", connect);
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
            if (email.Text != "" && fname.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO AUTHOR (EMAIL_A, FIRST_NAME ,LAST_NAME, NATIONALITY) " +
                            "VALUES(@email, @FIRST, @second , @122)", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@email", email.Text);

                cmd.Parameters.AddWithValue("@FIRST", fname.Text);
                cmd.Parameters.AddWithValue("@second", last.Text);

                cmd.Parameters.AddWithValue("@122", password.Text);
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
            email.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            fname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            last.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            password.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            // sex.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void last_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void sqlDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

        }
    }
}
