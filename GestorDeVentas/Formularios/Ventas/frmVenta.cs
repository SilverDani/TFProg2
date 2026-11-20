using GestorDeVentas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Ventas
{
    public partial class frmVenta : Form
    {
        private List<Articulo> articulo;
        private List<Cliente> cliente;
        private List<Venta> ventas;
        private List<DetalleVenta> detallesVenta, temporalDetalle;
        private int idVentaTemporal;
        private DetalleVenta detalleSeleccionado;

        public frmVenta(List<Articulo> articulos, List<Cliente> clientes, List<Venta> listaVentas, List<DetalleVenta> ListaDetalles)
        {
            InitializeComponent();
            articulo = articulos;
            cliente = clientes;
            ventas = listaVentas;
            detallesVenta = ListaDetalles;

            temporalDetalle = new List<DetalleVenta>();
        }//Constructor

        private void frmVenta_Load(object sender, System.EventArgs e)
        {
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = temporalDetalle;
            dgvDetalleVenta.RowHeadersVisible = false;

            cmbArticulo.DataSource = articulo;
            cmbArticulo.DisplayMember = "Nombre";
            cmbArticulo.ValueMember = "IdArticulo";
            cmbArticulo.SelectedIndex = -1;

            cmbCliente.DataSource = cliente;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "IdCliente";
            cmbCliente.SelectedIndex = -1;

            // Mostrar nombre y apellido del cliente
            cmbCliente.Format += (s, ev) =>
            {
                if (ev.ListItem is Cliente c)
                    ev.Value = c.Nombre + " " + c.Apellido;
            };

            // Obtener el siguiente ID disponible
            if (ventas.Count == 0)
                idVentaTemporal = 1;
            else
                idVentaTemporal = ventas.Max(v => v.IdVenta) + 1;

            txtCantidad.Enabled = false;
            txtSubTotal.ReadOnly = true;

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnVender.Enabled = false;

            lblTotal.Text = 0m.ToString("N2");
        }//Load

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Articulo seleccionado = cmbArticulo.SelectedItem as Articulo;

                if (seleccionado == null)
                    throw new ArgumentException("Seleccione un artículo.");

                if (!decimal.TryParse(txtCantidad.Text, out decimal cantidad) || cantidad <= 0)
                    throw new ArgumentException("Ingrese una cantidad válida.");

                // Buscar si el artículo ya está en el carrito
                DetalleVenta existente = temporalDetalle.FirstOrDefault(
                    d => d.IdArticulo == seleccionado.IdArticulo
                );

                decimal nuevaCantidad = cantidad;

                if (existente != null)
                    nuevaCantidad += existente.Cantidad;

                // Comprobar stock disponible
                if (nuevaCantidad > seleccionado.Stock)
                    throw new ArgumentException("No hay stock suficiente.");

                if (existente != null)
                {
                    existente.Cantidad = nuevaCantidad;
                }
                else
                {
                    DetalleVenta nuevoDetalle = new DetalleVenta(
                        idVentaTemporal,
                        seleccionado.IdArticulo,
                        cantidad,
                        seleccionado.Precio
                    );

                    temporalDetalle.Add(nuevoDetalle);
                }

                ActualizarDgvYTotales();

                // Preparar para agregar otro artículo
                detalleSeleccionado = null;
                cmbArticulo.Enabled = true;
                cmbArticulo.SelectedIndex = -1;

                txtCantidad.Text = "1";
                txtCantidad.Enabled = false;
                txtSubTotal.Clear();

                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }//Agregar Articulo de Lista

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (detalleSeleccionado == null)
            {
                MessageBox.Show("Seleccione un artículo.");
                return;
            }

            temporalDetalle.Remove(detalleSeleccionado);

            detalleSeleccionado = null;

            ActualizarDgvYTotales();

            cmbArticulo.Enabled = true;
            cmbArticulo.SelectedIndex = -1;

            txtCantidad.Text = "1";
            txtCantidad.Enabled = false;
            txtSubTotal.Clear();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }//Eliminar articulo de Lista

        private void btnLimpiar_Click(object sender, System.EventArgs e)
        {
            temporalDetalle.Clear();

            detalleSeleccionado = null;

            ActualizarDgvYTotales();

            LimpiarCampos();
        }//Limpiar Lista

        private void cmbArticulo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Articulo seleccionado = cmbArticulo.SelectedItem as Articulo;

            if (seleccionado == null)
            {
                txtCantidad.Enabled = false;
                txtCantidad.Clear();
                txtSubTotal.Clear();
                btnAgregar.Enabled = false;
                return;
            }

            txtCantidad.Enabled = true;
            txtCantidad.Text = "1";

            CalcularSubtotal();
        }//SelectedIndex ComboBox

        private void CalcularSubtotal()
        {
            Articulo seleccionado = cmbArticulo.SelectedItem as Articulo;

            if (seleccionado == null)
                return;

            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad))
            {
                if (cantidad > 0)
                {
                    decimal subtotal = cantidad * seleccionado.Precio;

                    txtSubTotal.Text = subtotal.ToString("N2");
                    btnAgregar.Enabled = true;
                }
                else
                {
                    txtSubTotal.Clear();
                    btnAgregar.Enabled = false;
                }
            }
            else
            {
                txtSubTotal.Clear();
                btnAgregar.Enabled = false;
            }
        }//CalcularSubTotal

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }//Cantidad TextChanged

        private void btnVender_Click(object sender, System.EventArgs e)
        {
            try
            {
                Cliente clienteSeleccionado = cmbCliente.SelectedItem as Cliente;

                if (clienteSeleccionado == null)
                    throw new ArgumentException("Seleccione un cliente.");

                if (temporalDetalle.Count == 0)
                    throw new ArgumentException("Agregue al menos un artículo.");

                // Verificar nuevamente el stock de todos los artículos
                foreach (DetalleVenta detalle in temporalDetalle)
                {
                    Articulo articuloActual = articulo.FirstOrDefault(
                        a => a.IdArticulo == detalle.IdArticulo
                    );

                    if (articuloActual == null)
                        throw new ArgumentException("Uno de los artículos ya no existe.");

                    if (articuloActual.Stock < detalle.Cantidad)
                        throw new ArgumentException(
                            "Stock insuficiente para el artículo: " + articuloActual.Nombre
                        );
                }

                // Calcular total definitivo
                decimal total = temporalDetalle.Sum(d => d.SubTotal);

                // Crear venta
                Venta nuevaVenta = new Venta(
                    idVentaTemporal,
                    clienteSeleccionado.IdCliente,
                    DateTime.Today,
                    total
                );

                // Guardar venta
                ventas.Add(nuevaVenta);

                //temporalDetalle.Clear();

                // Guardar detalles
                detallesVenta.AddRange(temporalDetalle);

                // Descontar stock
                foreach (DetalleVenta detalle in temporalDetalle)
                {
                    Articulo articuloActual = articulo.First(
                        a => a.IdArticulo == detalle.IdArticulo
                    );

                    articuloActual.Stock -= detalle.Cantidad;
                }

                MessageBox.Show(
                    "Venta registrada correctamente.",
                    "Venta exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Preparar siguiente venta

                idVentaTemporal = ventas.Max(v => v.IdVenta) + 1;

                ActualizarDgvYTotales();

                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }//Vender Click

        private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            detalleSeleccionado = (DetalleVenta)dgvDetalleVenta.Rows[e.RowIndex].DataBoundItem;

            cmbArticulo.SelectedValue = detalleSeleccionado.IdArticulo;

            txtCantidad.Text = detalleSeleccionado.Cantidad.ToString("N2");
            txtSubTotal.Text = detalleSeleccionado.SubTotal.ToString("N2");

            cmbArticulo.Enabled = false;
            txtCantidad.Enabled = false;

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
        }//Detalle Venta CellClick

        private void ActualizarDgvYTotales()
        {
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = temporalDetalle;

            decimal total = temporalDetalle.Sum(d => d.SubTotal);

            lblTotal.Text = "Total: $ " + total.ToString("N2");

            btnLimpiar.Enabled = temporalDetalle.Count > 0;
            btnVender.Enabled = temporalDetalle.Count > 0;
        }//Actualizar DGVsy totales

        private void LimpiarCampos()
        {
            cmbArticulo.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            txtCantidad.Clear();
            txtSubTotal.Clear();
            temporalDetalle.Clear();
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = temporalDetalle;
            lblTotal.Text = "Total: $ 0,00";
            cmbArticulo.Focus();
        }//LimpiarCampor

    }//Class
}//Namespace