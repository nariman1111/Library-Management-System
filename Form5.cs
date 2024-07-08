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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 aform = new Form4();
            aform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 rform = new Form9();
            rform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show(); this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show(); this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show(); this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();   
            form15.Show(); this.Hide();
        }
    }
}
