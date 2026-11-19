using GestorDeVentas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Articulos
{
    public partial class ModificarArticulo : Form
    {
        private List<Articulo> articulo;
        private List<Proveedor> proveedor;
        private int idSeleccionado;

        public ModificarArticulo(List<Articulo> listaArticulos, List<Proveedor> listaProveedores)
        {
            InitializeComponent();
            articulo = listaArticulos;
            proveedor = listaProveedores;
        }//Constructor

        private void ModificarArticulo_Load(object sender, System.EventArgs e)
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articulo;

            dgvArticulos.RowHeadersVisible = false;

            cmbProveedor.DataSource = proveedor;
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "IdProveedor";
            cmbProveedor.SelectedIndex = -1;
        }//Load

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            cmbProveedor.SelectedIndex = -1;
            cmbProveedor.Enabled = true;
            txtNombre.Focus();

            Articulo arSeleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;

            idSeleccionado = arSeleccionado.IdArticulo;

            txtNombre.Text = arSeleccionado.Nombre;
            txtStock.Text = arSeleccionado.Stock.ToString("F2");
            txtPrecio.Text = arSeleccionado.Precio.ToString("F2");
            cmbProveedor.SelectedValue = arSeleccionado.IdProveedor;

        }//dgv Cell Click

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(idSeleccionado <= 0)
                {
                    MessageBox.Show("Selleccione un Articulo.");
                    return;
                }//if

                Articulo Seleccionado = articulo.FirstOrDefault(a => a.IdArticulo == idSeleccionado);

                if (Seleccionado != null)
                {
                    // Validar campos vacíos
                    if (string.IsNullOrWhiteSpace(txtNombre.Text))
                        throw new ArgumentException("Ingrese un nombre para el artículo.");

                    if (string.IsNullOrWhiteSpace(txtStock.Text))
                        throw new ArgumentException("Ingrese el stock.");

                    if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                        throw new ArgumentException("Ingrese el precio.");

                    if (cmbProveedor.SelectedIndex == -1)
                        throw new ArgumentException("Seleccione un proveedor.");

                    // Validar valores numéricos
                    if (!decimal.TryParse(txtStock.Text, out decimal stock))
                        throw new ArgumentException("Ingrese un stock válido.");

                    if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                        throw new ArgumentException("Ingrese un precio válido.");

                    // Obtener ID del proveedor seleccionado
                    int idProveedor = (int)cmbProveedor.SelectedValue;

                    Seleccionado.Nombre = txtNombre.Text;
                    Seleccionado.Stock = stock;
                    Seleccionado.Precio = precio;
                    Seleccionado.IdProveedor=idProveedor;

                    dgvArticulos.DataSource = null;
                    dgvArticulos.DataSource = articulo;

                    MessageBox.Show(
                        "Articulo modifocado correctamente.",
                        "Modificación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                }//if

            }//try
            catch(ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }//catch
        }//Modificar

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtNombre.Enabled = false;
            txtPrecio.Clear();
            txtPrecio.Enabled = false;
            txtStock.Clear();
            txtStock.Enabled = false;
            cmbProveedor.SelectedIndex = -1;
            cmbProveedor.Enabled = false;
            txtNombre.Focus();
        }//LimpiarCampos

    }//Class
}//Namespace