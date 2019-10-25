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
    public partial class ModalAutores : Form
    {
        Author _selectedAuthor;
        public ModalAutores(Author selectedAuthor)
        {
            InitializeComponent();
            _selectedAuthor = selectedAuthor;
        }

        private void ModalAutores_Load(object sender, EventArgs e)
        {
            labelNombre.Text = _selectedAuthor.NOM_AUT;
        }
    }
}
