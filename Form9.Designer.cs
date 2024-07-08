namespace connect_to_server2
{
    partial class Form9
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
            id = new TextBox();
            label9 = new Label();
            review = new TextBox();
            email = new TextBox();
            label4 = new Label();
            label3 = new Label();
            des = new TextBox();
            label1 = new Label();
            rate = new TextBox();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            dataSet11 = new DataSet1();
            reviewTableAdapter1 = new DataSet1TableAdapters.REVIEWTableAdapter();
            button6 = new Button();
            bindingSource2 = new BindingSource(components);
            rEVIEWBindingSource = new BindingSource(components);
            studentTableAdapter1 = new DataSet1TableAdapters.STUDENTTableAdapter();
            tableAdapterManager1 = new DataSet1TableAdapters.TableAdapterManager();
            bindingSource3 = new BindingSource(components);
            bindingSource4 = new BindingSource(components);
            sTUDENTBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rEVIEWBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sTUDENTBindingSource).BeginInit();
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
            dataGridView1.Location = new Point(0, 356);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1066, 263);
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
            button3.Location = new Point(77, 240);
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
            button2.Location = new Point(289, 240);
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
            button1.Location = new Point(632, 240);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 84;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // id
            // 
            id.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            id.Location = new Point(700, 12);
            id.Name = "id";
            id.Size = new Size(356, 37);
            id.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HotTrack;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(565, 6);
            label9.Name = "label9";
            label9.Size = new Size(66, 39);
            label9.TabIndex = 80;
            label9.Text = "U_ID";
            // 
            // review
            // 
            review.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            review.Location = new Point(160, 50);
            review.Name = "review";
            review.Size = new Size(356, 37);
            review.TabIndex = 79;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(160, 7);
            email.Name = "email";
            email.Size = new Size(356, 37);
            email.TabIndex = 78;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(137, 39);
            label4.TabIndex = 77;
            label4.Text = "REVIEW NO:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(36, 7);
            label3.Name = "label3";
            label3.Size = new Size(84, 39);
            label3.TabIndex = 76;
            label3.Text = "Email: ";
            // 
            // des
            // 
            des.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            des.Location = new Point(160, 98);
            des.Multiline = true;
            des.Name = "des";
            des.Size = new Size(356, 106);
            des.TabIndex = 91;
            des.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(-9, 98);
            label1.Name = "label1";
            label1.Size = new Size(158, 39);
            label1.TabIndex = 90;
            label1.Text = "DESCRIBTION";
            label1.Click += label1_Click;
            // 
            // rate
            // 
            rate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rate.Location = new Point(699, 58);
            rate.Name = "rate";
            rate.Size = new Size(356, 37);
            rate.TabIndex = 93;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(551, 61);
            label2.Name = "label2";
            label2.Size = new Size(100, 39);
            label2.TabIndex = 92;
            label2.Text = "RATING:";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = dataSet11;
            bindingSource1.Position = 0;
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // dataSet11
            // 
            dataSet11.DataSetName = "DataSet1";
            dataSet11.Namespace = "http://tempuri.org/DataSet1.xsd";
            dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewTableAdapter1
            // 
            reviewTableAdapter1.ClearBeforeFill = true;
            // 
            // button6
            // 
            button6.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.HotTrack;
            button6.ImeMode = ImeMode.NoControl;
            button6.Location = new Point(833, 240);
            button6.Name = "button6";
            button6.Size = new Size(169, 52);
            button6.TabIndex = 94;
            button6.Text = "select";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = rEVIEWBindingSource;
            // 
            // rEVIEWBindingSource
            // 
            rEVIEWBindingSource.DataMember = "REVIEW";
            rEVIEWBindingSource.DataSource = bindingSource1;
            // 
            // studentTableAdapter1
            // 
            studentTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            tableAdapterManager1.ADMINTableAdapter = null;
            tableAdapterManager1.AUTHORTableAdapter = null;
            tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            tableAdapterManager1.BOOK_LOANSTableAdapter = null;
            tableAdapterManager1.BOOKTableAdapter = null;
            tableAdapterManager1.COMPLAINTTableAdapter = null;
            tableAdapterManager1.PHONE_ADMINTableAdapter = null;
            tableAdapterManager1.PHONE_STUDENTTableAdapter = null;
            tableAdapterManager1.PUBLISHTableAdapter = null;
            tableAdapterManager1.RESERVETableAdapter = null;
            tableAdapterManager1.REVIEWTableAdapter = reviewTableAdapter1;
            tableAdapterManager1.STUDENTTableAdapter = studentTableAdapter1;
            tableAdapterManager1.UpdateOrder = DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingSource4
            // 
            bindingSource4.DataSource = sTUDENTBindingSource;
            // 
            // sTUDENTBindingSource
            // 
            sTUDENTBindingSource.DataMember = "STUDENT";
            sTUDENTBindingSource.DataSource = bindingSource1;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 625);
            Controls.Add(button6);
            Controls.Add(rate);
            Controls.Add(label2);
            Controls.Add(des);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(id);
            Controls.Add(label9);
            Controls.Add(review);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rEVIEWBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)sTUDENTBindingSource).EndInit();
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
        private TextBox id;
        private Label label9;
        private TextBox review;
        private TextBox email;
        private Label label4;
        private Label label3;
        private TextBox des;
        private Label label1;
        private TextBox rate;
        private Label label2;
        private BindingSource bindingSource1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.REVIEWTableAdapter reviewTableAdapter1;
        private Button button6;
        private BindingSource bindingSource2;
        private BindingSource rEVIEWBindingSource;
        private DataSet1TableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private BindingSource bindingSource3;
        private BindingSource bindingSource4;
        private BindingSource sTUDENTBindingSource;
    }
}