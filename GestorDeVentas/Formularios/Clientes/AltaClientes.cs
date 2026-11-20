using GestorDeVentas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Clientes
{
    public partial class AltaClientes : Form
    {
        private List<Cliente> cliente;
        public AltaClientes(List<Cliente> listaClientes)
        {
            InitializeComponent();
            cliente = listaClientes;
        }//Constructor

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cliente.Any(c => c.CUIL == txtCUIL.Text.Replace("-", "").Trim()))
                {
                    MessageBox.Show(
                        "Ya existe un cliente registrado con ese CUIL.",
                        "CUIL duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }//Ya existe CUIL

                int nuevoId = ObtenerSiguienteId();

                Cliente nuevoCliente = new Cliente(
                    nuevoId,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtCUIL.Text,
                    dtpNacimiento.Value.Date
                    );

                cliente.Add(nuevoCliente);

                MessageBox.Show(
                    "Cliente registrado correctamente",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LimpiarCampos();
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
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCUIL.Clear();
            dtpNacimiento.Value = DateTime.Today;
            txtNombre.Focus();
        }

        private int ObtenerSiguienteId()
        {
            if (cliente.Count == 0)
                return 1;
            return cliente.Max(c => c.IdCliente) + 1;
        }//ObtenerSiguienteId

    }//Class
}//Namespace