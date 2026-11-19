using GestorDeVentas.Clases;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Clientes
{
    public partial class AltaClientes : Form
    {
        private List<Cliente> cliente;
        public AltaClientes(List<Cliente> listaClientes)
        {
            InitializeComponent();
            cliente = listaClientes;
        }//Constructor
    }//Class
}//Namespace