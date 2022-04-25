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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            loginField.Text = "Логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Пароль";
            passField.ForeColor = Color.Gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (passField.Text == "Пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (isUserExists() == true)
                return;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`user_id`, `login`, `password`) VALUES (NULL, @login, @password)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не создан");
            db.closeConnection();
        }
        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть введите другой");
                return true;
            }
            else
                return false;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
    }
}
