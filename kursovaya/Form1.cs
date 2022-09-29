using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace kursovaya
{
    public partial class Website : Form
    {
        private SqlConnection sqlConnection = null;
        public Website()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db1.Магазин". При необходимости она может быть перемещена или удалена.
            this.магазинTableAdapter.Fill(this.db.Магазин);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.db.Товар);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "kanctovarDataSet.Товар". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kanctovarDataSet.Магазин". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kanctovarDataSet.Товар". При необходимости она может быть перемещена или удалена.
            //this.товарTableAdapter.Fill(this.kanctovarDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.sssr". При необходимости она может быть перемещена или удалена.
            //sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            //dataGridView1.DataSource = kanctovarDataSet.Товар;
            //sqlConnection.Open();
           // if (sqlConnection.State == ConnectionState.Open);
            {
              //  MessageBox.Show("Подключение установлено!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Магазин;
            label1.Text = "Сотрудничество:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Товар;
            label1.Text = "Каталог товаров:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int z=0;
            for(int i=0;i<dataGridView1.RowCount;i++)
            {
                for(int j=0;j<dataGridView1.ColumnCount;j++)
                {
                    if (z==1)
                    { break; }
                    if(Convert.ToString(dataGridView1.Rows[i].Cells[j].Value).Contains(textBox1.Text))
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[j];
                        z = 1;
                        break;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form Website = new Учётная_запись();
            Website.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
