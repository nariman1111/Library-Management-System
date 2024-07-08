namespace connect_to_server2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sex = new ComboBox();
            label11 = new Label();
            last = new TextBox();
            label10 = new Label();
            fname = new TextBox();
            label9 = new Label();
            checkBox1 = new CheckBox();
            password = new TextBox();
            email = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sex
            // 
            sex.DisplayMember = "female ";
            sex.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sex.FormattingEnabled = true;
            sex.Items.AddRange(new object[] { "Female", "Male" });
            sex.Location = new Point(398, 157);
            sex.Name = "sex";
            sex.Size = new Size(355, 38);
            sex.TabIndex = 51;
            sex.ValueMember = "male";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HotTrack;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(324, 157);
            label11.Name = "label11";
            label11.Size = new Size(59, 39);
            label11.TabIndex = 50;
            label11.Text = "sex:";
            // 
            // last
            // 
            last.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            last.Location = new Point(699, 72);
            last.Name = "last";
            last.Size = new Size(356, 37);
            last.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HotTrack;
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(564, 70);
            label10.Name = "label10";
            label10.Size = new Size(121, 39);
            label10.TabIndex = 48;
            label10.Text = "last name:";
            label10.Click += label10_Click;
            // 
            // fname
            // 
            fname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            fname.Location = new Point(699, 29);
            fname.Name = "fname";
            fname.Size = new Size(356, 37);
            fname.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HotTrack;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(564, 23);
            label9.Name = "label9";
            label9.Size = new Size(127, 39);
            label9.TabIndex = 46;
            label9.Text = "first name:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ImeMode = ImeMode.NoControl;
            checkBox1.Location = new Point(351, 110);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(164, 29);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(159, 67);
            password.Name = "password";
            password.Size = new Size(356, 37);
            password.TabIndex = 40;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(159, 24);
            email.Name = "email";
            email.Size = new Size(356, 37);
            email.TabIndex = 39;
            email.TextChanged += email_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(27, 67);
            label4.Name = "label4";
            label4.Size = new Size(126, 39);
            label4.TabIndex = 38;
            label4.Text = "password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(35, 24);
            label3.Name = "label3";
            label3.Size = new Size(84, 39);
            label3.TabIndex = 37;
            label3.Text = "Email: ";
            // 
            // button3
            // 
            button3.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HotTrack;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(69, 218);
            button3.Name = "button3";
            button3.Size = new Size(169, 52);
            button3.TabIndex = 55;
            button3.Text = "update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HotTrack;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(334, 218);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 54;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(597, 218);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 53;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.HotTrack;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(666, 315);
            button4.Name = "button4";
            button4.Size = new Size(148, 52);
            button4.TabIndex = 56;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 373);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1066, 252);
            dataGridView1.TabIndex = 57;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button5
            // 
            button5.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.HotTrack;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(839, 315);
            button5.Name = "button5";
            button5.Size = new Size(216, 52);
            button5.TabIndex = 58;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 625);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sex);
            Controls.Add(label11);
            Controls.Add(last);
            Controls.Add(label10);
            Controls.Add(fname);
            Controls.Add(label9);
            Controls.Add(checkBox1);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox sex;
        private Label label11;
        private TextBox last;
        private Label label10;
        private TextBox fname;
        private Label label9;
        private CheckBox checkBox1;
        private TextBox password;
        private TextBox email;
        private Label label4;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
    }
}