using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PublishingHouse.Connect;
using System.Runtime.InteropServices;
using PublishingHouse.Authorization;
using PublishingHouse.InfoSystem;

namespace PublishingHouse
{
    public partial class MainMenu : Form
    {
        ConnectForDbMain connect = new ConnectForDbMain();

        private DataTable table = null;

        private SqlDataAdapter adapter = null;

        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            FillingInData(dataGridView1);
        }
        private void FillingInData(DataGridView dwg)
        {
            dwg.Rows.Clear();
            //SELECT item_id, item_name, sup_name FROM  product, suppliers1 where product.sup_id = suppliers1.sup_id", dbConnection
            string queryString = $"SELECT * FROM Publications";

            SqlConnection con = connect.Connection();

            SqlDataAdapter adapter = new SqlDataAdapter(queryString, con);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void addData_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.Show();
            this.Hide();
        }
    }
}
