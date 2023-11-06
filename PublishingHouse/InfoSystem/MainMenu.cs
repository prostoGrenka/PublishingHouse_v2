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
            LoadForm();
        }
        private void LoadForm()
        {
            try
            {
                string query =
                    "SELECT id_P AS ID, CONCAT_WS(' ', Name_author, Suname_Author, Middle_name_author) AS Автор, " +
                    "CONCAT_WS(' ', NameSoAuthor, Suname_SoAuthor, Middle_Name_SoAuthor) AS Соавтор, " +
                    "CONCAT_WS(' ', NameReviewer, Surname, Middle_Name) AS Лицензёр," +
                    "Name AS Название, Registration_Number AS Регистрационный_номер, Registration_Date_Number AS Дата_регистрации, Journal_Number AS Номер_журнала, Date_Issue_Journal AS Дата_Издания, " +
                    "TypePublication.Publication_Type AS Тип_Публикации, UDKPublications.UDK FROM Publications " +
                    "JOIN Author ON Publications.id_Author = Author.id_Author " +
                    "JOIN SoAuthor ON Publications.id_Soauthor = SoAuthor.id_Soauthor " +
                    "JOIN TypePublication ON Publications.Id_Publication_Type = TypePublication.id_Type_publication " +
                    "JOIN Reviewer ON Publications.id_Reviewer = Reviewer.id_Reviewer " +
                    "JOIN UDKPublications ON Publications.id_UDK_Publications = UDKPublications.id_UDK_Public";

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
        }
    }
}
