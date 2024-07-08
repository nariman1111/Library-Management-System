namespace connect_to_server2
{
    partial class Form15
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
            button5 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            fname = new TextBox();
            label9 = new Label();
            email = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.HotTrack;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(841, 304);
            button5.Name = "button5";
            button5.Size = new Size(216, 52);
            button5.TabIndex = 99;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 387);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1066, 238);
            dataGridView1.TabIndex = 98;
            // 
            // button4
            // 
            button4.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.HotTrack;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(668, 304);
            button4.Name = "button4";
            button4.Size = new Size(148, 52);
            button4.TabIndex = 97;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HotTrack;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(71, 207);
            button3.Name = "button3";
            button3.Size = new Size(169, 52);
            button3.TabIndex = 96;
            button3.Text = "update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HotTrack;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(336, 207);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 95;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(599, 207);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 94;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fname
            // 
            fname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            fname.Location = new Point(687, 65);
            fname.Name = "fname";
            fname.Size = new Size(356, 37);
            fname.TabIndex = 93;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HotTrack;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(552, 59);
            label9.Name = "label9";
            label9.Size = new Size(77, 39);
            label9.TabIndex = 92;
            label9.Text = "phone";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(147, 60);
            email.Name = "email";
            email.Size = new Size(356, 37);
            email.TabIndex = 91;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(23, 60);
            label3.Name = "label3";
            label3.Size = new Size(84, 39);
            label3.TabIndex = 90;
            label3.Text = "Email: ";
            // 
            // Form15
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
            Controls.Add(fname);
            Controls.Add(label9);
            Controls.Add(email);
            Controls.Add(label3);
            Name = "Form15";
            Text = "Form15";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox fname;
        private Label label9;
        private TextBox email;
        private Label label3;
    }
}