using GestorDeVentas.Clases;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Ventas
{
    public partial class frmVenta : Form
    {
        private List<Articulo> articulo;
        private List<Cliente> cliente;
        private List<Proveedor> proveedor;
        public frmVenta(List<Articulo> articulos, List<Cliente> clientes, List<Proveedor> proveedores)
        {
            InitializeComponent();
            proveedor = proveedores;
            articulo = articulos;
            cliente = clientes;
        }//Constructor

        private void frmVenta_Load(object sender, System.EventArgs e)
        {

        }
    }//Class
}//Namespace