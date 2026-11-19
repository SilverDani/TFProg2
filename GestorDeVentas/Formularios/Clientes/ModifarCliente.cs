using GestorDeVentas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Clientes
{
    public partial class ModifarCliente : Form
    {
        private List<Cliente> cliente;
        private int idSeleccionado;
        public ModifarCliente(List<Cliente> listaCliente)
        {
            InitializeComponent();
            cliente = listaCliente;
        }//Constructor

        private void ModifarCliente_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = cliente;

            dgvClientes.RowHeadersVisible = false;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Cliente cliSeleccionado = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;

            idSeleccionado = cliSeleccionado.IdCliente;

            txtNombre.Text = cliSeleccionado.Nombre;
            txtApellido.Text = cliSeleccionado.Apellido;
            txtCUIL.Text = cliSeleccionado.CUIL;
            dtpNacimiento.Value = cliSeleccionado.FechaNacimiento;

        }//dgv cell click

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(idSeleccionado<=0)
                {
                    MessageBox.Show("Seleccione un cliente.");
                    return;
                }//if

                Cliente Seleccionado = cliente.FirstOrDefault(c => c.IdCliente == idSeleccionado);

                if (Seleccionado != null)
                {
                    Seleccionado.Nombre = txtNombre.Text;
                    Seleccionado.Apellido = txtApellido.Text;
                    Seleccionado.CUIL = txtCUIL.Text;
                    Seleccionado.FechaNacimiento = dtpNacimiento.Value.Date;

                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = cliente;

                    MessageBox.Show(
                        "Cliente modifocado correctamente.",
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
        }//btnModificar

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