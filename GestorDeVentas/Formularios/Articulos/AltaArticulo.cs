using GestorDeVentas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Articulos
{
    public partial class AltaArticulo : Form
    {
        private List<Articulo> articulo;
        private List<Proveedor> proveedor;
        public AltaArticulo(List<Articulo> listaArticulos, List<Proveedor> listaProveedores)
        {
            InitializeComponent();
            articulo = listaArticulos;
            proveedor = listaProveedores;
        }//Constructor

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            cmbProveedor.DataSource = proveedor;
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "IdProveedor";
            cmbProveedor.SelectedIndex = -1;
        }//Load

        private int ObtenerSiguienteId()
        {
            if (articulo.Count == 0)
                return 1;

            return articulo.Max(a => a.IdArticulo) + 1;
        }//ObtenerSiguienteId

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
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

                // Crear artículo
                int nuevoId = ObtenerSiguienteId();

                Articulo nuevoArticulo = new Articulo(
                    nuevoId,
                    txtNombre.Text,
                    stock,
                    precio,
                    idProveedor
                );

                // Agregar a la lista
                articulo.Add(nuevoArticulo);

                MessageBox.Show(
                    "Artículo registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

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
        }//btnGrabar

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();

            cmbProveedor.SelectedIndex = -1;

            txtNombre.Focus();
        }//LimpiarCampos

    }//Class
}//Namespace