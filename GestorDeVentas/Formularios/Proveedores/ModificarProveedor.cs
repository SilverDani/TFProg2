using GestorDeVentas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Proveedores
{
    public partial class ModificarProveedor : Form
    {
        private List<Proveedor> proveedor;
        private int idSeleccionado;
        public ModificarProveedor(List<Proveedor> listaProveedor)
        {
            InitializeComponent();
            proveedor = listaProveedor;
        }//Constructor

        private void ModificarProveedor_Load(object sender, System.EventArgs e)
        {
            //
        }//Load

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }//dgv Cell Click

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un proveedor.");
                return;
            }

            Proveedor seleccionado = proveedor.FirstOrDefault(a => a.IdProveedor == idSeleccionado);
            if (seleccionado != null)
            {
                seleccionado.RazonSocial = txtRazonSocial.Text;
                seleccionado.CUIT = txtCUIT.Text;

                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = proveedor;

                MessageBox.Show(
                "Proveedor Modificado correctamente.",
                "Modificación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }//btnModificar

    }//Class
}//Namespace