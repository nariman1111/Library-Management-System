using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using System.Data.SqlClient; 


namespace connect_to_server2
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\database assignment\sql database\library mangment.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Form2()
        {
            InitializeComponent();
            DisplayData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void DisplayData()
        {
            connect.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from STUDENT", connect);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        private void ClearData()
        {
            email.Text = "";
            id.Text = "";
            sex.Text = "";
            level.Text = "";
            fname.Text = "";
            last.Text = "";
            password.Text = "";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (email.Text != "" && id.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO STUDENT (Email,U_ID, FIRST_NAME ,LAST_NAME,LEVEL,SIX, PASSWORD) " +
              "VALUES(@email,@12, @FIRST, @second,@2 ,@FEMAL, @122)", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@email", email.Text.Trim());
                cmd.Parameters.AddWithValue("@12", id.Text.Trim());
                cmd.Parameters.AddWithValue("@2", level.Text.Trim());
                cmd.Parameters.AddWithValue("@FIRST", fname.Text.Trim());
                cmd.Parameters.AddWithValue("@second", last.Text.Trim());
                cmd.Parameters.AddWithValue("@FEMAL", sex.Text.Trim());
                cmd.Parameters.AddWithValue("@122", password.Text.Trim());

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

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 nform = new Form1();
            nform.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();

        }

        private void sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            sex.Items.Add("Male");
            sex.Items.Add("Female");
            this.Controls.Add(sex);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete STUDENT where U_ID=@id", connect);
            connect.Open();

            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Record Deleted Successfully!");
            DisplayData();
            ClearData();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || id.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed) connect.Open();
                cmd = new SqlCommand("update STUDENT set EMAIL=@e ,level=@level, FIRST_NAME = @first, LAST_NAME= @last ,SIX = @fem , PASSWORD = @pass where U_ID=@id", connect);

                //cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@e", email.Text);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@level", level.Text);
                cmd.Parameters.AddWithValue("@first", fname.Text);
                cmd.Parameters.AddWithValue("@last", last.Text);
                cmd.Parameters.AddWithValue("@fem", sex.Text);
                cmd.Parameters.AddWithValue("@pass", password.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                connect.Close();
                DisplayData();
                ClearData();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();   
            form16.Show();
            this.Hide();
        }
    }
}
