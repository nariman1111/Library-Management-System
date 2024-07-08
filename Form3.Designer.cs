namespace connect_to_server2
{
    partial class Form3
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
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.HotTrack;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(543, 304);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(104, 31);
            button4.TabIndex = 40;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.HotTrack;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(358, 304);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(151, 31);
            button5.TabIndex = 59;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(808, 245);
            dataGridView1.TabIndex = 63;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button1
            // 
            button1.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(153, 304);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(178, 31);
            button1.TabIndex = 64;
            button1.Text = "Back to student page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HotTrack;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(358, 248);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(104, 31);
            button2.TabIndex = 65;
            button2.Text = "show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 368);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}