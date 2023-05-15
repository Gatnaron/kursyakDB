namespace WindowsFormsApp11
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Pserv = new System.Windows.Forms.TextBox();
            this.textBox_Pform = new System.Windows.Forms.TextBox();
            this.textBox_Pcity = new System.Windows.Forms.TextBox();
            this.textBox_Ptitle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aADataSet = new WindowsFormsApp11.AADataSet();
            this.statementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statementTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.StatementTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_AdvertiserTitle = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Release = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_Request = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Pserv);
            this.groupBox1.Controls.Add(this.textBox_Pform);
            this.groupBox1.Controls.Add(this.textBox_Pcity);
            this.groupBox1.Controls.Add(this.textBox_Ptitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Профиль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Услуги организации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Форма организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название организации";
            // 
            // textBox_Pserv
            // 
            this.textBox_Pserv.Location = new System.Drawing.Point(142, 97);
            this.textBox_Pserv.Name = "textBox_Pserv";
            this.textBox_Pserv.Size = new System.Drawing.Size(172, 20);
            this.textBox_Pserv.TabIndex = 3;
            // 
            // textBox_Pform
            // 
            this.textBox_Pform.Location = new System.Drawing.Point(142, 71);
            this.textBox_Pform.Name = "textBox_Pform";
            this.textBox_Pform.Size = new System.Drawing.Size(172, 20);
            this.textBox_Pform.TabIndex = 2;
            // 
            // textBox_Pcity
            // 
            this.textBox_Pcity.Location = new System.Drawing.Point(142, 45);
            this.textBox_Pcity.Name = "textBox_Pcity";
            this.textBox_Pcity.Size = new System.Drawing.Size(172, 20);
            this.textBox_Pcity.TabIndex = 1;
            // 
            // textBox_Ptitle
            // 
            this.textBox_Ptitle.Location = new System.Drawing.Point(142, 19);
            this.textBox_Ptitle.Name = "textBox_Ptitle";
            this.textBox_Ptitle.Size = new System.Drawing.Size(172, 20);
            this.textBox_Ptitle.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(377, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 335);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ваши заказ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // aADataSet
            // 
            this.aADataSet.DataSetName = "AADataSet";
            this.aADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statementBindingSource
            // 
            this.statementBindingSource.DataMember = "Statement";
            this.statementBindingSource.DataSource = this.aADataSet;
            // 
            // statementTableAdapter
            // 
            this.statementTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Comment);
            this.groupBox2.Controls.Add(this.button_exit);
            this.groupBox2.Controls.Add(this.comboBox_AdvertiserTitle);
            this.groupBox2.Controls.Add(this.dateTimePicker_Release);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTimePicker_Request);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 190);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные заказа";
            // 
            // comboBox_AdvertiserTitle
            // 
            this.comboBox_AdvertiserTitle.DisplayMember = "Title";
            this.comboBox_AdvertiserTitle.FormattingEnabled = true;
            this.comboBox_AdvertiserTitle.Location = new System.Drawing.Point(142, 19);
            this.comboBox_AdvertiserTitle.Name = "comboBox_AdvertiserTitle";
            this.comboBox_AdvertiserTitle.Size = new System.Drawing.Size(211, 21);
            this.comboBox_AdvertiserTitle.TabIndex = 35;
            this.comboBox_AdvertiserTitle.ValueMember = "ID_Advertiser";
            // 
            // dateTimePicker_Release
            // 
            this.dateTimePicker_Release.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Release.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Release.Location = new System.Drawing.Point(142, 72);
            this.dateTimePicker_Release.Name = "dateTimePicker_Release";
            this.dateTimePicker_Release.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker_Release.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Дата выпуска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Дата заказа";
            // 
            // dateTimePicker_Request
            // 
            this.dateTimePicker_Request.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Request.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Request.Location = new System.Drawing.Point(142, 46);
            this.dateTimePicker_Request.Name = "dateTimePicker_Request";
            this.dateTimePicker_Request.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker_Request.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Рекламодатель";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(6, 161);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(29, 23);
            this.button_exit.TabIndex = 36;
            this.button_exit.Text = "<";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(89, 98);
            this.textBox_Comment.Multiline = true;
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(264, 86);
            this.textBox_Comment.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Комментарий";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Издатель";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_Ptitle;
        public System.Windows.Forms.TextBox textBox_Pcity;
        public System.Windows.Forms.TextBox textBox_Pform;
        public System.Windows.Forms.TextBox textBox_Pserv;
        public System.Windows.Forms.DataGridView dataGridView1;
        private AADataSet aADataSet;
        private System.Windows.Forms.BindingSource statementBindingSource;
        private AADataSetTableAdapters.StatementTableAdapter statementTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_AdvertiserTitle;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Release;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Request;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Comment;
    }
}