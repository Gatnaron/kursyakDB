using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp11
{
    public partial class Form5 : Form
    {
        DataBase database = new DataBase();
        public Form5()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }

        private void button_regist_Click(object sender, EventArgs e)
        {
            var login = textBox_log.Text;
            var password = textBox_pass.Text;
            var role = comboBox_role.SelectedIndex;

            var Atitle = textBox_Atitle.Text;
            var Asurname = textBox_Asurname.Text;
            var Aname = textBox_Aname.Text;
            var Apatronymic = textBox_Apatronymic.Text;
            var Acity = comboBox_Acity.SelectedValue;

            var Ptitle = textBox_Ptitle.Text;
            var Pcity = comboBox_Pcity.SelectedValue;
            var Pform = comboBox_Pform.SelectedValue;
            var Pserv = comboBox_Pserv.SelectedValue;

            SqlCommand command1 = new SqlCommand();
            SqlCommand command2 = new SqlCommand();
            string querryString1 = "";
            string querryString2 = "";
            if (checkUser())
            {
                string querryString = $"INSERT INTO Autorization(login, password, role) VALUES ('{login}', '{password}', {role})";
                SqlCommand command = new SqlCommand(querryString, database.getConnection());
                if (tabControl1.SelectedTab == tabPage1 && comboBox_role.SelectedIndex == 0)
                {
                    querryString1 = $"INSERT INTO Advertiser(Title, Surname, Name, Patronymic, ID_City, ID_Autorization) VALUES ('{Atitle}', '{Asurname}', '{Aname}', '{Apatronymic}', {Acity}, (SELECT TOP 1 Autorization.ID_Autorization FROM Autorization ORDER BY ID_Autorization DESC))";
                }
                if (tabControl1.SelectedTab == tabPage2 && comboBox_role.SelectedIndex == 1)
                {
                    querryString2 = $"INSERT INTO Publisher(Title, ID_City, ID_Form, ID_Service, ID_Autorization) VALUES ('{Ptitle}', {Pcity}, {Pform}, {Pserv}, (SELECT TOP 1 Autorization.ID_Autorization FROM Autorization ORDER BY ID_Autorization DESC))";
                }
                command1 = new SqlCommand(querryString1, database.getConnection());
                
                command2 = new SqlCommand(querryString2, database.getConnection());
                database.openConnection();
                if (tabControl1.SelectedTab == tabPage1 && comboBox_role.SelectedIndex == 0)
                { command1.ExecuteNonQuery(); }
                if (tabControl1.SelectedTab == tabPage2 && comboBox_role.SelectedIndex == 1)
                { command2.ExecuteNonQuery(); }

                if (command.ExecuteNonQuery() == 1 /*&& (command1.ExecuteNonQuery() == 1 || command2.ExecuteNonQuery() == 1)*/)
                {
                    MessageBox.Show("Аккаунт успешно создан");
                    Form4 form4 = new Form4();
                    this.Hide();
                    form4.ShowDialog();
                }
                else
                    MessageBox.Show("Аккаунт не создан");
                database.closeConnection();
            }
        }

        private Boolean checkUser()
        {
            var login = textBox_log.Text;
            var password = textBox_pass.Text;
            var role = comboBox_role.SelectedIndex;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querryString = $"SELECT ID_Autorization, login, password FROM Autorization WHERE login = '{login}' AND password = '{password}'";

            SqlCommand command = new SqlCommand(querryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return false;
            }
            else return true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.aADataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Form". При необходимости она может быть перемещена или удалена.
            this.formTableAdapter.Fill(this.aADataSet.Form);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.City". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this.aADataSet.City);

        }

        
    }
}
