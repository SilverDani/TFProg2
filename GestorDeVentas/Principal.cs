namespace GestorDeVentas
{
    using GestorDeVentas.Clases;
    using GestorDeVentas.Formularios.Articulos;
    using GestorDeVentas.Formularios.Clientes;
    using GestorDeVentas.Formularios.Proveedores;
    using GestorDeVentas.Formularios.Ventas;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class Principal : Form
    {
        private List<Proveedor> proveedor;
        private List<Cliente> cliente;
        private List<Articulo> articulo;
        private List<Venta> ventas;
        private List<DetalleVenta> detallesVenta;

        public Principal()
        {
            InitializeComponent();
        }//Constructor

        private void Principal_Load(object sender, System.EventArgs e)
        {
            proveedor = new List<Proveedor>();
            cliente = new List<Cliente>();
            articulo = new List<Articulo>();
            ventas = new List<Venta>();
            detallesVenta = new List<DetalleVenta>();

            Cliente c1 = new Cliente(1, "Daniel", "Miranda", "20374239377", DateTime.Parse("12/02/1994"));
            cliente.Add(c1);
            Proveedor p1 = new Proveedor(1, "El Danie Instalaciones", "20374239377");
            proveedor.Add(p1);
            Articulo a1 = new Articulo(1, "Cámara Dahua Analógica 2Mpx", 15, 20000, 1);
            articulo.Add(a1);
        }//Load

        private void AbrirFormHijos(object formHijo)
        {
            Form fh = formHijo as Form;

            if(pnlContenedor.Controls.Count > 0)
            {
                Form formActual = pnlContenedor.Controls[0] as Form;

                if(formActual.GetType() == fh.GetType())
                {
                    formActual.Close();
                    formActual.Dispose();
                    return;
                }

                formActual.Close();
                formActual.Dispose();
            }


            //if (this.pnlContenedor.Controls.Count > 0)
            //{
            //    this.pnlContenedor.Controls.RemoveAt(0);
            //}
            //Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;

            fh.Left = (pnlContenedor.Width - fh.Width) / 2;
            fh.Top = (pnlContenedor.Height - fh.Height) / 2;

            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;

            fh.Show();
        }//AbrirFormHijos

        private void altaCleintesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new AltaClientes(cliente));
        }

        private void modificarCleinteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new ModifarCliente(cliente));
        }

        private void bajaClienteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new BajaCliente(cliente));

        }

        private void altaProveedorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new AltaProveedor(proveedor));

        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new ModificarProveedor(proveedor));

        }

        private void bajaProveedorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new BajaProveedor(proveedor));

        }

        private void altaArticuloToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new AltaArticulo(articulo,proveedor));

        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new ModificarArticulo(articulo,proveedor));
        }

        private void bajaArticuloToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new BajaArticulo(articulo, proveedor));
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijos(new frmVenta(articulo, cliente, ventas, detallesVenta));
        }
    }//Class
}//Namespace