using GestorDeVentas.Formularios.Articulos;
using GestorDeVentas.Formularios.Clientes;
using GestorDeVentas.Formularios.Proveedores;
using GestorDeVentas.Formularios.Ventas;
using System.Windows.Forms;

namespace GestorDeVentas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }//Constructor

        private void AbrirFormHijos(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }//AbrirFormHijos

        private void altaCleintesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new AltaClientes());
        }

        private void modificarCleinteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new ModifarCliente());
        }

        private void bajaClienteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new BajaCliente());

        }

        private void altaProveedorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new AltaProveedor());

        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new ModificarProveedor());

        }

        private void bajaProveedorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new BajaProveedor());

        }

        private void altaArticuloToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new AltaArticulo());

        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new ModificarArticulo());
        }

        private void bajaArticuloToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new BajaArticulo());
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new Venta());
        }
    }//Class
}//Namespace