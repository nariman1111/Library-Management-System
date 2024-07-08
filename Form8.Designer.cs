namespace connect_to_server2
{
    partial class Form8
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
            dataSet11 = new DataSet1();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            pUBLISHBindingSource = new BindingSource(components);
            publishTableAdapter1 = new DataSet1TableAdapters.PUBLISHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pUBLISHBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.HotTrack;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(840, 298);
            button5.Name = "button5";
            button5.Size = new Size(216, 52);
            button5.TabIndex = 89;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 381);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1066, 238);
            dataGridView1.TabIndex = 88;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.HotTrack;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(667, 298);
            button4.Name = "button4";
            button4.Size = new Size(148, 52);
            button4.TabIndex = 87;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HotTrack;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(70, 201);
            button3.Name = "button3";
            button3.Size = new Size(169, 52);
            button3.TabIndex = 86;
            button3.Text = "update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HotTrack;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(335, 201);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 85;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(598, 201);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 84;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fname
            // 
            fname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            fname.Location = new Point(686, 59);
            fname.Name = "fname";
            fname.Size = new Size(356, 37);
            fname.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HotTrack;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(551, 53);
            label9.Name = "label9";
            label9.Size = new Size(110, 39);
            label9.TabIndex = 80;
            label9.Text = "BOOK_ID";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(146, 54);
            email.Name = "email";
            email.Size = new Size(356, 37);
            email.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(22, 54);
            label3.Name = "label3";
            label3.Size = new Size(84, 39);
            label3.TabIndex = 76;
            label3.Text = "Email: ";
            // 
            // dataSet11
            // 
            dataSet11.DataSetName = "DataSet1";
            dataSet11.Namespace = "http://tempuri.org/DataSet1.xsd";
            dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = dataSet11;
            bindingSource1.Position = 0;
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = pUBLISHBindingSource;
            // 
            // pUBLISHBindingSource
            // 
            pUBLISHBindingSource.DataMember = "PUBLISH";
            pUBLISHBindingSource.DataSource = bindingSource1;
            // 
            // publishTableAdapter1
            // 
            publishTableAdapter1.ClearBeforeFill = true;
            // 
            // Form8
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
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pUBLISHBindingSource).EndInit();
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
        private DataSet1 dataSet11;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private BindingSource pUBLISHBindingSource;
        private DataSet1TableAdapters.PUBLISHTableAdapter publishTableAdapter1;
    }
}