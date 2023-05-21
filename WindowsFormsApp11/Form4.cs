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

        private void Autorization()
        {
            var login = textBox_login.Text;
            var password = textBox_password.Text;
            var role = comboBox_role.SelectedIndex;
            Form2 form2 = new Form2();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            int ID = 1;

            if (role == 0)
            {
                string querryString1 = $"SELECT ID_Autorization, login, password FROM Autorization WHERE login = '{login}' AND password = '{password}' AND Role = 0";
                //string querryID1 = $"SELECT ID_Autorization FROM Autorization WHERE login = '{login}' AND password = '{password}'";

                SqlCommand command = new SqlCommand(querryString1, datebase.getConnection());

                datebase.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID = int.Parse(reader[0].ToString());
                }
                reader.Close();
                datebase.closeConnection();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                using (SqlConnection connection = new DataBase().getConnection())
                {
                    connection.Open();
                    string querryAdv = $"SELECT Advertiser.Title, Advertiser.Surname, Advertiser.Name, Advertiser.Patronymic, City.Name FROM dbo.Advertiser JOIN dbo.City ON Advertiser.ID_City = City.ID_City WHERE ID_Autorization = {ID}";
                    SqlCommand command1 = new SqlCommand(querryAdv, connection);
                    using (SqlDataReader reader1 = command1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            form2.textBox_title.Text = reader1.GetValue(0).ToString();
                            form2.textBox_surname.Text = reader1.GetValue(1).ToString();
                            form2.textBox_name.Text = reader1.GetValue(2).ToString();
                            form2.textBox_patronymic.Text = reader1.GetValue(3).ToString();
                            form2.textBox_city.Text = reader1.GetValue(4).ToString();
                        }
                        reader1.Close();
                    }
                    connection.Close();
                }
                string querryStatement1 = $"SELECT Statement.ID AS '№', Statement.Request AS 'Заказ', Statement.Release AS 'Выпуск', Publisher.Title AS 'Издатель', Statement.Сomment AS 'Комметарий' FROM Statement JOIN Publisher ON Statement.ID_Publisher = Publisher.ID_Publisher WHERE Statement.ID_Advertiser = (SELECT Autorization.ID_Autorization FROM Autorization JOIN Advertiser ON Advertiser.ID_Autorization = Autorization.ID_Autorization WHERE Autorization.ID_Autorization = {ID})";
                datebase.openConnection();
                adapter = new SqlDataAdapter(querryStatement1, datebase.getConnection());
                table = new DataTable();
                adapter.Fill(table);
                form2.dataGridView1.DataSource = table;

                datebase.closeConnection();

                if (table.Rows.Count >= 0)
                {
                    this.Hide();
                    form2.ShowDialog();
                }

            }


            if (role == 1)
            {
                string querryString2 = $"SELECT ID_Autorization, login, password FROM Autorization WHERE login = '{login}' AND password = '{password}' AND Role = 1";
                //string querryID2 = $"SELECT ID_Autorization FROM Autorization WHERE login = '{login}' AND password = '{password}'";

                SqlCommand command2 = new SqlCommand(querryString2, datebase.getConnection());

                datebase.openConnection();
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    ID = int.Parse(reader2[0].ToString());
                }
                reader2.Close();
                datebase.closeConnection();

                adapter.SelectCommand = command2;
                adapter.Fill(table);

                string querryPub = $"SELECT Publisher.Title, City.Name, Form.Form, Service.Name FROM dbo.Publisher  JOIN dbo.City ON Publisher.ID_City = City.ID_City JOIN dbo.Form ON Publisher.ID_Form = Form.ID_Form JOIN dbo.Service ON Publisher.ID_Service = Service.ID_Service WHERE ID_Autorization = {ID}";
                SqlCommand command3 = new SqlCommand(querryPub, datebase.getConnection());

                Form3 form3 = new Form3();
                datebase.openConnection();
                SqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    form3.textBox_Ptitle.Text = (reader3[0]).ToString();
                    form3.textBox_Pcity.Text = (reader3[1]).ToString();
                    form3.textBox_Pform.Text = (reader3[2]).ToString();
                    form3.textBox_Pserv.Text = (reader3[3]).ToString();
                }
                reader3.Close();
                datebase.closeConnection();

                string querryStatement2 = $"SELECT Statement.ID AS '№', Statement.Request AS 'Заказ', Statement.Release AS 'Выпуск', Advertiser.Title AS 'Рекламодатель', Statement.Сomment AS 'Комметарий' FROM Statement JOIN Publisher ON Statement.ID_Publisher = Publisher.ID_Publisher JOIN Advertiser ON Statement.ID_Advertiser = Advertiser.ID_Advertiser WHERE Publisher.ID_Autorization = {ID}";
                datebase.openConnection();
                adapter = new SqlDataAdapter(querryStatement2, datebase.getConnection());
                table = new DataTable();
                adapter.Fill(table);
                form3.dataGridView1.DataSource = table;

                datebase.closeConnection();

                if (table.Rows.Count >= 0)
                {
                    this.Hide();
                    form3.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization();
        } 
    }
}
