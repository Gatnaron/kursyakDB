namespace WindowsFormsApp11
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_manager = new System.Windows.Forms.Button();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Location = new System.Drawing.Point(99, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox_login.Location = new System.Drawing.Point(86, 24);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(148, 20);
            this.textBox_login.TabIndex = 4;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox_password.Location = new System.Drawing.Point(86, 50);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '◯';
            this.textBox_password.Size = new System.Drawing.Size(148, 20);
            this.textBox_password.TabIndex = 5;
            // 
            // button_manager
            // 
            this.button_manager.BackColor = System.Drawing.Color.SandyBrown;
            this.button_manager.Location = new System.Drawing.Point(186, 143);
            this.button_manager.Name = "button_manager";
            this.button_manager.Size = new System.Drawing.Size(81, 23);
            this.button_manager.TabIndex = 6;
            this.button_manager.Text = "Менеджер";
            this.button_manager.UseVisualStyleBackColor = false;
            this.button_manager.Click += new System.EventHandler(this.button_manager_Click);
            // 
            // comboBox_role
            // 
            this.comboBox_role.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "Рекламодатель",
            "Издатель"});
            this.comboBox_role.Location = new System.Drawing.Point(86, 77);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(148, 21);
            this.comboBox_role.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(279, 174);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.button_manager);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_manager;
        private System.Windows.Forms.ComboBox comboBox_role;
    }
}