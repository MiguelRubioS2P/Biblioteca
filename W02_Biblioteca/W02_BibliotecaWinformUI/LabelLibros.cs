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
    public partial class LabelLibros : Form
    {
        Book _selectedBook;
        public LabelLibros(Book selected)
        {
            InitializeComponent();
            _selectedBook = selected;
        }

        private void LabelLibros_Load(object sender, EventArgs e)
        {
            Book prueba = _selectedBook;
            labelTitulo.Text = prueba.TITOL;
            labelDescripcion.Text = prueba.Descrip_Llib;
            labelAutor.Text = prueba.NOM_AUT;

        }
    }
}
