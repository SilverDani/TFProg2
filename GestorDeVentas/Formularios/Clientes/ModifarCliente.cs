using GestorDeVentas.Clases;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Clientes
{
    public partial class ModifarCliente : Form
    {
        private List<Cliente> cliente;
        public ModifarCliente(List<Cliente> listaCliente)
        {
            InitializeComponent();
            cliente = listaCliente;
        }//Constructor
    }//Class
}//Namespace