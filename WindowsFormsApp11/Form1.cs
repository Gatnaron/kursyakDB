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
    public partial class Form1 : Form
    {
        public string connection = ConfigurationManager.ConnectionStrings["WindowsFormsApp11.Properties.Settings.AAConnectionString"].ConnectionString;
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp11.Properties.Settings.AAConnectionString"].ConnectionString);
        
        SqlCommand command = new SqlCommand();
        private SqlDataAdapter adapter = null;
        private DataTable dt = null;

        public int SelectedID = -1;

        public Form1()
        {
            InitializeComponent();
            this.dataGridView4.RowHeaderMouseClick += dataGridView4_RowHeaderMouseClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
        }

        private void button_add1_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"INSERT INTO Advertiser (Title, Surname, Name, Patronymic, ID_City) VALUES ('{textBox_AComp.Text}', '{textBox_Surname.Text}', '{textBox_Name.Text}', '{textBox_Patronymic.Text}', {comboBox_ACity.SelectedValue})", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Рекламодатель добавлен");
        }

        private void button_del1_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"DELETE Advertiser WHERE ID_Advertiser = {comboBox_AID.SelectedValue}", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Рекламодатель удален");
        }

        private void button_add2_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"INSERT INTO Publisher (Title, ID_City, ID_Form, ID_Service) VALUES ('{textBox_PComp.Text}', {comboBox_PCity.SelectedValue}, {comboBox_Form.SelectedValue}, {comboBox_Serv.SelectedValue})", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Издатель добавлен");
        }

        private void button_del2_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"DELETE Publisher WHERE ID_Publisher = {comboBox_PID.SelectedValue}", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Издатель удален");
        }

        private void button_add3_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"INSERT INTO Statement (Request, Release, ID_Advertiser, ID_Publisher) VALUES ('{dateTimePicker_Request.Text}', '{dateTimePicker_Release.Text}', {comboBox_AdvertiserTitle.SelectedValue}, {comboBox_PublisherTitle.SelectedValue})", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Заказ добавлен");
        }

        private void button_del3_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"DELETE Statement WHERE ID = {comboBox_SID.SelectedValue}", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Заказ удален");
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
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
    }
}
