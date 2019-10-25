using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W02_BibliotecaWinformUI
{
    public partial class AuthorsForm : Form
    {
        private string connectionString =
            "Server=localhost;Database=biblioteca;Uid=lector;Pwd=seCret_16";
        BibliotecaMainForm uno = new BibliotecaMainForm();
        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            List<Author> authors = new List<Author>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"select * from autors where" +
                $" NOM_AUT like '%{searchBox.Text}%'";
            authors = connection.Query<Author>(sql).ToList();

            listBoxAuthor.DataSource = authors;
            listBoxAuthor.DisplayMember = "FullInfo";

            connection.Close();
        }

        private void goLibrary_Click(object sender, EventArgs e)
        {
            
            //Application.Run(new BibliotecaMainForm());
            this.Hide();
            
            uno.Location = new Point(50, 50);
            uno.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //añadir una variable global para controlar si exite y entonces solo declarar uno.
            //if (!existsAuthorsForm)
            //{
            //    authorsForm = new AuthorForm
            //}
            BibliotecaMainForm form = new BibliotecaMainForm();

            form.Show();
        }

        private void AuthorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void listBoxAuthor_DoubleClick(object sender, EventArgs e)
        {
            Author selectedBook = listBoxAuthor.SelectedItem as Author;
            ModalAutores modal = new ModalAutores(selectedBook);
            DialogResult result = modal.ShowDialog(this);

            if (result == DialogResult.OK)
            {



            }
            else if (result == DialogResult.Cancel)
            {



            }

            modal.Dispose();
        }
    }
}
