namespace connect_to_server2
{
    partial class Form11
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            label11 = new Label();
            label10 = new Label();
            book = new TextBox();
            label8 = new Label();
            id = new TextBox();
            label7 = new Label();
            loan = new TextBox();
            email = new TextBox();
            label4 = new Label();
            label3 = new Label();
            status = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            booK_loansTableAdapter1 = new DataSet1TableAdapters.BOOK_LOANSTableAdapter();
            tableAdapterManager1 = new DataSet1TableAdapters.TableAdapterManager();
            bindingSource1 = new BindingSource(components);
            dataSet11 = new DataSet1();
            bindingSource2 = new BindingSource(components);
            bOOKLOANSBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bOOKLOANSBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1068, 290);
            dataGridView1.TabIndex = 86;
            // 
            // button1
            // 
            button1.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(260, 257);
            button1.Name = "button1";
            button1.Size = new Size(143, 52);
            button1.TabIndex = 85;
            button1.Text = "update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HotTrack;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(435, 257);
            button2.Name = "button2";
            button2.Size = new Size(143, 52);
            button2.TabIndex = 84;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.HotTrack;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(649, 257);
            button4.Name = "button4";
            button4.Size = new Size(143, 52);
            button4.TabIndex = 83;
            button4.Text = "Insert";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.HotTrack;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(649, 175);
            button5.Name = "button5";
            button5.Size = new Size(190, 52);
            button5.TabIndex = 82;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Vivaldi", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HotTrack;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(909, 185);
            button3.Name = "button3";
            button3.Size = new Size(107, 42);
            button3.TabIndex = 81;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HotTrack;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(563, 123);
            label11.Name = "label11";
            label11.Size = new Size(79, 39);
            label11.TabIndex = 79;
            label11.Text = "status";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HotTrack;
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(16, 117);
            label10.Name = "label10";
            label10.Size = new Size(109, 39);
            label10.TabIndex = 77;
            label10.Text = "Due Date";
            // 
            // book
            // 
            book.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            book.Location = new Point(677, 65);
            book.Name = "book";
            book.Size = new Size(330, 37);
            book.TabIndex = 74;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HotTrack;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(546, 57);
            label8.Name = "label8";
            label8.Size = new Size(96, 39);
            label8.TabIndex = 73;
            label8.Text = "Book ID";
            // 
            // id
            // 
            id.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            id.Location = new Point(677, 15);
            id.Name = "id";
            id.Size = new Size(330, 37);
            id.TabIndex = 72;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(515, 7);
            label7.Name = "label7";
            label7.Size = new Size(156, 39);
            label7.TabIndex = 71;
            label7.Text = "University ID:";
            // 
            // loan
            // 
            loan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loan.Location = new Point(151, 62);
            loan.Name = "loan";
            loan.Size = new Size(330, 37);
            loan.TabIndex = 69;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(151, 12);
            email.Name = "email";
            email.Size = new Size(330, 37);
            email.TabIndex = 68;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(-2, 65);
            label4.Name = "label4";
            label4.Size = new Size(147, 39);
            label4.TabIndex = 67;
            label4.Text = "Loan number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(58, 12);
            label3.Name = "label3";
            label3.Size = new Size(84, 39);
            label3.TabIndex = 66;
            label3.Text = "Email: ";
            // 
            // status
            // 
            status.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            status.Location = new Point(676, 128);
            status.Name = "status";
            status.Size = new Size(330, 37);
            status.TabIndex = 87;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(330, 31);
            dateTimePicker1.TabIndex = 88;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // booK_loansTableAdapter1
            // 
            booK_loansTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            tableAdapterManager1.ADMINTableAdapter = null;
            tableAdapterManager1.AUTHORTableAdapter = null;
            tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            tableAdapterManager1.BOOK_LOANSTableAdapter = booK_loansTableAdapter1;
            tableAdapterManager1.BOOKTableAdapter = null;
            tableAdapterManager1.COMPLAINTTableAdapter = null;
            tableAdapterManager1.PHONE_ADMINTableAdapter = null;
            tableAdapterManager1.PHONE_STUDENTTableAdapter = null;
            tableAdapterManager1.PUBLISHTableAdapter = null;
            tableAdapterManager1.RESERVETableAdapter = null;
            tableAdapterManager1.REVIEWTableAdapter = null;
            tableAdapterManager1.STUDENTTableAdapter = null;
            tableAdapterManager1.UpdateOrder = DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = dataSet11;
            bindingSource1.Position = 0;
            // 
            // dataSet11
            // 
            dataSet11.DataSetName = "DataSet1";
            dataSet11.Namespace = "http://tempuri.org/DataSet1.xsd";
            dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = bOOKLOANSBindingSource;
            // 
            // bOOKLOANSBindingSource
            // 
            bOOKLOANSBindingSource.DataMember = "BOOK_LOANS";
            bOOKLOANSBindingSource.DataSource = bindingSource1;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 625);
            Controls.Add(dateTimePicker1);
            Controls.Add(status);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(book);
            Controls.Add(label8);
            Controls.Add(id);
            Controls.Add(label7);
            Controls.Add(loan);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bOOKLOANSBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button3;
        private Label label11;
        private Label label10;
        private TextBox book;
        private Label label8;
        private TextBox id;
        private Label label7;
        private TextBox loan;
        private TextBox email;
        private Label label4;
        private Label label3;
        private TextBox status;
        private DateTimePicker dateTimePicker1;
        private DataSet1TableAdapters.BOOK_LOANSTableAdapter booK_loansTableAdapter1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private BindingSource bindingSource1;
        private DataSet1 dataSet11;
        private BindingSource bindingSource2;
        private BindingSource bOOKLOANSBindingSource;
    }
}