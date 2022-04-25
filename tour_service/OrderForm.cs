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
    public partial class OrderForm : Form
    {
        string loginUser;
        public OrderForm(string loginUser)
        {
            this.loginUser = loginUser;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Point lastPoint;
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

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (numOrder.Text == "") return;
            if (dateOrder.Text == "") return;
            if (docsOrder.Text == "") return;
            if (teamOrder.Text == "") return;
            if (nameOrder.Text == "") return;
            DB db = new DB();
            db.openConnection();
            MySqlCommand com2 = new MySqlCommand("select user_id from `user` where login = @login");
            MySqlCommand command = new MySqlCommand("INSERT INTO `order` (`order_id`, `name`, `date`, `team_size`, `docs`, `user_id`, `service_id`) VALUES (NULL, @name, @date, @team_size, @docs, @user_id, @service_id)", db.getConnection());
            com2.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameOrder.Text;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = dateOrder.Text;
            command.Parameters.Add("@team_size", MySqlDbType.VarChar).Value = teamOrder.Text;
            command.Parameters.Add("@docs", MySqlDbType.VarChar).Value = docsOrder.Text;
            command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = 1;
            command.Parameters.Add("@service_id", MySqlDbType.Int32).Value = Convert.ToInt32(numOrder.Text);
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заказ успешно создан");

            }
            else
            {
                MessageBox.Show("Заказ не создан");
            }
            db.closeConnection();
            this.Hide();
        }
    }
}
