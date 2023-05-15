namespace WindowsFormsApp11
{
    partial class Form5
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_regist = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Acity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aADataSet = new WindowsFormsApp11.AADataSet();
            this.textBox_Apatronymic = new System.Windows.Forms.TextBox();
            this.textBox_Aname = new System.Windows.Forms.TextBox();
            this.textBox_Asurname = new System.Windows.Forms.TextBox();
            this.textBox_Atitle = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Pserv = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Pform = new System.Windows.Forms.ComboBox();
            this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Pcity = new System.Windows.Forms.ComboBox();
            this.textBox_Ptitle = new System.Windows.Forms.TextBox();
            this.cityTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.CityTableAdapter();
            this.formTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.FormTableAdapter();
            this.serviceTableAdapter = new WindowsFormsApp11.AADataSetTableAdapters.ServiceTableAdapter();
            this.button_exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(12, 286);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(124, 23);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_regist
            // 
            this.button_regist.Location = new System.Drawing.Point(143, 286);
            this.button_regist.Name = "button_regist";
            this.button_regist.Size = new System.Drawing.Size(124, 23);
            this.button_regist.TabIndex = 1;
            this.button_regist.Text = "Зарегистрироваться";
            this.button_regist.UseVisualStyleBackColor = true;
            this.button_regist.Click += new System.EventHandler(this.button_regist_Click);
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(86, 40);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(180, 20);
            this.textBox_log.TabIndex = 2;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(86, 66);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(180, 20);
            this.textBox_pass.TabIndex = 3;
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "Рекламодатель",
            "Издатель"});
            this.comboBox_role.Location = new System.Drawing.Point(86, 93);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(180, 21);
            this.comboBox_role.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Роль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(82, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Регистрация";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(254, 164);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBox_Acity);
            this.tabPage1.Controls.Add(this.textBox_Apatronymic);
            this.tabPage1.Controls.Add(this.textBox_Aname);
            this.tabPage1.Controls.Add(this.textBox_Asurname);
            this.tabPage1.Controls.Add(this.textBox_Atitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(246, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Рекламодатель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Город";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Компания";
            // 
            // comboBox_Acity
            // 
            this.comboBox_Acity.DataSource = this.cityBindingSource;
            this.comboBox_Acity.DisplayMember = "Name";
            this.comboBox_Acity.FormattingEnabled = true;
            this.comboBox_Acity.Location = new System.Drawing.Point(60, 110);
            this.comboBox_Acity.Name = "comboBox_Acity";
            this.comboBox_Acity.Size = new System.Drawing.Size(180, 21);
            this.comboBox_Acity.TabIndex = 14;
            this.comboBox_Acity.ValueMember = "ID_City";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.aADataSet;
            // 
            // aADataSet
            // 
            this.aADataSet.DataSetName = "AADataSet";
            this.aADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_Apatronymic
            // 
            this.textBox_Apatronymic.Location = new System.Drawing.Point(60, 84);
            this.textBox_Apatronymic.Name = "textBox_Apatronymic";
            this.textBox_Apatronymic.Size = new System.Drawing.Size(180, 20);
            this.textBox_Apatronymic.TabIndex = 13;
            // 
            // textBox_Aname
            // 
            this.textBox_Aname.Location = new System.Drawing.Point(60, 58);
            this.textBox_Aname.Name = "textBox_Aname";
            this.textBox_Aname.Size = new System.Drawing.Size(180, 20);
            this.textBox_Aname.TabIndex = 12;
            // 
            // textBox_Asurname
            // 
            this.textBox_Asurname.Location = new System.Drawing.Point(60, 32);
            this.textBox_Asurname.Name = "textBox_Asurname";
            this.textBox_Asurname.Size = new System.Drawing.Size(180, 20);
            this.textBox_Asurname.TabIndex = 11;
            // 
            // textBox_Atitle
            // 
            this.textBox_Atitle.Location = new System.Drawing.Point(60, 6);
            this.textBox_Atitle.Name = "textBox_Atitle";
            this.textBox_Atitle.Size = new System.Drawing.Size(180, 20);
            this.textBox_Atitle.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboBox_Pserv);
            this.tabPage2.Controls.Add(this.comboBox_Pform);
            this.tabPage2.Controls.Add(this.comboBox_Pcity);
            this.tabPage2.Controls.Add(this.textBox_Ptitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(246, 138);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Издатель";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Услуги";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Форма";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Компания";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Город";
            // 
            // comboBox_Pserv
            // 
            this.comboBox_Pserv.DataSource = this.serviceBindingSource;
            this.comboBox_Pserv.DisplayMember = "Name";
            this.comboBox_Pserv.FormattingEnabled = true;
            this.comboBox_Pserv.Location = new System.Drawing.Point(60, 86);
            this.comboBox_Pserv.Name = "comboBox_Pserv";
            this.comboBox_Pserv.Size = new System.Drawing.Size(180, 21);
            this.comboBox_Pserv.TabIndex = 7;
            this.comboBox_Pserv.ValueMember = "ID_Service";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.aADataSet;
            // 
            // comboBox_Pform
            // 
            this.comboBox_Pform.DataSource = this.formBindingSource;
            this.comboBox_Pform.DisplayMember = "Form";
            this.comboBox_Pform.FormattingEnabled = true;
            this.comboBox_Pform.Location = new System.Drawing.Point(60, 59);
            this.comboBox_Pform.Name = "comboBox_Pform";
            this.comboBox_Pform.Size = new System.Drawing.Size(180, 21);
            this.comboBox_Pform.TabIndex = 6;
            this.comboBox_Pform.ValueMember = "ID_Form";
            // 
            // formBindingSource
            // 
            this.formBindingSource.DataMember = "Form";
            this.formBindingSource.DataSource = this.aADataSet;
            // 
            // comboBox_Pcity
            // 
            this.comboBox_Pcity.DataSource = this.cityBindingSource;
            this.comboBox_Pcity.DisplayMember = "Name";
            this.comboBox_Pcity.FormattingEnabled = true;
            this.comboBox_Pcity.Location = new System.Drawing.Point(60, 32);
            this.comboBox_Pcity.Name = "comboBox_Pcity";
            this.comboBox_Pcity.Size = new System.Drawing.Size(180, 21);
            this.comboBox_Pcity.TabIndex = 5;
            this.comboBox_Pcity.ValueMember = "ID_City";
            // 
            // textBox_Ptitle
            // 
            this.textBox_Ptitle.Location = new System.Drawing.Point(60, 6);
            this.textBox_Ptitle.Name = "textBox_Ptitle";
            this.textBox_Ptitle.Size = new System.Drawing.Size(180, 20);
            this.textBox_Ptitle.TabIndex = 3;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // formTableAdapter
            // 
            this.formTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 6);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(29, 23);
            this.button_exit.TabIndex = 24;
            this.button_exit.Text = "<";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 321);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_regist);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_log);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_regist;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_Apatronymic;
        private System.Windows.Forms.TextBox textBox_Aname;
        private System.Windows.Forms.TextBox textBox_Asurname;
        private System.Windows.Forms.TextBox textBox_Atitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_Ptitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Acity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Pserv;
        private System.Windows.Forms.ComboBox comboBox_Pform;
        private System.Windows.Forms.ComboBox comboBox_Pcity;
        private AADataSet aADataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private AADataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource formBindingSource;
        private AADataSetTableAdapters.FormTableAdapter formTableAdapter;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private AADataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Button button_exit;
    }
}