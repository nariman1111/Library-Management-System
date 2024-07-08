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
namespace connect_to_server2
{
    public partial class Form13 : Form
    {


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\database assignment\sql database\library mangment.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        SqlDataAdapter adapt;
        private void DisplayData()
        {
            connect.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from COMPLAINT", connect);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        private void ClearData()
        {
            email.Text = "";
            id.Text = "";
            comp.Text = "";
            comp.Text = "";
            des.Text = "";


        }
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (email.Text != "" && id.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO COMPLAINT (EMAIL,U_ID ,COMPLAINT_NO, DATE,DESCRIPTION) " +
                            "VALUES(@email, @id,@rev,  @date,@desc)", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@id", id.Text);
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

                cmd.Parameters.AddWithValue("@date", sqlFormattedDate);
                cmd.Parameters.AddWithValue("@rev", comp.Text);
                cmd.Parameters.AddWithValue("@desc", des.Text);

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
                cmd = new SqlCommand("delete COMPLAINT where U_ID=@id and EMAIL = @email", connect);
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
            if (email.Text == "" || id.Text == "" || comp.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                cmd = new SqlCommand("update COMPLAINT set EMAIL=@e,U_ID = @id ,DATE=@date, DESCRIPTION = @des , RATING= @rate where REVIEW_NO=@review", connect);

                //cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@e", email.Text);
                //cmd.Parameters.AddWithValue("@date", sqlFormattedDate);
                cmd.Parameters.AddWithValue("@des", des.Text);
                cmd.Parameters.AddWithValue("@review", comp.Text);
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
