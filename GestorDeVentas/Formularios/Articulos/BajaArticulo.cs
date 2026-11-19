using GestorDeVentas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Articulos
{
    public partial class BajaArticulo : Form
    {
        private List<Articulo> articulo;
        private List<Proveedor> proveedor;
        private int idSeleccionado;

        public BajaArticulo(List<Articulo> listaArticulos, List<Proveedor> listaProveedores)
        {
            InitializeComponent();
            articulo= listaArticulos;
            proveedor = listaProveedores;
        }//Constructor

        private void BajaArticulo_Load(object sender, System.EventArgs e)
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articulo;

            dgvArticulos.RowHeadersVisible = false;

            cmbProveedor.DataSource = proveedor;
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "IdProveedor";
            cmbProveedor.SelectedIndex = -1;
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            cmbProveedor.SelectedIndex = -1;
            cmbProveedor.Enabled = true;
            txtNombre.Focus();

            if (e.RowIndex < 0) return;

            Articulo arSeleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;

            idSeleccionado = arSeleccionado.IdArticulo;

            txtNombre.Text = arSeleccionado.Nombre;
            txtStock.Text = arSeleccionado.Stock.ToString("F2");
            txtPrecio.Text = arSeleccionado.Precio.ToString("F2");
            cmbProveedor.SelectedValue = arSeleccionado.IdProveedor;

        }//dgv Cell Click

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            try
            {

                if (idSeleccionado <= 0)
                {
                    MessageBox.Show("Seleccione un Articulo.");
                    return;
                }//if

                Articulo seleccionado = articulo.FirstOrDefault(a => a.IdArticulo == idSeleccionado);

                if (seleccionado != null)
                {
                    articulo.Remove(seleccionado);

                    dgvArticulos.DataSource = null;
                    dgvArticulos.DataSource = articulo;

                    MessageBox.Show(
                    "Articulo eliminado correctamente.",
                    "Eliminación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
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
        }//Eliminar

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbProveedor.SelectedIndex = -1;
            txtNombre.Focus();
        }//LimpiarCampos
    }//Class
}//Namespace