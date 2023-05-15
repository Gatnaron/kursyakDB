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
    public partial class Form2 : Form
    {
        public string connection = ConfigurationManager.ConnectionStrings["WindowsFormsApp11.Properties.Settings.AAConnectionString"].ConnectionString;
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp11.Properties.Settings.AAConnectionString"].ConnectionString);

        SqlCommand command = new SqlCommand();
        //private SqlDataAdapter adapter = null;
        //private DataTable dt = null;

        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet1.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.aADataSet1.Publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Statement". При необходимости она может быть перемещена или удалена.
            this.statementTableAdapter.Fill(this.aADataSet.Statement);

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"INSERT INTO Statement (Request, Release, ID_Advertiser, ID_Publisher, Сomment) VALUES ('{dateTimePicker_Request.Text}', '{dateTimePicker_Release.Text}', (SELECT ID_Advertiser FROM Advertiser WHERE Advertiser.Title = '{textBox_title.Text}'), {comboBox_Publisher.SelectedValue}, '{textBox_Comment.Text}')", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Заказ добавлен");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            MessageBox.Show("Вы вышли из профиля РЕКЛАМОДАТЕЛЯ");
            this.Close();
            form4.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dateTimePicker_Request.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker_Release.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox_Publisher.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_Comment.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand($"DELETE Statement WHERE Request = '{dateTimePicker_Request}' AND Release = '{dateTimePicker_Release}'", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Заказ удален");
        }
    }
}
