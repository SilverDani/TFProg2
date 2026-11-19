using GestorDeVentas.Clases;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Articulos
{
    public partial class BajaArticulo : Form
    {
        private List<Articulo> articulo;
            
        public BajaArticulo(List<Articulo> listaArticulos)
        {
            InitializeComponent();
            articulo= listaArticulos;
        }//Constructor
    }//Class
}//Namespace