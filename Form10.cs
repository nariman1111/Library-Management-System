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

namespace connect_to_server2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();


        }
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\database assignment\sql database\library mangment.mdf"";Integrated Security=True;Connect Timeout=30");



        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter a = new SqlDataAdapter("select REVIEW_NO, FIRST_NAME ,LAST_NAME ,STUDENT.U_ID, STUDENT.EMAIL ,DESCRIPTION, RATING   from STUDENT , REVIEW   where STUDENT.U_ID = REVIEW.U_ID and STUDENT.EMAIL = REVIEW.EMAIL ", connect);
            DataTable d = new DataTable();

            a.Fill(d);
            dataGridView1.DataSource = d;
            connect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.reviewTableAdapter1.Fill(this.dataSet11.REVIEW);
            this.studentTableAdapter1.Fill(this.dataSet11.STUDENT);

        }
    }
}
