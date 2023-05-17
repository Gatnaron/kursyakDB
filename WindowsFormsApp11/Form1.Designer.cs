namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Изменение = new System.Windows.Forms.GroupBox();
            this.button_del1 = new System.Windows.Forms.Button();
            this.button_add1 = new System.Windows.Forms.Button();
            this.comboBox_AID = new System.Windows.Forms.ComboBox();
            this.advertiserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aADataSet = new WindowsFormsApp11.AADataSet();
            this.comboBox_ACity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Patronymic = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_AComp = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_del2 = new System.Windows.Forms.Button();
            this.comboBox_PID = new System.Windows.Forms.ComboBox();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_add2 = new System.Windows.Forms.Button();
            this.comboBox_Serv = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Form = new System.Windows.Forms.ComboBox();
            this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_PCity = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_PComp = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_del3 = new System.Windows.Forms.Button();
            this.comboBox_SID = new System.Windows.Forms.ComboBox();
            this.statementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_add3 = new System.Windows.Forms.Button();
            this.comboBox_PublisherTitle = new System.Windows.Forms.ComboBox();
            this.comboBox_AdvertiserTitle = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Release = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_Request = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_countPubInCity = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_countAdvInCity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_CityName = new System.Windows.Forms.TextBox();
            this.button_add4 = new System.Windows.Forms.Button();
            this.button_del4 = new System.Windows.Forms.Button();
            this.comboBox_IDCity = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_countPubInForm = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_FormName = new System.Windows.Forms.TextBox();
            this.button_add5 = new System.Windows.Forms.Button();
            this.button_del5 = new System.Windows.Forms.Button();
            this.comboBox_IDForm = new System.Windows.Forms.ComboBox();
            this.formBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_countPubInServ = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_ServName = new System.Windows.Forms.TextBox();
            this.button_add6 = new System.Windows.Forms.Button();
            this.button_del6 = new System.Windows.Forms.Button();
            this.comboBox_IDServ = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cityTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.CityTableAdapter();
            this.advertiserTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.AdvertiserTableAdapter();
            this.formTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.FormTableAdapter();
            this.serviceTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.ServiceTableAdapter();
            this.publisherTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.PublisherTableAdapter();
            this.statementTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.StatementTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Word = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Excel = new System.Windows.Forms.ToolStripButton();
            this.button_exitManager = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.Изменение.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advertiserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statementBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(29, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найти заказ по дате";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Выпуск:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Заказ:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(53, 44);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(219, 327);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(512, 167);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Изменение);
            this.tabPage4.Controls.Add(this.comboBox_ACity);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.textBox_Patronymic);
            this.tabPage4.Controls.Add(this.textBox_Name);
            this.tabPage4.Controls.Add(this.textBox_Surname);
            this.tabPage4.Controls.Add(this.textBox_AComp);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(504, 141);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Рекламодатель";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Изменение
            // 
            this.Изменение.Controls.Add(this.button_del1);
            this.Изменение.Controls.Add(this.button_add1);
            this.Изменение.Controls.Add(this.comboBox_AID);
            this.Изменение.Location = new System.Drawing.Point(315, 6);
            this.Изменение.Name = "Изменение";
            this.Изменение.Size = new System.Drawing.Size(186, 103);
            this.Изменение.TabIndex = 30;
            this.Изменение.TabStop = false;
            this.Изменение.Text = "Изменение";
            // 
            // button_del1
            // 
            this.button_del1.Location = new System.Drawing.Point(6, 75);
            this.button_del1.Name = "button_del1";
            this.button_del1.Size = new System.Drawing.Size(174, 23);
            this.button_del1.TabIndex = 21;
            this.button_del1.Text = "Удалить";
            this.button_del1.UseVisualStyleBackColor = true;
            this.button_del1.Click += new System.EventHandler(this.button_del1_Click);
            // 
            // button_add1
            // 
            this.button_add1.Location = new System.Drawing.Point(6, 16);
            this.button_add1.Name = "button_add1";
            this.button_add1.Size = new System.Drawing.Size(174, 23);
            this.button_add1.TabIndex = 21;
            this.button_add1.Text = "Добавить";
            this.button_add1.UseVisualStyleBackColor = true;
            this.button_add1.Click += new System.EventHandler(this.button_add1_Click);
            // 
            // comboBox_AID
            // 
            this.comboBox_AID.DataSource = this.advertiserBindingSource;
            this.comboBox_AID.DisplayMember = "Title";
            this.comboBox_AID.FormattingEnabled = true;
            this.comboBox_AID.Location = new System.Drawing.Point(6, 51);
            this.comboBox_AID.Name = "comboBox_AID";
            this.comboBox_AID.Size = new System.Drawing.Size(174, 21);
            this.comboBox_AID.TabIndex = 23;
            this.comboBox_AID.ValueMember = "ID_Advertiser";
            // 
            // advertiserBindingSource
            // 
            this.advertiserBindingSource.DataMember = "Advertiser";
            this.advertiserBindingSource.DataSource = this.aADataSet;
            // 
            // aADataSet
            // 
            this.aADataSet.DataSetName = "AADataSet";
            this.aADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_ACity
            // 
            this.comboBox_ACity.DataSource = this.cityBindingSource;
            this.comboBox_ACity.DisplayMember = "Name";
            this.comboBox_ACity.FormattingEnabled = true;
            this.comboBox_ACity.Location = new System.Drawing.Point(129, 110);
            this.comboBox_ACity.Name = "comboBox_ACity";
            this.comboBox_ACity.Size = new System.Drawing.Size(182, 21);
            this.comboBox_ACity.TabIndex = 22;
            this.comboBox_ACity.ValueMember = "ID_City";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.aADataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Город";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Фамилия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Компания";
            // 
            // textBox_Patronymic
            // 
            this.textBox_Patronymic.Location = new System.Drawing.Point(129, 84);
            this.textBox_Patronymic.Name = "textBox_Patronymic";
            this.textBox_Patronymic.Size = new System.Drawing.Size(182, 20);
            this.textBox_Patronymic.TabIndex = 10;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(129, 58);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(182, 20);
            this.textBox_Name.TabIndex = 9;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(129, 32);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(182, 20);
            this.textBox_Surname.TabIndex = 8;
            // 
            // textBox_AComp
            // 
            this.textBox_AComp.Location = new System.Drawing.Point(129, 6);
            this.textBox_AComp.Name = "textBox_AComp";
            this.textBox_AComp.Size = new System.Drawing.Size(182, 20);
            this.textBox_AComp.TabIndex = 7;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.comboBox_Serv);
            this.tabPage5.Controls.Add(this.comboBox_Form);
            this.tabPage5.Controls.Add(this.comboBox_PCity);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.textBox_PComp);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(504, 141);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Издатель";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_del2);
            this.groupBox3.Controls.Add(this.comboBox_PID);
            this.groupBox3.Controls.Add(this.button_add2);
            this.groupBox3.Location = new System.Drawing.Point(315, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 103);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменение";
            // 
            // button_del2
            // 
            this.button_del2.Location = new System.Drawing.Point(6, 75);
            this.button_del2.Name = "button_del2";
            this.button_del2.Size = new System.Drawing.Size(174, 23);
            this.button_del2.TabIndex = 21;
            this.button_del2.Text = "Удалить";
            this.button_del2.UseVisualStyleBackColor = true;
            this.button_del2.Click += new System.EventHandler(this.button_del2_Click);
            // 
            // comboBox_PID
            // 
            this.comboBox_PID.DataSource = this.publisherBindingSource;
            this.comboBox_PID.DisplayMember = "Title";
            this.comboBox_PID.FormattingEnabled = true;
            this.comboBox_PID.Location = new System.Drawing.Point(6, 52);
            this.comboBox_PID.Name = "comboBox_PID";
            this.comboBox_PID.Size = new System.Drawing.Size(174, 21);
            this.comboBox_PID.TabIndex = 27;
            this.comboBox_PID.ValueMember = "ID_Publisher";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.aADataSet;
            // 
            // button_add2
            // 
            this.button_add2.Location = new System.Drawing.Point(6, 19);
            this.button_add2.Name = "button_add2";
            this.button_add2.Size = new System.Drawing.Size(174, 23);
            this.button_add2.TabIndex = 21;
            this.button_add2.Text = "Добавить";
            this.button_add2.UseVisualStyleBackColor = true;
            this.button_add2.Click += new System.EventHandler(this.button_add2_Click);
            // 
            // comboBox_Serv
            // 
            this.comboBox_Serv.DataSource = this.serviceBindingSource;
            this.comboBox_Serv.DisplayMember = "Name";
            this.comboBox_Serv.FormattingEnabled = true;
            this.comboBox_Serv.Location = new System.Drawing.Point(129, 86);
            this.comboBox_Serv.Name = "comboBox_Serv";
            this.comboBox_Serv.Size = new System.Drawing.Size(182, 21);
            this.comboBox_Serv.TabIndex = 29;
            this.comboBox_Serv.ValueMember = "ID_Service";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.aADataSet;
            // 
            // comboBox_Form
            // 
            this.comboBox_Form.DataSource = this.formBindingSource;
            this.comboBox_Form.DisplayMember = "Form";
            this.comboBox_Form.FormattingEnabled = true;
            this.comboBox_Form.Location = new System.Drawing.Point(129, 59);
            this.comboBox_Form.Name = "comboBox_Form";
            this.comboBox_Form.Size = new System.Drawing.Size(182, 21);
            this.comboBox_Form.TabIndex = 28;
            this.comboBox_Form.ValueMember = "ID_Form";
            // 
            // formBindingSource
            // 
            this.formBindingSource.DataMember = "Form";
            this.formBindingSource.DataSource = this.aADataSet;
            // 
            // comboBox_PCity
            // 
            this.comboBox_PCity.DataSource = this.cityBindingSource;
            this.comboBox_PCity.DisplayMember = "Name";
            this.comboBox_PCity.FormattingEnabled = true;
            this.comboBox_PCity.Location = new System.Drawing.Point(129, 34);
            this.comboBox_PCity.Name = "comboBox_PCity";
            this.comboBox_PCity.Size = new System.Drawing.Size(182, 21);
            this.comboBox_PCity.TabIndex = 26;
            this.comboBox_PCity.ValueMember = "ID_City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Услуга";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Форма";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Город";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Компания";
            // 
            // textBox_PComp
            // 
            this.textBox_PComp.Location = new System.Drawing.Point(129, 8);
            this.textBox_PComp.Name = "textBox_PComp";
            this.textBox_PComp.Size = new System.Drawing.Size(182, 20);
            this.textBox_PComp.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.comboBox_PublisherTitle);
            this.tabPage3.Controls.Add(this.comboBox_AdvertiserTitle);
            this.tabPage3.Controls.Add(this.dateTimePicker_Release);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dateTimePicker_Request);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(504, 141);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_del3);
            this.groupBox1.Controls.Add(this.comboBox_SID);
            this.groupBox1.Controls.Add(this.button_add3);
            this.groupBox1.Location = new System.Drawing.Point(312, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 103);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменение";
            // 
            // button_del3
            // 
            this.button_del3.Location = new System.Drawing.Point(6, 75);
            this.button_del3.Name = "button_del3";
            this.button_del3.Size = new System.Drawing.Size(174, 23);
            this.button_del3.TabIndex = 21;
            this.button_del3.Text = "Удалить";
            this.button_del3.UseVisualStyleBackColor = true;
            this.button_del3.Click += new System.EventHandler(this.button_del3_Click);
            // 
            // comboBox_SID
            // 
            this.comboBox_SID.DataSource = this.statementBindingSource;
            this.comboBox_SID.DisplayMember = "ID";
            this.comboBox_SID.FormattingEnabled = true;
            this.comboBox_SID.Location = new System.Drawing.Point(6, 51);
            this.comboBox_SID.Name = "comboBox_SID";
            this.comboBox_SID.Size = new System.Drawing.Size(174, 21);
            this.comboBox_SID.TabIndex = 24;
            this.comboBox_SID.ValueMember = "ID";
            // 
            // statementBindingSource
            // 
            this.statementBindingSource.DataMember = "Statement";
            this.statementBindingSource.DataSource = this.aADataSet;
            // 
            // button_add3
            // 
            this.button_add3.Location = new System.Drawing.Point(6, 16);
            this.button_add3.Name = "button_add3";
            this.button_add3.Size = new System.Drawing.Size(174, 23);
            this.button_add3.TabIndex = 21;
            this.button_add3.Text = "Добавить";
            this.button_add3.UseVisualStyleBackColor = true;
            this.button_add3.Click += new System.EventHandler(this.button_add3_Click);
            // 
            // comboBox_PublisherTitle
            // 
            this.comboBox_PublisherTitle.DataSource = this.publisherBindingSource;
            this.comboBox_PublisherTitle.DisplayMember = "Title";
            this.comboBox_PublisherTitle.FormattingEnabled = true;
            this.comboBox_PublisherTitle.Location = new System.Drawing.Point(124, 37);
            this.comboBox_PublisherTitle.Name = "comboBox_PublisherTitle";
            this.comboBox_PublisherTitle.Size = new System.Drawing.Size(182, 21);
            this.comboBox_PublisherTitle.TabIndex = 28;
            this.comboBox_PublisherTitle.ValueMember = "ID_Publisher";
            // 
            // comboBox_AdvertiserTitle
            // 
            this.comboBox_AdvertiserTitle.DataSource = this.advertiserBindingSource;
            this.comboBox_AdvertiserTitle.DisplayMember = "Title";
            this.comboBox_AdvertiserTitle.FormattingEnabled = true;
            this.comboBox_AdvertiserTitle.Location = new System.Drawing.Point(124, 10);
            this.comboBox_AdvertiserTitle.Name = "comboBox_AdvertiserTitle";
            this.comboBox_AdvertiserTitle.Size = new System.Drawing.Size(182, 21);
            this.comboBox_AdvertiserTitle.TabIndex = 27;
            this.comboBox_AdvertiserTitle.ValueMember = "ID_Advertiser";
            // 
            // dateTimePicker_Release
            // 
            this.dateTimePicker_Release.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Release.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Release.Location = new System.Drawing.Point(124, 89);
            this.dateTimePicker_Release.Name = "dateTimePicker_Release";
            this.dateTimePicker_Release.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker_Release.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Дата выпуска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Издатель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата заказа";
            // 
            // dateTimePicker_Request
            // 
            this.dateTimePicker_Request.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Request.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Request.Location = new System.Drawing.Point(124, 63);
            this.dateTimePicker_Request.Name = "dateTimePicker_Request";
            this.dateTimePicker_Request.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker_Request.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Рекламодатель";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.textBox_countPubInCity);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.textBox_countAdvInCity);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.textBox_CityName);
            this.tabPage1.Controls.Add(this.button_add4);
            this.tabPage1.Controls.Add(this.button_del4);
            this.tabPage1.Controls.Add(this.comboBox_IDCity);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(504, 141);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Города";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Кол-во издателей";
            // 
            // textBox_countPubInCity
            // 
            this.textBox_countPubInCity.Location = new System.Drawing.Point(138, 61);
            this.textBox_countPubInCity.Name = "textBox_countPubInCity";
            this.textBox_countPubInCity.Size = new System.Drawing.Size(174, 20);
            this.textBox_countPubInCity.TabIndex = 31;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "Кол-во рекламодателей";
            // 
            // textBox_countAdvInCity
            // 
            this.textBox_countAdvInCity.Location = new System.Drawing.Point(138, 35);
            this.textBox_countAdvInCity.Name = "textBox_countAdvInCity";
            this.textBox_countAdvInCity.Size = new System.Drawing.Size(174, 20);
            this.textBox_countAdvInCity.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Название";
            // 
            // textBox_CityName
            // 
            this.textBox_CityName.Location = new System.Drawing.Point(138, 87);
            this.textBox_CityName.Name = "textBox_CityName";
            this.textBox_CityName.Size = new System.Drawing.Size(174, 20);
            this.textBox_CityName.TabIndex = 26;
            // 
            // button_add4
            // 
            this.button_add4.Location = new System.Drawing.Point(138, 113);
            this.button_add4.Name = "button_add4";
            this.button_add4.Size = new System.Drawing.Size(174, 23);
            this.button_add4.TabIndex = 21;
            this.button_add4.Text = "Добавить";
            this.button_add4.UseVisualStyleBackColor = true;
            this.button_add4.Click += new System.EventHandler(this.button_add4_Click);
            // 
            // button_del4
            // 
            this.button_del4.Location = new System.Drawing.Point(327, 113);
            this.button_del4.Name = "button_del4";
            this.button_del4.Size = new System.Drawing.Size(174, 23);
            this.button_del4.TabIndex = 21;
            this.button_del4.Text = "Удалить";
            this.button_del4.UseVisualStyleBackColor = true;
            this.button_del4.Click += new System.EventHandler(this.button_del4_Click);
            // 
            // comboBox_IDCity
            // 
            this.comboBox_IDCity.DataSource = this.cityBindingSource;
            this.comboBox_IDCity.DisplayMember = "Name";
            this.comboBox_IDCity.FormattingEnabled = true;
            this.comboBox_IDCity.Location = new System.Drawing.Point(327, 87);
            this.comboBox_IDCity.Name = "comboBox_IDCity";
            this.comboBox_IDCity.Size = new System.Drawing.Size(174, 21);
            this.comboBox_IDCity.TabIndex = 24;
            this.comboBox_IDCity.ValueMember = "ID_City";
            this.comboBox_IDCity.SelectedIndexChanged += new System.EventHandler(this.comboBox_IDCity_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.textBox_countPubInForm);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.textBox_FormName);
            this.tabPage2.Controls.Add(this.button_add5);
            this.tabPage2.Controls.Add(this.button_del5);
            this.tabPage2.Controls.Add(this.comboBox_IDForm);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(504, 141);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Формы издательств";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 65);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 13);
            this.label24.TabIndex = 37;
            this.label24.Text = "Кол-во издателей";
            // 
            // textBox_countPubInForm
            // 
            this.textBox_countPubInForm.Location = new System.Drawing.Point(136, 62);
            this.textBox_countPubInForm.Name = "textBox_countPubInForm";
            this.textBox_countPubInForm.Size = new System.Drawing.Size(174, 20);
            this.textBox_countPubInForm.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Название";
            // 
            // textBox_FormName
            // 
            this.textBox_FormName.Location = new System.Drawing.Point(136, 88);
            this.textBox_FormName.Name = "textBox_FormName";
            this.textBox_FormName.Size = new System.Drawing.Size(174, 20);
            this.textBox_FormName.TabIndex = 33;
            // 
            // button_add5
            // 
            this.button_add5.Location = new System.Drawing.Point(136, 115);
            this.button_add5.Name = "button_add5";
            this.button_add5.Size = new System.Drawing.Size(174, 23);
            this.button_add5.TabIndex = 29;
            this.button_add5.Text = "Добавить";
            this.button_add5.UseVisualStyleBackColor = true;
            this.button_add5.Click += new System.EventHandler(this.button_add5_Click);
            // 
            // button_del5
            // 
            this.button_del5.Location = new System.Drawing.Point(327, 115);
            this.button_del5.Name = "button_del5";
            this.button_del5.Size = new System.Drawing.Size(174, 23);
            this.button_del5.TabIndex = 30;
            this.button_del5.Text = "Удалить";
            this.button_del5.UseVisualStyleBackColor = true;
            this.button_del5.Click += new System.EventHandler(this.button_del5_Click);
            // 
            // comboBox_IDForm
            // 
            this.comboBox_IDForm.DataSource = this.formBindingSource1;
            this.comboBox_IDForm.DisplayMember = "Form";
            this.comboBox_IDForm.FormattingEnabled = true;
            this.comboBox_IDForm.Location = new System.Drawing.Point(327, 88);
            this.comboBox_IDForm.Name = "comboBox_IDForm";
            this.comboBox_IDForm.Size = new System.Drawing.Size(174, 21);
            this.comboBox_IDForm.TabIndex = 31;
            this.comboBox_IDForm.ValueMember = "ID_Form";
            // 
            // formBindingSource1
            // 
            this.formBindingSource1.DataMember = "Form";
            this.formBindingSource1.DataSource = this.aADataSet;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label25);
            this.tabPage6.Controls.Add(this.textBox_countPubInServ);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.textBox_ServName);
            this.tabPage6.Controls.Add(this.button_add6);
            this.tabPage6.Controls.Add(this.button_del6);
            this.tabPage6.Controls.Add(this.comboBox_IDServ);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(504, 141);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Услуги издательств";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 13);
            this.label25.TabIndex = 44;
            this.label25.Text = "Кол-во издателей";
            // 
            // textBox_countPubInServ
            // 
            this.textBox_countPubInServ.Location = new System.Drawing.Point(134, 62);
            this.textBox_countPubInServ.Name = "textBox_countPubInServ";
            this.textBox_countPubInServ.Size = new System.Drawing.Size(174, 20);
            this.textBox_countPubInServ.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Название";
            // 
            // textBox_ServName
            // 
            this.textBox_ServName.Location = new System.Drawing.Point(134, 88);
            this.textBox_ServName.Name = "textBox_ServName";
            this.textBox_ServName.Size = new System.Drawing.Size(174, 20);
            this.textBox_ServName.TabIndex = 40;
            // 
            // button_add6
            // 
            this.button_add6.Location = new System.Drawing.Point(134, 115);
            this.button_add6.Name = "button_add6";
            this.button_add6.Size = new System.Drawing.Size(174, 23);
            this.button_add6.TabIndex = 36;
            this.button_add6.Text = "Добавить";
            this.button_add6.UseVisualStyleBackColor = true;
            this.button_add6.Click += new System.EventHandler(this.button_add6_Click);
            // 
            // button_del6
            // 
            this.button_del6.Location = new System.Drawing.Point(327, 115);
            this.button_del6.Name = "button_del6";
            this.button_del6.Size = new System.Drawing.Size(174, 23);
            this.button_del6.TabIndex = 37;
            this.button_del6.Text = "Удалить";
            this.button_del6.UseVisualStyleBackColor = true;
            this.button_del6.Click += new System.EventHandler(this.button_del6_Click);
            // 
            // comboBox_IDServ
            // 
            this.comboBox_IDServ.DataSource = this.serviceBindingSource1;
            this.comboBox_IDServ.DisplayMember = "Name";
            this.comboBox_IDServ.FormattingEnabled = true;
            this.comboBox_IDServ.Location = new System.Drawing.Point(327, 88);
            this.comboBox_IDServ.Name = "comboBox_IDServ";
            this.comboBox_IDServ.Size = new System.Drawing.Size(174, 21);
            this.comboBox_IDServ.TabIndex = 38;
            this.comboBox_IDServ.ValueMember = "ID_Service";
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "Service";
            this.serviceBindingSource1.DataSource = this.aADataSet;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(142, 11);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(571, 292);
            this.dataGridView4.TabIndex = 1;
            this.dataGridView4.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView4_RowHeaderMouseClick);
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // advertiserTableAdapter
            // 
            this.advertiserTableAdapter.ClearBeforeFill = true;
            // 
            // formTableAdapter
            // 
            this.formTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // statementTableAdapter
            // 
            this.statementTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.toolStrip2);
            this.groupBox4.Controls.Add(this.dataGridView4);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(719, 309);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Таблицы";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripButton_Word,
            this.toolStripButton_Excel});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(136, 290);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(133, 19);
            this.toolStripButton7.Text = "Рекламодатель";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(133, 19);
            this.toolStripButton8.Text = "Издатель";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(133, 19);
            this.toolStripButton9.Text = "Заказы";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(133, 19);
            this.toolStripButton10.Text = "Города";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(133, 19);
            this.toolStripButton11.Text = "Формы издательств";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(133, 19);
            this.toolStripButton12.Text = "Услуги издательств";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // toolStripButton_Word
            // 
            this.toolStripButton_Word.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton_Word.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Word.Image")));
            this.toolStripButton_Word.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Word.Name = "toolStripButton_Word";
            this.toolStripButton_Word.Size = new System.Drawing.Size(133, 20);
            this.toolStripButton_Word.Text = "Импорт в Word";
            this.toolStripButton_Word.Click += new System.EventHandler(this.toolStripButton_Word_Click);
            // 
            // toolStripButton_Excel
            // 
            this.toolStripButton_Excel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton_Excel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Excel.Image")));
            this.toolStripButton_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Excel.Name = "toolStripButton_Excel";
            this.toolStripButton_Excel.Size = new System.Drawing.Size(133, 20);
            this.toolStripButton_Excel.Text = "Импорт в Excel";
            this.toolStripButton_Excel.Click += new System.EventHandler(this.toolStripButton_Excel_Click);
            // 
            // button_exitManager
            // 
            this.button_exitManager.Location = new System.Drawing.Point(29, 466);
            this.button_exitManager.Name = "button_exitManager";
            this.button_exitManager.Size = new System.Drawing.Size(173, 23);
            this.button_exitManager.TabIndex = 23;
            this.button_exitManager.Text = "Выйти";
            this.button_exitManager.UseVisualStyleBackColor = true;
            this.button_exitManager.Click += new System.EventHandler(this.button_exitManager_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 505);
            this.Controls.Add(this.button_exitManager);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Менеджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.Изменение.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advertiserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statementBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Release;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Request;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TextBox textBox_Patronymic;
        public System.Windows.Forms.TextBox textBox_Name;
        public System.Windows.Forms.TextBox textBox_Surname;
        public System.Windows.Forms.TextBox textBox_AComp;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox textBox_PComp;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ACity;
        private System.Windows.Forms.ComboBox comboBox_PCity;
        private System.Windows.Forms.ComboBox comboBox_PID;
        private System.Windows.Forms.ComboBox comboBox_AID;
        private System.Windows.Forms.ComboBox comboBox_Form;
        private System.Windows.Forms.ComboBox comboBox_Serv;
        private System.Windows.Forms.ComboBox comboBox_PublisherTitle;
        private System.Windows.Forms.ComboBox comboBox_AdvertiserTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_del3;
        private System.Windows.Forms.Button button_add3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_del2;
        private System.Windows.Forms.Button button_add2;
        private System.Windows.Forms.ComboBox comboBox_SID;
        private System.Windows.Forms.GroupBox Изменение;
        private System.Windows.Forms.Button button_del1;
        private System.Windows.Forms.Button button_add1;
        private AADataSet aADataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private AADataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource advertiserBindingSource;
        private AADataSetTableAdapters.AdvertiserTableAdapter advertiserTableAdapter;
        private System.Windows.Forms.BindingSource formBindingSource;
        private AADataSetTableAdapters.FormTableAdapter formTableAdapter;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private AADataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private AADataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.BindingSource statementBindingSource;
        private AADataSetTableAdapters.StatementTableAdapter statementTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_CityName;
        private System.Windows.Forms.Button button_add4;
        private System.Windows.Forms.Button button_del4;
        private System.Windows.Forms.ComboBox comboBox_IDCity;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_FormName;
        private System.Windows.Forms.Button button_add5;
        private System.Windows.Forms.Button button_del5;
        private System.Windows.Forms.ComboBox comboBox_IDForm;
        private System.Windows.Forms.BindingSource formBindingSource1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_ServName;
        private System.Windows.Forms.Button button_add6;
        private System.Windows.Forms.Button button_del6;
        private System.Windows.Forms.ComboBox comboBox_IDServ;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_countPubInCity;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_countAdvInCity;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_countPubInForm;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_countPubInServ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.Button button_exitManager;
        private System.Windows.Forms.ToolStripButton toolStripButton_Word;
        private System.Windows.Forms.ToolStripButton toolStripButton_Excel;
    }
}

