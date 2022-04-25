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
    public partial class TourForm : Form
    {
        Point lastPoint;
        public TourForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void buttonTourCreate_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `service` (`service_id`, `name`, `type`, `price`, `duration`, `route`) VALUES (NULL, @name, @type, @price, @duration, @route)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@duration", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@route", MySqlDbType.VarChar).Value = textBox5.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Создано!");
            else
                MessageBox.Show("Ошибка");
            db.closeConnection();
        }
    }
}
