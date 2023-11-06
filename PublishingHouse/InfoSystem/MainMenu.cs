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


namespace PublishingHouse
{
    public partial class MainMenu : Form
    {
        ConnectForDbMain connect = new ConnectForDbMain();
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "publishingHouseDataSet.Publications". При необходимости она может быть перемещена или удалена.
            //this.publicationsTableAdapter.Fill(this.publishingHouseDataSet.Publications);

            LoadForm();
        }
        private void addData_Click(object sender, EventArgs e)
        {


        }

        private void LoadForm()
        {
            try
            {
                string query =
                    "SELECT CONCAT(Author.Name_author, '',Author.Suname_Author, '', Author.Middle_name_author) AS FullName, " +
                    "TypePublication.Publication_Type AS TypePublic, UDKPublications.UDK FROM Publications Author " +
                    "JOIN TypePublication ON Publications.Id_Publication_Type = TypePublication.id_Type_publication " +
                    "JOIN UDKPublications ON Publications.id_UDK_Publications = UDKPublications.id_UDK_Public ";

                //SELECT CONCAT(Author.Name_author, '', Author.Suname_Author, '', Author.Middle_name_author) AS FullName,
                //TypePublication.Publication_Type AS TypePublic, UDKPublications.UDK FROM Publications
                //JOIN TypePublication ON Publications.Id_Publication_Type = TypePublication.id_Type_publication
                //JOIN UDKPublications ON Publications.id_UDK_Publications = UDKPublications.id_UDK_Public


                SqlCommand myCommand = new SqlCommand(query, connect.Connection());

                //"."."
                SqlDataAdapter adpt = new SqlDataAdapter(query, connect.Connection());
                DataTable table = new DataTable();

                adpt.Fill(table);
                publicationsDataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            //string connectionString = "Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;";
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            //string query1 = "SELECT concat(Master_name.Surname,' ' , Master_name.Name,' ', Master_name.Lastname) as name FROM Master_name";
            //SqlCommand command1 = new SqlCommand(query1, connection);
            //SqlDataReader reader1 = command1.ExecuteReader();
            //while (reader1.Read())
            //{
            //    comboBox1.Items.Add(reader1["name"].ToString());
            //}
            //reader1.Close();

            //string query2 = "SELECT Name as name1 FROM Type_of_Service";
            //SqlCommand command2 = new SqlCommand(query2, connection);
            //SqlDataReader reader2 = command2.ExecuteReader();
            //while (reader2.Read())
            //{
            //    comboBox2.Items.Add(reader2["name1"].ToString());
            //}
            //reader2.Close();

            //connection.Close();
        }
    }
}
