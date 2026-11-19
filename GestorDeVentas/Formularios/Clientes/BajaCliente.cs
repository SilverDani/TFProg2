using GestorDeVentas.Clases;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Clientes
{
    public partial class BajaCliente : Form
    {
        private List<Cliente> cliente;
        public BajaCliente(List<Cliente> listaClientes)
        {
            InitializeComponent();
            cliente = listaClientes;
        }//Constructor
    }//Class
}//Namespace