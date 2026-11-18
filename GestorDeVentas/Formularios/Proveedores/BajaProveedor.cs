using GestorDeVentas.Clases;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorDeVentas.Formularios.Proveedores
{
    public partial class BajaProveedor : Form
    {
        private List<Proveedor> proveedor;
        public BajaProveedor(List<Proveedor> listaProveedor)
        {
            InitializeComponent();
            proveedor = listaProveedor;
        }//Constructor

        private void BajaProveedor_Load(object sender, System.EventArgs e)
        {
            //llenar dgv
        }//Load

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Proveedor provSeleccionado = (Proveedor)dgvProveedores.Rows[e.RowIndex].DataBoundItem;

            txtRazonSocial.Text = provSeleccionado.RazonSocial;
            txtCUIT.Text = provSeleccionado.CUIT;
        }//dgv Cell Click

    }//Class
}//Namespace