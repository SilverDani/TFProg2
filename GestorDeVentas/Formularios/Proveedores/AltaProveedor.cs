namespace GestorDeVentas.Formularios.Proveedores
{
    using GestorDeVentas.Clases;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AltaProveedor : Form
    {
        private List<Proveedor> proveedor;
        private int siguienteId = 1;
        public AltaProveedor(List<Proveedor> listaProveedor)
        {
            InitializeComponent();
            proveedor = listaProveedor;
        }//Constructor

        private void btnGrabar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (proveedor.Any(p => p.CUIT == txtCUIT.Text.Replace("-", "").Trim()))
                {
                    MessageBox.Show(
                        "Ya existe un proveedor registrado con ese CUIT.",
                        "CUIT duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                int nuevoId = ObtenerSiguienteId();

                Proveedor nuevoProveedor = new Proveedor(
                    nuevoId,
                    txtRazonSocial.Text,
                    txtCUIT.Text
                );

                proveedor.Add(nuevoProveedor);

                MessageBox.Show(
                    "Proveedor registrado correctamente",
                    "OK",
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
            txtRazonSocial.Clear();
            txtCUIT.Clear();
            txtRazonSocial.Focus();
        }

        private int ObtenerSiguienteId()
        {
            if (proveedor.Count == 0)
                return 1;

            return proveedor.Max(p => p.IdProveedor) + 1;
        }

       

    }//Class
}//Namespace