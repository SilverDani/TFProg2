using GestorDeVentas.Clases;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Proveedores
{
    public partial class AltaProveedor : Form
    {
        private List<Proveedor> proveedor;
        public AltaProveedor(List<Proveedor> listaProveedor)
        {
            InitializeComponent();
            proveedor = listaProveedor;
        }//Constructor

        private void txtRazonSocial_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
                MessageBox.Show("Error", "Por favor ingrese una Razon Social", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (string.IsNullOrWhiteSpace(txtCUIT.Text))
                MessageBox.Show("ERROR", "Por favor ingrese un CUIT Valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Proveedor nuevoProveedor = new Proveedor(txtRazonSocial.Text, txtCUIT.Text);

            proveedor.Add(nuevoProveedor);

            MessageBox.Show("Proveedor registrado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }//Class
}//Namespace