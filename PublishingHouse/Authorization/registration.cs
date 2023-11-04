using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PublishingHouse.Authorization
{
    public partial class registration : Form
    {
        ConnectionDbForUser con = new ConnectionDbForUser();
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            regPassBox.UseSystemPasswordChar = true;
            pictureBox5.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            regPassBox.UseSystemPasswordChar = false;
            pictureBox5.Visible = false;
            pictureBox2.Visible = true;
        }
        private void regUser_Click(object sender, EventArgs e)
        {
            try
            {
                var login = regLoginBox.Text;
                var password = regPassBox.Text;

                if(login != "" && password != "")
                {
                    string query = $"insert into userData(username, password) values('{login}', '{password}')";

                    SqlCommand command = new SqlCommand(query, con.Connection());

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Успех! Аккаунт создан");
                        this.Hide();
                        AuthorizationLogin aut = new AuthorizationLogin();
                        aut.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при создании аккаунта");
                    }
                    con.Close();

                    if (checkUser())

                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                }
            }
            catch
            {
                MessageBox.Show("Произошла критическая ошибка");
            }
        }
        private Boolean checkUser()
        {
            var loginUser = regLoginBox.Text;
            var passUser = regPassBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select * from userData = '{loginUser}' and password = '{passUser}'";

            SqlCommand command = new SqlCommand(queryString, con.Connection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Данный пользователь уже существует ");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AuthorizationLogin aut = new AuthorizationLogin();
            aut.Show();
            this.Hide();
        }
    }
}
