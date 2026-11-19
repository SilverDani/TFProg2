using GestorDeVentas.Clases;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Articulos
{
    public partial class AltaArticulo : Form
    {
        private List<Articulo> articulo;
        public AltaArticulo(List<Articulo> listaArticulos)
        {
            InitializeComponent();
            articulo = listaArticulos;
        }//Constructor
    }//Class
}//Namespace