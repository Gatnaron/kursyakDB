using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Statement". При необходимости она может быть перемещена или удалена.
            this.statementTableAdapter.Fill(this.aADataSet.Statement);

        }

        private void button_Execute_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dateTimePicker_Request.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker_Release.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox_AdvertiserTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_Comment.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            MessageBox.Show("Вы вышли из профиля Издателя");
            this.Close();
            form4.ShowDialog();
        }
    }
}
