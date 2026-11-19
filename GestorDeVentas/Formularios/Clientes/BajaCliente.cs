using GestorDeVentas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Clientes
{
    public partial class BajaCliente : Form
    {
        private List<Cliente> cliente;
        private int idSeleccionado;
        public BajaCliente(List<Cliente> listaClientes)
        {
            InitializeComponent();
            cliente = listaClientes;
        }//Constructor

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }//dgv cell click

        private void btnEliminar_click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado <= 0)
                {
                    MessageBox.Show("Seleccione un proveedor.");
                    return;
                }//if

                Cliente seleccionado = cliente.FirstOrDefault(c => c.IdCliente == idSeleccionado);

                if (cliente != null)
                {
                    cliente.Remove(seleccionado);

                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = cliente;

                    MessageBox.Show(
                    "Cliente eliminado correctamente.",
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
        }//btnEliminar
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCUIL.Clear();
            dtpNacimiento.Value = DateTime.Today;
            txtNombre.Focus();
        }//LimpiarCampos
    }//Class
}//Namespace