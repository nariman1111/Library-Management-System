namespace connect_to_server2
{
    partial class Form10
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
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            dataSet11 = new DataSet1();
            reviewTableAdapter1 = new DataSet1TableAdapters.REVIEWTableAdapter();
            studentTableAdapter1 = new DataSet1TableAdapters.STUDENTTableAdapter();
            bindingSource1 = new BindingSource(components);
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            bindingSource2 = new BindingSource(components);
            rEVIEWBindingSource = new BindingSource(components);
            bindingSource3 = new BindingSource(components);
            sTUDENTBindingSource = new BindingSource(components);
            tableAdapterManager1 = new DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rEVIEWBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sTUDENTBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HotTrack;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(500, 427);
            button2.Name = "button2";
            button2.Size = new Size(148, 52);
            button2.TabIndex = 70;
            button2.Text = "show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(208, 520);
            button1.Name = "button1";
            button1.Size = new Size(254, 52);
            button1.TabIndex = 69;
            button1.Text = "Back to review page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1133, 355);
            dataGridView1.TabIndex = 68;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.HotTrack;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(500, 520);
            button5.Name = "button5";
            button5.Size = new Size(216, 52);
            button5.TabIndex = 67;
            button5.Text = "Home Page";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Vivaldi", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.HotTrack;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(765, 520);
            button4.Name = "button4";
            button4.Size = new Size(148, 52);
            button4.TabIndex = 66;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            // studentTableAdapter1
            // 
            studentTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = dataSet11;
            bindingSource1.Position = 0;
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessTokenCallback = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
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
            // bindingSource3
            // 
            bindingSource3.DataSource = sTUDENTBindingSource;
            // 
            // sTUDENTBindingSource
            // 
            sTUDENTBindingSource.DataMember = "STUDENT";
            sTUDENTBindingSource.DataSource = bindingSource1;
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
            // Form10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 614);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet11).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rEVIEWBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)sTUDENTBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.REVIEWTableAdapter reviewTableAdapter1;
        private DataSet1TableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private BindingSource bindingSource1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private BindingSource bindingSource2;
        private BindingSource rEVIEWBindingSource;
        private BindingSource bindingSource3;
        private BindingSource sTUDENTBindingSource;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}