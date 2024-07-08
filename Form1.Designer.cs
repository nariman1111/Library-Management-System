namespace connect_to_server2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            label7 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 548);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vivaldi", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(493, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 53);
            label1.TabIndex = 2;
            label1.Text = "Hello,";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Vivaldi", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(493, 62);
            label2.Name = "label2";
            label2.Size = new Size(169, 62);
            label2.TabIndex = 3;
            label2.Text = "welcome!";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(493, 211);
            label3.Name = "label3";
            label3.Size = new Size(117, 38);
            label3.TabIndex = 4;
            label3.Text = "username:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(497, 275);
            label4.Name = "label4";
            label4.Size = new Size(113, 38);
            label4.TabIndex = 5;
            label4.Text = "password:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(628, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 39);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(628, 275);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 39);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Vivaldi", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(628, 370);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 8;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(816, 320);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(168, 29);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(500, 465);
            label5.Name = "label5";
            label5.Size = new Size(251, 29);
            label5.TabIndex = 11;
            label5.Text = "Don't have an account? ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(800, 465);
            label6.Name = "label6";
            label6.Size = new Size(215, 29);
            label6.TabIndex = 12;
            label6.Text = "Register as Student  ";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(697, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 211);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Font = new Font("Vivaldi", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HotTrack;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(881, 410);
            button3.Name = "button3";
            button3.Size = new Size(123, 34);
            button3.TabIndex = 40;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(800, 511);
            label7.Name = "label7";
            label7.Size = new Size(204, 29);
            label7.TabIndex = 41;
            label7.Text = "Register as Admin  ";
            label7.Click += label7_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Vivaldi", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.HotTrack;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(628, 410);
            button5.Name = "button5";
            button5.Size = new Size(162, 34);
            button5.TabIndex = 59;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1015, 549);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.HotTrack;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Button button3;
        private Label label7;
        private Button button5;
    }
}