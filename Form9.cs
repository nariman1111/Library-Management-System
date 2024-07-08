using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace connect_to_server2
{
    public partial class Form9 : Form
    {


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\database assignment\sql database\library mangment.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        SqlDataAdapter adapt;
        private void DisplayData()
        {
            connect.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from REVIEW", connect);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        private void ClearData()
        {
            email.Text = "";
            id.Text = "";
            rate.Text = "";
            review.Text = "";
            des.Text = "";
            

        }
        public Form9()
        {
            InitializeComponent();
            DisplayData();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String checkUsername = "SELECT * FROM STUDENT WHERE EMAIL = '"
                            + email.Text.Trim() + "'";
            String userid = "SELECT * FROM STUDENT WHERE U_ID = '"
                           + id.Text.Trim() + "'";


            if (email.Text != "" && id.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO REVIEW (EMAIL,U_ID ,REVIEW_NO, DATE,DESCRIPTION, RATING) " +
                            "VALUES(@email, @id,@rev,  @date,@desc,@rate )", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@id", id.Text);
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                cmd.Parameters.AddWithValue("@date", sqlFormattedDate);
                cmd.Parameters.AddWithValue("@rev", review.Text);
                cmd.Parameters.AddWithValue("@desc", des.Text);
                cmd.Parameters.AddWithValue("@rate", rate.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (email.Text != "")
            {
                cmd = new SqlCommand("delete REVIEW where U_ID=@id and EMAIL = @email", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || id.Text == "" || review.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                cmd = new SqlCommand("update REVIEW set EMAIL=@e,U_ID = @id ,DATE=@date, DESCRIPTION = @des , RATING= @rate where REVIEW_NO=@review", connect);

                //cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@rate", rate.Text);
                cmd.Parameters.AddWithValue("@e", email.Text);
                //cmd.Parameters.AddWithValue("@date", date.Text);
                cmd.Parameters.AddWithValue("@des", des.Text);
                cmd.Parameters.AddWithValue("@review", review.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                connect.Close();
                DisplayData();
                ClearData();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
