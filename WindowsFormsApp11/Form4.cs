using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form4 : Form
    {
        DataBase datebase = new DataBase();
        public Form4()
        {
            InitializeComponent();
        }

        private void button_manager_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("Вы вошли как МЕНЕДЖЕР");
            this.Hide();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var password = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

                Form2 form2 = new Form2();
                string querryString1 = $"SELECT ID_Autorization, login, password FROM Autorization WHERE login = '{login}' AND password = '{password}'";
                string querryID1 = $"SELECT ID_Autorization FROM Autorization WHERE login = '{login}' AND password = '{password}'";
                
                SqlCommand command = new SqlCommand(querryString1, datebase.getConnection());

                datebase.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    querryID1 = (reader[0]).ToString();
                }
                reader.Close();
                datebase.closeConnection();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                string querryAdv = $"SELECT Advertiser.Title, Advertiser.Surname, Advertiser.Name, Advertiser.Patronymic, City.Name FROM dbo.Advertiser JOIN dbo.City ON Advertiser.ID_City = City.ID_City WHERE ID_Autorization = {querryID1}";
                SqlCommand command1 = new SqlCommand(querryAdv, datebase.getConnection());
                
                datebase.openConnection();
                reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    form2.textBox_title.Text = (reader[0]).ToString();
                    form2.textBox_surname.Text = (reader[1].ToString());
                    form2.textBox_name.Text = (reader[2].ToString());
                    form2.textBox_patronymic.Text = (reader[3].ToString());
                    form2.textBox_city.Text = (reader[4].ToString());
                }
                reader.Close();
                datebase.closeConnection();

                string querryStatement1 = $"SELECT Statement.ID AS '№', Statement.Request AS 'Заказ', Statement.Release AS 'Выпуск', Publisher.Title AS 'Издатель', Statement.Сomment AS 'Комметарий' FROM Statement JOIN Publisher ON Statement.ID_Publisher = Publisher.ID_Publisher WHERE Statement.ID_Advertiser = (SELECT Autorization.ID_Autorization FROM Autorization JOIN Advertiser ON Advertiser.ID_Autorization = Autorization.ID_Autorization WHERE Autorization.ID_Autorization = {querryID1})";
                datebase.openConnection();
                adapter = new SqlDataAdapter(querryStatement1, datebase.getConnection());
                table = new DataTable();
                adapter.Fill(table);
                form2.dataGridView1.DataSource = table;

                datebase.closeConnection();

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы усепешно авторизировались как РЕКЛАМОДАТЕЛЬ");

                    this.Hide();
                    form2.ShowDialog();
                }
                /*else
                    MessageBox.Show("Такого аккаунта не существует");*/
            
            //
                string querryString2 = $"SELECT ID_Autorization, login, password FROM Autorization WHERE login = '{login}' AND password = '{password}'";
                string querryID2 = $"SELECT ID_Autorization FROM Autorization WHERE login = '{login}' AND password = '{password}'";

                SqlCommand command2 = new SqlCommand(querryString2, datebase.getConnection());

                datebase.openConnection();
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    querryID2 = (reader2[0]).ToString();
                }
                reader2.Close();
                datebase.closeConnection();

                adapter.SelectCommand = command2;
                adapter.Fill(table);

                string querryPub = $"SELECT Publisher.Title, City.Name, Form.Form, Service.Name FROM dbo.Publisher  JOIN dbo.City ON Publisher.ID_City = City.ID_City JOIN dbo.Form ON Publisher.ID_Form = Form.ID_Form JOIN dbo.Service ON Publisher.ID_Service = Service.ID_Service WHERE ID_Autorization = {querryID2}";
                SqlCommand command3 = new SqlCommand(querryPub, datebase.getConnection());

                Form3 form3 = new Form3();
                datebase.openConnection();
                reader2 = command3.ExecuteReader();
                while (reader2.Read())
                {
                    form3.textBox_Ptitle.Text = (reader2[0]).ToString();
                    form3.textBox_Pcity.Text = (reader2[1]).ToString();
                    form3.textBox_Pform.Text = (reader2[2]).ToString();
                    form3.textBox_Pserv.Text = (reader2[3]).ToString();
                }
                reader2.Close();
                datebase.closeConnection();

                string querryStatement2 = $"SELECT Statement.ID AS '№', Statement.Request AS 'Заказ', Statement.Release AS 'Выпуск', Advertiser.Title AS 'Рекламодатель', Statement.Сomment AS 'Комметарий' FROM Statement JOIN Publisher ON Statement.ID_Publisher = Publisher.ID_Publisher JOIN Advertiser ON Statement.ID_Advertiser = Advertiser.ID_Advertiser WHERE Publisher.ID_Autorization = {querryID2}";
                datebase.openConnection();
                adapter = new SqlDataAdapter(querryStatement2, datebase.getConnection());
                table = new DataTable();
                adapter.Fill(table);
                form3.dataGridView1.DataSource = table;

                datebase.closeConnection();

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы усепешно авторизировались как ИЗДАТЕЛЬ");
                    form3.ShowDialog();
                }
                /*else
                    MessageBox.Show("Такого аккаунта не существует");*/
            
        }
    }
}
