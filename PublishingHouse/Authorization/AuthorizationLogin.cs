using PublishingHouse;
using PublishingHouse.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingHouse
{
    public partial class AuthorizationLogin : Form
    {
        ConnectionDbForUser con = new ConnectionDbForUser();
        public AuthorizationLogin()
        {
            InitializeComponent();
            
        }

        private void AuthorizationLogin_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            loginBox.MaxLength = 25;
            passBox.MaxLength = 25;
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var loginUser = loginBox.Text;
                var passUser = passBox.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string query = $"select username, password from userData where username = '{loginUser}' and password = '{passUser}' ";

                SqlCommand command = new SqlCommand(query, con.Connection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show($"Рады вас видеть {loginUser}");
                    MainMenu main = new MainMenu();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Такого аккаунта не существует, проверьте правильность логина и пароля");
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Произошла критическая ошибка");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = true;
            pictureBox5.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = false;
            pictureBox5.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}
