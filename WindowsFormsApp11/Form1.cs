﻿using System;
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
    public partial class Form1 : Form
    {
        public string connection = ConfigurationManager.ConnectionStrings["WindowsFormsApp11.Properties.Settings.AAConnectionString"].ConnectionString;
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp11.Properties.Settings.AAConnectionString"].ConnectionString);
        
        SqlCommand command = new SqlCommand();
        private SqlDataAdapter adapter = null;
        private DataTable dt = null;

        public int ID = -1;

        public Form1()
        {
            InitializeComponent();
            this.dataGridView4.RowHeaderMouseClick += dataGridView4_RowHeaderMouseClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Statement". При необходимости она может быть перемещена или удалена.
            this.statementTableAdapter.Fill(this.aADataSet.Statement);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.aADataSet.Publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.aADataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Form". При необходимости она может быть перемещена или удалена.
            this.formTableAdapter.Fill(this.aADataSet.Form);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Advertiser". При необходимости она может быть перемещена или удалена.
            this.advertiserTableAdapter.Fill(this.aADataSet.Advertiser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.City". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this.aADataSet.City);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Statement.Request AS 'Заявление', Statement.Release AS 'Выпуск', Advertiser.Title AS 'Рекламодатель', Publisher.Title AS 'Издатель' FROM dbo.Statement JOIN dbo.Advertiser ON Advertiser.ID_Advertiser = Statement.ID_Advertiser JOIN dbo.Publisher ON Publisher.ID_Publisher = Statement.ID_Publisher" + $" WHERE Statement.Request = '{dateTimePicker1.Text}' AND Statement.Release = '{dateTimePicker2.Text}'", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;

            conn.Close();
        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                if (tabControl2.SelectedTab == tabPage4)
                {
                    textBox_AComp.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBox_Surname.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBox_Name.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textBox_Patronymic.Text = dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();
                    comboBox_ACity.Text = dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                if (tabControl2.SelectedTab == tabPage5)
                {
                    textBox_PComp.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
                    comboBox_PCity.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
                    comboBox_Form.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
                    comboBox_Serv.Text = dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                if (tabControl2.SelectedTab == tabPage3)
                {
                    dateTimePicker_Request.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
                    dateTimePicker_Release.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
                    comboBox_AdvertiserTitle.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
                    comboBox_PublisherTitle.Text = dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                if (tabControl2.SelectedTab == tabPage1)
                {
                    textBox_CityID.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBox_CityName.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBox_countAdvInCity.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textBox_countPubInCity.Text = dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
                if (tabControl2.SelectedTab == tabPage2)
                {
                    textBox_FormID.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBox_FormName.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBox_countPubInForm.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                if (tabControl2.SelectedTab == tabPage6)
                {
                    textBox_ServID.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBox_ServName.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBox_countPubInServ.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
        }

        private void button_add1_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"INSERT INTO Advertiser (Title, Surname, Name, Patronymic, ID_City) VALUES ('{textBox_AComp.Text}', '{textBox_Surname.Text}', '{textBox_Name.Text}', '{textBox_Patronymic.Text}', {comboBox_ACity.SelectedValue})", conn);
            
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Рекламодатель добавлен");
        }

        private void button_del1_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"DELETE Advertiser WHERE ID_Advertiser = {comboBox_AID.SelectedValue}", conn);
            
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Рекламодатель удален");
        }

        private void button_add2_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"INSERT INTO Publisher (Title, ID_City, ID_Form, ID_Service) VALUES ('{textBox_PComp.Text}', {comboBox_PCity.SelectedValue}, {comboBox_Form.SelectedValue}, {comboBox_Serv.SelectedValue})", conn);
            
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Издатель добавлен");
        }

        private void button_del2_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"DELETE Publisher WHERE ID_Publisher = {comboBox_PID.SelectedValue}", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Издатель удален");
        }

        private void button_add3_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"INSERT INTO Statement (Request, Release, ID_Advertiser, ID_Publisher) VALUES ('{dateTimePicker_Request.Text}', '{dateTimePicker_Release.Text}', {comboBox_AdvertiserTitle.SelectedValue}, {comboBox_PublisherTitle.SelectedValue})", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Заказ добавлен");
        }

        private void button_del3_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"DELETE Statement WHERE ID = {comboBox_SID.SelectedValue}", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Заказ удален");
        }

        /*private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Advertiser.Title AS 'Компания', Advertiser.Surname AS 'Фамилия', Advertiser.Name AS 'Имя', Advertiser.Patronymic AS 'Отчество',City.Name AS 'Город' FROM dbo.Advertiser JOIN dbo.City ON Advertiser.ID_City = City.ID_City", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            
            conn.Close();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Publisher.Title AS 'Компания', City.Name AS 'Город', Form.Form AS 'Форма', Service.Name AS 'Услуга' FROM dbo.Publisher JOIN dbo.City ON Publisher.ID_City = City.ID_City JOIN dbo.Form ON Publisher.ID_Form = Form.ID_Form JOIN dbo.Service ON Publisher.ID_Service = Service.ID_Service", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;

            conn.Close();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Statement.Request AS 'Заявление', Statement.Release AS 'Выпуск', Advertiser.Title AS 'Рекламодатель', Publisher.Title AS 'Издатель' FROM dbo.Statement JOIN dbo.Advertiser ON Advertiser.ID_Advertiser = Statement.ID_Advertiser JOIN dbo.Publisher ON Publisher.ID_Publisher = Statement.ID_Publisher", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;

            conn.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Advertiser.Title AS 'Компания', Advertiser.Surname AS 'Фамилия', Advertiser.Name AS 'Имя', Advertiser.Patronymic AS 'Отчество',City.Name AS 'Город' FROM dbo.Advertiser JOIN dbo.City ON Advertiser.ID_City = City.ID_City", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Publisher.Title AS 'Компания', City.Name AS 'Город', Form.Form AS 'Форма', Service.Name AS 'Услуга' FROM dbo.Publisher JOIN dbo.City ON Publisher.ID_City = City.ID_City JOIN dbo.Form ON Publisher.ID_Form = Form.ID_Form JOIN dbo.Service ON Publisher.ID_Service = Service.ID_Service", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Statement.Request AS 'Заявление', Statement.Release AS 'Выпуск', Advertiser.Title AS 'Рекламодатель', Publisher.Title AS 'Издатель' FROM dbo.Statement JOIN dbo.Advertiser ON Advertiser.ID_Advertiser = Statement.ID_Advertiser JOIN dbo.Publisher ON Publisher.ID_Publisher = Statement.ID_Publisher", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT City.ID_City AS '№', City.Name AS 'Название', (SELECT COUNT(Advertiser.ID_Advertiser) FROM Advertiser WHERE City.ID_City = Advertiser.ID_City) AS 'Рекламодателей', (SELECT COUNT(Publisher.ID_Publisher) FROM Publisher WHERE City.ID_City = Publisher.ID_City) AS 'Издателей' FROM City", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Form.ID_Form AS '№', Form.Form AS 'Форма', (SELECT COUNT(Publisher.ID_Publisher) FROM Publisher WHERE Form.ID_Form = Publisher.ID_Form) AS 'Издателей' FROM Form", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            *//*conn.Open();
            adapter = new SqlDataAdapter("SELECT Service.ID_Service AS '№', Service.Name AS 'Название', (SELECT COUNT(Publisher.ID_Publisher) FROM Publisher WHERE Service.ID_Service = Publisher.ID_Service) AS 'Издателей' FROM Service", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();*//*
        }*/

        private void button_del4_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"DELETE City WHERE ID_City = {comboBox_IDCity.SelectedValue}", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Город удален");
        }

        private void button_add4_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"INSERT INTO City (Name) VALUES ('{textBox_CityName.Text}')", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Город добавлен");
        }

        private void button_del5_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"DELETE Form WHERE ID_Form = {comboBox_IDForm.SelectedValue}", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Форма издательства удалена");
        }

        private void button_add5_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"INSERT INTO Form (Form) VALUES ('{textBox_FormName.Text}')", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Форма издательства добавлена");
        }

        private void button_add6_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"INSERT INTO Service (Name) VALUES ('{textBox_ServName.Text}')", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Услуга издательства добавлена");
        }

        private void button_del6_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"DELETE Service WHERE ID_Service = {comboBox_IDServ.SelectedValue}", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Услуга издательства удалена");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_IDCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Advertiser.Title AS 'Компания', Advertiser.Surname AS 'Фамилия', Advertiser.Name AS 'Имя', Advertiser.Patronymic AS 'Отчество',City.Name AS 'Город' FROM dbo.Advertiser JOIN dbo.City ON Advertiser.ID_City = City.ID_City", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;

            conn.Close();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Publisher.Title AS 'Компания', City.Name AS 'Город', Form.Form AS 'Форма', Service.Name AS 'Услуга' FROM dbo.Publisher JOIN dbo.City ON Publisher.ID_City = City.ID_City JOIN dbo.Form ON Publisher.ID_Form = Form.ID_Form JOIN dbo.Service ON Publisher.ID_Service = Service.ID_Service", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Statement.Request AS 'Заявление', Statement.Release AS 'Выпуск', Advertiser.Title AS 'Рекламодатель', Publisher.Title AS 'Издатель' FROM dbo.Statement JOIN dbo.Advertiser ON Advertiser.ID_Advertiser = Statement.ID_Advertiser JOIN dbo.Publisher ON Publisher.ID_Publisher = Statement.ID_Publisher", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;

            conn.Close();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT City.ID_City AS '№', City.Name AS 'Название', (SELECT COUNT(Advertiser.ID_Advertiser) FROM Advertiser WHERE City.ID_City = Advertiser.ID_City) AS 'Рекламодателей', (SELECT COUNT(Publisher.ID_Publisher) FROM Publisher WHERE City.ID_City = Publisher.ID_City) AS 'Издателей' FROM City", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Form.ID_Form AS '№', Form.Form AS 'Форма', (SELECT COUNT(Publisher.ID_Publisher) FROM Publisher WHERE Form.ID_Form = Publisher.ID_Form) AS 'Издателей' FROM Form", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT Service.ID_Service AS '№', Service.Name AS 'Название', (SELECT COUNT(Publisher.ID_Publisher) FROM Publisher WHERE Service.ID_Service = Publisher.ID_Service) AS 'Издателей' FROM Service", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }
    }
}
