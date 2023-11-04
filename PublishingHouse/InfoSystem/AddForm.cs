using PublishingHouse.Authorization;
using PublishingHouse.Connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingHouse.InfoSystem
{
    public partial class AddForm : Form
    {
        ConnectForDbMain connect = new ConnectForDbMain();
        public AddForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
