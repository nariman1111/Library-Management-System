namespace connect_to_server2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            password = new TextBox();
            email = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            id = new TextBox();
            label7 = new Label();
            level = new TextBox();
            label8 = new Label();
            fname = new TextBox();
            label9 = new Label();
            last = new TextBox();
            label10 = new Label();
            label11 = new Label();
            sex = new ComboBox();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            dataSet11 = new DataSet1();
            studentTableAdapter1 = new DataSet1TableAdapters.STUDENTTableAdapter();
            bindingSource1 = new BindingSource(components);
            button6 = new Button();
            bindingSource2 = new BindingSource(components);
            sTUDENTBindingSource = new BindingSource(components);
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sTUDENTBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // password
            // 
            resources.ApplyResources(password, "password");
            password.Name = "password";
            password.TextChanged += textBox2_TextChanged;
            // 
            // email
            // 
            resources.ApplyResources(email, "email");
            email.Name = "email";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.HotTrack;
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.HotTrack;
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.HotTrack;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.HotTrack;
            label1.Name = "label1";
            // 
            // id
            // 
            resources.ApplyResources(id, "id");
            id.Name = "id";
            id.TextChanged += id_TextChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = SystemColors.HotTrack;
            label7.Name = "label7";
            // 
            // level
            // 
            resources.ApplyResources(level, "level");
            level.Name = "level";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = SystemColors.HotTrack;
            label8.Name = "label8";
            label8.Click += label8_Click;
            // 
            // fname
            // 
            resources.ApplyResources(fname, "fname");
            fname.Name = "fname";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = SystemColors.HotTrack;
            label9.Name = "label9";
            // 
            // last
            // 
            resources.ApplyResources(last, "last");
            last.Name = "last";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = SystemColors.HotTrack;
            label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = SystemColors.HotTrack;
            label11.Name = "label11";
            label11.Click += label11_Click;
            // 
            // sex
            // 
            sex.DisplayMember = "female ";
            resources.ApplyResources(sex, "sex");
            sex.FormattingEnabled = true;
            sex.Items.AddRange(new object[] { resources.GetString("sex.Items"), resources.GetString("sex.Items1") });
            sex.Name = "sex";
            sex.ValueMember = "male";
            sex.SelectedIndexChanged += sex_SelectedIndexChanged;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = SystemColors.HotTrack;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.ForeColor = SystemColors.HotTrack;
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = SystemColors.HotTrack;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = SystemColors.HotTrack;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.ForeColor = SystemColors.HotTrack;
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 33;
            // 
            // dataSet11
            // 
            dataSet11.DataSetName = "DataSet1";
            dataSet11.Namespace = "http://tempuri.org/DataSet1.xsd";
            dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter1
            // 
            studentTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = dataSet11;
            bindingSource1.Position = 0;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.ForeColor = SystemColors.HotTrack;
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = sTUDENTBindingSource;
            // 
            // sTUDENTBindingSource
            // 
            sTUDENTBindingSource.DataMember = "STUDENT";
            sTUDENTBindingSource.DataSource = bindingSource1;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.ForeColor = SystemColors.HotTrack;
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(sex);
            Controls.Add(label11);
            Controls.Add(last);
            Controls.Add(label10);
            Controls.Add(fname);
            Controls.Add(label9);
            Controls.Add(level);
            Controls.Add(label8);
            Controls.Add(id);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(checkBox1);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sTUDENTBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private CheckBox checkBox1;
        private TextBox password;
        private TextBox email;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox id;
        private Label label7;
        private TextBox level;
        private Label label8;
        private TextBox fname;
        private Label label9;
        private TextBox last;
        private Label label10;
        private Label label11;
        private ComboBox sex;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button2;
        private Button button4;
        private DataGridView dataGridView1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private BindingSource bindingSource1;
        private Button button6;
        private BindingSource bindingSource2;
        private BindingSource sTUDENTBindingSource;
        private Button button7;
    }
}