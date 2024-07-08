using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace connect_to_server2
{
    public partial class Form11 : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\database assignment\sql database\library mangment.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        SqlDataAdapter adapt;
        private void DisplayData()
        {
            connect.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from BOOK_LOANS", connect);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        private void ClearData()
        {
            email.Text = "";
            id.Text = "";
            book.Text = "";
            loan.Text = "";
            //dd.Text = "";
            //d_loan.Text = "";
            status.Text = "";
        }
        public Form11()
        {
            InitializeComponent();
            DisplayData();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (email.Text != "" && id.Text != "" && book.Text != "" && loan.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO BOOK_LOANS (EMAIL,U_ID ,LOAN_NO,BOOK_ID, STATUS, LOAN_DATE ,DUE_DATE) " +
                            "VALUES(@email, @id,@loan,  @book,@stat,@ld , @dd )", connect);

                connect.Open();
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                DateTime selectedDateTime = dateTimePicker1.Value;
               
                string dateString = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@book", book.Text);
                cmd.Parameters.AddWithValue("@loan", loan.Text);
                cmd.Parameters.AddWithValue("@stat", status.Text);
                cmd.Parameters.AddWithValue("@ld", sqlFormattedDate);
                cmd.Parameters.AddWithValue("@dd", dateString);
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
                cmd = new SqlCommand("delete BOOK_LOANS where U_ID=@id and EMAIL = @email and LOAN_NO = @l", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@l", loan.Text);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || id.Text == "" || loan.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                cmd = new SqlCommand("update BOOK_LOANS set EMAIL=@e,U_ID = @id ,BOOK_ID = @book , STATUS= @stat, LOAN_DATE = @ld, Due_DATE = @dd where LOAN_NO=@loan", connect);


                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@e", email.Text);
                cmd.Parameters.AddWithValue("@loan", loan.Text);
                cmd.Parameters.AddWithValue("@stat", status.Text);
                //cmd.Parameters.AddWithValue("@ld", d_loan.Text);
                //cmd.Parameters.AddWithValue("@dd", dd.Text);
                cmd.Parameters.AddWithValue("@book", book.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                connect.Close();
                DisplayData();
                ClearData();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
