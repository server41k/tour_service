using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tour_service
{
    enum rowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

    }
    enum rowState2
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainForm : Form
    {
        DB database = new DB();
        string loginUser;
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("service_id", "Номер услуги");
            dataGridView1.Columns.Add("name", "Название");
            dataGridView1.Columns.Add("type", "Тип");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("duration", "Длительность");
            dataGridView1.Columns.Add("route", "Путь");

        }
        private void CreateColumns2()
        {
            dataGridView2.Columns.Add("order_id", "Номер заказа");
            dataGridView2.Columns.Add("name", "Имя");
            dataGridView2.Columns.Add("data", "Дата");
            dataGridView2.Columns.Add("team_size", "Команда");
            dataGridView2.Columns.Add("docs", "Документы");
            dataGridView2.Columns.Add("service_id", "Номер услуги");

        }
            private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5), rowState.ModifiedNew);
        }
        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(6), rowState2.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            database.openConnection();
            string queryString = "select * from service";
            MySqlCommand command = new MySqlCommand(queryString, database.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);

            }
            reader.Close();
            database.closeConnection();
        }
        private void RefreshDataGrid2(DataGridView dgw)
        {
            dgw.Rows.Clear();
            database.openConnection();
            string queryString = "SELECT * FROM `order`";
            MySqlCommand command = new MySqlCommand(queryString, database.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow2(dgw, reader);

            }
            reader.Close();
            database.closeConnection();
        }
        public MainForm(string loginUser)
        {
            InitializeComponent();
            this.dataGridView2.Hide();
            this.label2.Text = loginUser;
            this.loginUser = loginUser;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            CreateColumns2();
            RefreshDataGrid2(dataGridView2);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TourForm tourForm = new TourForm();
            tourForm.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid2(dataGridView2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(loginUser);
            orderForm.Show();
        }
        int key = 0;
        private void swap_Click(object sender, EventArgs e)
        {
            if (key % 2 == 0){
                this.swap.Text = "Список услуг>";
                this.dataGridView1.Hide();
                this.dataGridView2.Show();
            }
            if (key % 2 == 1)
            {
                this.swap.Text = "Список заказов>";
                this.dataGridView1.Show();
                this.dataGridView2.Hide();
            }
            key += 1;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("Help.chm"))
            {
                System.Diagnostics.Process.Start("Help.chm");
            }
        }
    }
}
