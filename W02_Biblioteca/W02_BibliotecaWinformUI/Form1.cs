using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace W02_BibliotecaWinformUI
{
    public partial class BibliotecaMainForm : Form
    {

        //private string connectionString = 
        //"Server=localhost;Database=biblioteca;Uid=lector;Pwd=seCret_16";
        private string connectionString = "Server=localhost;Database=biblioteca;Uid=lector;Pwd=seCret_16";
        public BibliotecaMainForm()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            //string sql = $"select * from llibres where" +
            //$" titol like '%{searchBox.Text}%'";
            string sql = $"select llibres.ID_LLIB, llibres.DESCRIP_LLIB, llibres.TITOL, autors.ID_AUT, autors.NOM_AUT  from autors, lli_aut, llibres where llibres.ID_LLIB = lli_aut.FK_IDLLIB and autors.ID_AUT = lli_aut.FK_IDAUT and llibres.titol like '%{searchBox.Text}%'";
            books = connection.Query<Book>(sql).ToList();

            //for (int i = 0; i < books.Count; i++)
            //{
            //    bookList.Items.Add(books[i].TITOL);
            //}

            //foreach (var book in books)
            //{
            //    bookList.Items.Add(book.ID_LLIB + ". " + " " + book.TITOL);
            //}

            bookList.DataSource = books;
            bookList.DisplayMember = "FullInfo";

            connection.Close();
        }

        private void goAuthor_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AuthorsForm form = new AuthorsForm();
            
            form.Show();
        }

        private void bookList_DoubleClick(object sender, EventArgs e)
        {
            Book selectedBook = bookList.SelectedItem as Book;
            LabelLibros modal = new LabelLibros(selectedBook);
            DialogResult result = modal.ShowDialog(this);

            if (result == DialogResult.OK)
            {



            }
            else if(result == DialogResult.Cancel)
            {



            }

            modal.Dispose();


        }
    }
}
