using PublishingHouse.Connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingHouse.InfoSystem
{
    public partial class AddData : Form
    {
        ConnectForDbMain connect = new ConnectForDbMain();
        public AddData()
        {
            InitializeComponent();
        }

        private void AddData_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
        //"SELECT CONCAT_WS(' ', Name_author, Suname_Author, Middle_name_author) as nameAuthor FROM Author"
        private void LoadComboBox()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-N8GPQUA;Initial Catalog=publishingHouse;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string commText = "SELECT id_Type_publication, Publication_Type FROM TypePublication";
                    SqlCommand comm = new SqlCommand(commText, conn);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(table);
                    PublicationTypeBox.DataSource = table;
                    PublicationTypeBox.DisplayMember = "Publication_Type";
                    PublicationTypeBox.ValueMember = "id_Type_publication";
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string commText = "SELECT id_UDK_Public, UDK FROM UDKPublications";
                    SqlCommand comm = new SqlCommand(commText, conn);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(table);
                    UdkBox.DataSource = table;
                    UdkBox.DisplayMember = "UDK";
                    UdkBox.ValueMember = "id_UDK_Public";
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string commText = "SELECT CONCAT_WS(' ', NameReviewer, Surname, Middle_Name) AS nameReviewer, id_Reviewer FROM Reviewer";
                    SqlCommand comm = new SqlCommand(commText, conn);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(table);
                    ReviewerBox.DataSource = table;
                    ReviewerBox.DisplayMember = "nameReviewer";
                    ReviewerBox.ValueMember = "id_Reviewer";
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string commText = "SELECT CONCAT_WS(' ', NameSoAuthor, Suname_SoAuthor, Middle_Name_SoAuthor) AS nameSoAuthor, id_Soauthor FROM SoAuthor";
                    SqlCommand comm = new SqlCommand(commText, conn);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(table);
                    SoAuthorBox.DataSource = table;
                    SoAuthorBox.DisplayMember = "nameSoAuthor";
                    SoAuthorBox.ValueMember = "id_Soauthor";
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string commText = "SELECT CONCAT_WS(' ', Name_author, Suname_Author, Middle_Name_Author) AS nameAuthor, id_Author FROM Author";
                    SqlCommand comm = new SqlCommand(commText, conn);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(table);
                    AuthorBox.DataSource = table;
                    AuthorBox.DisplayMember = "nameAuthor";
                    AuthorBox.ValueMember = "id_Author";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка, не все данные могут быть выведеными");
                Console.WriteLine(ex.ToString());
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into Publications(id_Author, id_SoAuthor, id_Reviewer, id_UDK_Publications, Id_Publication_Type, Name, Registration_Number, Registration_Date_Number, Journal_Number, Date_Issue_Journal) " +
                    "VALUES (@id_Author, @id_SoAuthor, @id_Reviewer, @id_UDK_Publications, @Id_Publication_Type, @Name, @Registration_Number, @Registration_Date_Number, @Journal_Number, @Date_Issue_Journal)";
                SqlCommand cmd = new SqlCommand(query, connect.Connection());

                cmd.Parameters.AddWithValue("@id_Author", AuthorBox.SelectedValue);
                cmd.Parameters.AddWithValue("@id_SoAuthor", SoAuthorBox.SelectedValue);
                cmd.Parameters.AddWithValue("@id_Reviewer", ReviewerBox.SelectedValue);
                cmd.Parameters.AddWithValue("@id_UDK_Publications", UdkBox.SelectedValue);
                cmd.Parameters.AddWithValue("@Id_Publication_Type", PublicationTypeBox.SelectedValue);

                string name = NameBox.Text;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;

                string Registration_Number = Registration_NumberBox.Text;
                cmd.Parameters.Add("@Registration_Number", SqlDbType.VarChar).Value = Registration_Number;

                DateTime Registration_Date_Number = RegistrationDateNumberBox.Value;
                cmd.Parameters.Add("@Registration_Date_Number", SqlDbType.Date).Value = Registration_Date_Number;

                var Journal_Number = JournalNumberBox.Text;
                cmd.Parameters.Add("@Journal_Number", SqlDbType.VarChar).Value = Journal_Number;

                DateTime Date_Issue_Journal = DateIssueJournalBox.Value;
                cmd.Parameters.Add("@Date_Issue_Journal", SqlDbType.Date).Value = Date_Issue_Journal;

                cmd.ExecuteNonQuery();
                connect.Close();




                MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка");
            }

        }
    }
}
