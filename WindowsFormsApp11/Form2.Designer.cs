namespace WindowsFormsApp11
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_patronymic = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aADataSet = new WindowsFormsApp11.AADataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Release = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Request = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Publisher = new System.Windows.Forms.ComboBox();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aADataSet1 = new WindowsFormsApp11.AADataSet();
            this.button_Create = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.statementTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.StatementTableAdapter();
            this.publisherTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.PublisherTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_city);
            this.groupBox1.Controls.Add(this.textBox_patronymic);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.textBox_surname);
            this.groupBox1.Controls.Add(this.textBox_title);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Профиль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название компании";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(122, 124);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(164, 20);
            this.textBox_city.TabIndex = 4;
            // 
            // textBox_patronymic
            // 
            this.textBox_patronymic.Location = new System.Drawing.Point(122, 98);
            this.textBox_patronymic.Name = "textBox_patronymic";
            this.textBox_patronymic.Size = new System.Drawing.Size(164, 20);
            this.textBox_patronymic.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(122, 72);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(164, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(122, 46);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(164, 20);
            this.textBox_surname.TabIndex = 1;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(122, 20);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(164, 20);
            this.textBox_title.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_exit);
            this.groupBox2.Controls.Add(this.button_del);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заказы";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(6, 107);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(29, 23);
            this.button_exit.TabIndex = 25;
            this.button_exit.Text = "<";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(275, 107);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 9;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 88);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // statementBindingSource
            // 
            this.statementBindingSource.DataMember = "Statement";
            this.statementBindingSource.DataSource = this.aADataSet;
            // 
            // aADataSet
            // 
            this.aADataSet.DataSetName = "AADataSet";
            this.aADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker_Release);
            this.groupBox3.Controls.Add(this.dateTimePicker_Request);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBox_Publisher);
            this.groupBox3.Controls.Add(this.button_Create);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_Comment);
            this.groupBox3.Location = new System.Drawing.Point(375, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 294);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Создать новый заказ";
            // 
            // dateTimePicker_Release
            // 
            this.dateTimePicker_Release.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Release.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Release.Location = new System.Drawing.Point(179, 48);
            this.dateTimePicker_Release.Name = "dateTimePicker_Release";
            this.dateTimePicker_Release.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Release.TabIndex = 17;
            // 
            // dateTimePicker_Request
            // 
            this.dateTimePicker_Request.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Request.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Request.Location = new System.Drawing.Point(179, 19);
            this.dateTimePicker_Request.Name = "dateTimePicker_Request";
            this.dateTimePicker_Request.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Request.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Издатель";
            // 
            // comboBox_Publisher
            // 
            this.comboBox_Publisher.DataSource = this.publisherBindingSource;
            this.comboBox_Publisher.DisplayMember = "Title";
            this.comboBox_Publisher.FormattingEnabled = true;
            this.comboBox_Publisher.Location = new System.Drawing.Point(179, 83);
            this.comboBox_Publisher.Name = "comboBox_Publisher";
            this.comboBox_Publisher.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Publisher.TabIndex = 14;
            this.comboBox_Publisher.ValueMember = "ID_Publisher";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.aADataSet1;
            // 
            // aADataSet1
            // 
            this.aADataSet1.DataSetName = "AADataSet";
            this.aADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(169, 265);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 13;
            this.button_Create.Text = "Создать";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Комментарий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата выпуска";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Дата заказа";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(8, 123);
            this.textBox_Comment.Multiline = true;
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(399, 136);
            this.textBox_Comment.TabIndex = 9;
            // 
            // statementTableAdapter
            // 
            this.statementTableAdapter.ClearBeforeFill = true;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Рекламодатель";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textBox_patronymic;
        public System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.TextBox textBox_surname;
        public System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Button button_del;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Comment;
        private AADataSet aADataSet;
        private System.Windows.Forms.BindingSource statementBindingSource;
        private AADataSetTableAdapters.StatementTableAdapter statementTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Publisher;
        private AADataSet aADataSet1;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private AADataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Release;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Request;
        private System.Windows.Forms.Button button_exit;
    }
}